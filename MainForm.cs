///////////////////////////////
// Created by: Markus Lidrot //
// Date: 2016-01-02          //
// MainForm.cs               //
///////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlayTheMonster
{
    /// <summary>
    /// The main GUI class. The game is played through this winform and all other GUI windows are
    /// accesed through the menustrip in this class.
    /// </summary>
    public partial class MainForm : Form
    {
        //The object and 
        private GameEnigine gameEngine;
        private string[] highScores;

        /// <summary>
        /// The main construct that initializes the GUI components. And initiates the gameEngine object
        /// and the array used in the main GUI form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            
            gameEngine = new GameEnigine();
            highScores = new string[20];

            InitializeGUI();
        }

        /// <summary>
        /// Intitializes the GUI so that the buttons are disabled, the highscore is retrived and added to the listbox.
        /// The picturebox containing the monster is also made invisable.
        /// </summary>
        private void InitializeGUI()
        {
            lockButtons();
            OpenFileAndSaveToArray();
            AddHighScoresToListbox();
            pictureBoxMonster.Visible = false;
        }

        /// <summary>
        /// Method that is used to disable all buttons in the main GUI form.
        /// </summary>
        private void lockButtons()
        {
            buttonBody.Enabled = false;
            buttonRightArm.Enabled = false;
            buttonLeftArm.Enabled = false;
            buttonLegs.Enabled = false;
            buttonHeal.Enabled = false;
            buttonRunAway.Enabled = false;
        }

        /// <summary>
        /// Method that is used to enable all buttons in the main GUI form.
        /// </summary>
        private void unlockAllButtons()
        {
            unlockAttackButtons();
            buttonHeal.Enabled = true;
            buttonRunAway.Enabled = true;
        }

        /// <summary>
        /// Method that is used to enable the attack buttons in the main GUI form.
        /// </summary>
        private void unlockAttackButtons()
        {
            buttonBody.Enabled = true;
            buttonRightArm.Enabled = true;
            buttonLeftArm.Enabled = true;
            buttonLegs.Enabled = true;
        }

        /// <summary>
        /// The method updates the GUI. All active stats are retrived from through the GameEngine object.
        /// </summary>
        private void UpdateGUI()
        {
            int[] monsterHealth = gameEngine.GetMonsterHealth();
            labelBodyNumber.Text = "" + monsterHealth[0];
            labelLeftArmNumber.Text = "" + monsterHealth[1];
            labelRightArmNumber.Text = "" + monsterHealth[2];
            labelLegsNumber.Text = "" + monsterHealth[3];
            labelHeroHealthNumber.Text = "" + gameEngine.GetHeroHealth();
            labelHealsLeftNumber.Text = "" + gameEngine.GetHeroNrOfHealings();
            labelCrurrentScoreNumber.Text = "" + gameEngine.GetPoints();
            pictureBoxMonster.Image = SlayTheMonster.Properties.Resources.MonsterNormal;

            if (monsterHealth[1] == 0)
                buttonLeftArm.Enabled = false;
            if (monsterHealth[2] == 0)
                buttonRightArm.Enabled = false;
            if (monsterHealth[3] == 0)
                buttonLegs.Enabled = false;
            if (gameEngine.GetHeroNrOfHealings() == 0)
                buttonHeal.Enabled = false;
        }

        /// <summary>
        /// Tries to open the file HighScore.txt and save the text from it to the array highScores. 
        /// If the file can not be found or if something else is wrong the array is filled with empty strings.
        /// The last is true even when the file is opened succesfully but does not contain as many lines as the
        /// arrays size as well. Then the remaing slots in the array is filled with empty strings.
        /// </summary>
        private void OpenFileAndSaveToArray()
        {
            string fileName = Application.StartupPath + "\\HighScore.txt";
            StreamReader reader = null;

            for (int i = 0; i < highScores.Length; i++)
            {
                highScores[i] = String.Empty;
            }

            try
            {
                string textIn;
                reader = new StreamReader(fileName);
                int index = 0;
                while (!reader.EndOfStream && index < highScores.Length)
                {
                    textIn = reader.ReadLine();
                    highScores[index] = textIn;
                    index++;
                }
            }
            catch
            {
                ShowMessage("Problem retriving Highscore data. If you continue playing " +
                    "a new list will be created when you enter a Highscore", "Could not load the highscore");
            }
            finally
            {
                if (reader != null) reader.Close();
            }
        }

        /// <summary>
        /// Method that adds the string values from the array highScores to the listbox.
        /// </summary>
        private void AddHighScoresToListbox()
        {
            listBoxHighScore.Items.Clear();
            try
            {
                for (int i = 0; i < highScores.Length; i++)
                {
                    listBoxHighScore.Items.Add(highScores[i]);
                }
            }
            catch
            {
                ShowError("Could not update the listbox.", "Listbox error");
            }

        }

        /// <summary>
        /// Method that takes a Bodypart as parameter and then calls the attack method in the gameEngine object.
        /// Depending on return value the status of the monster is checked. The status of the player is always checked.
        /// </summary>
        /// <param name="bodypart"></param>
        private void AttackMonster(BodyParts bodypart)
        {
            if (gameEngine.HurtMonster(bodypart))
            {
                IndicateHealthReduction();
                UpdateGUI();
            }
            else
            {
                UpdateGUI();
                CheckIfMonsteIsDead();
                CheckIfMonsterRunAway();
                UpdateGUI();
            }
            CheckIfHeroIsDead();
        }

        /// <summary>
        /// Method that checks if the monster is dead. If the monster is dead the attack buttons are enabled, the image is changed
        /// and a message indicating that the monster is dead is shown.
        /// </summary>
        private void CheckIfMonsteIsDead()
        {
            if (gameEngine.IsMonsterDead())
            {
                unlockAttackButtons();
                pictureBoxMonster.Image = SlayTheMonster.Properties.Resources.MonsterDead;
                ShowMessage("You killed the monster!", "Monster killer");
            }
        }

        /// <summary>
        /// Method that checks if the monster is ran away. If the monster ran away the attack buttons are enabled, the image is changed
        /// and a message indicating that the monster ran away is shown.
        /// </summary>
        private void CheckIfMonsterRunAway()
        {
            if (gameEngine.HasMonsterRunAway())
            {
                unlockAttackButtons();
                pictureBoxMonster.Image = SlayTheMonster.Properties.Resources.MonsterRunAway;
                ShowMessage("The monster ran away!", "Monster failure");
            }
        }

        /// <summary>
        /// Method that checks if the hero died. If the hero died all buttons are diabled, the image is changed
        /// and a message indicating that the player died i shown. 
        /// The method GameOver is also called that deals with the points and the Highscore.
        /// </summary>
        private void CheckIfHeroIsDead()
        {
            if(!gameEngine.IsHeroAlive())
            {
                lockButtons();
                pictureBoxMonster.Image = SlayTheMonster.Properties.Resources.MonsterPlayerLose;
                ShowMessage("You have been killed!\nGame Over", "Game Over");
                GameOver();
            }
        }

        /// <summary>
        /// The method checks if the accumulated points are enough for the Highscore. If it is, the user is asked if they want to enter
        /// ther score to the highscore. If they want to a new winform is opened and depending on if they click on OK the score is assumed
        /// to be saved so the Highscore file is opened again and added to the listbox.
        /// </summary>
        private void GameOver()
        {
            HighScore hs = new HighScore(gameEngine.GetPoints(), highScores);
            if (!hs.ValueHighEnoughForHighScore())
            {
                ShowMessage("You did not reach a Highscore", "No Highscore");
            }
            else
            {
                DialogResult res = MessageBox.Show("Do you want to enter your name for the Highscore?", "Highscore", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    DialogResult result = hs.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        OpenFileAndSaveToArray();
                        AddHighScoresToListbox();
                    }
                }
            }
        }

        /// <summary>
        /// Method used to show error messages. It takes to strings as parameters (message and title).
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <param name="errorTitle"></param>
        private void ShowError(string errorMessage, string errorTitle)
        {
            MessageBox.Show(errorMessage, errorTitle,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Method used to show messages. It takes to strings as parameters (message and title).
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        private void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        /// <summary>
        /// Method that changes the background color of the label used to show player health to red
        /// for a brief moment to indicate that the player has taken damage.
        /// </summary>
        private async void IndicateHealthReduction()
        {
            labelHeroHealthNumber.BackColor = System.Drawing.Color.Red;
            await Task.Delay(150);
            labelHeroHealthNumber.BackColor = System.Drawing.Color.Silver;
        }

        /// <summary>
        /// Method that exits the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        /// Method that starts a new game. It unlocks all buttons and makes the monster image visible. If NewGame
        /// method is not true the user is given a message about it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(gameEngine.NewGame())
            {
                pictureBoxMonster.Visible = true;
                UpdateGUI();
                unlockAllButtons();
            }
            else
            {
                ShowError("Could not start a new game", "New Game error");
            }
        }

        /// <summary>
        /// Method that opens a new winform with gameinstructions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameInstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameInstructions help = new GameInstructions();
            help.Show();
        }

        /// <summary>
        /// Method that opens a winform with information about the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }

        /// <summary>
        /// Method that calls the AttackMonster method to attack the body. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBody_Click(object sender, EventArgs e)
        {
            AttackMonster(BodyParts.Body);
        }

        /// <summary>
        /// Method that calls the AttackMonster method to attack the left arm. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRightArm_Click(object sender, EventArgs e)
        {
            AttackMonster(BodyParts.LeftArm); //The body
        }

        /// <summary>
        /// Method that calls the AttackMonster method to attack the right arm. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeftArm_Click(object sender, EventArgs e)
        {
            AttackMonster(BodyParts.RightArm); //The body
        }

        /// <summary>
        /// Method that calls the AttackMonster method to attack the legs. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLegs_Click(object sender, EventArgs e)
        {
            AttackMonster(BodyParts.Legs); //The body
        }

        /// <summary>
        /// Method that calls the heal method in gameEngine object. If there is no more healing possible
        /// the player is told with a message. This will never happen if the UpdateGUI metod is called as
        /// it contains a control for the Heal button that makes it disabled if there is no more healing possible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHeal_Click(object sender, EventArgs e)
        {
            if (!gameEngine.UseHealing())
            {
                ShowMessage("Can not heal anymore!", "No more healing");
            }
            IndicateHealthReduction();
            UpdateGUI();
        }

        /// <summary>
        /// Method that calles the HeroRunAway method that creates a new monster so that the player
        /// is not damaged as much.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRunAway_Click(object sender, EventArgs e)
        {
            gameEngine.HeroRunAway();
            unlockAttackButtons();
            UpdateGUI();
        }
    }
}
