///////////////////////////////
// Created by: Markus Lidrot //
// Date: 2016-01-02          //
// Monster.cs                //
///////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheMonster
{
    /// <summary>
    /// The class is used to create Monster objects. The monster consists of four body parts and if
    /// the body part 'body' reaches zero the monster is regarded as dead.
    /// </summary>
    class Monster
    {
        //The fields used
        private int body;
        private int leftArm;
        private int rightArm;
        private int legs;
        private double damageCounter;
        private int startTotalHealth;
        private bool runAway;

        /// <summary>
        /// The construct of the class. It takes four integears as parameters and assigns the values
        /// to the differnt bodyparts of the monster. It also initiates the other fields.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="leftArm"></param>
        /// <param name="rightArm"></param>
        /// <param name="legs"></param>
        public Monster(int body, int leftArm, int rightArm, int legs)
        {
            this.body = body;
            this.leftArm = leftArm;
            this.rightArm = rightArm;
            this.legs = legs;
            startTotalHealth = body + leftArm + rightArm + legs;
            damageCounter = 1;
            runAway = false;
        }

        /// <summary>
        /// Property that returns the current "health" of the body.
        /// </summary>
        public int Body
        {
            get
            {
                return body;
            }
        }

        /// <summary>
        /// Property that returns the current "health" of the left arm.
        /// </summary>
        public int LeftArm
        {
            get
            {
                return leftArm;
            }
        }

        /// <summary>
        /// Property that returns the current "health" of the right arm.
        /// </summary>
        public int RightArm
        {
            get
            {
                return rightArm;
            }
        }

        /// <summary>
        /// Property that returns the current "health" of the legs.
        /// </summary>
        public int Legs
        {
            get
            {
                return legs;
            }
        }

        /// <summary>
        /// Method that returns true if the monster is dead.
        /// </summary>
        /// <returns>bool</returns>
        public bool IsDead()
        {
            if(body < 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method that returns true if the monster runs away. The outcome is randomized so that
        /// each result is differnt. If the method is called more than once after a monster has run
        /// away the result still be true as the field 'runAway' is used to indicate if the monster has 
        /// run away before.
        /// </summary>
        /// <returns>bool</returns>
        public bool WillRunAway()
        {
            Random rnd = new Random();
            int life = body + leftArm + rightArm + legs;
            int calcLife = life / 5;
            life = rnd.Next((life - calcLife), (life + calcLife));
            life = life * 2;
            if(legs > 0 && life < startTotalHealth || runAway == true)
            {
                runAway = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method returns an attack value from the monster. With method call made the value
        /// increases.
        /// </summary>
        /// <returns>int</returns>
        public int DoDamage()
        {
            Random rnd = new Random();
            double damageDouble = 5 * damageCounter;
            int damageInt = (int)Math.Round(damageDouble);
            damageInt = rnd.Next((damageInt - 3), (damageInt + 3));

            damageCounter = damageCounter + 0.2;

            if (leftArm < 1 && rightArm < 1)
            {
                return 0;
            }
            else if (leftArm < 1 || rightArm < 1)
            {
                return (damageInt / 2);
            }
            else
            {
                return damageInt;
            }

        }

        /// <summary>
        /// The mothod is used to deal damage to the monster. The value and which bodypart to attack is
        /// based on the parameters sent with the method call.
        /// </summary>
        /// <param name="damage"></param>
        /// <param name="bodypart"></param>
        public void TakeDamage(int damage, BodyParts bodypart)
        {
            switch (bodypart)
            {
                case BodyParts.Body:
                    body = body - damage;
                    if (body < 0)
                        body = 0;
                    break;
                case BodyParts.LeftArm:
                    leftArm = leftArm - damage;
                    if (leftArm < 0)
                        leftArm = 0;
                    break;
                case BodyParts.RightArm:
                    rightArm = rightArm - damage;
                    if (rightArm < 0)
                        rightArm = 0;
                    break;
                case BodyParts.Legs:
                    legs = legs - damage;
                    if (legs < 0)
                        legs = 0;
                    break;
                default:
                    break;
            }
        }

    }
}
