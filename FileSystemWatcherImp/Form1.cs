using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;//namespace contains FileSystemWatcher

namespace FileSystemWatcherImp
{
    public partial class Form1 : Form
    {
        internal class FileChangedArgs : EventArgs
        {
            public FileInfo ChangedFile { get; set; }
        }

        FileSystemWatcher watcher = new FileSystemWatcher()
        {
            IncludeSubdirectories = false,
            NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName
        };
        StringBuilder logLines = new StringBuilder(2000);
        int logCapacity = 1000;
        int logLinesLength = 0;
        EventHandler<FileChangedArgs> FileChanged;
        bool isFileModified = false;

        public Form1()
        {
            InitializeComponent();

            watcher.Created += new FileSystemEventHandler(watcher_Detected);
            watcher.Changed += new FileSystemEventHandler(watcher_Detected);
            watcher.Renamed += new RenamedEventHandler(watcher_Renamed);

            FileChanged += FileChanged_Action;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            logLines.Append(Properties.Settings.Default.History);
            checkBox_Auto.Checked = Properties.Settings.Default.EnableAuto;
            if (checkBox_Auto.Checked)
                checkBox_Auto_CheckedChanged(null, null);
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var path = fbd.SelectedPath;
                if (path != null)
                {
                    textBox_TargetFolder.Text = path;
                    Properties.Settings.Default.Save();//remember the setting
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {            
            watcher.Path = textBox_TargetFolder.Text;
            watcher.EnableRaisingEvents = true; //start watching

            timer1.Start();
            buttonStart.Enabled = false;
            string logTextLine = string.Format("{0} Watcher is detecting...{1}{2}", DateTime.Now, Environment.NewLine, Environment.NewLine);
            logLines.Insert(0, logTextLine);
                     
        }

        void watcher_Renamed(object sender, RenamedEventArgs e)
        {            
            watcher.EnableRaisingEvents = false;
            string logTextLine = string.Format("{0} {1}: {2} -> {3}.{4}", DateTime.Now, e.ChangeType, e.OldName, e.Name, Environment.NewLine);
            logLines.Insert(0, logTextLine);
            watcher.EnableRaisingEvents = true;
        }


        void watcher_Detected(object sender, FileSystemEventArgs e)
        {           
            watcher.EnableRaisingEvents = false;
            string logTextLine = string.Format("{0} {1}: {2}.{3}", DateTime.Now, e.ChangeType, e.Name, Environment.NewLine);
            logLines.Insert(0, logTextLine);
            if (e.ChangeType == WatcherChangeTypes.Changed)
            {
                FileChangedArgs fca = new FileChangedArgs();
                fca.ChangedFile = new FileInfo(e.FullPath);

                
                if (FileChanged != null)
                {
                    var fileChangedEvent = new EventHandler<FileChangedArgs>(FileChanged);
                    fileChangedEvent(null, fca);
                }
            }
            watcher.EnableRaisingEvents = true;
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (logLines.Length == logLinesLength)
                return;

            timer1.Stop();
            {               
                if (logLines.Length > logCapacity)
                {
                    int startIndex = Convert.ToInt32(logCapacity * 0.8);
                    int removeCount = Convert.ToInt32(logLines.Length - logCapacity * 0.8);
                    logLines.Remove(startIndex, removeCount);
                }

                logLinesLength = logLines.Length;
                textBox_log.Text = logLines.ToString();

                Properties.Settings.Default.Save();//remember the setting
            }
            timer1.Start();
        }



        private void checkBox_Auto_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();//remember the setting
            if (checkBox_Auto.Checked)
            {
                buttonStart.Enabled = false;
                buttonStart_Click(null, null);
            }
            else
            {
                buttonStart.Enabled = true;
            }
        }

        private void FileChanged_Action(object s, FileChangedArgs f)
        {
            bool watchStatus = watcher.EnableRaisingEvents;
            try
            {
                string findStrRaw = textBox_FindWhat.Text;
                string[] findStrings = findStrRaw.Replace(" ", "").Split(';');                
                string newStr = textBox_ReplaceWith.Text;

                if (findStrings == null || newStr == null)
                {
                    logLines.Insert(0, DateTime.Now.ToString() + "Cannot replace any words");
                    return;
                }

                string content;
                using (StreamReader sr = new StreamReader(f.ChangedFile.FullName))
                {
                    content = sr.ReadToEnd();  
                }

                foreach (var findStr in findStrings)
                {
                    content = content.Replace(findStr, newStr);
                }

                isFileModified = true;
                watcher.EnableRaisingEvents = false;
                lock (watcher)
                {
                    using (StreamWriter sw = new StreamWriter(f.ChangedFile.FullName))
                    {
                        sw.Write(content);
                    }
                    logLines.Insert(0, DateTime.Now.ToString() + " Data is modified" + Environment.NewLine);
                }
            }
            catch (Exception e)
            {
                logLines.Insert(0, DateTime.Now.ToString() + " **ERROR** " + e.ToString() + Environment.NewLine);
                return;
            }
            finally
            {
                isFileModified = false;
                watcher.EnableRaisingEvents = watchStatus;
            }
        }
    }
}
