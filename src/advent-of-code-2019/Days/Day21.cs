﻿using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AdventOfCode.Y2019.Days
{
    /*
     */

    public class Day21 : DayBase
    {
        public override object Part1()
        {
            return -1;
        }

        public override object Part2()
        {
            return -1;
        }

        private static IEnumerable<int> Parse(string input)
        {
            return null;
        }

        [Fact]
        public static void Test()
        {
            var day = Program.CreateInstance(21);
            Assert.Equal(484, day.Part1());
            Assert.Equal(5754, day.Part2());
        }
    }
}