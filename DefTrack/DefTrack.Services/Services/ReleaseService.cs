using DataAccess.Repositories.Releases;
using DefTrack.Services.Contracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefTrack.Services.Services
{
    public class ReleaseService:IReleaseService
    {
        private readonly IReleasesRepository _releasesRepository;

        public ReleaseService(IReleasesRepository releasesRepository)
        {
            _releasesRepository = releasesRepository;
        }

        public IList<Domain.Entities.Release> Get(int id)
        {
            return _releasesRepository.Get().Where(x=>x.Prod_Id == id).ToList();
        }

        public Release GetRelDetails(int id)
        {
            return _releasesRepository.Find(x => x.Id == id).SingleOrDefault();
        }

        public void Add(Domain.Entities.Release release)
        {
            _releasesRepository.Add(release);
            _releasesRepository.SaveChanges();
        }

        public void Edit(Domain.Entities.Release release)
        {
            _releasesRepository.Update(release);
            _releasesRepository.SaveChanges();
        }

        public void Remove(Domain.Entities.Release release)
        {
            _releasesRepository.Remove(release);
            _releasesRepository.SaveChanges();
        }
    }
}
