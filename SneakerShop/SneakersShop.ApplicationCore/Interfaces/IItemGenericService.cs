using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakersShop.ApplicationCore.Interfaces
{
    public interface IItemGenericService<T> where T : class
    {
        public Task<IEnumerable<T>> GetViewModelsAsync();
        public Task<T> GetViewModelByIdAsync(int id);
        public Task<T> CreateViewModelAsync(T viewModel);
        public Task<T> UpdateViewModelAsync(T viewModel);
        public Task<T> DeleteViewModelAsync(T viewModel);
    }
}
