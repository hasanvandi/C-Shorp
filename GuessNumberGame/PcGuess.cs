public class PcGuess
{
    Random random = new();
 
    public int randomPc(int num,int num2)
    {
       return random.Next(num, num2);
    }

}
