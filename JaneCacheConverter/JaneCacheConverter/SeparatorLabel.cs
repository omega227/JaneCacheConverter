using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JaneCacheConverter
{
    public sealed class SeparatorLable : Label
    {
        private const int SeparatorHeight = 2;
        public SeparatorLable()
        {
            AutoSize = false;
            BorderStyle = BorderStyle.Fixed3D;
            Text = string.Empty;
            Height = SeparatorHeight;
        }
    }
}
