using System.Drawing;

namespace RobotCaveFightTestArena
{
    internal class Plankton : IRobot
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


        public Plankton()
        {
            name = "Plankton";
            Color colorCode = ColorTranslator.FromHtml("#000000"); // color black
            color = Convert.ToString(colorCode);
            Color ColorTwo = ColorTranslator.FromHtml("#FF0000"); // color red
            colorTwo = Convert.ToString(ColorTwo);
            studentNames = new string[] {"Tyler", "Robert", "Mason", "Eli"};
            health = 10;
            attack = double.MinValue;
            speed = double.MaxValue;
            defense = double.MinValue;
            constitution = 1;
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
            throw new NotImplementedException();
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
