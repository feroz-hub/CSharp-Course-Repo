using OOP.Understanding.Topics;
using Xunit;
using FluentAssertions;

namespace OOP.Understanding.Tests;

public class OverloadOverrideTests
{
    [Fact]
    public void Calculator_Add_Overloads_Should_Work()
    {
        var c = new OverloadOverride.Calculator();
        c.Add(2, 3).Should().Be(5);
        c.Add(2.5, 3.5).Should().Be(6.0);
    }

    [Fact]
    public void Virtual_Override_Should_Dispatch_To_Derived()
    {
        OverloadOverride.Base b = new OverloadOverride.Derived();
        b.Greet().Should().Be("Hello from Derived");
    }
}
