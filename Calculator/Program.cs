using static System.Console;
using static CalcLibrary;

public class Program
{
    public void Main(string[] args)
    {
        var data = GetCalcData(args);

        if(data.ShowHelp)
        {
            ShowHelp();
            return;
        }

        if(data.QtdNumbers != 2 || data.Operation == Operation.NotInformed ||
           !data.NumberA.HasValue || !data.NumberB.HasValue)
        {
            ShowUsage();
            return;
        }

        ShowResultOfCalc(data);
    }
}
