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
            var instance1 = SingletonClass.GetInstance();
            var instance2 = SingletonClass.GetInstance();

            instance1.Name.ShouldBe(instance2.Name);
        }
    }
}