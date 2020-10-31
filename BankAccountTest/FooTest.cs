using BankAccount;
using Xunit;

namespace BankAccountTest
{
    public class UnitTest1
    {
        [Fact]
        public void Should_get_bar()
        {
            var foo = new Foo();
            Assert.Equal("bar", foo.Bar());
        }
    }
}
