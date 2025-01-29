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
    public partial class FormAtualizarAtividade : Form
    {
        private readonly ActivitiesController _activitiesController = new ActivitiesController(new ActivitiesRepository(new ApplicationDbContext()));
        private readonly int _id;
        public FormAtualizarAtividade(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FormAtualizarAtividade_Load(object sender, EventArgs e)
        {
            Activities activitie = await _activitiesController.GetById(_id);

            if (activitie == null) throw new Exception("Atividade não encontrada!");

            tbx_name.Text = activitie.Name;
            tbx_location.Text = activitie.Location;
            tbx_date.Value = activitie.Date;
            tbx_time.Text = activitie.Time;
            tbx_status.Text = activitie.Status;
        }

        private void HandleCancelForm(object sender, EventArgs e)
        {
            DetalhesDaViagem detalhesDaViagem = new DetalhesDaViagem(_id);
            detalhesDaViagem.Show();
            this.Close();
        }

        private async void HandleUpdateActivitieAsync(object sender, EventArgs e)
        {
            string name = tbx_name.Text;
            string location = tbx_location.Text;
            DateTime date = tbx_date.Value;
            string time = tbx_time.Text;
            string status = tbx_status.Text;

            Activities activitie = new Activities(_id, name, location, time, date, status);

            await Task.Run(() => _activitiesController.UpdateActivitie(activitie, _id));

            (Application.OpenForms["DetalhesDaViagem"] as DetalhesDaViagem)?.DetalhesDaViagem_Load(this, EventArgs.Empty);

            DetalhesDaViagem detalhesDaViagem = new DetalhesDaViagem(_id);
            detalhesDaViagem.Show();
            this.Close();
        }
    }
}
