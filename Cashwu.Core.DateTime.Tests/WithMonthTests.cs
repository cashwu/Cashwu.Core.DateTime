using System;
using FluentAssertions;
using Xunit;

namespace Cashwu.Core.DateTime.Tests
{
    public class WithMonthTests
    {
        [Fact]
        public void Get_month_10()
        {
            var current = new System.DateTime(2019, 9, 1, 1, 10, 55, 123);
            var expected = new System.DateTime(2019, 10, 1, 1, 10, 55, 123);

            current.WithMonth(10).Should().Be(expected);
        }

        [Fact]
        public void Get_month_13()
        {
            var current = new System.DateTime(2019, 9, 1, 1, 10, 55, 123);

            Action action = () => current.WithMonth(13);
            action.Should().Throw<ArgumentOutOfRangeException>();
        }
        
        [Fact]
        public void Get_month_zero()
        {
            var current = new System.DateTime(2019, 9, 1, 1, 10, 55, 123);

            Action action = () => current.WithMonth(0);
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Get_month_negative()
        {
            var current = new System.DateTime(2019, 9, 1, 1, 10, 55, 123);

            Action action = () => current.WithMonth(-1);
            action.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}