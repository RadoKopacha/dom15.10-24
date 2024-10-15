namespace Domashna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { -3, 5, 1, 9, -12, 4, 6, -2, 0 };

            Sortlist(numbers);
            FilterList(numbers);
            Displaylist(numbers);
        }

        static void Sortlist(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        int temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }

        static void FilterList(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0 && numbers[i] % 2 == 0)
                {
                    numbers.RemoveAt(i);
                }
            }
        }

        static void Displaylist(List<int> nums)
        {
            Console.WriteLine(string.Join(" ", nums));
        }
    }
    
}
