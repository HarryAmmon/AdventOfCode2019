namespace AdventOfCode2019
{
    public class IntCodeComputer : IIntCodeComputer
    {
        private int[] _programCode;
        public IntCodeComputer(int[] programCode)
        {
            _programCode = programCode;
        }

        public int Addition(int inputLocationOne, int inputLocationTwo, int outputLocation)
        {
            int valueOnePosition = _programCode[inputLocationOne];
            int valueTwoPosition = _programCode[inputLocationTwo];
            int outputPosition = _programCode[outputLocation];

            _programCode[outputPosition] = _programCode[valueOnePosition] + _programCode[valueTwoPosition];
            return _programCode[outputPosition];
        }

        public int Multiplication(int inputLocationOne, int inputLocationTwo, int outputLocation)
        {
            int valueOnePosition = _programCode[inputLocationOne];
            int valueTwoPosition = _programCode[inputLocationTwo];
            int outputPosition = _programCode[outputLocation];

            _programCode[outputPosition] = _programCode[inputLocationOne] * _programCode[inputLocationTwo];
            return _programCode[outputPosition];
        }

        public int RunProgramCode()
        {
            return _programCode[0];
        }
    }
}