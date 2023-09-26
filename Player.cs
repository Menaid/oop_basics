using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_basics
{
    public class Player : IAttacker, IAttacker
    {
        void IAttacker.Attack(IDamageable enemy)
        {
            enemy.Damage(amount: 10);
        }
    }
}
