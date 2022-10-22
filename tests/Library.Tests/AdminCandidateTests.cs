namespace Library.Tests;

using Library;

public class AdminCandidateTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CreateTest()
    {
        const string name = "Un nombre";
        AdminCandidate candidate = new AdminCandidate(name);
        Assert.AreEqual(name, candidate.Name);
    }
}