namespace JaneCacheConverter
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.janeFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFolderTextBox = new System.Windows.Forms.TextBox();
            this.saveFolderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.janeFolderButton = new System.Windows.Forms.Button();
            this.janeFolderTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.processLabel = new System.Windows.Forms.Label();
            this.optionButton = new System.Windows.Forms.Button();
            this.separatorLable1 = new JaneCacheConverter.SeparatorLable();
            this.SuspendLayout();
            // 
            // janeFolderBrowserDialog
            // 
            this.janeFolderBrowserDialog.Description = "Janeのインストール場所（Jane2ch.exeのあるフォルダー）を指定してください。";
            this.janeFolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // saveFolderTextBox
            // 
            this.saveFolderTextBox.Location = new System.Drawing.Point(13, 30);
            this.saveFolderTextBox.Name = "saveFolderTextBox";
            this.saveFolderTextBox.ReadOnly = true;
            this.saveFolderTextBox.Size = new System.Drawing.Size(337, 19);
            this.saveFolderTextBox.TabIndex = 0;
            // 
            // saveFolderButton
            // 
            this.saveFolderButton.Location = new System.Drawing.Point(356, 28);
            this.saveFolderButton.Name = "saveFolderButton";
            this.saveFolderButton.Size = new System.Drawing.Size(26, 23);
            this.saveFolderButton.TabIndex = 1;
            this.saveFolderButton.Text = "...";
            this.saveFolderButton.UseVisualStyleBackColor = true;
            this.saveFolderButton.Click += new System.EventHandler(this.saveFolderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "保存場所";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Janeのインストール場所（Jane2ch.exeのあるフォルダー）";
            // 
            // janeFolderButton
            // 
            this.janeFolderButton.Location = new System.Drawing.Point(356, 83);
            this.janeFolderButton.Name = "janeFolderButton";
            this.janeFolderButton.Size = new System.Drawing.Size(26, 23);
            this.janeFolderButton.TabIndex = 4;
            this.janeFolderButton.Text = "...";
            this.janeFolderButton.UseVisualStyleBackColor = true;
            this.janeFolderButton.Click += new System.EventHandler(this.janeFolderButton_Click);
            // 
            // janeFolderTextBox
            // 
            this.janeFolderTextBox.Location = new System.Drawing.Point(13, 85);
            this.janeFolderTextBox.Name = "janeFolderTextBox";
            this.janeFolderTextBox.ReadOnly = true;
            this.janeFolderTextBox.Size = new System.Drawing.Size(337, 19);
            this.janeFolderTextBox.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(300, 170);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(97, 23);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "変換";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 173);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(274, 14);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // saveFolderBrowserDialog
            // 
            this.saveFolderBrowserDialog.Description = "画像を保存する場所を指定してください。";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Location = new System.Drawing.Point(11, 158);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(0, 12);
            this.processLabel.TabIndex = 8;
            // 
            // optionButton
            // 
            this.optionButton.Location = new System.Drawing.Point(307, 112);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(75, 23);
            this.optionButton.TabIndex = 9;
            this.optionButton.Text = "オプション";
            this.optionButton.UseVisualStyleBackColor = true;
            this.optionButton.Click += new System.EventHandler(this.optionButton_Click);
            // 
            // separatorLable1
            // 
            this.separatorLable1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separatorLable1.Location = new System.Drawing.Point(15, 148);
            this.separatorLable1.Name = "separatorLable1";
            this.separatorLable1.Size = new System.Drawing.Size(382, 2);
            this.separatorLable1.TabIndex = 10;
            this.separatorLable1.Text = "separatorLable1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 199);
            this.Controls.Add(this.separatorLable1);
            this.Controls.Add(this.optionButton);
            this.Controls.Add(this.processLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.janeFolderButton);
            this.Controls.Add(this.janeFolderTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveFolderButton);
            this.Controls.Add(this.saveFolderTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Jane画像キャッシュ変換";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saveFolderTextBox;
        private System.Windows.Forms.Button saveFolderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button janeFolderButton;
        private System.Windows.Forms.TextBox janeFolderTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog saveFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog janeFolderBrowserDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Button optionButton;
        private SeparatorLable separatorLable1;
    }
}

