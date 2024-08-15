using Dapper;

using ETreeks.Core.Data;
using ETreeks.Core.DTO;
using ETreeks.Core.ICommon;
using ETreeks.Core.IRepository;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETreeks.Infra.Repository
{
    public class AddressRepository :IAddressRepository
    {
        private readonly IDbContext _dbContext;
        public AddressRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateAddress(AddresssDto address)
        {
            var parameters = new DynamicParameters();
            parameters.Add("A_LongItude", address.Longitude, DbType.Double, ParameterDirection.Input);
            parameters.Add("A_LatItude", address.Latitude, DbType.Double, ParameterDirection.Input);
            parameters.Add("A_City", address.City, DbType.String, ParameterDirection.Input);
            parameters.Add("A_Country", address.Country, DbType.String, ParameterDirection.Input);
            parameters.Add("C_id", dbType: DbType.Int32, direction: ParameterDirection.Output);
            parameters.Add("P_UserId", address.UserId, DbType.Int32, ParameterDirection.Input); 

            await _dbContext.Connection.ExecuteAsync("ADDRESS_PACKAGE.CreateAddress", parameters, commandType: CommandType.StoredProcedure);
            return parameters.Get<int>("C_id");
        }



        public async Task<int> UpdateAddress(AddresssDto address)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Address_ID", address.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("A_LongItude", address.Longitude, DbType.Double, ParameterDirection.Input);
            parameters.Add("A_LatItude", address.Latitude, DbType.Double, ParameterDirection.Input);
            parameters.Add("A_City", address.City, DbType.String, ParameterDirection.Input);
            parameters.Add("A_Country", address.Country, DbType.String, ParameterDirection.Input);
            parameters.Add("C_id", dbType: DbType.Int32, direction: ParameterDirection.Output);

            {
                await _dbContext.Connection.ExecuteAsync("ADDRESS_PACKAGE.UpdateAddress", parameters, commandType: CommandType.StoredProcedure);
                int AID = parameters.Get<int>("C_id");
                return AID;
            }
        }
      

        public async Task<int> DeleteAddress(int addressId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Address_ID", addressId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("C_id", dbType: DbType.Int32, direction: ParameterDirection.Output);

            {
                await _dbContext.Connection.ExecuteAsync("ADDRESS_PACKAGE.DeleteAddress", parameters, commandType: CommandType.StoredProcedure);
                return parameters.Get<int>("C_id"); 
            }
        }


        public async Task<List<AddresssDto>> GetAllAddresses()
        {
            {
                var result = await _dbContext.Connection.QueryAsync<AddresssDto>(
                    "ADDRESS_PACKAGE.DisplayAllAddress",
                    commandType: CommandType.StoredProcedure
                );
                return result.ToList();
            }
        }




        public async Task<AddresssDto> GetAddressById(int addressId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Address_ID", addressId, DbType.Int32, ParameterDirection.Input);

            {
                var result = await _dbContext.Connection.QueryAsync<AddresssDto>(
                    "ADDRESS_PACKAGE.GetAddressById",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
                return result.FirstOrDefault();
            }
        }
    }
}
