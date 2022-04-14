using System;
using System.Collections.Generic;


namespace GerenciamentoEventos
{
    internal class Evento : EventoBase
    {
        public int id;
        public string nome;
        public DateTime data;
        public Endereco endereco;
        public Tipo tipo;
        public int capacidade;
        public List<Apresentacao> apresentacao;
        public int duracao;
    }
}
