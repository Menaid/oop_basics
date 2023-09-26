using oop_basics;

//Character c1 = new Character();
//Character c2 = new Character();

//Console.WriteLine(c2.Damage);
//c1.Attack(c2);
//Console.WriteLine();


//Player p1 = new Player();
//Player p2 = new Player();

//Console.WriteLine(p2.HP);
//p1.Attack(p2);
//Console.WriteLine(p2.HP);

//Player player = new Player();
//Hostile enemy = new Hydra();

//void WriteHP(string name, Character c)
//{
//    Console.WriteLine(name + " Has: " + c.HP + " HP left ");
//}

//player.Attack(enemy);
//WriteHP(name: "Hydra", enemy);
//WriteHP(name: "Hekmat", player);
//enemy.


Player player = new Player();
Hydra enemy = new Hydra();

Console.WriteLine(enemy.HP);
((IAttacker)player).Attack(enemy);
enemy.Attack(player);