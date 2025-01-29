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
    public partial class FormCadastroAtividade : Form
    {

        private readonly int _id;
        public FormCadastroAtividade(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormCadastroAtividade_Load(object sender, EventArgs e)
        {

        }

        private async void HandleCreateActivitie(object sender, EventArgs e)
        {
            string name = tbx_name.Text;
            string location = tbx_location.Text;
            DateTime date = tbx_date.Value;
            string time = tbx_time.Text;
            string status = tbx_status.Text;
            int travelId = _id;

            Activities activities = new Activities(travelId, name, location, time, date, status);

            ActivitiesController activitiesController = new ActivitiesController(new ActivitiesRepository(new ApplicationDbContext()));

            await activitiesController.CreateActivitie(activities);

            (Application.OpenForms["DetalhesDaViagem"] as DetalhesDaViagem)?.DetalhesDaViagem_Load(this, EventArgs.Empty);

            DetalhesDaViagem detalhesDaViagem = new DetalhesDaViagem(_id);
            detalhesDaViagem.Show();
            this.Close();
        }

        private void HandleCancelCreateActivitie(object sender, EventArgs e)
        {
            DetalhesDaViagem detalhesDaViagem = new DetalhesDaViagem(_id);
            detalhesDaViagem.Show();
            this.Close();
        }
    }
}
