using System;
using System.Windows.Input;
using JetBrains.Annotations;
using Variant_1.Model;

namespace Variant_1.ViewModel
{
    public class QuadraticEquationViewModel: ViewModelBase
    {
        private const bool IGNORE_ERROR_ON_PARSE = true;
        private const int MAX_RANDOM_VALUE = 1000;
        private SquareEquation _squareEquation = new SquareEquation();
        private string _inputValue = "1 * x^2 + 1 * x + 0";
        public string inputValue
        {
            get => _inputValue;
            set
            {
                _inputValue = value;
                calc(value);
                OnPropertyChanged();
            }
        }

        private string _resultValue = "Результат работы";
        public string resultValue
        {
            get => _resultValue;
            set
            {
                _resultValue = value;
                OnPropertyChanged();
            }
        }

        public ICommand randomButtonOnClick
        {
            get
            {
                return new DelegateCommand(o =>
                {
                    inputValue = getRandomString();
                });
            }
        }

        [CanBeNull]
        private int[] parseInput(string input)
        {
            var rawInput = input.Replace(' ', new char());
            var rawNumbers = new String[3];
            var numbers = new int[3];
            rawNumbers[0] = rawInput.Split('*')[0];
            rawNumbers[1] = rawInput.Split('*')[1].Split('+')[1];
            rawNumbers[2] = rawInput.Split('*')[2].Split('+')[1];
            
            // фикс нулевого символа который мешал парсить
            for (int i = 0; i < rawNumbers.Length; i++)
                if (rawNumbers[i].Substring(0, 1).ToCharArray()[0] == '\0') 
                    rawNumbers[i] = rawNumbers[i].Trim('\0');
            
            for (int i = 0; i < 3; i++)
            {
                int number;
                if (int.TryParse(rawNumbers[i], out number)) numbers[i] = number;
                else if (IGNORE_ERROR_ON_PARSE)
                {
                    numbers = null;
                }
                else numbers[i] = _squareEquation.calcSimpleExercise(rawNumbers[i]);
            }
            return numbers;
        }
        private void calc(string input)
        {
            int[] numbers = parseInput(input) ;
            if (numbers != null )
            {
                resultValue = _squareEquation.calc(numbers);
            }
            else resultValue = "Ошибка";
        }

        private double[] getRandomNumbers()
        {
            Random random = new Random();
            return new double[] {random.Next(MAX_RANDOM_VALUE), random.Next(MAX_RANDOM_VALUE), random.Next(MAX_RANDOM_VALUE)};
        }

        private string getRandomString()
        {
            double[] numbers = getRandomNumbers();
            return numbers[0] + " * x^2 + " + numbers[1] + " * x + " + numbers[2];
        }
        
        // private 
    }
}