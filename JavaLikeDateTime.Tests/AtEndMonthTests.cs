using System;
using FluentAssertions;
using Xunit;

namespace JavaLikeDateTime.Tests
{
    public class AtEndMonthTests
    {
        [Fact]
        public void First_day_of_month()
        {
            var current = new DateTime(2019, 9, 1, 1, 00, 00, 000);
            var expected = new DateTime(2019, 9, 30, 1, 00, 00, 000);

            current.AtEndOfMonth().Should().Be(expected);
        }

        [Fact]
        public void End_day_of_month()
        {
            var current = new DateTime(2019, 9, 30, 1, 00, 00, 000);
            var expected = new DateTime(2019, 9, 30, 1, 00, 00, 000);

            current.AtEndOfMonth().Should().Be(expected);
        }

        [Fact]
        public void Big_Month_First_day_of_month()
        {
            var current = new DateTime(2019, 8, 1, 1, 00, 00, 000);
            var expected = new DateTime(2019, 8, 31, 1, 00, 00, 000);

            current.AtEndOfMonth().Should().Be(expected);
        }

        [Fact]
        public void Big_Month_End_day_of_month()
        {
            var current = new DateTime(2019, 8, 31, 1, 00, 00, 000);
            var expected = new DateTime(2019, 8, 31, 1, 00, 00, 000);

            current.AtEndOfMonth().Should().Be(expected);
        }

        [Fact]
        public void Normal_February()
        {
            var current = new DateTime(2019, 2, 5, 1, 00, 00, 000);
            var expected = new DateTime(2019, 2, 28, 1, 00, 00, 000);

            current.AtEndOfMonth().Should().Be(expected);
        }

        [Fact]
        public void Leap_year_February()
        {
            var current = new DateTime(2020, 2, 5, 1, 00, 00, 000);
            var expected = new DateTime(2020, 2, 29, 1, 00, 00, 000);

            current.AtEndOfMonth().Should().Be(expected);
        }
    }
}