using OOP.Understanding.Topics;
using Xunit;
using FluentAssertions;

namespace OOP.Understanding.Tests;

public class GenericsTests
{
    [Fact]
    public void Repository_Should_Store_And_Retrieve_By_Id()
    {
        var repo = new GenericsOop.Repository<GenericsOop.Customer>();
        var c = new GenericsOop.Customer(7, "Zed");
        repo.Add(c);
        repo.FindById(7)?.Name.Should().Be("Zed");
        repo.FindById(99).Should().BeNull();
    }
}
