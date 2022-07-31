using System;
using Projeto_.NET.src.Entities;

namespace Projeto .NET
{

    class Program{

        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard Wizard = new Wizard("Jennica", 23, "White Wizard");
            
            Console.WriteLine(Wizard.Attack(1));
            Console.WriteLine(Wizard.Attack(7));
        }
    }
}
