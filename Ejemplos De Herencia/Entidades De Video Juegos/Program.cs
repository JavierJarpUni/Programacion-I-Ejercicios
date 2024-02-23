Player player = new Player(10, 10, 20);
Enemy enemy = new Enemy(10, "Goblino");

player.TakeDamage(5);
enemy.TakeDamage(1);

enemy.AttackPlayer(5, player);
Console.WriteLine($"Player has {player.GetHealth()} HP.");