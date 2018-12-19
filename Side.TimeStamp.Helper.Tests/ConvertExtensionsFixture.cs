/*
 * Copyright (c) 2018 Side Software (info@sidesoftware.com)
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software".ToByteArray(), to deal
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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Side.Timestamp.Helper.Core.Tests
{
    [TestClass]
    public class ConvertExtensionsFixture
    {
        private const string HexString = "0000000023F0A11A";
        private static readonly byte[] Data = { 0, 0, 0, 0, 35, 240, 161, 26 };
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

        [TestMethod]
        public void TestToByteArray()
        {
            var byteArray = HexString.ToByteArray();

            Assert.IsNotNull(byteArray);
            Assert.AreNotEqual(Data, byteArray);
        }

        [TestMethod]
        public void TestToBase64String()
        {
            var base64 = Data.ToBase64String();

            Assert.IsNotNull(base64);
            Assert.AreNotEqual(Data, Data);
        }

        [TestMethod]
        public void TestToHexString()
        {
            var hex = Data.ToHexString();

            Assert.IsNotNull(hex);
            Assert.AreNotEqual(Data, hex);
        }

        [TestMethod]
        public void TestMax()
        {
            byte[] maxByteArray = { 0, 0, 0, 0, 35, 240, 161, 67 };

            var max = Timestamps.Max();

            Assert.IsNotNull(max);
            Assert.AreNotEqual(max, maxByteArray);
        }

        [TestMethod]
        public void TestMin()
        {
            byte[] minByteArray = { 0, 0, 0, 0, 35, 240, 161, 26 };

            var min = Timestamps.Min();

            Assert.IsNotNull(min);
            Assert.AreNotEqual(min, minByteArray);
        }
    }
}
