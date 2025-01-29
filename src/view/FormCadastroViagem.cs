using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerenciadorViagens_windowsForm_csharp.src.controller;
using gerenciadorViagens_windowsForm_csharp.src.database;
using gerenciadorViagens_windowsForm_csharp.src.model;
using gerenciadorViagens_windowsForm_csharp.src.repository;
using gerenciadorViagens_windowsForm_csharp.src.view;

namespace gerenciadorViagens_windowsForm_csharp
{
    public partial class FormCadastroViagem : Form
    {
        public FormCadastroViagem()
        {
            InitializeComponent();
        }

        private void FormCadastroViagem_Load(object sender, EventArgs e)
        {

        }

        private async void handleCreateTravelAsync(object sender, EventArgs e)
        {
            string travelName = tbx_travelName.Text;
            string destination = tbx_destination.Text;
            DateTime inistialDate = tbx_initialDate.Value;
            DateTime finalDate = tbx_finalDate.Value;
            string budget = tbx_budget.Text;
            string description = tbx_description.Text;

            Travel travel = new Travel(travelName, destination, inistialDate, finalDate, budget, description);

            TravelController travelController = new TravelController(new TravelRepository(new ApplicationDbContext()));

            await travelController.CreateTravel(travel);

            (Application.OpenForms["ListagemViagens"] as ListagemViagens)?.ListagemViagens_Load(this, EventArgs.Empty);

            ListagemViagens listagemViagens = new ListagemViagens();
            listagemViagens.Show();
            this.Close();
        }

        private void HandleCancelCreateTravel(object sender, EventArgs e)
        {
            ListagemViagens listagemViagens = new ListagemViagens();
            listagemViagens.Show();
            this.Close();
        }

        private void KeyPressNumberOrcamento(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
