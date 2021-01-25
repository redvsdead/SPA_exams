using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_exams.Models
{
    public class ExamRepo
    {
        private static ExamRepo repo = new ExamRepo();

        public static ExamRepo Current
        {
            get
            {
                return repo;
            }
        }

        private List<ExamResult> resultData = new List<ExamResult> {
            new ExamResult {
                Id = 1, Semester = 5, Subject = "Probability theories", Mark = 5},
            new ExamResult {
                Id = 2, Semester = 5, Subject = "Operation systems", Mark = 4},
            new ExamResult {
                Id = 3, Semester = 5, Subject = "Data bases", Mark = 5},
            new ExamResult {
                Id = 3, Semester = 5, Subject = "Calculus methods", Mark = 4},
        };

        public IEnumerable<ExamResult> GetAll()
        {
            return resultData;
        }

        public ExamResult Get(int id)
        {
            return resultData.Where(r => r.Id == id).FirstOrDefault();
        }

        public ExamResult Add(ExamResult item)
        {
            item.Id = resultData.Count + 1;
            resultData.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            ExamResult item = Get(id);
            if (item != null)
            {
                resultData.Remove(item);
            }
        }

        public bool Update(ExamResult item)
        {
            ExamResult storedItem = Get(item.Id);
            if (storedItem != null)
            {
                storedItem.Semester = item.Semester;
                storedItem.Subject = item.Subject;
                storedItem.Mark = item.Mark;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
