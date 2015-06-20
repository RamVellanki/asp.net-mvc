using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefTrack.Services.Contracts
{
    public interface IDefectService
    {
        IList<Defect> Get(int prodId, int relId);
        Defect GetDefectDetails(int id);
        void Add(Defect defect);
        void Edit(Defect defect);
        void Remove(Defect defect);
        void UpdateDefectStatus(int id, string status);
    }
}
