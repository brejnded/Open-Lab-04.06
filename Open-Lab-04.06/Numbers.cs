
namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            int k = 0;
            int[] A = new int[count];
                    for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    A[k] = numbers[j];
                    k++;
                }
            }
            return A;
            }
    
        }
}
