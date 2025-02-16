namespace RobotCaveFightTestArena {
	internal class Program {
		static void Main(string[] args) {
			//Create bots
			//TrainingDummy trainingDummy = new TrainingDummy();
			TrainingDummy trainingDummy1 = new TrainingDummy();
			Bill bill = new Bill();
			//Plankton plankton = new Plankton();


			//Create a new arena
			Arena arena = new Arena(bill, trainingDummy1);

			arena.RunBattle();
		}
	}
}