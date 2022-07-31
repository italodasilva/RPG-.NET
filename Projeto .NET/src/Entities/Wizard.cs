using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_.NET.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name,
                      int Level,
                      string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " Lançou Magia";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " Lançou magia super efetiva com bônus de " + Bonus;
            }else{
                return this.Name + " Lançou magia com força fraca com bônus de " + Bonus;
            }

        }
    }
}