
namespace Calculator
{   public class Numbers
    {
      int number1;
      int number2;
      public void GetNumber()
      {
            Console.Write("Please Enter number1:");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Please Enter number2:");
            number2 = int.Parse(Console.ReadLine());
      }


        public string sum()
        {
            string num = $"Sum is:{number1} + {number2} = {number1 + number2}";
            return num;

        }
        public string sub()
        {
            string num = $"Sub is:{number1} - {number2} = {number1 - number2}";
            return num;
        }
        public string multiple()
        {
            string num = $"multiple is:{number1} * {number2} = {number1 * number2}";
            return num;
        }

    }
}
