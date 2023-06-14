using Template.Domain.Interfaces.Repositories;
using Template.Domain.Interfaces.Services;
using Template.Domain.Models;

namespace Template.Service.Implementation
{
    public class CommonService : ICommonService
    {
        private readonly ICommonRepository _commonRepository;

        public CommonService(ICommonRepository commonRepository)
        {
            _commonRepository = commonRepository;
        }

        public IEnumerable<CommonModel> GetAll()
        {
           return _commonRepository.GetAll();
        }
    }
}
