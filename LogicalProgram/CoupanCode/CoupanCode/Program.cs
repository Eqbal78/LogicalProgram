using System;
using System.Collections;



namespace CoupanCode
{
    class Program
    {
        static String chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        static String Coupan()
        {
            var random = new Random();
            var stringChars = new char[6];
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            return finalString;
        }
        static void Main(string[] args)
        {
          
            var arlist = new ArrayList();
            Console.WriteLine("Enter the Number to code Generate:");
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j<n; j++)
            {
                var cp = Coupan();
                if(!arlist.Contains(cp))
                {
                    arlist.Add(cp);
                }
            }
            foreach ( String cp in arlist)
            {
                Console.WriteLine(cp);
            }            
        }
      
    }
}
