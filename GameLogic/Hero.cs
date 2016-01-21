///////////////////////////////
// Created by: Markus Lidrot //
// Date: 2016-01-02          //
// Hero.cs                   //
///////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheMonster
{
    /// <summary>
    /// The class is used to create Hero objects. The health, number of healings
    /// and damagecounters are the main fieleds used. 
    /// </summary>
    class Hero
    {
        //The fields used
        private int health;
        private int intitalHealth;
        private int numberOfHealings;
        private int amountOfHealing;
        private double damageCounter;

        /// <summary>
        /// The construct of the class. It takes two int parameters as the starting health of the hero created
        /// and the number of healings the hero has. It also initiates all the other fields.
        /// </summary>
        /// <param name="health"></param>
        /// <param name="numberOfHealings"></param>
        public Hero(int health, int numberOfHealings)
        {
            this.health = health;
            this.numberOfHealings = numberOfHealings;
            intitalHealth = health;
            amountOfHealing = health / numberOfHealings;
            NewMonsterCreated();
        }

        /// <summary>
        /// Property that returns the health value.
        /// </summary>
        public int Health
        {
            get
            {
                return health;
            }
        }

        /// <summary>
        /// Property that returns the number of healings left.
        /// </summary>
        public int NumberOfHealings
        {
            get
            {
                return numberOfHealings;
            }
        }

        /// <summary>
        /// Method that returns a boolean that is true if the Hero is alive and false if the hero is not.
        /// </summary>
        /// <returns>bool</returns>
        public bool IsAlive()
        {
            if (health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method used to reset the damageCounter of the hero to the start value.
        /// </summary>
        public void NewMonsterCreated()
        {
            damageCounter = 1;
        }

        /// <summary>
        /// The method increases the hero health if there are healings left. The hero can never gain more
        /// life than the total life the hero began with.
        /// </summary>
        /// <returns>bool</returns>
        public bool Heal()
        {
            bool check = false;
            if(numberOfHealings > 0)
            {
                health = health + amountOfHealing;
                if(health > intitalHealth)
                {
                    health = intitalHealth;
                }
                numberOfHealings--;

                check = true;
            }
                return check;
        }

        /// <summary>
        /// The method is used to hurt the hero. The hero can never reach a number below 0. If parameter damage would cause this
        /// the hero health is set to zero. 
        /// </summary>
        /// <param name="damage"></param>
        public void TakeDamage(int damage)
        {
            health = health - damage;
            if(health < 0)
            {
                health = 0;
            }
        }

        /// <summary>
        /// The method deals damage based on the damage counter and a randomized value.
        /// </summary>
        /// <returns>int</returns>
        public int DoDamage()
        {
            Random rnd = new Random();
            double damageDouble = 6 * damageCounter;
            int damageInt = (int) Math.Round(damageDouble);
            damageInt = rnd.Next((damageInt - 3), (damageInt + 3));

            damageCounter = damageCounter + 0.2;
            return damageInt;
        }
    }
}
