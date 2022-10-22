using System.Text;

namespace Library;

public class ListAdminCandidatesCommand
{
    public string ListAdminCandidates()
    {
        StringBuilder result = new StringBuilder();
        foreach (var candidate in AdminCandidatesList.Instance.GetAdminCandidates())
        {
            result.Append($"{candidate.Name}\n");
        }

        return result.ToString();
    }
}