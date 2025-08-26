

namespace Inheritance_Example;

    public class Parent
    {
        public double Number;

        public Parent(double number)
        {
            this.Number = number;
        }



        public virtual double Show()
        {
            return Math.Pow(Number, 2);
        }
    }

