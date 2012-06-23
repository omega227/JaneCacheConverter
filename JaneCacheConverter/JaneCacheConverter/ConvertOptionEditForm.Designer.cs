namespace JaneCacheConverter
{
    partial class ConvertOptionEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.folderFormatTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.separatorLable1 = new JaneCacheConverter.SeparatorLable();
            this.overWriteRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.otherNameRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "作成フォルダー名のフォーマット";
            // 
            // formatComboBox
            // 
            this.formatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Items.AddRange(new object[] {
            "フォーマット選択"});
            this.formatComboBox.Location = new System.Drawing.Point(280, 37);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(114, 20);
            this.formatComboBox.TabIndex = 3;
            this.formatComboBox.SelectedIndexChanged += new System.EventHandler(this.formatComboBox_SelectedIndexChanged);
            // 
            // folderFormatTextBox
            // 
            this.folderFormatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderFormatTextBox.Location = new System.Drawing.Point(9, 38);
            this.folderFormatTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.folderFormatTextBox.Name = "folderFormatTextBox";
            this.folderFormatTextBox.Size = new System.Drawing.Size(265, 19);
            this.folderFormatTextBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(324, 191);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(243, 191);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // separatorLable1
            // 
            this.separatorLable1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separatorLable1.Location = new System.Drawing.Point(9, 178);
            this.separatorLable1.Name = "separatorLable1";
            this.separatorLable1.Size = new System.Drawing.Size(385, 2);
            this.separatorLable1.TabIndex = 6;
            this.separatorLable1.Text = "separatorLable1";
            // 
            // overWriteRadioButton
            // 
            this.overWriteRadioButton.AutoSize = true;
            this.overWriteRadioButton.Checked = true;
            this.overWriteRadioButton.Location = new System.Drawing.Point(15, 96);
            this.overWriteRadioButton.Name = "overWriteRadioButton";
            this.overWriteRadioButton.Size = new System.Drawing.Size(80, 16);
            this.overWriteRadioButton.TabIndex = 7;
            this.overWriteRadioButton.TabStop = true;
            this.overWriteRadioButton.Text = "上書き保存";
            this.overWriteRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "同じ名前のファイルが既に存在するとき";
            // 
            // otherNameRadioButton
            // 
            this.otherNameRadioButton.AutoSize = true;
            this.otherNameRadioButton.Location = new System.Drawing.Point(15, 118);
            this.otherNameRadioButton.Name = "otherNameRadioButton";
            this.otherNameRadioButton.Size = new System.Drawing.Size(81, 16);
            this.otherNameRadioButton.TabIndex = 9;
            this.otherNameRadioButton.Text = "別名で保存";
            this.otherNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // ConvertOptionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 226);
            this.Controls.Add(this.otherNameRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.overWriteRadioButton);
            this.Controls.Add(this.separatorLable1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.formatComboBox);
            this.Controls.Add(this.folderFormatTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConvertOptionEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "オプション";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConvertOptionEditForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.TextBox folderFormatTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private SeparatorLable separatorLable1;
        private System.Windows.Forms.RadioButton overWriteRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton otherNameRadioButton;
    }
}