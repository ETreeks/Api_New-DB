using ETreeks.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETreeks.Core.IService
{
    public interface IRegisterService
    {
        Task<int> RegisterStudent(Guser guser);

        Task RegisterTrainer(Guser guser);
    }
}
