using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SPA_exams.Models;

namespace SPA_exams.Controllers
{
    public class WebController : ApiController
    {
        private ExamRepo repo = ExamRepo.Current;

        public IEnumerable<ExamResult> GetAllReservations()
        {
            return repo.GetAll();
        }

        public ExamResult GetReservation(int id)
        {
            return repo.Get(id);
        }

        public ExamResult PostReservation(ExamResult item)
        {
            return repo.Add(item);
        }

        public bool PutReservation(ExamResult item)
        {
            return repo.Update(item);
        }

        public void DeleteReservation(int id)
        {
            repo.Remove(id);
        }
    }
}
