var game = new Game();

game.SetName("Player1");
game.SetMoney("100");
game.SetWeapon("Sword");

var careTaker = new CareTaker(game);

careTaker.AddCheckPoint(game.createCheckPoint());

game.SetName("Player2");
game.SetMoney("200");
game.SetWeapon("Axe");

careTaker.AddCheckPoint(game.createCheckPoint());

game.SetName("Player3");
game.SetMoney("300");
game.SetWeapon("Bow");

careTaker.AddCheckPoint(game.createCheckPoint());



Console.WriteLine("Current Checkpoints:");
careTaker.showCheckPoints();

Console.WriteLine("Current Player State:");
game.showCurrentState();

Console.WriteLine("=======================================");
careTaker.undoCheckpoint();

Console.WriteLine("Current Checkpoints:");
careTaker.showCheckPoints();

Console.WriteLine("Current Player State:");
game.showCurrentState();

