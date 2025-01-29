using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
    public partial class ListagemViagens : Form
    {
        private readonly TravelController _travelController = new TravelController(new TravelRepository(new ApplicationDbContext()));
        public ListagemViagens()
        {
            InitializeComponent();
        }

        public async void ListagemViagens_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();


            IEnumerable<Travel> travels = await _travelController.FindAll();
            

            foreach (Travel travel in travels)
            {
                decimal budget = Convert.ToDecimal(travel.Budget);
                dataGridView1.Rows.Add(travel.Id,travel.TravelName, travel.Destination, travel.InitialDate.ToString("dd/MM/yyyy"), travel.FinalDate.ToString("dd/MM/yyyy"), budget.ToString("C2", new CultureInfo("pt-BR")), travel.Description, "Editar", "Excluir", "Detalhes");
            }

        }

        private void HandleFormCreateTravel(object sender, EventArgs e)
        {
            FormCadastroViagem formCadastroViagem = new FormCadastroViagem();
            formCadastroViagem.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int travelId = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

            if (e.ColumnIndex == dataGridView1.Columns["editTravel"].Index && e.RowIndex >= 0)
            {
                FormAtualizarViagem formAtualizarViagem = new FormAtualizarViagem(travelId);
                formAtualizarViagem.Show();
                this.Hide();
            }

            if (e.ColumnIndex == dataGridView1.Columns["details"].Index && e.RowIndex >= 0)
            {
                DetalhesDaViagem detalhesDaViagem = new DetalhesDaViagem(travelId);
                detalhesDaViagem.Show();
                this.Hide();
            }

            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                bool deleteTravel = _travelController.DeleteTravel(travelId);

                (Application.OpenForms["ListagemViagens"] as ListagemViagens)?.ListagemViagens_Load(this, EventArgs.Empty);

                ListagemViagens listagemViagens = new ListagemViagens();
                listagemViagens.Show();
                this.Close();

            }
        }
    }
}
