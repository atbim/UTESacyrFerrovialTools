#region Namespaces
using System;
using System.Collections.Generic;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Reflection;
#endregion

namespace UTESacyrFerrovialTools
{
    class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            var thisAssemblyPath = Assembly.GetExecutingAssembly().Location;

            var tabName1 = "UTE Sacyr Ferrovial";
            a.CreateRibbonTab(tabName1);

            var panel1 = a.CreateRibbonPanel(tabName1, "Modelado Túnel");

            // Creamos los botones del panel.
            var button1 = panel1.AddItem(new PushButtonData("Button1", "Pantalla Pilotes", thisAssemblyPath, "UTESacyrFerrovialTools.InsertPiles")) as PushButton;
            //button1.ToolTip = "Crea una sección por cada uno de los conjuntos existentes en el documento.";
            //button1.LargeImage = new BitmapImage(new Uri(thisAssemblyPath.Remove(thisAssemblyPath.Length - 17) + @"\Resources\new_Profile.ico"));

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
    }
}
