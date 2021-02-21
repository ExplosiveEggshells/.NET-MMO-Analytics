using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogersErwin_Assign3
{
    public partial class Form1 : Form
    {
        JARDriver jarDriver;

        public Form1()
        {
            InitializeComponent();

            GuildCollection guildCollection = new GuildCollection();
            PlayerCollection playerCollection = new PlayerCollection();
            jarDriver = new JARDriver(ref OutputListBox);

            jarDriver.Initializer(ref GuildsPerTypeComboBox);
        }


        private void GuildsPerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jarDriver == null) return;
            jarDriver.ShowGuildsPerType(sender);
        }

        private void FulfillRadioClick(object sender, EventArgs e)
        {
            if (jarDriver == null) return;
            jarDriver.ShowUnfulfilledRoles(sender);
        }
    }
}
