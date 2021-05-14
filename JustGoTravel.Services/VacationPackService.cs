using JustGoTravel.Data;
using JustGoTravel.Models.VacationPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustGoTravel.Services
{
   public class VacationPackService
    {
        private readonly Guid _userId;

        public VacationPackService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateVacationPack(VacationPackCreate model)
        {
            var entity =
                new VacationPack()
                {
                    AuthorId = _userId,
                    Title = model.Title,
                    TripLength =  model.TripLength,
                    TotalCost = model.TotalCost,
                    Location = model.Location,
                    Description = model.Description,
                    TimeOfPublication = DateTimeOffset.Now

                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.VacationPacks.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<VacationPackListItem> GetVacationPacks()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .VacationPacks
                    .Where(e => e.AuthorId == _userId)
                    .Select(e => new VacationPackListItem
                    {
                        VacationPackID = e.ID,
                        Title = e.Title,
                        TripLength = e.TripLength,
                        TotalCost = e.TotalCost,
                        Location = e.Location,
                        Description = e.Description,
                        TimeOfPublication=e.TimeOfPublication


                    });
                return query.ToArray();
            }
        }
    }
}
