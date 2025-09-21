using OOP.Understanding.Topics;
using Xunit;
using FluentAssertions;

namespace OOP.Understanding.Tests;

public class RefOutReadonlyTests
{
    [Fact]
    public void DoubleInPlace_Should_Modify_Original()
    {
        int x = 5;
        RefOutReadonly.DoubleInPlace(ref x);
        x.Should().Be(10);
    }

    [Theory]
    [InlineData("42", true, 42)]
    [InlineData("-1", false, 0)]
    [InlineData("oops", false, 0)]
    public void TryParsePositive_Works(string input, bool expectedOk, int expectedVal)
    {
        var ok = RefOutReadonly.TryParsePositive(input, out var v);
        ok.Should().Be(expectedOk);
        v.Should().Be(expectedVal);
    }
}
