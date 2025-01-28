using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciadorViagens_windowsForm_csharp.src.model
{
    internal class Travel
    {
        public int Id { get; set; }
        public string TravelName { get; set; }
        public string Destination { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public string Budget { get; set; }
        public string Description { get; set; }

        public Travel()
        {
        }

        public Travel(string travelName, string destination, DateTime initialDate, DateTime finalDate, string budget, string description)
        {
            TravelName = travelName;
            Destination = destination;
            InitialDate = initialDate;
            FinalDate = finalDate;
            Budget = budget;
            Description = description;
        }

        public void validate()
        {
            if (InitialDate >= FinalDate) throw new Exception("A data inicial não pode ser maior ou igual a data final!");
            if (string.IsNullOrEmpty(TravelName)) throw new Exception("O nome da viagem não pode ser vazio!");
            if (string.IsNullOrEmpty(Destination)) throw new Exception("O destino da viagem não pode ser vazio!");
            if (string.IsNullOrEmpty(Budget)) throw new Exception("O orçamento da viagem não pode ser vazio!");
            if (string.IsNullOrEmpty(Description)) throw new Exception("A descrição da viagem não pode ser vazia!");

        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"Id: {Id}, ");
            stringBuilder.Append($"TravelName: {TravelName}, ");
            stringBuilder.Append($"Destination: {Destination}, ");
            stringBuilder.Append($"InitialDate: {InitialDate}, ");
            stringBuilder.Append($"FinalDate: {FinalDate}, ");
            stringBuilder.Append($"Budget: {Budget}, ");
            stringBuilder.Append($"Description: {Description}");

            return stringBuilder.ToString();
        }

    }
}
