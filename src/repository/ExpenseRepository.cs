using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerenciadorViagens_windowsForm_csharp.src.database;
using gerenciadorViagens_windowsForm_csharp.src.interfaces;
using gerenciadorViagens_windowsForm_csharp.src.model;

namespace gerenciadorViagens_windowsForm_csharp.src.repository
{
    internal class ExpenseRepository : IRepository<Expense>
    {

        private readonly ApplicationDbContext _context;

        public ExpenseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Expense> GetById(int id)
        {
            return await Task.Run(() => _context.Expenses.FirstOrDefault(expense => expense.Id == id));
        }

        public Task Add(Expense expense)
        {
            _context.Expenses.Add(expense);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Expense>> GetAll()
        {
            return await Task.Run(() => _context.Expenses.ToList());
        }

        public async Task Update(Expense expense, int id)
        {
            Expense existingExpense = await Task.Run(() => _context.Expenses.FirstOrDefault(e => e.Id == id));
            if (existingExpense != null)
            {
                expense.Id = existingExpense.Id;
                _context.Entry(existingExpense).CurrentValues.SetValues(expense);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Despesa não encontrada.");
            }
        }

        public bool Delete(int id)
        {
            Expense expense = _context.Expenses.Find(id);
            if (expense != null)
            {
                _context.Expenses.Remove(expense);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
