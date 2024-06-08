using System.Linq;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] arg)
        {
            int Question;
            Console.WriteLine("which question ");
            Question = Convert.ToInt32(Console.ReadLine());
            if (Question == 2)
            {

            
            // variables
            double a,d,n,r,l,k,p;
            int question;
            // selection
            Console.WriteLine("1 = Arithmetic "       + " 5 = Infinity ");
            Console.WriteLine("2 = arithmetic Total " + "6 = Sigma Notation");
            Console.WriteLine("3 = geometric "         + " 7 = Sigma Notation Pattern");
            Console.WriteLine("4 = Geometric total ");
            Console.WriteLine("enter the sum number");
            question = Convert.ToInt32(Console.ReadLine());
          
            if (question == 1 )
            {
                Console.WriteLine(" enter a");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter d");
                d = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter n");
                n = Convert.ToDouble(Console.ReadLine());

                    // method

                    double anw = maths_Fun.Question2.Arithmetic(a,d,n);
                Console.WriteLine("the anw is "+ anw);
            }
            else if (question == 2)
            {
                Console.WriteLine(" enter a");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter d");
                d = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter n");
                n = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter l");
                l = Convert.ToDouble(Console.ReadLine());

                // method
                double anw = maths_Fun.Question2.ArithmeticTotal(a,d,n,l);
                Console.WriteLine("the anw is " + anw);
            }
            else if (question == 3)
            {
                Console.WriteLine(" enter a");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter n");
                n = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter r");
                r = Convert.ToDouble(Console.ReadLine());

                // method
                double anw = maths_Fun.Question2.Geometric(a,r,n);
                Console.WriteLine("the anw is " + anw);
            }
            else if (question == 4)
            {
                Console.WriteLine(" enter a");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter n");
                n = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter r");
                r = Convert.ToDouble(Console.ReadLine());

                // method
                double anw = maths_Fun.Question2.GeometricTotal(a,r,n);
                Console.WriteLine("the anw is " + anw);
            }
            else if (question == 5)
            {
                Console.WriteLine(" enter a");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter r");
                r = Convert.ToDouble(Console.ReadLine());

                // method
                double anw = maths_Fun.Question2.infinity(a, r);
                Console.WriteLine("the anw is " + anw);
            }
            else if (question == 6)
            {

                Console.WriteLine(" enter n");
                n = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter k");
                k = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter p");
                p = Convert.ToDouble(Console.ReadLine());

                //method
                double anw = maths_Fun.Question2.SigmaNotation(n, k, p);
                Console.WriteLine("the anw is " + anw);
            }
            else if (question == 7)
            {
                Console.WriteLine(" enter n");
                n = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter k");
                k = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter p");
                p = Convert.ToDouble(Console.ReadLine());

                //method
                double anw = maths_Fun.Question2.SigmaNotationPattern(n, k, p);
                Console.WriteLine("the anw is " + anw);
            }
             

            Console.Read(); 
        }
    }

       

    }
}
