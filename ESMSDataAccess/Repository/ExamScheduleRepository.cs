using ESMSBusinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESMSDataAccess.Repository
{
    public class ExamScheduleRepository : IExamScheduleRepository
    {
        public ExamSchedule GetAirConditionerByID(int id) => ExamScheduleDAO.Instance.GetAirConditionerByID(id);
        public IEnumerable<ExamSchedule> GetAirConditioners() => ExamScheduleDAO.Instance.GetAirConditioners();
        public void AddNewAirConditioner(ExamSchedule AirConditioner) => ExamScheduleDAO.Instance.AddNewAirConditioner(AirConditioner);
        public void RemoveAirConditioner(int id) => ExamScheduleDAO.Instance.RemoveAirConditioner(id);
        public void UpdateAirConditioner(ExamSchedule AirConditioner) => ExamScheduleDAO.Instance.UpdateAirConditioner(AirConditioner);
        public IEnumerable<ExamSchedule> SearchByRoom(string room) => ExamScheduleDAO.Instance.SearchByRoom(room);
        public IEnumerable<ExamSchedule> SearchByCourse(string course) => ExamScheduleDAO.Instance.SearchByCourse(course);
    }
}
