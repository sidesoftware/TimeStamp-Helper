using System;
using System.Collections.Generic;
using Side.Timestamp.Helper.Core;

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
