namespace Library;

public class InputInterfacer
{
    public const string COMMAND_TEXT = "Listar candidatos";

    public ListAdminCandidatesCommand TranslateToCommand(string input)
    {
        if (input.Equals(COMMAND_TEXT))
        {
            return new ListAdminCandidatesCommand();
        }

        return null;
    }
}