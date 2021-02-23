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
        JEEDriver jeeDriver;
        public Form1()
        {
            InitializeComponent();

            GuildCollection guildCollection = new GuildCollection();
            PlayerCollection playerCollection = new PlayerCollection();
            JARDriver jarDriver = new JARDriver(ref OutputListBox);

            jeeDriver = new JEEDriver(ref OutputListBox,
                                      ref ClassComboBox,
                                      ref ServerComboBox,
                                      ref AllClassTypeQueryButton,
                                      ref PercentageOfRaceComboBox,
                                      ref MaxLvlPlayersQueryButton
                                      );
            jeeDriver.Initializer(ref ClassComboBox, ref ServerComboBox, ref PercentageOfRaceComboBox);
            jarDriver.PrintAllPlayers();

        }

        private void PercentageOfRaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jeeDriver == null) return;
            jeeDriver.PercentageRaceFromServer(sender);
        }
    }
}
