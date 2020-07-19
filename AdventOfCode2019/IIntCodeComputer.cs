namespace AdventOfCode2019
{
    public interface IIntCodeComputer
    {
        int[] RunProgramCode();

        int RunProgramCode(int noun, int verb);
        int Addition(int inputLocationOne, int inputLocationTwo, int outputLocation);
        void ResetProgramCode();
        int Multiplication(int inputLocationOne, int inputLocationTwo, int outputLocation);
    }
}