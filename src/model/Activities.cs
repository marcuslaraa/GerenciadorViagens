using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciadorViagens_windowsForm_csharp.src.model
{
    internal class Activities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Time { get; set; }
        public DateTime Date { get; set; }
        public string Budget { get; set; }
        public string Status { get; set; }

        public Activities()
        {
        }

        public Activities(string name, string location, string time, DateTime date, string status)
        {
            Name = name;
            Location = location;
            Time = time;
            Date = date;
            Status = status;
        }

        public void validate()
        {
            if (string.IsNullOrEmpty(Name)) throw new Exception("O nome da atividade não pode ser vazio!");
            if (string.IsNullOrEmpty(Location)) throw new Exception("O local da atividade não pode ser vazio!");
            if (string.IsNullOrEmpty(Time)) throw new Exception("O horário da atividade não pode ser vazio!");
            if (string.IsNullOrEmpty(Status)) throw new Exception("O status da atividade não pode ser vazio!");


        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Id: {Id}");
            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine($"Location: {Location}");
            stringBuilder.AppendLine($"Time: {Time}");
            stringBuilder.AppendLine($"Date: {Date}");
            stringBuilder.AppendLine($"Budget: {Budget}");
            stringBuilder.AppendLine($"Status: {Status}");

            return stringBuilder.ToString();
        }

    }
}
