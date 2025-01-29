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
            MessageBox.Show("chegou Service");
            return await _expenseRepository.GetById(id);
        }

        public async Task UpdateExpense(Expense expense, int id)
        {
            expense.validate();
            await _expenseRepository.Update(expense, id);
        }

        public bool Delete(int id)
        {
            try
            {
                return _expenseRepository.Delete(id);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao excluir despesa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
