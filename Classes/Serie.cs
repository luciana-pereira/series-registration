using System;

namespace series.registration
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluded { get; set; }


        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluded = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: "+ this.Genero + Environment.NewLine;
            retorno += "Titulo: "+ this.Titulo + Environment.NewLine;
            retorno += "Descrição: "+ this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: "+ this.Ano + Environment.NewLine;
            retorno += "Excluido: "+ this.Excluded;

            return retorno;
        }

        public string returnTitle()
        {
            return this.Titulo;
        }

        internal int returnId()
        {
            return this.Id;
        }

        internal bool returnDeleted()
        {
            return this.Excluded;
        }

        public void Delete()
        {
            this.Excluded = true;
        }
    }
}