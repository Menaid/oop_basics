using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_basics
{
    public interface IAttacker
    {
        void Attack(IDamageable enemy);
    }
}
