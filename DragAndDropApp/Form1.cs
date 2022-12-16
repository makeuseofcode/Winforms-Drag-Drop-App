using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDropApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dragDropPanel.AllowDrop = true;
            dragDropPanel.AutoScroll = true;
        }

        private void dragDropPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void dragDropPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (var file in files)
            {
                string fileName = file.Substring(file.LastIndexOf("\\") + 1, file.Length - (file.LastIndexOf("\\") + 1));

                try
                {
                    uploadedFilesList.Items.Add(fileName);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }

            uploadedFilesList.Visible = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            uploadedFilesList.Items.Clear();
            uploadedFilesList.Visible = false;
        }
    }
}
