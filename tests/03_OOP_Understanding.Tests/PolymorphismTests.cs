using OOP.Understanding.Topics;
using Xunit;
using FluentAssertions;

namespace OOP.Understanding.Tests;

public class PolymorphismTests
{
    [Fact]
    public void Circle_Rectangle_Area_Should_Work_Via_Base_Type()
    {
        Polymorphism.Shape c = new Polymorphism.Circle(2);
        Polymorphism.Shape r = new Polymorphism.Rectangle(3, 4);
        c.Area().Should().BeApproximately(Math.PI * 4, 1e-6);
        r.Area().Should().BeApproximately(12, 1e-6);
    }
}
