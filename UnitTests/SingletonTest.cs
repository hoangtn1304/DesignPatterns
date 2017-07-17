using Shouldly;
using Xunit;
using SingletonClass = Singleton.Singleton;

namespace UnitTests
{
    public class SingletonTest
    {
        [Fact]
        public void SingletonClassTest()
        {
            var instance1 = SingletonClass.Instance;
            var instance2 = SingletonClass.Instance;

            instance1.Name.ShouldBe(instance2.Name);
        }
    }
}