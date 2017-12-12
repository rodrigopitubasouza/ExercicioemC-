using System;


namespace Controle_de_Filmes.dominio {
    class ModelException : Exception{
        public ModelException(string msg) : base(msg) {
        }
    }
}
