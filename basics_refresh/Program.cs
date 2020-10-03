using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_refresh
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "koma";
            string s = string.Empty; // te var is exsist but has no value
            string n = null; // var is not be set 
            // two statements print nothing
            string my_name = " koma ";
            var current_time = DateTime.Now; //time now
            var today = DateTime.Today; //today
            var tommowro = DateTime.Today.AddDays(1); // tommowro
            var some = new DateTime(2020, 8, 7);
            Console.WriteLine(some.Year +"\t"+ some.Month +"\t"+ some.Day);
            Console.WriteLine(some);
            Console.WriteLine(my_name.Trim().Substring(0,3)); //kom
            Console.WriteLine(s + "empty var");
            Console.WriteLine(n + "null var");
            Console.WriteLine("Hello " + name +"!");      
            //arrays 
            int [] x = new int []{1,2,3}; // one row array
            Console.WriteLine(x[1]);//2
            int[,] y = new int[2, 2]{{1,2},{3,4}};
            Console.WriteLine(y[0,1]);//2
            int [][]jagged = new int [4][];
            jagged[0]= new int[2]{5,6};
            jagged[1] = new int[3] { 7, 8, 9 };
            Console.WriteLine(jagged[0][1]);

        }
    }
}
