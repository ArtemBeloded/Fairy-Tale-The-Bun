using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBun.Models
{
    public class EnemyHero : BaseHero
    {
        public int id { get; set; }
        public string name { get; set; }
        public int buff { get; set; }
        public int damage { get; set; }
        public bool positiveCharacter { get; set; }
    }
}
