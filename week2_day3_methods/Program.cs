using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("please enter a name");
            //string name = Console.ReadLine();
            //Console.WriteLine("please enter the best food ever!");
            //string food = Console.ReadLine();
            //FavoriteFood(name, food);
            //FavoriteFood(" yusuf", "pasta");
            //FavoriteFood("ali", "rice");
            //FavoriteFood("ahmed", "kfc");
            RetirementCalculater(40);

        }
        public static void RetirementCalculater(int userAge)
        {
            int retirementAge = Math.Max(0, 65 - userAge);
            Console.WriteLine("the use will retire in " + retirementAge+ "userAge");
        }

        public static void FavoriteFood(string name , string food)
        {
           Console.WriteLine(name + "favorite food is" + food);
            Console.WriteLine("**********************************");
            
        } //end favorite

        public static int add(int firstName, int secondNumber)
        {
            int sum = firstName + secondNumber;
            return sum;
    
            
            
            
            
                

    }
    }
}

