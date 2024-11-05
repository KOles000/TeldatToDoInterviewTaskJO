using TeldatToDoInterviewTaskJO.Models;
using System.Collections.Generic;

namespace TeldatToDoInterviewTaskJO.Services
{
    public interface IAssigmentService
    {
        /// <summary>
        /// get assigments by chosen date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        List<Assigment> GetAssigmentsByDate(DateTime date);

        /// <summary>
        /// get assigment by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Assigment GetAssigmentById(int id);

        /// <summary>
        /// get all assigments in db
        /// </summary>
        /// <returns></returns>
        List<Assigment> GetAllAssigments();

        /// <summary>
        /// add and update assigment
        /// </summary>
        /// <param name="assigment"></param>
        void SaveAssigment (Assigment assigment);

        /// <summary>
        /// removes assigments by its id
        /// </summary>
        /// <param name="id"></param>
        void DeleteAssigmentById(int id);
    }
}
