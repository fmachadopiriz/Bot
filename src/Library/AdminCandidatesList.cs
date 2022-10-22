using System.Collections.Generic;

namespace Library;

public class AdminCandidatesList
{
    /// <summary>
    /// Este método es privado porque esta clase es un singleton.
    /// </summary>
    private AdminCandidatesList()
    {
        // Intencionalmente en blanco
    }

    private static AdminCandidatesList instance;

    public static AdminCandidatesList Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new AdminCandidatesList();
            }

            return instance;
        }
    }

    /// <summary>
    /// ... Usamos el LSP y DIP al declarar la variable de instancia candidates de un tipo más abstracto que el del
    /// objeto que creamos.
    /// </summary>
    /// <typeparam name="AdminCandidate"></typeparam>
    /// <returns></returns>
    private IList<AdminCandidate> candidates = new List<AdminCandidate>();

    public IEnumerable<AdminCandidate> GetAdminCandidates()
    {
        return this.candidates;
    }

    /// <summary>
    /// ... Como esta clase contiene instancias de AdminCandidate las tiene que crear para lo que necesita recibir
    /// el nombre como parámetro.
    /// </summary>
    /// <param name="name"></param>
    public void Add(string name)
    {
        this.candidates.Add(new AdminCandidate(name));
    }

    public void Clear()
    {
        this.candidates.Clear();
    }
}