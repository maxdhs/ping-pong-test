using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pong;

namespace Pong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
   public void PingPongGenerator_DIVISIBLEby3and5()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("ping-pong", testPingPong.PingPongGenerator(15));
    }

    [TestMethod]
   public void PingPongGenerator_DIVISIBLEby5()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("pong", testPingPong.PingPongGenerator(10));
    }

    [TestMethod]
   public void PingPongGenerator_DIVISIBLEby3()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("ping", testPingPong.PingPongGenerator(6));
    }

    [TestMethod]
    public void PingPongGenerator_NOTDIVISIBLE()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("4", testPingPong.PingPongGenerator(4));
    }

}
}