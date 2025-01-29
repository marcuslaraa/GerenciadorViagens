using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerenciadorViagens_windowsForm_csharp.src.interfaces;
using gerenciadorViagens_windowsForm_csharp.src.model;
using gerenciadorViagens_windowsForm_csharp.src.service;

namespace gerenciadorViagens_windowsForm_csharp.src.controller
{
    internal class ActivitiesController
    {
        private readonly ActivitiesService _activitiesService;

        public ActivitiesController(IRepository<Activities> activitiesRepository)
        {
            _activitiesService = new ActivitiesService(activitiesRepository);
        }

        public async Task CreateActivitie(Activities activitie)
        {
            try
            {
                await _activitiesService.createActivitie(activitie);
                MessageBox.Show("Atividade criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<IEnumerable<Activities>> FindAll()
        {
            try
            {
                return await _activitiesService.FindAll();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar atividades: {e.Message}");
            }
        }

        public async Task<Activities> GetById(int id)
        {
            try
            {
                return await _activitiesService.GetById(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar atividade: {e.Message}");
            }
        }

        public async Task UpdateActivitie(Activities activitie, int id)
        {
            try
            {
                await _activitiesService.UpdateActivitie(activitie, id);
                MessageBox.Show("Atividade atulizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool DeleteActivities(int id)
        {
            bool result = _activitiesService.Delete(id);

            if (result)
            {
                MessageBox.Show("Atividade excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao excluir atividade. A atividade não foi encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        public async Task<IEnumerable<Activities>> GetByTravelIdAsync(int travelId)
        {
            try
            {
                return await _activitiesService.FindAllByTravelId(travelId);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao buscar atividades por ID de viagem: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Enumerable.Empty<Activities>();
            }
        }


    }
}
