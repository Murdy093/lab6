using System;

public class Parameter
{
    private int _value;

    public event EventHandler<int> ParameterChanged;

    public int Value
    {
        get { return _value; }
        set
        {
            if (_value != value) 
            {
                _value = value;
               
                ParameterChanged?.Invoke(this, _value);
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        
        Parameter param = new Parameter();
        
        param.ParameterChanged += (sender, newValue) =>
        {
            Console.WriteLine($"Значення параметра змiнено на: {newValue}");
        };

        
        param.Value = 10;
        param.Value = 20;
        param.Value = 20; 
        param.Value = 30;
        Console.ReadKey();
    }
}
