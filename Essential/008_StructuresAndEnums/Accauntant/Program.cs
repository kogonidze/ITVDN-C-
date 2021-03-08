using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accauntant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accauntant.AskForBonus(Post.Junior, 120)); 
            Console.WriteLine(Accauntant.AskForBonus(Post.Senior, 120)); 
            Console.WriteLine(Accauntant.AskForBonus(Post.Senior, 150)); 
            Console.WriteLine(Accauntant.AskForBonus(Post.Middle, 80)); 
            Console.WriteLine(Accauntant.AskForBonus(Post.Trainee, 81));

            Console.ReadKey();
        }
    }
}
