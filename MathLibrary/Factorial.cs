using System.Collections.Generic;

namespace MathLibrary
{
    public class Factorial
    {
        public List<byte> GetFactorial(int n)
        {
            List<byte> result = new List<byte>();
            result.Add(1);
            result[0] = 1;
            for (int i = 2; i <= n; i++)
            {
                result = Muliply(result, i);
            }
            return result;
        }

        private List<byte> Muliply(List<byte> source, int num)
        {
            List<byte> result = new List<byte>();
            for (int i = 0; i < source.Count; i++)
            {
                result.Add(0);
            }
            int index = 0;
            bool zero = true;
            while (num > 0)
            {
                byte number = (byte)(num % 10);
                if (number > 0)
                {
                    zero = false;
                    int reminder = 0;
                    for (int i = 0; i < source.Count; i++)
                    {
                        int mult = source[i] * number + reminder;
                        if (i + index == result.Count)
                        {
                            result.Add(0);
                        }
                        int tmp = result[i + index] + mult;
                        result[i + index] = (byte)(tmp % 10);
                        reminder = tmp / 10;
                    }
                    while (reminder > 0)
                    {
                        result.Add((byte)(reminder % 10));
                        reminder /= 10;
                    }
                }
                else
                {
                    if (zero)
                    {
                        result.Insert(0, 0);
                    }
                }
                num /= 10;
                index++;
            }
            return result;
        }
    }
}
