using System;
using System.Text;

namespace gerenciadorViagens_windowsForm_csharp.src.model
{
    internal class Expense
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

        public Expense()
        {
        }

        public Expense(string category, string value, string description)
        {
            Category = category;
            Value = value;
            Description = description;
        }

        public void validate()
        {
            if (string.IsNullOrEmpty(Category)) throw new Exception("A categoria não pode ser vazia!");
            if (string.IsNullOrEmpty(Value)) throw new Exception("O valor não pode ser vazio!");
            if (string.IsNullOrEmpty(Description)) throw new Exception("A descrição não pode ser vazia!");
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Id: {Id}, ");
            stringBuilder.Append($"Category: {Category}, ");
            stringBuilder.Append($"Value: {Value}, ");
            stringBuilder.Append($"Description: {Description}");
            return stringBuilder.ToString();
        }

    }
}
