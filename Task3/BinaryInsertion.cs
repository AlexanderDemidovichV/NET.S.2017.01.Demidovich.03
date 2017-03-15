using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// 
    /// </summary>
    public static class BinaryInsertion
    {
        /// <summary>
        /// Binaries the insertion integer into integer.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <param name="startIndex">The start index.</param>
        /// <param name="endIndex">The end index.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public static int BinaryInsertionIntegerIntoInteger(int number1, int number2, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
                throw new ArgumentException();
            if (startIndex < 0 || endIndex < 0 || startIndex > 32 || endIndex > 32)
                throw new ArgumentOutOfRangeException();

            BitArray a = number1.ToBinary();
            BitArray b = number2.ToBinary();

            for (int i = startIndex, j = 0; i <= endIndex; i++)
            {
                a.Set(i, a.Get(i) | b.Get(j++));
            }       
            
            try
            {
                return a.ToNumeral();
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        /// <summary>
        /// To the binary.
        /// </summary>
        /// <param name="numeral">The numeral.</param>
        /// <returns></returns>
        private static BitArray ToBinary(this int numeral)
        {
            return new BitArray(new[] { numeral });
        }

        /// <summary>
        /// To the numeral.
        /// </summary>
        /// <param name="binaryArray">The binary array.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">binaryArray</exception>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        private static int ToNumeral(this BitArray binaryArray)
        {
            if (binaryArray == null)
                throw new ArgumentNullException(nameof(binaryArray));
            if (binaryArray.Length > 32)
                throw new ArgumentOutOfRangeException();

            var result = new int[1];
            binaryArray.CopyTo(result, 0);
            return result[0];
        }
    }
}
