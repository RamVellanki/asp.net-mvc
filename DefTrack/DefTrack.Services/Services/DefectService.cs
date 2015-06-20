using DataAccess.Repositories.Defects;
using DefTrack.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefTrack.Services.Services
{
    public class DefectService:IDefectService
    {
        private readonly IDefectsRepository _defectRepository;
        public DefectService(IDefectsRepository defectsRepository)
        {
            _defectRepository = defectsRepository;
        }
        public IList<Domain.Entities.Defect> Get(int prodId, int relId)
        {
            return _defectRepository.Get().Where(x => x.Prod_Id == prodId)
                                          .Where(x => x.Rel_Id == relId)
                                          .ToList();
        }

        public Domain.Entities.Defect GetDefectDetails(int id)
        {
            return _defectRepository.Find(x=>x.Id == id).FirstOrDefault();
        }

        public void Add(Domain.Entities.Defect defect)
        {
            _defectRepository.Add(defect);
            _defectRepository.SaveChanges();
        }

        public void Edit(Domain.Entities.Defect defect)
        {
            _defectRepository.Update(defect);
            _defectRepository.SaveChanges();
        }

        public void Remove(Domain.Entities.Defect defect)
        {
            _defectRepository.Update(defect);
            _defectRepository.SaveChanges();
        }

        public void UpdateDefectStatus(int id, string status)
        {
            //TODO: Implement this in DefectRepository
            throw new NotImplementedException();
        }
    }
}
