using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Services.IServices;
using System;

namespace MagicVilla_Web.Services
{
    // We need to add BaseService that way we will be able to make a calls to our API

    public class VillaNumberService : BaseService, IVillaNumberService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string villaUrl;
        public VillaNumberService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            this.villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public Task<T> CreateAsync<T>(VillaNumberCreateDto dto, string Token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = dto,
                Url = villaUrl + "/api/v1/VillaNumberAPI",
                Token = Token
            });
        }

        public Task<T> DeleteAsync<T>(int id,string Token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = villaUrl + "/api/v1/VillaNumberAPI?id=" + id,
                Token = Token
            });
        }

        public Task<T> GetAllAsync<T>(string Token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = villaUrl + "/api/v1/VillaNumberAPI",
                Token = Token
            });
        }

        public Task<T> GetAsync<T>(int id, string Token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = villaUrl + "/api/v1/VillaNumberAPI/id?id=" + id,
                Token = Token
            });
        }

        public Task<T> UpdateAsync<T>(VillaNumberUpdateDto dto, string Token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                Url = villaUrl + "/api/v1/VillaNumberAPI?id=" + dto.VillaNo,
                Token = Token
            });
        }
    }
}
