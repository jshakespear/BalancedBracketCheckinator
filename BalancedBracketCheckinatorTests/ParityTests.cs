using BalancedBracketCheckinatorNS;

namespace BalancedBracketCheckinatorTests;

[TestClass]
public class ParityTests
{
    [TestMethod]
    public void HappyPath_BalancedBrackets()
    {
        bool result = Parity.checkBracketParity("{}");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void BeginningClosedBracket()
    {
        bool result = Parity.checkBracketParity("}{");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void OneUnclosedBracket()
    {
        bool result = Parity.checkBracketParity("{{}");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void EmptyString()
    {
        bool result = Parity.checkBracketParity("");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void NonBracketCharactersOnly()
    {
        bool result = Parity.checkBracketParity("abc...xyz");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void BalancedBracketsWithNonBracketCharactersOnly()
    {
        bool result = Parity.checkBracketParity("{abc...xyz}");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void BeginningClosedBracketWithNonBracketCharactersOnly()
    {
        bool result = Parity.checkBracketParity("}abc...xyz{");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void BalancedNestedBrackets()
    {
        bool result = Parity.checkBracketParity("{{}{}}");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void BalancedMultilevelBrackets()
    {
        bool result = Parity.checkBracketParity("{{{}}}");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void UnbalancedMultilevelBrackets()
    {
        bool result = Parity.checkBracketParity("{{}}}");

        Assert.IsFalse(result);
    }
}
