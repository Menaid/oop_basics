using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_basics
{
    public class Hydra : IDamageable, IAttacker
    {
        public int HP = 900;
        public NPCType Type = NPCType.Hostile;
        private int _baseDamage = 40;
        private int _heads = 3;

        public void Damage(int amount)
        {
            HP -= amount;
        }

       public void Attack(IDamageable enemy)
        {
            Random random = new Random();
            enemy.Damage(_baseDamage + random.Next(-2, 5));
        }
    }

    public void Damage(int amount)
    {
        HP -= amount;
    }
    public void Attack(IDamageable enemy)
    {
        Random random = new Random();
        int total = 0;
        for (int i = 0; i < _heads; i++)
        {
            total += _baseDamage + random.Next(-2, 5);
        }
        enemy.Damage(_baseDamage + random.Next(-5, 15));
    }
}
