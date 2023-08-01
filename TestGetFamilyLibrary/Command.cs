using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;
using Autodesk.Revit.ApplicationServices;

namespace TestGetFamilyLibrary
{
    [Transaction(TransactionMode.Manual)]
    public class Command: IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Autodesk.Revit.ApplicationServices.Application app = uiapp.Application;
            Document doc = uidoc.Document;

            //string path = "C:\\ProgramData\\Autodesk\\RVT 2022\\Libraries\\English-Imperial\\Structural Columns\\Concrete\\Concrete-Rectangular-Column.rfa";
            string path = "C:\\ProgramData\\Autodesk\\RVT 2022\\Libraries\\English-Imperial\\Doors\\Door-Double-Flush_Panel.rfa";
            using (Transaction tx = new Transaction(doc))
            {
                try
                {
                    tx.Start("Transaction Name");

                    var famDoc = app.OpenDocumentFile(path);

                    var familyManager = famDoc.FamilyManager;

                    Form_GetDataFamily form1 = new Form_GetDataFamily();

                    FamilyParameterSet listFamilyParameter = familyManager.Parameters;

                    form1.Path = path;
                    form1.CountParameters = listFamilyParameter.Size;
                    
                    
                    List<string> listIdFamily = new List<string>();
                    List<string> listGroupFamily = new List<string>();
                    List<string> listNameFamily = new List<string>();
                    List<string> listTypeFamily = new List<string>();



                    foreach (FamilyParameter itemPara in familyManager.Parameters)
                    {
                        string idParameter = itemPara.Id.ToString();
                        string nameParameter = itemPara.Definition.Name.ToString();
                        string groupParameter = itemPara.Definition.ParameterGroup.ToString();
                        //string groupParameter = itemPara.s.ToString();
                        string unitParameter = itemPara.Definition.ParameterType.ToString();


                        listIdFamily.Add(idParameter);
                        listNameFamily.Add(nameParameter);
                        listGroupFamily.Add(groupParameter);
                        listTypeFamily.Add(unitParameter);

                        //allParameters = allParameters + itemPara.Definition.Name.ToString() + " // " + itemPara.Definition.ParameterGroup.ToString() + " // " + "\n";
                    }
                    
                    form1.ListIdParaTable = listIdFamily;
                    form1.ListNameParaTable = listNameFamily;
                    form1.ListGroupParaTable = listGroupFamily;
                    form1.ListTypeParaTable = listTypeFamily;
                    
                    if (form1.ShowDialog() == DialogResult.OK)
                    {
                        TaskDialog.Show("message", listIdFamily.Count.ToString());

                    }


                    tx.Commit();
                }
                catch (Exception e)
                {
                    //creat dialog box for error
                    TaskDialog td = new TaskDialog("Error");
                    td.Title = "Error";
                    td.AllowCancellation = true;

                    
                    td.MainInstruction = "Error";
                    td.MainContent = "Error: " + e.Message;

                    
                    td.CommonButtons = TaskDialogCommonButtons.Close;

                    
                    td.Show();

                    tx.RollBack();
                }


            }


            return Result.Succeeded;

        }
    }
}
