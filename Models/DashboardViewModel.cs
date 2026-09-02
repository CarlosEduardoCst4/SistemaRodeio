using System.Collections.Generic;

namespace SistemaRodeio.Models
{
    public class AnimalPorTipo
    {
        public string Tipo { get; set; } = string.Empty;
        public int Quantidade { get; set; }
    }

    public class DashboardViewModel
    {
        public int TotalAnimais { get; set; }
        public int TotalCompetidores { get; set; }
        public int TotalCidades { get; set; }
        public int TotalRounds { get; set; }
        public int TotalTiposAnimais { get; set; }

        public List<AnimalPorTipo> AnimaisPorTipo { get; set; } = new();
        public List<Competidor> TopCompetidores { get; set; } = new();
        public List<Round> UltimosRounds { get; set; } = new();
    }
}
