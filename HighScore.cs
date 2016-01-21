///////////////////////////////
// Created by: Markus Lidrot //
// Date: 2016-01-02          //
// HighScore.cs              //
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
    /// The class is used to retrive the players name and add it to the highscore file if the score is
    /// big enough.
    /// </summary>
    public partial class HighScore : Form
    {
        //The fields used
        private int score;
        private int rowCount;
        private string[] highScores;
        private int[] highScoresPoints;

        /// <summary>
        /// The cosntruct that initializes the components and the GUI. It also takes the parameters and
        /// initiates the two main fields.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="highScores"></param>
        public HighScore(int score, string[] highScores)
        {
            InitializeComponent();

            this.score = score;
            this.highScores = highScores;

            InitializeGUI();
            CompareScores();
        }

        /// <summary>
        /// The method initializes the GUI.
        /// </summary>
        private void InitializeGUI()
        {
            textBoxHighScore.Text = String.Empty;
            labelYourScoreNr.Text = "" + score;
        }

        /// <summary>
        /// The method initiates a comparison between the score used to create the Highscore object with
        /// the values in the HighScore string array also gotten when the object was created.
        /// </summary>
        private void CompareScores()
        {
            CreateIntArray();
            CompareInts();
        }

        /// <summary>
        /// The method changes the order of the highscores to reflect possible changes to it and saves the new 
        /// highscore array to the .txt file.
        /// </summary>
        private void SaveTheScore()
        {
            ChangeOrder();
            SaveNewHighScores();
        }
        
        /// <summary>
        /// The method creates an int array from the the string array. This way values can be
        /// compared correctly.
        /// </summary>
        private void CreateIntArray()
        {
            highScoresPoints = new int[highScores.Length];
                for (int i = 0; i < highScores.Length; i++)
                {
                    string input = highScores[i];
                    string last = input.Split(' ').LastOrDefault();
                    int output;
                    if (int.TryParse(last, out output))
                    {
                        highScoresPoints[i] = output;
                    }
                    else
                    {
                        highScoresPoints[i] = 9999;
                    }
                }

            
        }

        /// <summary>
        /// The method compares the score sent as a parameter when the object was created with the int array created
        /// in with the method CreateIntArray.
        /// </summary>
        private void CompareInts()
        {
            try
            {
                for (int i = 0; i < highScores.Length; i++)
                {
                    if (highScoresPoints[i] > score)
                    {
                        rowCount++;
                    }
                }
            }
            catch(Exception e)
            {
                ShowError("The scores could not be compared.\nError message: " + e, "Could not compare ints");
            }
        }

        /// <summary>
        /// The method changes the order of the highscore based on the rowCount field (contains the position that the score should get).
        /// </summary>
        private void ChangeOrder()
        {
            if(rowCount >= highScores.Length)
            {
                //Do nothing
            }
            else
            {
                int oldRows = 0;
                string[] tempString = new string[highScores.Length];
                for(int i = 0; i < highScores.Length; i++)
                {
                    if(i == rowCount)
                    {
                        tempString[i] = PlayerNameAndScore();
                    }
                    else
                    {
                        tempString[i] = highScores[oldRows];
                        oldRows++;
                    }
                }
                highScores = tempString;
            }
        }

        /// <summary>
        /// The method is used to create a new HighScore.txt file containing the current values from
        /// the array highScores.
        /// </summary>
        private void SaveNewHighScores()
        {
            string fileName = Application.StartupPath + "\\HighScore.txt";
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(fileName);
                for (int i = 0; i < highScores.Length; i++)
                {
                    writer.WriteLine(highScores[i]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problem saving data to file!" + e.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>
        /// The method formats the name of the player and the score to look as the other results used in the highscore.
        /// </summary>
        /// <returns>string</returns>
        private string PlayerNameAndScore()
        {
            string name = textBoxHighScore.Text;
            if(name.Length > 8)
            {
                name = name.Substring(0, 8);
            }
            string namnAndScore = String.Format("{0,-8} | {1}", name, score);
            return namnAndScore;
        }

        /// <summary>
        /// The method is used to show a error message.
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <param name="errorTitle"></param>
        private void ShowError(string errorMessage, string errorTitle)
        {
            MessageBox.Show(errorMessage, errorTitle,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// The metohd is used to get a boolean result telling if the score used to create the HighScore object is big enough to
        /// qualify for the highscore list. This way the winform does not even have to be opened if the reslut is not big enough anyway.
        /// </summary>
        /// <returns>bool</returns>
        public bool ValueHighEnoughForHighScore()
        {
            if (rowCount < highScores.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method is used check if the textbox of the form is filled with text or empty before saving
        /// the new score and name to the highscore file. If the textbox is blank the user is asked to enter
        /// a name and the new score and name are not saved until the user enters a name.
        /// The dialogresult is then set to OK. To indicate that the user descided to enter a name and not
        /// just exit the form through the X in the right corner. (If the dialogresult was OK from the
        /// beginning the form would be closed as soon as the button was pressed, making the text control
        /// not work)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(textBoxHighScore.Text.Equals("") || textBoxHighScore.Text.Equals(" "))
            {
                ShowError("Textfield cannot be empty!", "Textfield error");
            }
            else
            {
                SaveTheScore();
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// If the user presses the 'Enter' jey instead of the button the result is the same as the button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                buttonOK_Click(sender, e);
            }
        }
    }
}
