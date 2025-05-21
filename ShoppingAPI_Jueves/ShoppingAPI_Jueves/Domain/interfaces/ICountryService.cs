using ShoppingAPI_Jueves.DAL.Entities;

namespace ShoppingAPI_Jueves.Domain.interfaces
{
    public interface ICountryService
    {
        Task <IEnumerable<Country>> GetCountriesAsync(); // es una firma de metodos
        Task<Country> GetCountryByIdAsync(Guid id);
        Task<Country> CreateCountryAsync(Country country);
        Task<Country> EditCountryAsync(Country country);
        Task<Country> DeletCountryAsync(Guid id);
    }
}
