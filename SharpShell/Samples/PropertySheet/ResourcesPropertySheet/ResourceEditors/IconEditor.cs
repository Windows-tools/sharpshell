﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResourcesPropertySheet.Loader;

namespace ResourcesPropertySheet.ResourceEditors
{
    internal partial class IconEditor : UserControl, IResourceEditor
    {
        private Icon iconData;

        public IconEditor()
        {
            InitializeComponent();
        }

        public void Initialise(Win32Resource resource)
        {
            //  Create a byte stream from the data.
            iconData = resource.IconData;
        }

        public void Release()
        {
        }

        private void pictureBoxPreview_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawIcon(iconData, 0, 0);
        }
    }
}
