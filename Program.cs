namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4,5,6   ,7};
            Console.WriteLine($"Max:{Print(ints).max} \n Min:{Print(ints).min}");
        }

        static (int max, int min) Print(int[] arr)
        {// maxsimal element qiymati min ga min element qiymati maxga teng: 
            (int max, int min) value = (int.MinValue, int.MaxValue);

            foreach(int item in arr)
            {
                if (value.max < item)
                {
                    value.max = item;
                }
                if(value.min > item)
                {
                    value.min = item;
                }
            }
            return value;


        }

    }
}