using System;
using Cashwu.JavaLikeDateTime;
using FluentAssertions;
using Xunit;

namespace JavaLikeDateTime.Tests
{
    public class AtDayTests
    {
        [Fact]
        public void First_day_get_end_day()
        {
            var current = new DateTime(2019, 9, 1, 1, 00, 00, 000);
            var expected = new DateTime(2019, 9, 30, 1, 00, 00, 000);

            current.AtDay(30).Should().Be(expected);
        }

        [Fact]
        public void End_day_get_first_day()
        {
            var current = new DateTime(2019, 9, 30, 1, 00, 00, 000);
            var expected = new DateTime(2019, 9, 1, 1, 00, 00, 000);

            current.AtDay(1).Should().Be(expected);
        }

        [Fact]
        public void More_than_day_of_month_not_valid_day()
        {
            var current = new DateTime(2019, 9, 10, 1, 00, 00, 000);

            Action action = () => current.AtDay(31);
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Zero_day_of_month_not_valid_day()
        {
            var current = new DateTime(2019, 9, 20, 1, 00, 00, 000);

            Action action = () => current.AtDay(0);
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Negative_day_of_month_not_valid_day()
        {
            var current = new DateTime(2019, 9, 30, 1, 00, 00, 000);

            Action action = () => current.AtDay(-1);
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Normal_February_get_end_day()
        {
            var current = new DateTime(2019, 2, 5, 1, 01, 01, 001);
            var expected = new DateTime(2019, 2, 28, 1, 01, 01, 001);

            current.AtDay(28).Should().Be(expected);
        }

        [Fact]
        public void Leap_year_February_get_end_day()
        {
            var current = new DateTime(2020, 2, 10, 1, 01, 01, 001);
            var expected = new DateTime(2020, 2, 29, 1, 01, 01, 001);

            current.AtDay(29).Should().Be(expected);
        }
    }
}