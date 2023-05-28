using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTO_Management
{
    public class Validation_Class
    {
        public static void capslockvalidation()
        {


            //if (Control.IsKeyLocked(Keys.CapsLock))
            //{
            //    MessageBox.Show("The Caps Lock key is ON.");
            //}
            
            
        }

        public bool blanktextbx(string a)
        {
            if (a == "")
            { 
                return true;
            }
                return false;
            
        }
    }
}
