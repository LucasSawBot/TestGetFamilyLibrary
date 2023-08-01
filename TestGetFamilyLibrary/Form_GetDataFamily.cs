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
        List<string> listIdFamily;
        List<string> listNameFamily;
        List<string> listGroupFamily;
        int countParameters;
        List<string> listIdParaTable;
        List<string> listTypeParaTable;
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        

        public List<string> ListNameParaTable
        {
            get { return listNameFamily; }
            set { listNameFamily = value; }
        }

        public List<string> ListGroupParaTable
        {
            get { return listGroupFamily; }
            set { listGroupFamily = value; }
        }
        
        public int CountParameters
        {
            get { return countParameters; }
            set { countParameters = value; }
        }

        public List<string> ListIdParaTable
        {
            get { return listIdParaTable; }
            set { listIdParaTable = value; }
        }

        public List<string> ListTypeParaTable
        {
            get { return listTypeParaTable; }
            set { listTypeParaTable = value; }
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
            
            //TaskDialog.Show("message", listIdParaTable[0]);
            
            for (int i = 0; i < countParameters; i++)
            {
                ListViewItem item = new ListViewItem(listIdParaTable[i]);
                item.SubItems.Add(listNameFamily[i]);
                item.SubItems.Add(listGroupFamily[i]);
                item.SubItems.Add(listTypeParaTable[i]);

                listView1.Items.Add(item);
            }
        }  
    }
}
