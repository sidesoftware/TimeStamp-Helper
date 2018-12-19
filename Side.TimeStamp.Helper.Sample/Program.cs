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
using Side.TimeStamp.Helper.Standard;

namespace Side.TimeStamp.Helper.Sample
{
    class Program
    {
        private static readonly IEnumerable<byte[]> Timestamps = new List<byte[]>
        {
            new byte[] { 0, 0, 0, 0, 35, 240, 161, 26 },
            new byte[] { 0, 0, 0, 0, 35, 240, 161, 33 },
            new byte[] { 0, 0, 0, 0, 35, 240, 161, 36 },
            new byte[] { 0, 0, 0, 0, 35, 240, 161, 38 },
            new byte[] { 0, 0, 0, 0, 35, 240, 161, 40 },
            new byte[] { 0, 0, 0, 0, 35, 240, 161, 44 },
            new byte[] { 0, 0, 0, 0, 35, 240, 161, 45 },
            new byte[] { 0, 0, 0, 0, 35, 240, 161, 48 },
            new byte[] { 0, 0, 0, 0, 35, 240, 161, 55 },
            new byte[] { 0, 0, 0, 0, 35, 240, 161, 67 }
        };

        static void Main(string[] args)
        {
            // Get the max timestamp in the byte array
            var max = Timestamps.Max();

            // Get the min timestamp in the byte array
            var min = Timestamps.Min();

            // Convert to hex
            var maxHex = max.ToHexString();
            var minHex = min.ToHexString();

            Console.WriteLine($"Max: {maxHex}");
            Console.WriteLine($"Min: {minHex}");
            Console.ReadLine();
        }
    }
}
