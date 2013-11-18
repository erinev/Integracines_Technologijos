using System;

namespace Utility
{
    public class InputStreamUtility
    {
        public byte[] ProcessFirstNumber(string firstNumberInput)
        {
            int firstNumber = Convert.ToInt16(firstNumberInput, 10);
            byte[] firstNumberBytes = BitConverter.GetBytes(firstNumber);
            return firstNumberBytes;
        }

        public byte[] ProcessSecondNumber(string secondNumberInput)
        {
            int secondNumber = Convert.ToInt16(secondNumberInput, 10);
            byte[] secondNumberBytes = BitConverter.GetBytes(secondNumber);
            return secondNumberBytes;
        }
    }
}