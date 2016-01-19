    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }
    class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int resultado = 1 + n, i = 2;
            for (; i * i < n; ++i)
            {
                if (n % i == 0)
                {
                    resultado += i;
                    resultado += n / i;
                }
            }
            if (i * i == n)
            {
                return resultado + i;
            }
            return resultado;
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
