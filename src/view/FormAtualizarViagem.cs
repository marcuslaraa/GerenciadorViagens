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
    public partial class FormAtualizarViagem : Form
    {

        private readonly TravelController _travelController = new TravelController(new TravelRepository(new ApplicationDbContext()));
        private readonly int _id;
        public FormAtualizarViagem(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FormAtualizarViagem_LoadAsync(object sender, EventArgs e)
        {
            Travel travel = await _travelController.GetById(_id);

            if (travel == null) throw new Exception("Viagem não encontrada!");

            tbx_travelName.Text = travel.TravelName;
            tbx_destination.Text = travel.Destination;
            tbx_initialDate.Value = travel.InitialDate;
            tbx_finalDate.Value = travel.FinalDate;
            tbx_budget.Text = travel.Budget;
            tbx_description.Text = travel.Description;

        }

        private async void handleUpdateTravelAsync(object sender, EventArgs e)
        {
            string travelName = tbx_travelName.Text;
            string destination = tbx_destination.Text;
            DateTime inistialDate = tbx_initialDate.Value;
            DateTime finalDate = tbx_finalDate.Value;
            string budget = tbx_budget.Text;
            string description = tbx_description.Text;

            Travel travel = new Travel(travelName, destination, inistialDate, finalDate, budget, description);

            await _travelController.UpdateTravel(travel, _id);

            (Application.OpenForms["ListagemViagens"] as ListagemViagens)?.ListagemViagens_Load(this, EventArgs.Empty);

            ListagemViagens listagemViagens = new ListagemViagens();
            listagemViagens.Show();
            this.Close();
        }

        private void HandleCancelUpdateTravel(object sender, EventArgs e)
        {
            ListagemViagens listagemViagens = new ListagemViagens();
            listagemViagens.Show();
            this.Close();
        }
    }
}
