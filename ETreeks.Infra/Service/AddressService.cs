using ETreeks.Core.DTO;
using ETreeks.Core.IRepository;
using ETreeks.Core.IService;
using ETreeks.Infra.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETreeks.Infra.Service
{
    public class AddressService :IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<int> CreateAddress(AddresssDto address )
        {
            return await _addressRepository.CreateAddress(address );
        }

        public async Task<int> UpdateAddress(AddresssDto address)
        {
            return await _addressRepository.UpdateAddress(address);
        }

        public async Task<int> DeleteAddress(int addressId)
        {
            return await _addressRepository.DeleteAddress(addressId);
        }

        public async Task<List<AddresssDto>> GetAllAddresses()
        {
            return await _addressRepository.GetAllAddresses();
        }

        public async Task<AddresssDto> GetAddressById(int addressId)
        {
            return await _addressRepository.GetAddressById(addressId);
        }





    }
}
