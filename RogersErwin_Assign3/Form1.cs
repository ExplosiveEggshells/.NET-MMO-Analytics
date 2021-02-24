/*
 * NAME: Form1.cs
 * AUTHORS: Jake Rogers (z1826513), John Erwin (z1856469)
 * 
 * Serves the GUI to the user and calls JEEDriver and JARDriver to
 * fill multiple components with dynamically-intialized data 
 * (Such as the ListBoxes and the ComboBoxes).
 * 
 * Furthermore, it also contains definitions for event-handlers.
 */
using System;
using System.Windows.Forms;

namespace RogersErwin_Assign3
{
    public partial class Form1 : Form
    {
        JEEDriver jeeDriver; // instantiate JEEDriver class outside of main for wider scope
        JARDriver jarDriver;
        
        public Form1()
        {
            InitializeComponent();

            GuildCollection guildCollection = new GuildCollection();
            PlayerCollection playerCollection = new PlayerCollection();
            
            jarDriver = new JARDriver(ref OutputListBox, ref PRSLRolesComboBox, ref PRSLServersComboBox, ref PRSLMinLevelUpDown, ref PRSLMaxLevelUpDown);
            jarDriver.Initializer(ref GuildsPerTypeComboBox);

            //jeeDriver = new JEEDriver(ref OutputListBox, ref ClassComboBox, ref ServerComboBox);
            //jeeDriver.Initializer(ref ClassComboBox, ref ServerComboBox, ref PercentageOfRaceComboBox);

        }

        // DELETE ME: Hey Jake, here are all my event handlers, feel free to move things around.
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
            jarDriver = new JARDriver(ref OutputListBox, ref PRSLRolesComboBox, ref PRSLServersComboBox,
                ref PRSLMinLevelUpDown, ref PRSLMaxLevelUpDown);



            jarDriver.Initializer(ref GuildsPerTypeComboBox);
        }

        /*
         * Objective: 4 - Event handler
         * 
         * When the GuildType combo box changes, trigger the 'ShowGuildsPerType'
         * method within jarDriver. Pass the sender along as well.
         */
        private void GuildsPerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jarDriver == null) return;
            jarDriver.ShowGuildsPerType(sender);
        }

        /*
         * Objective: 5 - Event handler
         * 
         * When any of the Radio Buttons for roles are selected, trigger
         * the 'ShowUnfulfilledRoles' method within jarDriver. Pass
         * the sender along as well so it can determine which radio
         * button was selected.
         */
        private void FulfillRadioClick(object sender, EventArgs e)
        {
            if (jarDriver == null) return;
            jarDriver.ShowUnfulfilledRoles(sender);
        }

        /*
         * Objective: 3 - Event handler
         * 
         * Whenever either the Min or Max level up/downs
         * related to objective 3 are changed, run the
         * 'ConstrainUpDowns' method in jarDriver to make sure
         * they are logically constrained.
         * 
         * Additionally, trigger the 'DoPSRLSearch' to refresh
         * the query to the new level filter.
         */
        private void PRSLUpDownChange(object sender, EventArgs e)
        {
            if (jarDriver == null) return;
            jarDriver.ConstrainUpDowns(sender);
            DoPSRLSearch(sender, e);
        }


        /*
         * Objective: 3 - Event handler
         * 
         * Whenever any component related to Objective 3 is
         * changed, trigger the 'PlayersByRoleServerLevel' method
         * in jarDriver to refresh the query.
         * 
         */
        private void DoPSRLSearch(object sender, EventArgs e)
        {
            if (jarDriver == null) return;
            jarDriver.PlayersByRoleServerLevel();
        }
        #endregion
    }
}
