using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefTrack.Services.Contracts
{
    public interface IReleaseService
    {
        IList<Release> Get(int id);
        Release GetRelDetails(int id);
        void Add(Release release);
        void Edit(Release release);
        void Remove(Release release);
    }
}
