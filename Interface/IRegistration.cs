using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRTO.ViewModel;
using OnlineRTO.Models;
namespace eRTO
{
    interface IRegistration
    {
        IEnumerable<Registration> GetData();
        Registration GetDatabyRegId(int RegId);
        void NewRegistration(Registration obj);
        void UpdateRegistration(int RegId, Registration obj);
    }
}
