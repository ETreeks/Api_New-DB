using ETreeks.Core.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETreeks.Core.IService
{
    public interface IAddressService
    {

        Task<int> CreateAddress(AddresssDto address);
        Task<int> UpdateAddress(AddresssDto address);
        Task<int> DeleteAddress(int addressId);
        Task<List<AddresssDto>> GetAllAddresses();
        Task<AddresssDto> GetAddressById(int addressId);
    }
}
