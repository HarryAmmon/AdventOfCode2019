using System;

namespace AdventOfCode2019
{
    public class IntCodeComputer : IIntCodeComputer
    {
        private int[] _programCode;
        public IntCodeComputer(int[] programCode)
        {
            _programCode = programCode;
        }
        public int[] RunProgramCode()
        {
            for (int i = 0; i < _programCode.Length; i += 4)
            {
                if (_programCode[i] == 99)
                {
                    break;
                }
                switch (_programCode[i])
                {
                    case 1:
                        Addition(_programCode[i + 1], _programCode[i + 2], _programCode[i + 3]);
                        break;
                    case 2:
                        Multiplication(_programCode[i + 1], _programCode[i + 2], _programCode[i + 3]);
                        break;
                }
            }
            return _programCode;
        }
        public int Addition(int inputLocationOne, int inputLocationTwo, int outputLocation)
        {

            _programCode[outputLocation] = _programCode[inputLocationOne] + _programCode[inputLocationTwo];
            return _programCode[outputLocation];
        }

        public int Multiplication(int inputLocationOne, int inputLocationTwo, int outputLocation)
        {
            _programCode[outputLocation] = _programCode[inputLocationOne] * _programCode[inputLocationTwo];

            return _programCode[outputLocation];
        }


    }
}