using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JaneCacheConverter
{
    public partial class ConvertOptionEditForm : Form
    {
        public ConvertOptionEditForm(ConvertOption option)
        {
            InitializeComponent();
            for (int i = 1; i < Thread.FormatNamePairs.Length; i += 2)
            {
                formatComboBox.Items.Add(Thread.FormatNamePairs[i]);
            }
            formatComboBox.SelectedIndex = 0;
            GetOption(option);
        }

        private void GetOption(ConvertOption option)
        {
            Option = option;
            folderFormatTextBox.Text = string.IsNullOrWhiteSpace(option.FolderFormat) ? Thread.TitleFormat : option.FolderFormat;
            overWriteRadioButton.Checked = (option.ImageSaveMode == ImageSaveMode.OverWrite);
            otherNameRadioButton.Checked = (option.ImageSaveMode == ImageSaveMode.ChangeName);
        }

        public ConvertOption Option { get; private set; }

        private void formatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formatComboBox.SelectedIndex > 0)
            {
                folderFormatTextBox.AppendText(Thread.FormatNamePairs[2 * (formatComboBox.SelectedIndex - 1)]);
            }
        }

        private void SetOption()
        {
            Option.FolderFormat = folderFormatTextBox.Text;
            Option.ImageSaveMode = overWriteRadioButton.Checked ? ImageSaveMode.OverWrite : ImageSaveMode.ChangeName;
        }

        private void ConvertOptionEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                SetOption();
            }
        }
    }
}
