
public class AdocaoRepositorio : iRepositorio<Adocao>
{
    private List<Adocao> listaAdocao= new List<Adocao>();
    public void Atualiza(int id, Adocao objeto)
    {
        listaAdocao[id] = objeto;
    }

    public void Exclui(int id)
    {
        listaAdocao[id].Excluir();
    }

    public void Insere(Adocao objeto)
    {
        listaAdocao.Add(objeto);
    }

    public List<Adocao> Lista()
    {
        return listaAdocao;
    }

    public int ProximoId()
    {
        return listaAdocao.Count;
    }

    public Adocao RetornaPorId(int id)
    {
        return listaAdocao[id];
    }
}