using System;
using System.Collections.Generic;
using System.Globalization;


namespace Controle_de_Filmes.dominio {
    class Filme {
        public int codigo { get; set; }
        public String titulo { get; set; }
        public int ano { get; set; }
        public List<Participacao> participacoes { get; set; }

        public Filme(int codigo, String titulo, int ano) {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
            this.participacoes = new List<Participacao>();
        }

        public double custoTotal() {

            double valorTotal =0;
            for (int i = 0; i < participacoes.Count; i++) {
                valorTotal = valorTotal + participacoes[i].custo();
            }
            return valorTotal;
        }

        public override string ToString() {
            String s ="Filme: " + codigo
                + ", Título: " + titulo
                + ", Ano: " + ano
                + "\nParticipações:\n";
            for(int i = 0; i < participacoes.Count; i++) {
                s = s + participacoes[i] + "\n";
            }
            s = s + "Custo total do filme: " + custoTotal().ToString("F2", CultureInfo.InvariantCulture);
            return s;
        }

    }
}
