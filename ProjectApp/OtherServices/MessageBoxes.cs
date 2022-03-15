using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp.OtherServices
{
    public class MessageBoxes
    {
        public void WarningMessage(string text)
        {
            MessageBox.Show(text, "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
