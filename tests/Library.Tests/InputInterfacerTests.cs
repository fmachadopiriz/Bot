namespace Library.Tests;

using Library;

public class InputInterfacerTests
{
    [SetUp]
    public void Setup()
    {
        AdminCandidatesList.Instance.Clear();
    }

    [Test]
    public void TranslateToCommandTest()
    {
        const string input = InputInterfacer.COMMAND_TEXT;
        InputInterfacer interfacer = new InputInterfacer();
        ListAdminCandidatesCommand command = interfacer.TranslateToCommand(input);
        Assert.IsNotNull(command);
    }
}