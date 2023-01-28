// See https://leetcode.com/problems/divide-two-integers/description/
public class DivideTwoNumbers
{
    public int Divide(int dividend, int divisor)
    {
        if (dividend < Int32.MinValue || divisor < Int32.MinValue) return Int32.MinValue;
        if (dividend > Int32.MaxValue || divisor > Int32.MaxValue) return Int32.MaxValue;
        decimal result = decimal.Divide(dividend, divisor);
        if (result < Int32.MinValue) result = Int32.MinValue;
        if (result > Int32.MaxValue) result = Int32.MaxValue;
        return (int)result;
    }

}

