
using System.Globalization;


namespace Controle_de_Filmes.dominio {
    class Participacao {

        public double desconto { get; set; }
        public Artista artista { get; set; }
        public Filme filme { get; set; }

        public Participacao(double desconto,Artista artista, Filme filme) {
            this.desconto = desconto;
            this.artista = artista;
            this.filme = filme;
        }

        public double custo() {
            double valor = artista.cache - desconto;
            return valor;
        }

        public override string ToString() {
            return artista.nome
                + ", Cachê: " + artista.cache.ToString("F2",CultureInfo.InvariantCulture)
                + ", Desconto: " + desconto.ToString("F2",CultureInfo.InvariantCulture)
                + ", Custo: " + custo().ToString("F2",CultureInfo.InvariantCulture);

        }
    }
}
