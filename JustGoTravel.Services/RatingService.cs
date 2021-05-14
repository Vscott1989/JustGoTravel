using JustGoTravel.Data;
using JustGoTravel.Models.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustGoTravel.Services
{
   public class RatingService
    {
        private readonly Guid _userId;
        public RatingService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateRating(RatingCreate model)
        {
            var entity = new Rating()
            {
                AuthorID = _userId,
                StarRating = model.StarRating
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Ratings.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<RatingListItem> GetRatings()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .Ratings
                    .Where(e => e.AuthorID == _userId)
                    .Select(e => new RatingListItem
                    {
                        ID = e.ID,
                        StarRating = e.StarRating
                    });
                return query.ToArray();
            }
        }
    }
}
