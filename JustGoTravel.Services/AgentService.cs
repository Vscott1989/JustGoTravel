using JustGoTravel.Data;
using JustGoTravel.Models.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustGoTravel.Services
{
   public class AgentService
    {
        private readonly Guid _userId;
        public AgentService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateAgent(AgentCreate model)
        {
            var entity = new Agent()
            {
                AuthorId = _userId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Company = model.Company,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                LinkedIn = model.LinkedIn

            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Agents.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<AgentListItem> GetAgents()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .Agents
                    .Where(e => e.AuthorId == _userId)
                    .Select(e => new AgentListItem
                    {
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        Company = e.Company,
                        PhoneNumber = e.PhoneNumber,
                        Email = e.Email,
                        LinkedIn = e.LinkedIn

                    });
                return query.ToArray();
            }
        }

    }
}
