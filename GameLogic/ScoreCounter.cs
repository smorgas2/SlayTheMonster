///////////////////////////////
// Created by: Markus Lidrot //
// Date: 2016-01-02          //
// ScoreCounter.cs           //
///////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheMonster
{
    /// <summary>
    /// The class is used to keep the score during a game.
    /// </summary>
    class ScoreCounter
    {
        //The field containg the score
        private int score;

        /// <summary>
        /// The construct that initiates the field points to zero.
        /// </summary>
        public ScoreCounter()
        {
            score = 0;
        }

        /// <summary>
        /// Property that returns the score.
        /// </summary>
        public int Score
        {
            get
            {
                return score;
            }
        }

        /// <summary>
        /// The method is used to add points to the score by how much damage the
        /// hero has done. Sent as an integerar parameter.
        /// </summary>
        /// <param name="damage"></param>
        public void DamageByHero(int damage)
        {
            score = score + damage;
        }

        /// <summary>
        /// Method that adds points to the score as a monster has been killed.
        /// </summary>
        public void MonsterDead()
        {
            score = score + 100;
        }

        /// <summary>
        /// Method that subtracts points from the score as the hero run away.
        /// </summary>
        public void HeroRunAway()
        {
            score = score - 50;
        }

        /// <summary>
        /// Method that subtracts points from the score as the monster run away.
        /// </summary>
        public void MonsterRunAway()
        {
            score = score - 100;
        }
    }
}
