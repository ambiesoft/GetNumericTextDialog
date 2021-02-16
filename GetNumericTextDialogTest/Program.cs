using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GetNumericTextDialogTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ambiesoft.CppUtils.AmbSetProcessDPIAware();

            decimal val = 100;
            if (!Ambiesoft.NumericTextDialog.UIGetNumeric("My NUMERIC TEST", "labeltext", 0, 1000, ref val))
                return;

            MessageBox.Show(val.ToString());
        }
    }
}