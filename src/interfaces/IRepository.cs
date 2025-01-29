using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gerenciadorViagens_windowsForm_csharp.src.model;

namespace gerenciadorViagens_windowsForm_csharp.src.interfaces
{
    internal interface IRepository<T>
    {
        Task<T>GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T a);
        Task Update(T a, int id);
        bool Delete(int id);
        Task<IEnumerable<T>> GetByTravelIdAsync(int travelId);
    }
    }
