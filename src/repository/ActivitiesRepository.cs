using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerenciadorViagens_windowsForm_csharp.src.database;
using gerenciadorViagens_windowsForm_csharp.src.interfaces;
using gerenciadorViagens_windowsForm_csharp.src.model;

namespace gerenciadorViagens_windowsForm_csharp.src.repository
{
    internal class ActivitiesRepository : IRepository<Activities>
    {
        private readonly ApplicationDbContext _context;

        public ActivitiesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Activities> GetById(int id)
        {
            return await Task.Run(() => _context.Activities.FirstOrDefault(act => act.Id == id));
        }
        public Task Add(Activities act)
        {
            _context.Activities.Add(act);
            _context.SaveChanges();

            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Activities>> GetAll()
        {
            return await Task.Run(() => _context.Activities.ToList());
        }

        public async Task Update(Activities act, int id)
        {

            Activities existingAct = await Task.Run(() => _context.Activities.FirstOrDefault(a => a.Id == id));
            if (existingAct != null)
            {
                act.Id = existingAct.Id;
                _context.Entry(existingAct).CurrentValues.SetValues(act);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Viagem não encontrada.");
            }
        }

        public bool Delete(int id)
        {
            Activities act = _context.Activities.Find(id);
            if (act != null)
            {
                _context.Activities.Remove(act);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Activities>> GetByTravelIdAsync(int travelId)
        {
            return await _context.Activities.Where(a => a.TravelId == travelId).ToListAsync();
        }
    }
}
