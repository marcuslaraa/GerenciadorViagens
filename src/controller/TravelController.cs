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
    internal class TravelController
    {
        private readonly TravelService _travelService;

        public TravelController(IRepository<Travel> travelRepository)
        {
            _travelService = new TravelService(travelRepository);
        }

        public async Task CreateTravel(Travel travel)
        {
            try
            {
                await _travelService.createTravel(travel);
                MessageBox.Show("Viagem cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<List<Travel>> FindAll()
        {
            try
            {
                IEnumerable<Travel> travels = await _travelService.FindAll();
                return travels.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Travel>();
            }
        }

        public async Task<Travel> GetById(int id)
        {
            try
            {
                return await _travelService.GetById(id);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task UpdateTravel(Travel travel, int id)
        {
            try
            {
                await _travelService.UpdateTravel(travel, id);
                MessageBox.Show("Viagem atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool DeleteTravel(int id)
        {
            bool result = _travelService.Delete(id);

            if (result)
            {
                MessageBox.Show("Viagem excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao excluir viagem. A viagem não foi encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
    }
}
