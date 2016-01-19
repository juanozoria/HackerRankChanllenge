public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }
//Write your code here
class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            System.Collections.Generic.List<int> numero = new System.Collections.Generic.List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    numero.Add(i);
                }

            }
            return Sum(numero);
        }

        public int Sum(System.Collections.Generic.List<int> numero)
        {
            int res = 0;

            foreach (var item in numero)
            {
                res += item;
            }
            return res;
        }
    }
    class Solution{
    static void Main(string[] args){
        int n=Int32.Parse(Console.ReadLine());
      	AdvancedArithmetic myCalculator=new Calculator();
        int sum=myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n"+sum); 
    }
}
