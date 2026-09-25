

using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("Avaliar álbum");
        Console.Write("Digite o nome da banda que deseja avaliar o álbum: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine("Agora digite o nome do ábum: ");
            string tituloAlbum = Console.ReadLine()!;

            //Entre no if se tiver algum album com o nome igual a vaiavel tituloAlbum. E se for retorna true
            if(banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                //Pegue o primeiro elemento que atenda a essa condição
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));

                Console.Write($"Qual a nota que o {tituloAlbum} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o album {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO album {tituloAlbum} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
