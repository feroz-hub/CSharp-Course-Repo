using OOP.Understanding.Topics;
using Xunit;
using FluentAssertions;

namespace OOP.Understanding.Tests;

public class EncapsulationTests
{
    [Fact]
    public void BankAccount_Deposit_And_Withdraw_Should_Update_Balance_With_Rules()
    {
        var acc = new Encapsulation.BankAccount("Ava", 100m);
        acc.Deposit(50m);
        acc.Withdraw(120m).Should().BeTrue();
        acc.Balance.Should().Be(30m);
        acc.Withdraw(100m).Should().BeFalse();
        acc.Balance.Should().Be(30m);
    }
}
