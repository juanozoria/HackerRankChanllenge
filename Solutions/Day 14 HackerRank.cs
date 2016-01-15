public class Difference
    {
        private int[] elements;
        public int maximumDifference;
        //Constructor de la clase que toma un arreglo por parametro
        public Difference(int[] arreglo)
        {
            this.elements = arreglo;
        }
        public void computeDifference()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length; j++)
                {
                    int result = Math.Abs(elements[i] - elements[j]);
                    if (result > this.maximumDifference)
                    {
                        this.maximumDifference = result;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
