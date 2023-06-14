using Microsoft.EntityFrameworkCore;
using Template.Domain.Interfaces.Repositories;
using Template.Domain.Models;

namespace Template.DAL.Repositories
{
    public class CommonRepository : ICommonRepository
    {
        private readonly ApplicationDbContext _db;

        public CommonRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<CommonModel> GetAll()
        {
            return _db.Ones.Include(x => x.Manys).Select(x => new CommonModel
            {
                OneName = x.Name,
                ManyName = x.Manys.Select(x => x.Name).ToString()
            }).ToList();
        }
    }
}
