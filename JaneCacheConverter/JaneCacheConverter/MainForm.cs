using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JaneCacheConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void saveFolderButton_Click(object sender, EventArgs e)
        {
            if (saveFolderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                saveFolderTextBox.Text = saveFolderBrowserDialog.SelectedPath;
            }
        }

        private void janeFolderButton_Click(object sender, EventArgs e)
        {
            if (janeFolderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                janeFolderTextBox.Text = janeFolderBrowserDialog.SelectedPath;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(saveFolderTextBox.Text))
            {
                MessageBox.Show("保存場所のフォルダーが存在しません。正しく入力しなおしてください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(janeFolderTextBox.Text))
            {
                MessageBox.Show("Janeのフォルダーが存在しません。正しく入力しなおしてください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Jane2ch jane = new Jane2ch(janeFolderTextBox.Text);
            option.SaveFolder = saveFolderTextBox.Text;
            ConvertArgs args = new ConvertArgs(jane, option);

            //別ウインドにしたほうがきれい
            convertButton.Enabled = false;
            progressBar1.Visible = true;
            janeFolderButton.Enabled = false;
            saveFolderButton.Enabled = false;

            backgroundWorker.RunWorkerAsync(args);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ConvertArgs args = (ConvertArgs)e.Argument;
            Core.ConvertAll(args.Jane, args.Option, (parcent, processText) =>
                {
                    backgroundWorker.ReportProgress(parcent, processText);
                });
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            processLabel.Text = e.UserState.ToString();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                janeFolderButton.Enabled = true;
                saveFolderButton.Enabled = true;
                convertButton.Enabled = true;
                processLabel.Text = "変換途中でエラーが発生しました。";
                progressBar1.Value = progressBar1.Minimum;
            }
            else if (!e.Cancelled)
            {
                janeFolderButton.Enabled = true;
                saveFolderButton.Enabled = true;
                convertButton.Enabled = true;
                processLabel.Text = "変換完了";
                progressBar1.Value = progressBar1.Maximum;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
        }

        ConvertOption option = new ConvertOption();
        private void optionButton_Click(object sender, EventArgs e)
        {
            ConvertOptionEditForm editor = new ConvertOptionEditForm(option);
            if (editor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                option = editor.Option;
            }
        }
    }
}
