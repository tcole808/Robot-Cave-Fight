using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace RobotCaveFightTestArena
{
    internal class Bill : IRobot
    {

        //initiate private variables and lists and such
        private string name;
        private string color;
        private string colorTwo;
        private string students;
        private string[] studentNames;
        private double health;
        private double attack;
        private double speed;
        private double defense;
        private double constitution;
        public int roundCount;
        private string Animation;
        private string ActionName;


        public Bill()
        {
            name = "Plankton";
            Color colorCode = ColorTranslator.FromHtml("#000000"); // color black
            color = Convert.ToString(colorCode);
            Color ColorTwo = ColorTranslator.FromHtml("#FF0000"); // color red
            colorTwo = Convert.ToString(ColorTwo);
            studentNames = new string[] { "Tyler", "Robert", "Mason", "Eli" };
            health = (double.MaxValue / 2);
            attack = double.MinValue;
            speed = double.MaxValue;
            defense = double.MinValue;
            constitution = double.MaxValue / 20;
        }

        public double GetHealth()
        {
            return health;
        }

        public double GetMaxHealth()
        {
            return constitution * 10;
        }

        public string GetPrimaryColor()
        {
            return color;
        }

        public string GetRobotName()
        {
            return name;
        }

        public string GetSecondaryColor()
        {
            return colorTwo;
        }

        public double GetSpeed()
        {
            return speed;
        }

        public (double, double, double, double) GetStats()
        {
            return (attack, speed, defense, constitution);
        }

        public string[] GetStudentNames()
        {
            return studentNames;
        }


        public ActionResult PerformAction(IRobot opponent)
        {
            int randy = new Random().Next(21);

            if(randy < 19)
            {
                Attack(opponent);
            }
            else
            {
                PauseTime(opponent);
            }

            return new ActionResult(ActionName, Animation);
        }

        public ActionResult Attack(IRobot opponent)
        {
            double damage = ((.6 * attack) + (.4 * defense));
            ActionName = "Attack";
            Animation = "Punch";
            opponent.TakeDamage(damage);
            return new ActionResult(ActionName, Animation);
        }

        public ActionResult PauseTime(IRobot Bill)
        {

            double healing = (Double.MaxValue * .1);
            health = health + healing;
            speed = speed - ((Double.MaxValue * .1) * 3);
            roundCount = 110;
            ActionName = "Pause Time";
            Animation = "Heal";

            return new ActionResult(ActionName, Animation);
        }

        public void Reset()
        {
            GetStats();
            GetMaxHealth();
        }


        public double GetDefense(double defense)
        {
            return defense;
        }

        string IRobot.GetStats()
        {
            return ($"Current health: {health} \nAttack: {attack} \nDefense: {defense} \nSpeed: {speed}");

        }



        public void TakeDamage(double damage)
        {
            double damageDealt = damage - (defense / 100 * damage);
            health = health - damageDealt;
        }

        public double GetAttack()
        {
            return attack;
        }

        public double GetDefense()
        {
            return defense;
        }
    }
}
