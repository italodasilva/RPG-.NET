using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_.NET.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name,
                      int Level,
                      string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
    }
}