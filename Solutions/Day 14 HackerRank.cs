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
