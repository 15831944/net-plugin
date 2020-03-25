using System;
using System.Collections.Generic;
using System.Text;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;


namespace WpfCustomControlLibrary
{
    class Initialization
    {
        [Autodesk.AutoCAD.Runtime.CommandMethod
        ("MyFirstCommand")]
        public void cmdMyFirst()
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            ed.WriteMessage("\nI have created my first command");
        }
    }
}
