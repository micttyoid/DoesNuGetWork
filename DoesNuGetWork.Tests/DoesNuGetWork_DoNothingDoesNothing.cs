using Xunit;
using DoesNuGetWork;

namespace DoesNuGetWork.UnitTests;

public class DoesNuGetWork_DoNothingShould
{
    [Fact]
    public void DoNothing_NoInput_ReturnNothing()
    {
        bool isVoid = false;
        var n = new Nothing();
        try
        {
            n.DoNothing();
            isVoid = true;
            Assert.True(true, "DoNothing should a void method");
        }
        catch { }
        Assert.True(isVoid, "DoNothing should a void method");
    }
}

