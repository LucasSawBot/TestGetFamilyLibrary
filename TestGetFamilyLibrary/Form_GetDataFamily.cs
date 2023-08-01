//using Autodesk.Revit.Creation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace TestGetFamilyLibrary
{
    public partial class Form_GetDataFamily : System.Windows.Forms.Form
    {
        string path = "abc";

        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        

        
        public Form_GetDataFamily()
        {
            InitializeComponent();
            
        }

        private void btn_getInfo_Click(object sender, EventArgs e)
        {
            path = tb_path.Text;
            DialogResult = DialogResult.OK;
        }

        private void Form_GetDataFamily_Load(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.OK;
            tb_path.Text = path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ListViewItem item = new ListViewItem("s1" + i.ToString());
                item.SubItems.Add("A" + i.ToString());
                item.SubItems.Add("B" + i.ToString());
                listView1.Items.Add(item);
            }
        }  
    }
}
