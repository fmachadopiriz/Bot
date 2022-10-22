namespace Library.Tests;

using Library;

public class ListAdminCandidateCommandTests
{
    [SetUp]
    public void Setup()
    {
        AdminCandidatesList.Instance.Clear();
    }

    [Test]
    public void ListAdminCandidatesTest()
    {
        ListAdminCandidatesCommand command = new ListAdminCandidatesCommand();
        const string name = "Cualquier cosa";
        AdminCandidatesList.Instance.Add(name);
        string expected = name + "\n";
        string actual = command.ListAdminCandidates();
        Assert.AreEqual(expected, actual);
    }
}