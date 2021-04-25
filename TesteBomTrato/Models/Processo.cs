using System.ComponentModel.DataAnnotations;

namespace TesteBomTrato.Models
{
    public class Processo
    {
        public Processo()
        { }

        public Processo(int id, int numeroProcesso, string valorCausa, string escritorio, string nomeReclamante)
        {
            this.Id = id;
            this.NumeroProcesso = numeroProcesso;
            this.ValorCausa = valorCausa;
            this.Escritorio = escritorio;
            this.NomeReclamante = nomeReclamante;

        } 
        public int Id { get; set; }
        public int NumeroProcesso { get; set; }
        public string ValorCausa { get; set; }
        public string Escritorio { get; set; }
        public string NomeReclamante { get; set; }
    }
}