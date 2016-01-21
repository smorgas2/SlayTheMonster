///////////////////////////////
// Created by: Markus Lidrot //
// Date: 2016-01-02          //
// GameEngine.cs             //
///////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheMonster
{
    /// <summary>
    /// The class is responsible for the game mechanics. It has three objects that are used to create the game logic.
    /// Most of the classes metohds are public (either a Get-method for the GUI or a methodcall from the GUI to do something
    /// to the monster or hero object.
    /// </summary>
    class GameEnigine
    {
        //The objects used in the class
        private Hero hero;
        private Monster monster;
        private ScoreCounter scoreCount;

        /// <summary>
        /// The construct of the class. It initiates objects through the NewGame method.
        /// </summary>
        public GameEnigine()
        {
            NewGame();
        }

        /// <summary>
        /// Method that creates a new monster object and resets the attack damage of the hero
        /// </summary>
        private void CreateNewMonster()
        {
            monster = new Monster(120, 30, 30, 60);
            hero.NewMonsterCreated();
        }

        /// <summary>
        /// Method is used to deal damage to the hero (player). If the monster ran away or got killed
        /// the hero is not hurt. Also if after the attack if the heros health is unchanged (due to
        /// the monsters arms being zero), the return value is false.
        /// </summary>
        /// <returns>bool</returns>
        private bool HurtHero()
        {
            bool hurtHero = true;
            if (monster.WillRunAway() || monster.IsDead())
            {
                hurtHero = false;
            }
            else
            {
                int tempHealthHero = hero.Health;
                hero.TakeDamage(monster.DoDamage());
                if (tempHealthHero == hero.Health)
                {
                    hurtHero = false;
                }
            }
            return hurtHero;
        }

        /// <summary>
        /// Intitiates the objects and in doing so enables a new game to be played.
        /// </summary>
        /// <returns>bool</returns>
        public bool NewGame()
        {
            bool ok;
            try
            {
                hero = new Hero(200, 3);
                scoreCount = new ScoreCounter();
                CreateNewMonster();
                ok = true;
            }
            catch
            {
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// Method that when called upon deals damage to the monster and the hero (player).
        /// If the health of the hero or the monsters body is bigger than zero the attack
        /// will take place.
        /// </summary>
        /// <param name="bodypart"></param>
        /// <returns>bool</returns>
        public bool HurtMonster(BodyParts bodypart)
        {
            bool isHeroAttackedBack = true;
            if (hero.Health > 0 || monster.Body > 0)
            {
                int heroDamage = hero.DoDamage();
                monster.TakeDamage(heroDamage, bodypart);
                scoreCount.DamageByHero(heroDamage);

                if(!HurtHero())
                {
                    isHeroAttackedBack = false;
                }
            }

            return isHeroAttackedBack;
        }

        /// <summary>
        /// The method is used to heal the hero. Everytime the method is called the hero tries to heal. If there are no more heals left
        /// the hero is not healed and the return value is false. If the player does get healed the monster attacks.
        /// </summary>
        /// <returns>bool</returns>
        public bool UseHealing()
        {
            bool heal = hero.Heal();
            if (heal)
            {
                hero.TakeDamage(monster.DoDamage());
            }
            return heal;
        }

        /// <summary>
        /// When called upon a new monster is created and the damage counter off the hero is reset. A penalty for running away
        /// is also given to the hero (loss of points).
        /// </summary>
        public void HeroRunAway()
        {
            scoreCount.HeroRunAway();
            CreateNewMonster();
        }

        /// <summary>
        /// Method that checks if the monster will run away and if so a new monster is created
        /// and the score is adjusted.
        /// </summary>
        /// <returns>bool</returns>
        public bool HasMonsterRunAway()
        {
            bool currentValue = monster.WillRunAway();
            if (currentValue == true)
            {
                scoreCount.MonsterRunAway();
                CreateNewMonster();
            }
            return currentValue;
        }

        /// <summary>
        /// Method that checks if the monster is dead. If so a new monster is created and the score is adjusted.
        /// </summary>
        /// <returns>bool</returns>
        public bool IsMonsterDead()
        {
            bool currentValue = monster.IsDead();
            if(currentValue == true)
            {
                scoreCount.MonsterDead();
                CreateNewMonster();
            }
            return currentValue;
        }

        /// <summary>
        /// Method that checks if the hero is alive and returns a boolean depening on the heros health.
        /// </summary>
        /// <returns>bool</returns>
        public bool IsHeroAlive()
        {
            if (hero.IsAlive())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method that returns the heroes health.
        /// </summary>
        /// <returns>int</returns>
        public int GetHeroHealth()
        {
            return hero.Health;
        }

        /// <summary>
        /// Method that returns the number of healings the hero has left.
        /// </summary>
        /// <returns>int</returns>
        public int GetHeroNrOfHealings()
        {
            return hero.NumberOfHealings;
        }

        /// <summary>
        /// Method that returns the all the integear values of the body parts of the monster as 
        /// an int array.
        /// </summary>
        /// <returns>int array</returns>
        public int[] GetMonsterHealth()
        {
            int[] monsterHealth = new int[4];
            monsterHealth[0] = monster.Body;
            monsterHealth[1] = monster.LeftArm;
            monsterHealth[2] = monster.RightArm;
            monsterHealth[3] = monster.Legs;
            return monsterHealth;
        }

        /// <summary>
        /// Method that returns the the current score.
        /// </summary>
        /// <returns>int</returns>
        public int GetPoints()
        {
            return scoreCount.Score;
        }

    }
}
