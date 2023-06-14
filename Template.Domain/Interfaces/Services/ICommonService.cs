using Template.Domain.Models;

namespace Template.Domain.Interfaces.Services
{
    public interface ICommonService
    {
        IEnumerable<CommonModel> GetAll();
    }
}
