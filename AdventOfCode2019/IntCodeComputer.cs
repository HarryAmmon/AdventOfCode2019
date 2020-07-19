using System;

namespace AdventOfCode2019
{
    public class IntCodeComputer : IIntCodeComputer
    {
        private int[] _programCode;
        private int[] _originalProgramCode;

        public IntCodeComputer(int[] programCode)
        {
            _programCode = programCode;
            _originalProgramCode = new int[_programCode.Length];
            _programCode.CopyTo(_originalProgramCode, 0);
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

        public int RunProgramCode(int noun, int verb)
        {
            _programCode[1] = noun;
            _programCode[2] = verb;

            return RunProgramCode()[0];
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

        public void ResetProgramCode()
        {
            _originalProgramCode.CopyTo(_programCode, 0);
        }
    }
}