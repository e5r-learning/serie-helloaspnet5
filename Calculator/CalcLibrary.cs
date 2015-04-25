using static System.Console;

public enum Operation
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
    NotInformed
}

public class CalcData
{
    public bool ShowHelp { get; set; } = false;
    public Operation Operation { get; set; } = Operation.NotInformed;
    public int? NumberA { get; set; } = null;
    public int? NumberB { get; set; } = null;
    public int QtdNumbers { get; set; } = 0;
}

public static class CalcLibrary
{
    public static CalcData GetCalcData(string[] args)
    {
        var data = new CalcData();
        var argIndex = 0;
        var argSub = 0;

        while(args.Length > argIndex)
        {
            var arg = args[argIndex];

            if(arg.StartsWith("--"))
            {
                switch(arg.ToLower())
                {
                    case "--help":
                        data.ShowHelp = true;
                        argSub++;
                        break;
                    case "--add":
                        data.Operation = Operation.Addition;
                        argSub++;
                        break;
                    case "--sub":
                        data.Operation = Operation.Subtraction;
                        argSub++;
                        break;
                    case "--mult":
                        data.Operation = Operation.Multiplication;
                        argSub++;
                        break;
                    case "--div":
                        data.Operation = Operation.Division;
                        argSub++;
                        break;
                }
            } else if (data.NumberA == null) {
                int number;

                if(int.TryParse(arg, out number))
                {
                    data.NumberA = number;
                }
            } else if (data.NumberB == null) {
                int number;

                if(int.TryParse(arg, out number))
                {
                    data.NumberB = number;
                }
            }
            argIndex++;
        }

        data.QtdNumbers = args.Length - argSub;

        return data;
    }

    public static void ShowCopyright()
    {
        WriteLine("Copyright (C) Erlimar Silva Campos. All rights reserved.");
        WriteLine("Copyright (C) E5R Development Team. All rights reserved.");
        WriteLine();
    }

    public static void ShowHelp()
    {
        ShowCopyright();

        WriteLine("A simple calculator in command line.");
        WriteLine();

        ShowUsage();
    }

    public static void ShowUsage()
    {
        WriteLine("Usage: calculator <numberA> <numberB> [operation]");
        WriteLine();
        WriteLine("    <numberA>   Any integer number");
        WriteLine("    <numberB>   Any integer number");
        WriteLine();
        WriteLine("Operation:");
        WriteLine("    --add   <numberA> + <numberB>");
        WriteLine("    --sub   <numberA> - <numberB>");
        WriteLine("    --mult  <numberA> * <numberB>");
        WriteLine("    --div   <numberA> / <numberB>");
    }

    public static void ShowResultOfCalc(CalcData data)
    {
        char op = '?';
        int result = 0;

        if(data.Operation == Operation.Addition)
        {
            op = '+';
            result = data.NumberA.Value + data.NumberB.Value;
        }

        if(data.Operation == Operation.Subtraction)
        {
            op = '-';
            result = data.NumberA.Value - data.NumberB.Value;
        }

        if(data.Operation == Operation.Multiplication)
        {
            op = '*';
            result = data.NumberA.Value * data.NumberB.Value;
        }

        if(data.Operation == Operation.Division)
        {
            op = '/';
            result = data.NumberA.Value / data.NumberB.Value;
        }

        WriteLine($"{data.NumberA.Value} {op} {data.NumberB.Value} = {result}");
    }
}
