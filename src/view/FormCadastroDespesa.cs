using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerenciadorViagens_windowsForm_csharp.src.controller;
using gerenciadorViagens_windowsForm_csharp.src.database;
using gerenciadorViagens_windowsForm_csharp.src.model;
using gerenciadorViagens_windowsForm_csharp.src.repository;

namespace gerenciadorViagens_windowsForm_csharp.src.view
{
    public partial class FormCadastroDespesa : Form
    {
        private readonly int _id;
        public FormCadastroDespesa(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormCadastroDespesa_Load(object sender, EventArgs e)
        {

        }

        private async void HandleCreateExpense(object sender, EventArgs e)
        {
            string category = tbx_category.Text;
            string description = tbx_description.Text;
            string value = tbx_value.Text;

            Expense expense = new Expense(category, description, value);

            ExpenseController expenseController = new ExpenseController(new ExpenseRepository(new ApplicationDbContext()));

            await expenseController.CreateExpense(expense);

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
    }
}
