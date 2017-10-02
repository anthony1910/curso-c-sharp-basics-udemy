using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            test.addNumbers(9, 10);
        }
        public void addNumbers(int myNum, int otherNum)
        {
            int result = myNum + otherNum;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
