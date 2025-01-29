using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerenciadorViagens_windowsForm_csharp.src.controller;
using gerenciadorViagens_windowsForm_csharp.src.database;
using gerenciadorViagens_windowsForm_csharp.src.model;
using gerenciadorViagens_windowsForm_csharp.src.repository;

namespace gerenciadorViagens_windowsForm_csharp.src.view
{
    public partial class FormAtualizarDespesa : Form
    {
        private ExpenseController _expenseController = new ExpenseController(new ExpenseRepository(new ApplicationDbContext()));
        private readonly int _id;
        public FormAtualizarDespesa(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormAtualizarDespesa_Load(object sender, EventArgs e)
        {
            Expense expense = _expenseController.GetById(_id).Result;
            MessageBox.Show(expense.ToString());

            if (expense == null) throw new Exception("Despesa não encontrada!");

            tbx_category.Text = expense.Category;
            tbx_description.Text = expense.Description;
            tbx_value.Text = expense.Value;

        }

        private async void HandleUpdateExpense(object sender, EventArgs e)
        {
            string category = tbx_category.Text;
            string description = tbx_description.Text;
            string value = tbx_value.Text;

            Expense expense = new Expense(_id, category, description, value);

            await _expenseController.UpdateExpense(expense, _id);

            (Application.OpenForms["DetalhesDaViagem"] as DetalhesDaViagem)?.DetalhesDaViagem_Load(this, EventArgs.Empty);

            DetalhesDaViagem detalhesDaViagem = new DetalhesDaViagem(_id);
            detalhesDaViagem.Show();
            this.Close();
        }

        private void HandleCancelCreateExpense(object sender, EventArgs e)
        {
            DetalhesDaViagem detalhesDaViagem = new DetalhesDaViagem(_id);
            detalhesDaViagem.Show();
            this.Close();
        }

        private void KeyPressNumberExpense(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
