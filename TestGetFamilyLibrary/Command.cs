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

            string path = "C:\\ProgramData\\Autodesk\\RVT 2022\\Libraries\\English-Imperial\\Structural Columns\\Concrete\\Concrete-Rectangular-Column.rfa";
            using (Transaction tx = new Transaction(doc))
            {
                try
                {
                    tx.Start("Transaction Name");

                    var famDoc = app.OpenDocumentFile(path);

                    var familyManager = famDoc.FamilyManager;

                    Form_GetDataFamily form1 = new Form_GetDataFamily();

                    form1.Path = path;

                    //get reference
                    //FamilyTypeSet familyTypes = familyManager.Types;
                    if (form1.ShowDialog() == DialogResult.OK)
                    {
                        string allParameters = null;
                        foreach (FamilyParameter itemPara in familyManager.Parameters)
                        {
                            allParameters = allParameters + itemPara.Definition.Name.ToString() + " // " + itemPara.Definition.ParameterGroup.ToString() + " // " + "\n";
                        }
                        TaskDialog.Show("message", allParameters);
                        //TaskDialog.Show("message", form1.Path);

                    }


                    tx.Commit();
                }
                catch (Exception e)
                {
                    //creat dialog box for error
                    TaskDialog td = new TaskDialog("Error");
                    td.Title = "Error";
                    td.AllowCancellation = true;

                    //Message related stuff
                    td.MainInstruction = "Error";
                    td.MainContent = "Error: " + e.Message;

                    //Common button Stuffs
                    td.CommonButtons = TaskDialogCommonButtons.Close;

                    //dialog showup stuffs
                    td.Show();

                    tx.RollBack();
                }


            }


            return Result.Succeeded;

        }
    }
}
