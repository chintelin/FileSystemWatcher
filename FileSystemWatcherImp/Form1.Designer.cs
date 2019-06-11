namespace FileSystemWatcherImp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBox_Auto = new System.Windows.Forms.CheckBox();
            this.textBox_ReplaceWith = new System.Windows.Forms.TextBox();
            this.textBox_FindWhat = new System.Windows.Forms.TextBox();
            this.textBox_TargetFolder = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Find what";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Replace with";
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(419, 26);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFolder.TabIndex = 4;
            this.buttonSelectFolder.Text = "Select";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // textBox_log
            // 
            this.textBox_log.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FileSystemWatcherImp.Properties.Settings.Default, "History", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_log.Location = new System.Drawing.Point(28, 164);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(466, 172);
            this.textBox_log.TabIndex = 5;
            this.textBox_log.Text = global::FileSystemWatcherImp.Properties.Settings.Default.History;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Systen Log";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(419, 80);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 50);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkBox_Auto
            // 
            this.checkBox_Auto.AutoSize = true;
            this.checkBox_Auto.Checked = global::FileSystemWatcherImp.Properties.Settings.Default.EnableAuto;
            this.checkBox_Auto.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::FileSystemWatcherImp.Properties.Settings.Default, "EnableAuto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_Auto.Location = new System.Drawing.Point(423, 136);
            this.checkBox_Auto.Name = "checkBox_Auto";
            this.checkBox_Auto.Size = new System.Drawing.Size(71, 16);
            this.checkBox_Auto.TabIndex = 6;
            this.checkBox_Auto.Text = "Auto Start";
            this.checkBox_Auto.UseVisualStyleBackColor = true;
            this.checkBox_Auto.CheckedChanged += new System.EventHandler(this.checkBox_Auto_CheckedChanged);
            // 
            // textBox_ReplaceWith
            // 
            this.textBox_ReplaceWith.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FileSystemWatcherImp.Properties.Settings.Default, "newWord", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_ReplaceWith.Location = new System.Drawing.Point(100, 108);
            this.textBox_ReplaceWith.Name = "textBox_ReplaceWith";
            this.textBox_ReplaceWith.Size = new System.Drawing.Size(300, 22);
            this.textBox_ReplaceWith.TabIndex = 3;
            this.textBox_ReplaceWith.Text = global::FileSystemWatcherImp.Properties.Settings.Default.newWord;
            // 
            // textBox_FindWhat
            // 
            this.textBox_FindWhat.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FileSystemWatcherImp.Properties.Settings.Default, "FindWord", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_FindWhat.Location = new System.Drawing.Point(100, 82);
            this.textBox_FindWhat.Name = "textBox_FindWhat";
            this.textBox_FindWhat.Size = new System.Drawing.Size(300, 22);
            this.textBox_FindWhat.TabIndex = 3;
            this.textBox_FindWhat.Text = global::FileSystemWatcherImp.Properties.Settings.Default.FindWord;
            // 
            // textBox_TargetFolder
            // 
            this.textBox_TargetFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FileSystemWatcherImp.Properties.Settings.Default, "targetFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_TargetFolder.Location = new System.Drawing.Point(100, 26);
            this.textBox_TargetFolder.Multiline = true;
            this.textBox_TargetFolder.Name = "textBox_TargetFolder";
            this.textBox_TargetFolder.Size = new System.Drawing.Size(300, 50);
            this.textBox_TargetFolder.TabIndex = 3;
            this.textBox_TargetFolder.Text = global::FileSystemWatcherImp.Properties.Settings.Default.targetFolder;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 348);
            this.Controls.Add(this.checkBox_Auto);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.textBox_ReplaceWith);
            this.Controls.Add(this.textBox_FindWhat);
            this.Controls.Add(this.textBox_TargetFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TargetFolder;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.TextBox textBox_FindWhat;
        private System.Windows.Forms.TextBox textBox_ReplaceWith;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBox_Auto;
        private System.Windows.Forms.Timer timer1;
    }
}

