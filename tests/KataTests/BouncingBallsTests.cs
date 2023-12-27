namespace KataTests;
using Katas;

[TestFixture]
public class BouncingBallTests {

  [TestCase(3.0, .66, 1.5, 3, TestName = "test1")]
  [TestCase(30.0, .66, 1.5, 15, TestName = "test2")]
  [TestCase(3.0, 1, 1.5, -1, TestName = "testbad")]
  public void Test(double h, double bounce, double window, double expected) {
    Assert.That(BouncingBall.bouncingBall(3.0, 0.66, 1.5), Is.EqualTo(3));
  }

}