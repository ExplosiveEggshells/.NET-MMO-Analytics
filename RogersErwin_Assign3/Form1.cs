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

        #region EVENT_HANDLERS
        /**
         * Objective: 1 - Event
         * 
         * See PlayersOfClassByServer(object sender) for all details
         */
        private void AllClassTypeQueryButton_Click(object sender, EventArgs e)
        {
            if (jeeDriver == null) return;
            jeeDriver.PlayersOfClassByServer(sender);
        }
        /**
         * Objective: 2 - Event
         * 
         * See PercentageRaceFromServer(object sender) for all details
         */
        private void PercentageOfRaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jeeDriver == null) return;
            jeeDriver.PercentageRaceFromServer(sender);
        }
        /**
         * Objective: 3 - Event
         * 
         * See PercentageMaxPlayerQuery() for all details
         */
        private void MaxLvlPlayersQueryButton_Click(object sender, EventArgs e)
        {
            if (jeeDriver == null) return;
            jeeDriver.PercentageMaxPlayerQuery();
        }
        #endregion
    }
}
