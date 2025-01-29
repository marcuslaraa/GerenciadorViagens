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
    internal class ExpenseController
    {
        private readonly ExpenseService _expenseService;

        public ExpenseController(IRepository<Expense> expenseRepository)
        {
            _expenseService = new ExpenseService(expenseRepository);
        }

        public async Task CreateExpense(Expense expense)
        {
            try
            {
                await _expenseService.createExpense(expense);
                MessageBox.Show("Despesa cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<List<Expense>> FindAll()
        {
            try
            {
                IEnumerable<Expense> expenses = await _expenseService.FindAll();
                return expenses.ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro: {e.Message}");
            }
        }

        public async Task<Expense> GetById(int id)
        {
            try
            {
                MessageBox.Show("chegou");
                return await _expenseService.GetById(id);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task UpdateExpense(Expense expense, int id)
        {
            try
            {
                await _expenseService.UpdateExpense(expense, id);
                MessageBox.Show("Despesa atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool DeleteExpense(int id)
        {
            bool result = _expenseService.Delete(id);

            if (result)
            {
                MessageBox.Show("Despesa excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao excluir despesa. A despesa não foi encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }


    }
}
