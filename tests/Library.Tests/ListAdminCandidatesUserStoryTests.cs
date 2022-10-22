namespace Library.Tests;

using Library;

public class ListAdminCandidatesUserStoryTests
{
    [SetUp]
    public void Setup()
    {
        AdminCandidatesList.Instance.Clear();
    }

    [Test]
    public void UserStoryTest()
    {
        const string input = InputInterfacer.COMMAND_TEXT;
        const string name = "Cualquier nombre";
        const string expected = name + "\n";
        AdminCandidatesList.Instance.Add(name);
        InputInterfacer interfacer = new InputInterfacer();
        ListAdminCandidatesCommand command = interfacer.TranslateToCommand(input);
        string actual = command.ListAdminCandidates();
        Assert.AreEqual(expected, actual);
    }
}