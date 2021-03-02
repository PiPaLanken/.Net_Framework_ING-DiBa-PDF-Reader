using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ing_PDF_Reader
{
    public partial class Main : Form
    {
        String Path = "";
        public Main()
        {
            InitializeComponent();
        }

        private void button_loadfolder_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path))
                {
                    button_loadfolder.BackColor = Color.LightGreen;
                    effects = DragDropEffects.Copy;
                }
            }
            e.Effect = effects;
        }

        private void button_loadfolder_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop,false);
            foreach (string file in files)
                listbox_sourcefiles.Items.Add(file);

            button_loadfolder_DragLeave(sender, e);
        }

        private void button_loadfolder_DragLeave(object sender, EventArgs e)
        {
            button_loadfolder.BackColor = Color.LightGray;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            listbox_sourcefiles.Items.Clear();
            listbox_destinationfiles.Items.Clear();
            button_destinationfolder.AllowDrop = true;
            Path = null;
        }

        private void linkLabel_destfolderpath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Path != null) Process.Start(@Path);
        }

        private void button_savefolder_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(Path))
                {
                    button_destinationfolder.BackColor = Color.LightGreen;
                    effects = DragDropEffects.Copy;
                }
                else Path = null;
            }
            e.Effect = effects;
        }

        private void button_savefolder_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
                listbox_destinationfiles.Items.Add(file);

            button_destinationfolder.AllowDrop = false;
            button_savefolder_DragLeave(sender, e);
        }

        private void button_savefolder_DragLeave(object sender, EventArgs e)
        {
            button_destinationfolder.BackColor = Color.LightGray;
        }
    }
}
