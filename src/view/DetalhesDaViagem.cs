using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using gerenciadorViagens_windowsForm_csharp.src.controller;
using gerenciadorViagens_windowsForm_csharp.src.database;
using gerenciadorViagens_windowsForm_csharp.src.model;
using gerenciadorViagens_windowsForm_csharp.src.repository;

namespace gerenciadorViagens_windowsForm_csharp.src.view
{
    public partial class DetalhesDaViagem : Form
    {

        ActivitiesController _activitiesController = new ActivitiesController(new ActivitiesRepository(new ApplicationDbContext()));
        ExpenseController _expenseController = new ExpenseController(new ExpenseRepository(new ApplicationDbContext()));

        private readonly int _id;
        public DetalhesDaViagem(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        public async void DetalhesDaViagem_Load(object sender, EventArgs e)
        {
            TravelController travelController = new TravelController(new TravelRepository(new ApplicationDbContext()));
            Travel travel = await travelController.GetById(_id);
            decimal budget = Convert.ToDecimal(travel.Budget);

            lb_nomeViagem.Text = $"{travel.TravelName} - {travel.Destination}";
            lb_dataIda.Text = $"Ida: {travel.InitialDate.ToString("dd/MM/yyyy")}";
            lb_dataVolta.Text = $"Volta: {travel.FinalDate.ToString("dd/MM/yyyy")}";
            lb_orcamento.Text = budget.ToString("C", new CultureInfo("pt-BR"));
            lb_description.Text = travel.Description;

            dataGridView1.Rows.Clear();

            IEnumerable<Activities> activities = await _activitiesController.GetByTravelIdAsync(_id);

            IEnumerable<Expense> expenses = await _expenseController.GetByTravelIdAsync(_id);

            foreach (Activities activitie in activities)
            {
                dataGridView1.Rows.Add(activitie.Id, activitie.Name, activitie.Location, activitie.Time, activitie.Date.ToString("dd/MM/yyyy"), activitie.Status, "Editar", "Excluir");
            }

            foreach (Expense expense in expenses)
            {
                decimal Value = Convert.ToDecimal(expense.Value);
                dataGridView2.Rows.Add(expense.Id, expense.Category, Value.ToString("C2", new CultureInfo("pt-BR")), expense.Description, "Editar", "Excluir");
            }
        }

        private void HandleOpenFormCreateActivitie(object sender, EventArgs e)
        {
            FormCadastroAtividade formCadastroAtividade = new FormCadastroAtividade(_id);
            formCadastroAtividade.Show();
            this.Hide();
        }

        private void HandleOpenFormCreateExpense(object sender, EventArgs e)
        {
            FormCadastroDespesa formCadastroDespesa = new FormCadastroDespesa(_id);
            formCadastroDespesa.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["activitiesEdit"].Index && e.RowIndex >= 0)
            {

                FormAtualizarAtividade formAtualizarAtividade = new FormAtualizarAtividade(_id);
                formAtualizarAtividade.Show();
                this.Hide();

            }

            if (e.ColumnIndex == dataGridView1.Columns["deleteAct"].Index && e.RowIndex >= 0)
            {
                int activitieId = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                _activitiesController.DeleteActivities(activitieId);

                (Application.OpenForms["DetalhesDaViagem"] as DetalhesDaViagem)?.DetalhesDaViagem_Load(this, EventArgs.Empty);

                DetalhesDaViagem detalhesDaViagem = new DetalhesDaViagem(_id);
                detalhesDaViagem.Show();
                this.Hide();

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["expenseEdit"].Index && e.RowIndex >= 0)
            {
                FormAtualizarDespesa formAtualizarDespesa = new FormAtualizarDespesa(_id);
                formAtualizarDespesa.Show();
                this.Hide();
            }

            if (e.ColumnIndex == dataGridView2.Columns["deleteExp"].Index && e.RowIndex >= 0)
            {
                int expenseId = (int)dataGridView2.Rows[e.RowIndex].Cells["idExpense"].Value;
                _expenseController.DeleteExpense(expenseId);

                (Application.OpenForms["DetalhesDaViagem"] as DetalhesDaViagem)?.DetalhesDaViagem_Load(this, EventArgs.Empty);

                DetalhesDaViagem detalhesDaViagem = new DetalhesDaViagem(_id);
                detalhesDaViagem.Show();
                this.Hide();

            }


        }

        private void HandleBackList(object sender, EventArgs e)
        {
            ListagemViagens listagemViagens = new ListagemViagens();
            listagemViagens.Show();
            this.Close();

        }
    }
}
