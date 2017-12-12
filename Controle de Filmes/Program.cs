using System;
using System.Collections.Generic;
using Controle_de_Filmes.dominio;


namespace Controle_de_Filmes {
    class Program {
        public static List<Artista> artistas = new List<Artista>();
        public static List<Filme> filmes = new List<Filme>();
        static void Main(string[] args) {

            int selecao = 0;
            artistas.Add(new Artista(101, "Scarlett Johasson", 4000000.00));
            artistas.Add(new Artista(102, "Chris Evans", 2500000.00));
            artistas.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            artistas.Add(new Artista(104, "Morgan Freeman", 4000000.00));
            artistas.Sort();

            while (selecao != 5) {
                Console.Clear();
                Tela.mostrarMenu();
                try {
                    selecao = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (selecao) {
                        case 1:
                            Tela.mostrarArtistas();
                            break;
                        case 2:
                            Tela.cadastraArtista();
                            break;
                        case 3:
                            try {
                                Tela.cadastraFilme();
                            }
                            catch (ModelException e) {
                                Console.WriteLine("Erro de negocio: " + e.Message);
                            }
                            break;
                        case 4:
                            try {
                                Tela.mostraDadosFilme();
                            }
                            catch (ModelException e) {
                                Console.WriteLine("Erro de negocio: " + e.Message);
                            }

                            break;
                        case 5:
                            selecao = 5;
                            Console.WriteLine("Programa encerrado");
                            break;
                        default:
                            Console.WriteLine("A opção não existe");
                            break;

                    }

                }
                catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);

                }

                Console.ReadLine();
            }

        }
    }
}
