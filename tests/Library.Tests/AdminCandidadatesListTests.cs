namespace Library.Tests;

using Library;

public class AdminCandidatesListTests
{
     [SetUp]
    public void Setup()
    {
        AdminCandidatesList.Instance.Clear();
    }

    [Test]
    public void GetAdminCandidatesTest()
    {
        const string name = "Cualquier nombre";
        AdminCandidatesList.Instance.Add(name);
        foreach (var candidate in AdminCandidatesList.Instance.GetAdminCandidates())
        {
            if (candidate.Name == name)
            {
                Assert.Pass();
                return;
            }
        }

        Assert.Fail();
    }
}