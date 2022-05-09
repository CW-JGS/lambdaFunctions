using System;

namespace AnonFNs
{
    class Program 
    {
        public delegate void DelegateForLambdas(string pName);
        static void Main(string[] args)
        {
            // task 1
            DelegateForLambdas myDel;
            myDel = (string pName) => {Console.WriteLine(" Welcome friend {0}!",pName);};

            myDel.Invoke("Jack");


            // task 1 - 2 electric boogaloo
            Action<string> printGreating = (string pName) => Console.WriteLine(" Welcome friend {0}!",pName);
            printGreating("jack 2");
            // task 2
            Func<int, int, string> addTwoNums = (int num1, int num2) => (num1 + num2).ToString();
            Console.WriteLine(addTwoNums(60,9));
            // task 3
            int[] testData = new int[5];
            Console.WriteLine(" Input 5 elements in the array");
            for (int i = 0; i<5; i++) {
                Console.Write("\n element {0} - ",i);
                bool isInputValid = int.TryParse(Console.ReadLine(), out testData[i]);
                if (!isInputValid) {
                    Console.WriteLine(" I see you");
                    i--;
                }
            }
            Func<int[], int> sumArray = (int[] elements) => elements.Sum();
            Console.WriteLine(" {0}", sumArray(testData));
            // task 4
            Action<int, int> raiseToN = (int baseNumber, int exponent) => {
                double x = Convert.ToDouble(baseNumber);
                double y = Convert.ToDouble(exponent);
                double dblReturnVal = Math.Pow(x, y);
                Console.WriteLine(" {0}", Convert.ToInt32(dblReturnVal));
            };
            raiseToN(2, 2);
            
            Func<int, int> fibSeq = (int index) => {
                int a = 0; 
                int b = 1;
                for(int j=0; j<index; j++) 
                {
                    a = b;
                    b = a+b;
                }
                return b;
            };
            Console.WriteLine(" {0}", fibSeq(5));


        }
    }
}