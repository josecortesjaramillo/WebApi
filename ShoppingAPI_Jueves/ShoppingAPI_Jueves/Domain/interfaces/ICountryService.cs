using ShoppingAPI_Jueves.DAL.Entities;

namespace ShoppingAPI_Jueves.Domain.interfaces
{
    public interface ICountryService
    {
        Task <IEnumerable<Country>> GetCountriesAsync(); // es una firma de metodos
        Task<Country> CreateCountryAsync(Country country);
        Task<Country> GetCountryById(Guid id);
        Task<Country> EditCountryAsync(Country country);
        Task<Country> DeletCountryById(Guid id);

    }
}
