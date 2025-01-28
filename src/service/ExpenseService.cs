using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gerenciadorViagens_windowsForm_csharp.src.interfaces;
using gerenciadorViagens_windowsForm_csharp.src.model;

namespace gerenciadorViagens_windowsForm_csharp.src.service
{
    internal class ExpenseService
    {
        private readonly IRepository<Expense> _expenseRepository;

        public ExpenseService(IRepository<Expense> expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task createExpense(Expense expense)
        {
            expense.validate();
            await _expenseRepository.Add(expense);
        }

        public async Task<IEnumerable<Expense>> FindAll()
        {
            return await _expenseRepository.GetAll();
        }

        public async Task<Expense> GetById(int id)
        {
            return await _expenseRepository.GetById(id);
        }

        public async Task UpdateExpense(Expense expense, int id)
        {
            expense.validate();
            await _expenseRepository.Update(expense, id);
        }

    }
}
