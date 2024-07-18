using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class GuessNumberGame : IGame
    {
        private INumberGenerator _iNumberGenerator;
        private IUserInteraction _iInputAction;
        public GuessNumberGame(INumberGenerator iNumberGenerator, IUserInteraction iInputAction)
        {
            _iNumberGenerator = iNumberGenerator;
            _iInputAction = iInputAction;
        }

        public void Run()
        {
            while (true)
            {
                int secret = _iNumberGenerator.Value;
                Output("Итак, угадай число.");
                while (true)
                {
                    int user_val = _iInputAction.Input;
                    if (user_val == secret)
                    {
                        Output("Молодец, угадал!");
                        Output("Сыграем еще раз? Введи 1 для продолжения игры. ");
                        if (!_iInputAction.Continue)
                            return;
                        break;
                    }
                    else 
                    {
                        Output("Не угадал. Попробуй еще раз.");
                    }
                }
            }
        }
        public void Output(string output)
        {
            Console.WriteLine(output);
        }

    }
}
