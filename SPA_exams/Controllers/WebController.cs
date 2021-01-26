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

        public IEnumerable<ExamResult> GetAllExams()
        {
            return repo.GetAll();
        }

        public ExamResult GetExam(int id)
        {
            return repo.Get(id);
        }

        [HttpPost]
        public ExamResult CreateExam(ExamResult item)
        {
            return repo.Add(item);
        }

        [HttpPut]
        public bool UpdateExam(ExamResult item)
        {
            return repo.Update(item);
        }

        public void DeleteExam(int id)
        {
            repo.Remove(id);
        }
    }
}
