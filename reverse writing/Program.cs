using System;

namespace reverse_writing
{
    class Program
    {
        static void Main(string[] args)
        {

            
            StringReverse("KeleM");



        }

        //Reverse String
        static void StringReverse(string name)
        {
            string Reverse = String.Empty;

            for (int i = name.Length - 1; i > -1; i--)
            {
                Reverse += name[i];
            }

            Console.WriteLine(Reverse);


        }
            


    }

}
