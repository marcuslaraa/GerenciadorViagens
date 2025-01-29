using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerenciadorViagens_windowsForm_csharp.src.interfaces;
using gerenciadorViagens_windowsForm_csharp.src.model;
using gerenciadorViagens_windowsForm_csharp.src.repository;

namespace gerenciadorViagens_windowsForm_csharp.src.service
{
    internal class ActivitiesService
    {
        private readonly IRepository<Activities> _activitiesRepository;

        public ActivitiesService(IRepository<Activities> activitiesRepository)
        {
            _activitiesRepository = activitiesRepository;
        }

        public async Task createActivitie(Activities activitie)
        {
            activitie.validate();
            await _activitiesRepository.Add(activitie);
        }

        public async Task<IEnumerable<Activities>> FindAll()
        {
            return await _activitiesRepository.GetAll();
        }

        public async Task<Activities> GetById(int id)
        {
            return await _activitiesRepository.GetById(id);
        }

        public async Task UpdateActivitie(Activities activitie, int id)
        {
            activitie.validate();
            await _activitiesRepository.Update(activitie, id);
        }

        public bool Delete(int id)
        {
            try
            {
                return _activitiesRepository.Delete(id);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao excluir atividade: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
