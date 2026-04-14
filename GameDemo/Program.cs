using GameFramework.Creatures;
using GameFramework.Items.Attack;
using GameFramework.Items.Defence;
using GameFramework.Utils;
using GameFramework.World;

var config = ConfigLoader.Load("config.xml");

var world = new World(config.MaxX, config.MaxY);

Console.WriteLine($"World size: {config.MaxX}x{config.MaxY}");
Console.WriteLine($"Difficulty: {config.Difficulty}");

Logger.Instance.AddListener(msg => Console.WriteLine("LOG: " + msg));

var hero = new Player("Hero", 100);
var enemy = new Player("Enemy", 100);

enemy.OnHit += msg => Console.WriteLine(msg);
enemy.OnDeath += msg => Console.WriteLine(msg);

hero.AttackItems.Add(new AttackItem("Sword", 20));
enemy.DefenceItems.Add(new DefenceItem("Shield", 5));

int damage = hero.Hit();
enemy.ReceiveHit(damage);

Console.WriteLine($"Enemy HP: {enemy.HitPoints}");

