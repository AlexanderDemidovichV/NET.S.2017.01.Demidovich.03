using System;
using System.Collections;

namespace Task3
{
    /// <summary>
    /// Provides methods for binary insertion.
    /// </summary>
    public static class BinaryInsertion
    {
        #region Public Methods 

        /// <summary>
        /// Inserts <paramref name="number2"/> in <paramref name="number1"/>
        /// to the bit's position from <paramref name="startIndex"/> to <paramref name="endIndex"/>
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The integer to insert.</param>
        /// <param name="startIndex">The zero-based index start position of the insertion.</param>
        /// <param name="endIndex">The zero-based index end position of the insertion.</param>
        /// <returns>A new integer that is equivalent to <paramref name="number1"/>, 
        /// but with <paramref name="number2"/> inserted at bit's positions form <paramref name="startIndex"/> to <paramref name="endIndex"/>.</returns>
        /// <exception cref="System.ArgumentException"><paramref name="startIndex"/> is greater than <paramref name="endIndex"/></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"><paramref name="startIndex"/> is negative or greater than 32 bits.
        /// <paramref name="endIndex"/> is negative or greater than 32 bits.</exception>
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

        #endregion

        #region Private Methods

        /// <summary>
        /// Convert the number from decimal system into binary system.
        /// </summary>
        /// <param name="number">The number in decimal system to convert into binary system.</param>
        /// <returns>A new bit array that is equivalent to <paramref name="number"/> in binaty system.</returns>
        private static BitArray ToBinary(this int number)
        {
            return new BitArray(new[] { number });
        }

        /// <summary>
        /// Convert the binary array into a integer in decimal system.
        /// </summary>
        /// <param name="binaryArray">The binary array to convert.</param>
        /// <returns>An integer that present decimal representation of <paramref name="binaryArray"/></returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="binaryArray"/> is null</exception>
        /// <exception cref="System.ArgumentOutOfRangeException"><paramref name="binaryArray"/> length greater than 32 bits.</exception>
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

        #endregion
    }
}
