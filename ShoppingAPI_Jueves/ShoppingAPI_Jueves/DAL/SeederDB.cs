using ShoppingAPI_Jueves.DAL.Entities;

namespace ShoppingAPI_Jueves.DAL
{
    public class SeederDB
    {
        private readonly DataBaseContext _context;

        public SeederDB (DataBaseContext context)
        {
            _context = context;
        }

        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            await populateCountriesAsync();
        }

        #region Privaet Methos 

        private async Task PopulateCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country
                {
                    CreatedDate = DateTime.Now,
                    Name = "colombia",
                    States = new List<State>()
                    {
                        new State
                        {
                            CreatedDate=DateTime.Now,
                            Name = "antioquia",
                        },

                        new State
                        {
                            CreatedDate=DateTime.Now,
                            Name = "Cundinamarca",
                        }

                    }
                });






                _context.Countries.Add(new Country
                {
                    CreatedDate = DateTime.Now,
                    Name = "argentina",
                    States = new List<State>()
                    {
                        new State
                        {
                            CreatedDate=DateTime.Now,
                            Name = "buenoas aires",
                        },

                    }
                });



            }
        }

        #endregion
    }
}
