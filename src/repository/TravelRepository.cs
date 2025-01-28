using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerenciadorViagens_windowsForm_csharp.src.interfaces;
using gerenciadorViagens_windowsForm_csharp.src.model;
using gerenciadorViagens_windowsForm_csharp.src.database;

namespace gerenciadorViagens_windowsForm_csharp.src.repository
{
    internal class TravelRepository : IRepository<Travel>
    {
        private readonly ApplicationDbContext _context;

        public TravelRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Travel> GetById(int id)
        {
            return await Task.Run(() => _context.Travels.FirstOrDefault(travel => travel.Id == id));
        }
        public Task Add(Travel travel)
        {
            _context.Travels.Add(travel);
            _context.SaveChanges();

            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Travel>> GetAll()
        {
            return await Task.Run(() => _context.Travels.ToList());
        }

        public async Task Update(Travel travel, int id)
        {
            MessageBox.Show(id.ToString());

            Travel existingTravel = await Task.Run(() => _context.Travels.FirstOrDefault(t => t.Id == id));
            MessageBox.Show(existingTravel.ToString());
            if (existingTravel != null)
            {
                travel.Id = existingTravel.Id;
                _context.Entry(existingTravel).CurrentValues.SetValues(travel);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Viagem não encontrada.");
            }
        }

        public void Delete(int id)
        {
            Travel travel = _context.Travels.Find(id);
            if (travel != null)
            {
                _context.Travels.Remove(travel);
                _context.SaveChanges();
            }
        }
    }
}
