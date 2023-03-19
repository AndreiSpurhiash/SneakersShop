using AutoMapper;
using SneakersShop.ApplicationCore.Entities;
using SneakersShop.ApplicationCore.Interfaces;
using Website.Areas.Admin.Models;
using System.Data.Entity.Core;

namespace Website.Services
{
    public class ColorService : IItemGenericService<ColorViewModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppLogger<ColorService> _logger;

        public ColorService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IAppLogger<ColorService> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }


        public async Task<ColorViewModel> CreateViewModelAsync(ColorViewModel viewModel)
        {
            var model = _mapper.Map<Color>(viewModel);
            _unitOfWork.Color.Add(model);
            await _unitOfWork.Color.SaveChangesAsync();
            return viewModel;
        }

        public async Task<ColorViewModel> DeleteViewModelAsync(ColorViewModel viewModel)
        {
            var model = _mapper.Map<Color>(viewModel);
            _unitOfWork.Color.Remove(model);
            await _unitOfWork.Color.SaveChangesAsync();
            return viewModel;
        }

        public async Task<ColorViewModel> GetViewModelByIdAsync(int id)
        {
            var model = await _unitOfWork.Color.GetFirstOrDefaultAsync(
                predicate: i => i.Id == id,
                isTracking: false);

            if (model is null)
            {
                _logger.LogError("Get_by_id operation is failed");
                throw new ObjectNotFoundException("Object not found");
            }

            var viewModel = _mapper.Map<ColorViewModel>(model);
            return viewModel;
        }

        public async Task<IEnumerable<ColorViewModel>> GetViewModelsAsync()
        {
            var models = await _unitOfWork.Color.GetAllAsync(
                 orderBy: i => i.OrderBy(i => i.Name));

            if (models is null)
            {
                _logger.LogError("Get_All operation is failed");
                throw new ObjectNotFoundException("Object not found");
            }

            var viewModels = _mapper.Map<IEnumerable<ColorViewModel>>(models);
            return viewModels;
        }

        public async Task<ColorViewModel> UpdateViewModelAsync(ColorViewModel viewModel)
        {
            var model = _mapper.Map<Color>(viewModel);
            _unitOfWork.Color.Update(model);
            await _unitOfWork.Color.SaveChangesAsync();
            return viewModel;
        }
    }
}
