using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ambiesoft
{
    public partial class NumericTextDialog : Form
    {
        public NumericTextDialog()
        {
            InitializeComponent();
        }

        public static bool UIGetNumeric(string title, string label, decimal minimum, decimal maximum, ref decimal ret)
        {
            NumericTextDialog frm = new NumericTextDialog();
            frm.Text = title;
            frm.lblName.Text = label;
            frm.nudMain.Maximum = maximum;
            frm.nudMain.Minimum = minimum;
            frm.nudMain.Value = ret;
            if(DialogResult.OK != frm.ShowDialog())
                return false;

            ret = frm.nudMain.Value;
            return true;
        }
    }
}