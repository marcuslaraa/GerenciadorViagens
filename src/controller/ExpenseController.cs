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
                return await _expenseService.GetById(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro: {e.Message}");
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


    }
}
