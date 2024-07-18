using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class UserInput : IUserInteraction
    {
        private readonly int _min;
        private readonly int _max;
        public UserInput(int minVal, int maxVal) 
        { 
            _min = minVal;
            _max = maxVal;
        }
        public int Input 
        {
            get
            {
                while (true)
                {
                    try
                    {
                        int val = Convert.ToInt32(Console.ReadLine());
                        if (val >= _min && val <= _max)
                            return val;

                        Console.WriteLine($"Число должно находиться в диапазоне от {_min} до {_max}. Попробуй еще раз.");
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка преобразования введенного параметра в число. Попробуй еще раз.");
                    }
                }
            }
        }

        public bool Continue
        {
            get 
            {
                try
                {
                    int answer = Convert.ToInt32(Console.ReadLine());
                    return answer == 1;
                }
                catch 
                {
                }
                return false;
            }
        }
    }
}
