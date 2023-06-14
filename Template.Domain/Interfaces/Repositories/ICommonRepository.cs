using Template.Domain.Models;

namespace Template.Domain.Interfaces.Repositories
{
    public interface ICommonRepository
    {
        IEnumerable<CommonModel> GetAll();
    }
}
