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
            jarDriver = new JARDriver(ref OutputListBox, ref PRSLRolesComboBox, ref PRSLServersComboBox,
                ref PRSLMinLevelUpDown, ref PRSLMaxLevelUpDown);



            jarDriver.Initializer(ref GuildsPerTypeComboBox);
            jarDriver.PrcRaceInServer("Beta4Azeroth");
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

        private void PRSLUpDownChange(object sender, EventArgs e)
        {
            if (jarDriver == null) return;
            jarDriver.ConstrainUpDowns(sender);
            DoPSRLSearch(sender, e);
        }

        private void DoPSRLSearch(object sender, EventArgs e)
        {
            if (jarDriver == null) return;
            jarDriver.PlayersByRoleServerLevel();
        }
    }
}
