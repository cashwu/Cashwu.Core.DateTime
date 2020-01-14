using FluentAssertions;
using Xunit;

namespace Cashwu.Core.DateTime.Tests
{
    public class IsAfterTests
    {
        [Fact]
        public void Before_other_datetime()
        {
            var current = new System.DateTime(2019, 9, 1, 1, 00, 00, 000);
            var other = new System.DateTime(2019, 9, 1, 1, 00, 00, 001);

            current.IsAfter(other).Should().BeFalse();
        }

        [Fact]
        public void After_other_datetime()
        {
            var current = new System.DateTime(2019, 9, 1, 1, 00, 00, 001);
            var other = new System.DateTime(2019, 9, 1, 1, 00, 00, 000);

            current.IsAfter(other).Should().BeTrue();
        }

        [Fact]
        public void Equal_other_datetime()
        {
            var current = new System.DateTime(2019, 9, 1, 1, 00, 00, 000);
            var other = new System.DateTime(2019, 9, 1, 1, 00, 00, 000);

            current.IsAfter(other).Should().BeFalse();
        }
    }
}