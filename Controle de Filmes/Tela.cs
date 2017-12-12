using System;
using Controle_de_Filmes.dominio;
using System.Globalization;


namespace Controle_de_Filmes {
    class Tela {
        public static void mostrarMenu() {
            Console.WriteLine("1 - Listar artistas ordenadamente");
            Console.WriteLine("2 - Cadastrar artista");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite sua opção: ");
        }

        public static void mostrarArtistas() {
            Console.WriteLine("LISTAGEM DE ARTISTAS:");
            for(int i = 0; i < Program.artistas.Count; i++) {
                Console.WriteLine(Program.artistas[i]);
            }
        }

        public static void cadastraArtista() {
            Console.WriteLine("Digite os dados do artista:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Valor do cachê: ");
            double cache = double.Parse(Console.ReadLine());
            Program.artistas.Add(new Artista(codigo,nome,cache));
            Program.artistas.Sort();
        }

        public static void cadastraFilme() {
            Console.WriteLine("Digite os dados do filme:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Titulo: ");
            String titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Filme f = new Filme(codigo,titulo,ano);
            Console.Write("Quantas participações tem o filme: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite os dados da " + (i + 1) + "° particiáção:");
                Console.Write("Artista (código): ");
                int artCodigo = int.Parse(Console.ReadLine());
                int pos = Program.artistas.FindIndex(x => x.codigo == artCodigo);
                if (pos == -1) {
                    throw new ModelException("O código de artista inserido não existe:" + artCodigo);
                }
                Console.Write("Desconto: ");
                double desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Participacao participacao = new Participacao(desconto,Program.artistas[pos],f);
                f.participacoes.Add(participacao);
            }
            Program.filmes.Add(f);

        }

        public static void mostraDadosFilme() {
            Console.Write("Digite o codigo do filme: ");
            int codigo = int.Parse(Console.ReadLine());
            int pos = Program.filmes.FindIndex(x => x.codigo == codigo);
            if (pos == -1)
                throw new ModelException("O código do filme inserido não existe:" + codigo);
            Console.Write(Program.filmes[pos].ToString());
            
            
        }
    }
}
