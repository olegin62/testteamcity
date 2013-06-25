using Xunit;

namespace teamcity.Test
{
    public class MyClassTest
    {
        private MyClass mc;

        public MyClassTest()
        {
            mc = new MyClass();
        }

        [Fact]
        public void MyMethodTest()
        {
            Assert.Equal(1, mc.MyMethod());
        }
    }
}
