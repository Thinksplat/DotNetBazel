using FluentAssertions;
using Xunit;

namespace tests;

public class UnitTest1
{
    [Fact]
    public void ThreeShouldReturnThree()
    {
        lib.MyFunctions.Three().Should().Be(3);
    }
}