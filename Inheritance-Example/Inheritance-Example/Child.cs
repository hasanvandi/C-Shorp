
using System.Threading.Channels;

namespace Inheritance_Example;

    public class Child : Parent
    {
    private double _number1;

    public Child(double number, double number1) : base(number)
    {
       _number1 = number1;
    }


    public override double Show()
    {
        return _number1 * Number;
    }
}

