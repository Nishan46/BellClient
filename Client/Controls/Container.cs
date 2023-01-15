using Client.BellData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Controls
{
    public partial class Container : UserControl
    {
        public Container()
        {
            InitializeComponent();
        }

        private void Edit(object sender, EventArgs e)
        {
            foreach(MorningData morningData in Core.MorningList)
            {
                if(morningData.Name == lblheader.Text)
                {
                    Core.edit_id = morningData.Id;
                }
            }
            MorningEditor morningEditor = new MorningEditor();
            morningEditor.Show();
        }
    }
}
