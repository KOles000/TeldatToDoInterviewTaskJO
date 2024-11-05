using TeldatToDoInterviewTaskJO.Models;

namespace TeldatToDoInterviewTaskJO.Services
{
    public class AssigmentService : IAssigmentService
    {
        private AssigmentDbContext _context;
        public AssigmentService(AssigmentDbContext context)
        {
            _context = context;
        }

        public List<Assigment> GetAllAssigments()
        {
            List<Assigment> assigments;

            try
            {
                assigments = _context.Set<Assigment>().ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return assigments;
        }

        public Assigment GetAssigmentById(int id)
        {
            Assigment assigment;

            try
            {
                assigment = _context.Set<Assigment>().Find(id);
            }
            catch (Exception)
            {

                throw;
            }

            return assigment;
        }

        public List<Assigment> GetAssigmentsByDate(DateTime date)
        {
            List<Assigment> assigments;

            try
            {
                assigments = _context.Set<Assigment>().Where(x => x.AssigmentDate == date).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return assigments;
        }

        public void SaveAssigment(Assigment assigment)
        {
            try
            {
                Assigment sendAssigment = GetAssigmentById(assigment.AssigmentId);
                if (sendAssigment != null)
                { 
                    sendAssigment.AssigmentName = assigment.AssigmentName;
                    sendAssigment.AssigmentDescription = assigment.AssigmentDescription;
                    sendAssigment.AssigmentDate = assigment.AssigmentDate;

                    _context.Update(sendAssigment);
                }
                else
                {
                    _context.Add(assigment);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteAssigmentById(int id)
        {
            Assigment assigmentToRemove = GetAssigmentById(id);
            if (assigmentToRemove != null)
            {
                _context.Remove(assigmentToRemove);
                _context.SaveChanges();
            }
        }
    }
}
