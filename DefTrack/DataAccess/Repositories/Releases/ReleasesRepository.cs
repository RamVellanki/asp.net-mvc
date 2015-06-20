using DataAccess.Repositories.Base;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Releases
{
    public class ReleasesRepository : BaseRepository<Release>, IReleasesRepository
    {
    }
}
