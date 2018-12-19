/*
 * Copyright (c) 2018 Side Software (info@sidesoftware.com)
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Side.Timestamp.Helper.Core
{
    /// <summary>
    /// Provides helper methods for working with byte arrays with emphasis on working with TimeStamp data types from SQL Server.
    /// This is specifically useful when comparing timestamp column values such as looking for the changes after a particular
    /// timestamp value.
    /// </summary>
    public static class ConvertExtensions
    {
        /// <summary>
        /// Converts a hexadecimal string to a byte array
        /// </summary>
        /// <param name="hex">The string to convert</param>
        /// <returns>a byte array of the values in the input string</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="hex" /> is <see langword="null" />. </exception>
        public static byte[] ToByteArray(this string hex)
        {
            if (string.IsNullOrEmpty(hex)) throw new ArgumentNullException(nameof(hex));

            return Enumerable
                .Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }

        /// <summary>Converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits.</summary>
        /// <param name="bytes">An array of 8-bit unsigned integers. </param>
        /// <returns>The string representation, in base 64, of the contents of <paramref name="bytes" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="bytes" /> is <see langword="null" />. </exception>
        public static string ToBase64String(this byte[] bytes)
        {
            if (bytes == null) throw new ArgumentNullException(nameof(bytes));

            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// Converts a byte array to a hexadecimal string
        /// </summary>
        /// <param name="bytes">the byte array to convert</param>
        /// <returns> hexadecimal string of values from the byte array</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="bytes" /> is <see langword="null" />. </exception>
        public static string ToHexString(this byte[] bytes)
        {
            if (bytes == null) throw new ArgumentNullException(nameof(bytes));

            return $"0x{BitConverter.ToString(bytes).Replace("-", "")}";
        }

        /// <summary>
        /// Returns the max byte array value in a collection
        /// </summary>
        /// <param name="values">A collection of byte array values</param>
        /// <returns>The max byte array in a collection</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="values" /> is <see langword="null" />. </exception>
        public static byte[] Max(this IEnumerable<byte[]> values)
        {
            if (values == null) throw new ArgumentNullException(nameof(values));

            var max = values.Max(x => BitConverter.ToInt64(x.Reverse().ToArray(), 0));

            return BitConverter.GetBytes(max).Reverse().ToArray();
        }

        /// <summary>
        /// Returns the minimum byte array value in a collection
        /// </summary>
        /// <param name="values">A collection of byte array values</param>
        /// <returns>The minimum byte array in a collection</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="values" /> is <see langword="null" />. </exception>
        public static byte[] Min(this IEnumerable<byte[]> values)
        {
            if (values == null) throw new ArgumentNullException(nameof(values));

            var min = values.Min(x => BitConverter.ToInt64(x.Reverse().ToArray(), 0));

            return BitConverter.GetBytes(min).Reverse().ToArray();
        }
    }
}
