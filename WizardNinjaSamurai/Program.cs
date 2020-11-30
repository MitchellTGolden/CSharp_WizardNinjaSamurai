using System;
using WizardNinjaSamurai.Models;


namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Wizard mitchell = new Wizard("Mitchell");
            Wizard greg = new Wizard("Greg");

            Ninja adrien = new Ninja("Adrien");
            Ninja michael = new Ninja("Michael Choi");

            Samurai anne = new Samurai("Anne");
            mitchell.getStats();
            adrien.getStats();
            anne.getStats();
            mitchell.Attack(anne);
            anne.Attack(mitchell);
            adrien.Steal(anne);
            anne.Meditate();
            greg.Heal(anne);
            anne.getStats();
            Console.WriteLine("Greg says: She's... Unkillable... What have I done.");
            anne.Attack(greg);
            michael.Attack(anne);

            // adrien.Attack(mitchell);
            // adrien.Attack(mitchell);
            // adrien.Attack(mitchell);
            // adrien.Attack(mitchell);
            // adrien.Attack(mitchell);
            // adrien.Attack(mitchell);


            // adrien.getStats();



        }
    }
}
