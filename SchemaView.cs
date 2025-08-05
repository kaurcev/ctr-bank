using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SecHeper
{
    public partial class SchemaView : Form
    {
        public string Default_filename = "";
        public int Ext_i=1;
        public SchemaView()
        {
            InitializeComponent();
        }

      
        private void SchemaView_Load(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = this.Default_filename;
            switch (Ext_i)
            {
                case 1:
                    saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                    this.Text = "XML viewer";
                    break;
                case 2:
                    saveFileDialog1.Filter = "Schema files (*.xsd)|*.xsd|All files (*.*)|*.*";
                    this.Text = "Schema viewer";
                    break;
                default:
                   saveFileDialog1.Filter ="xml files (*.xml)|*.xml|All files (*.*)|*.*" ;
                   break;
           }
            saveFileDialog1.FilterIndex = 0;
           
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                
                StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
                sw.Write(EditorBox.Text);
                sw.Close();

            }
        }
    }
}
