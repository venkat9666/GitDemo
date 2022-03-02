using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjBanking
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }



        public void GetEmployee()
        {
            Console.WriteLine("Enter the Id");
            Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Name");
            Name=Console.ReadLine();


        }
        public void DisplayEmployee()
        {
            Console.WriteLine("Employee Id{0}", Id);
        }

    }
}
