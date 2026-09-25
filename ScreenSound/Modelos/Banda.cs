using System.ComponentModel.Design;

namespace ScreenSound.Modelos;

internal class Banda : IAvaliavel
{
    private List<Album> albunsInternos = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    //if: Vai verificar se não tem nenhuma avaliação na lista. Se não tiver vai retornar q a Media é 0
    //else:Ele vai percorrer a lista de avaliações e pegar a propriedade nota de cada uma, e por fim vai tirar a media
    public double Media
    {
        get
        {
            if(notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public IEnumerable<Album> Albuns => albunsInternos;

    public void AdicionarAlbum(Album album) 
    { 
        albunsInternos.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albunsInternos)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}