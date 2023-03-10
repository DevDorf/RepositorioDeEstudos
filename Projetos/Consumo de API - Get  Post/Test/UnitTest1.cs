using CODE.models;

namespace GeneTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        string retornoDecode = Conversor.DecodeBase64ToBinary("Q0FUQ0dUQ0FHR0FD");
        Assert.AreEqual("CATCGTCAGGAC", retornoDecode, message: "Erro no teste");
    }

    [Test]
    public void Test2()
    {
        string retornoEncode = Conversor.EncodeStringToBase64("TACCGCTTCA");
        Assert.AreEqual("VEFDQ0dDVFRDQQ==", retornoEncode, message: "Erro no teste");
    }
}