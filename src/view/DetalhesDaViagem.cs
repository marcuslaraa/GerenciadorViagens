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

            ActivitiesController activitiesController = new ActivitiesController(new ActivitiesRepository(new ApplicationDbContext()));
            IEnumerable<Activities> activities = await activitiesController.FindAll();

            foreach (Activities activitie in activities)
            {
                dataGridView1.Rows.Add(activitie.Name, activitie.Location, activitie.Time, activitie.Date.ToString("dd/MM/yyyy"), activitie.Status, "Editar");
            }
        }

        private void HandleOpenFormCreate(object sender, EventArgs e)
        {
            FormCadastroAtividade formCadastroAtividade = new FormCadastroAtividade(_id);
            formCadastroAtividade.Show();
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
        }
    }
}
