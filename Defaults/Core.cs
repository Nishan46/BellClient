using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Defaults.Properties;
using System.Windows.Forms;
namespace Defaults
{
    public class Core
    {
        public void Write(string Setting, object Value)
        {
            try
            {
                if (Setting == "ShutDownTime")
                {
                    Settings.Default.ShutDownTime = Convert.ToDateTime(Value);
                    Settings.Default.Save();
                }
                else
                {
                    Settings.Default[Setting] = Value;
                    Settings.Default.Save();
                }
                /*MessageBox.Show($"Setting is {Setting} and the Value is {Value}");*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            
        }

        public object Read(string Setting)
        {
            return Settings.Default[Setting];
        }
    }
}
