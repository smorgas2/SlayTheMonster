///////////////////////////////
// Created by: Markus Lidrot //
// Date: 2016-01-02          //
// GameInstructions.cs       //
///////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlayTheMonster
{
    /// <summary>
    /// The class is used for the winform GameInstructions. It is used to give the player information
    /// about how the game works.
    /// </summary>
    public partial class GameInstructions : Form
    {
        /// <summary>
        /// The construct of the class. It initializes the components and the GUI.
        /// </summary>
        public GameInstructions()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// The method fills the combobox and sets the selected index to 'General Info'. It also 
        /// initiates the labelHelp.
        /// </summary>
        private void InitializeGUI()
        {
            comboBoxHelp.Items.Add("General Info");
            comboBoxHelp.Items.Add("Player Info");
            comboBoxHelp.Items.Add("Monster Info");
            comboBoxHelp.Items.Add("Score Info");
            comboBoxHelp.SelectedIndex = 0;
            GeneralInfo();
        }

        /// <summary>
        /// Method that fills the labelHelp with general information
        /// </summary>
        private void GeneralInfo()
        {
            labelHelp.Text = "The goal of the game is to collect points and try to qualify for the High score. The game consists of the player and an endless amount of monsters.\n\n" +
                "The player uses the the Attack buttons when attacking the monster. Every time the player attacks the monster counters with it’s own attack. The monster has four " +
                "points that the player can attack (body, left arm, right arm and the legs). The body is the one keeping the monster alive and when it reaches zero the monster is killed.\n\n" +
                "The player has a health gauge that depletes with every attack made. The player is able to heal oneself as many times as shown in the bottom right corner of the main window. " +
                "Every time the player heals the monster attacks.";
        }

        /// <summary>
        /// Method that fills the labelHelp with player information
        /// </summary>
        private void PlayerInfo()
        {
            labelHelp.Text = "The player has the option to run away. This will cause a drop in the total score but might save the player. The monster does not attack a running player and the new " +
                "monster will have reset damage power.\nThe hero damage is also reset when a monster is killed or it runs away.\n\n" +
                "The player is rewarded with extra points when a monster is killed. But points are taken from the player if the monster or the player runs away.";
        }

        /// <summary>
        /// Method that fills the labelHelp with monster information
        /// </summary>
        private void MonsterInfo()
        {
            labelHelp.Text = "If one arm of the monsters arm is brought down to zero it attacks at half the strength as before. If both arms are brought down to zero the monster can not attack any more. " +
                "This is a good time to heal the player as can not attack after the player is healed.\n\n" +
                "For every attack on one monster the damage the player and the monster is able to do increases. When a new monster spawns the attack damage is reset\n\n" +
                "If the monster is damaged to much and still has health left in its legs it may run away. This will result in a loss of points and the attack power of the player is reset.";
        }

        /// <summary>
        /// Method that fills the labelHelp with score information
        /// </summary>
        private void ScoreInfo()
        {
            labelHelp.Text = "+100: If the player kills a monster \n\n- 100: If the monster runs away \n\n- 50: If the player runs away";
        }

        /// <summary>
        /// The method checks the current selected item in the combobox and then calls a method
        /// based on the selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxHelp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = comboBoxHelp.SelectedItem.ToString();
            switch(value)
            {
                case "General Info":
                    GeneralInfo();
                    break;
                case "Player Info":
                    PlayerInfo();
                    break;
                case "Monster Info":
                    MonsterInfo();
                    break;
                case "Score Info":
                    ScoreInfo();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// The method closes the winform.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
