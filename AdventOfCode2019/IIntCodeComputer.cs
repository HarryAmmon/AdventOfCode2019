namespace AdventOfCode2019
{
    public interface IIntCodeComputer
    {
        int RunProgramCode();
        int Addition(int inputLocationOne, int inputLocationTwo, int outputLocation);

        int Multiplication(int inputLocationOne, int inputLocationTwo, int outputLocation);
    }
}