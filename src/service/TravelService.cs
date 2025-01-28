using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gerenciadorViagens_windowsForm_csharp.src.interfaces;
using gerenciadorViagens_windowsForm_csharp.src.model;

namespace gerenciadorViagens_windowsForm_csharp.src.service
{
    internal class TravelService
    {
        private readonly IRepository<Travel> _travelRepository;
        public TravelService(IRepository<Travel> travelRepository)
        {
            _travelRepository = travelRepository;
        }

        public async Task createTravel(Travel travel)
        {
            travel.validate();
            await _travelRepository.Add(travel);
        }

        public async Task<IEnumerable<Travel>> FindAll()
        {
            return await _travelRepository.GetAll();
        }

        public async Task<Travel> GetById(int id)
        {
            return await _travelRepository.GetById(id);
        }

        public async Task UpdateTravel(Travel travel, int id)
        {
            travel.validate();
            await _travelRepository.Update(travel, id);
        }
    }

}
