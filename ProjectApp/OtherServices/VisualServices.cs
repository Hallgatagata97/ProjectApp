using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp.OtherServices
{
    public class VisualServices
    {
        public void resultCountLblText(Label lbl, DataGridView dgv)
        {
            lbl.Text = $"Találatok száma: {dgv.Rows.Count}";
        }
    }
}
