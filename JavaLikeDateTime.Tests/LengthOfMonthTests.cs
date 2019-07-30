using System;
using FluentAssertions;
using Xunit;

namespace JavaLikeDateTime.Tests
{
    public class LengthOfMonthTests
    {
        [Fact]
        public void First_day()
        {
            var current = new DateTime(2019, 9, 1, 1, 00, 00, 000);
            current.LengthOfMonth().Should().Be(30);
        }

        [Fact]
        public void End_day()
        {
            var current = new DateTime(2019, 9, 30, 1, 00, 00, 000);
            current.LengthOfMonth().Should().Be(30);
        }

        [Fact]
        public void Big_month_first_day()
        {
            var current = new DateTime(2019, 8, 1, 1, 00, 00, 000);
            current.LengthOfMonth().Should().Be(31);
        }

        [Fact]
        public void Big_month_end_day()
        {
            var current = new DateTime(2019, 8, 31, 1, 00, 00, 000);
            current.LengthOfMonth().Should().Be(31);
        }

        [Fact]
        public void Normal_February()
        {
            var current = new DateTime(2019, 2, 5, 1, 00, 00, 000);
            current.LengthOfMonth().Should().Be(28);
        }

        [Fact]
        public void Leap_year_february()
        {
            var current = new DateTime(2020, 2, 5, 1, 00, 00, 000);
            current.LengthOfMonth().Should().Be(29);
        }
    }
}