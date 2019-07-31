using System;
using Cashwu.JavaLikeDateTime;
using FluentAssertions;
using Xunit;

namespace JavaLikeDateTime.Tests
{
    public class IsBeforeTests
    {
        [Fact]
        public void Before_other_datetime()
        {
            var current = new DateTime(2019, 9, 1, 1, 00, 00, 000);
            var other = new DateTime(2019, 9, 1, 1, 00, 00, 001);

            current.IsBefore(other).Should().BeTrue();
        }

        [Fact]
        public void After_other_datetime()
        {
            var current = new DateTime(2019, 9, 1, 1, 00, 00, 001);
            var other = new DateTime(2019, 9, 1, 1, 00, 00, 000);

            current.IsBefore(other).Should().BeFalse();
        }

        [Fact]
        public void Equal_other_datetime()
        {
            var current = new DateTime(2019, 9, 1, 1, 00, 00, 000);
            var other = new DateTime(2019, 9, 1, 1, 00, 00, 000);

            current.IsBefore(other).Should().BeFalse();
        }
    }
}