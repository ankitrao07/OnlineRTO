using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineRTo.ViewModel;
using OnlineRTO.Models;
namespace OnlineRTo
{
    interface IRegistration
    {
        IEnumerable<Registration> GetData();
        IEnumerable<Registration> GetPendingRegistration();
        Registration GetDatabyRegId(int RegId);
        void NewRegistration(Registration obj);
        void UpdateRegistration(int RegId, Registration obj);
        void Approve(int RegId, Registration obj);
    }
}
