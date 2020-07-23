using Domain.DataAccess;
using Domain.Models.Models;
using Infrastructure.Database.Interfaces;

namespace Infrastructure.Database.Implementations
{
    public class EApplicationRepository : IRepository<EApplication>
    {
        private readonly SimpleAppContext _context;

        public EApplicationRepository(SimpleAppContext context)
        {
            _context = context;
        }

        public EApplication GetById(int id)
        {
            var application = _context.EApplications.Find(id);
            return application;
        }

        public EApplication Create(EApplication entity)
        {
            var addedApplication = _context.EApplications.Add(entity);
            _context.SaveChanges();
            return addedApplication.Entity;
        }

        public EApplication Update(int id, EApplication entity)
        {
            var application = _context.EApplications.Find(id);

            application.College = entity.College;
            application.Discipline1 = entity.Discipline1;
            application.Discipline2 = entity.Discipline2;
            application.Iin = entity.Iin;
            application.Score = entity.Score;

            _context.EApplications.Update(application);
            _context.SaveChanges();

            return application;
        }

        public EApplication Remove(int id)
        {
            var application = _context.EApplications.Find(id);

            _context.EApplications.Remove(application);
            _context.SaveChanges();

            return application;
        }
    }
}