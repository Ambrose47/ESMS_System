using ESMSBusinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESMSDataAccess.Repository
{
    public interface IExamScheduleRepository
    {
        IEnumerable<ExamSchedule> GetAirConditioners();
        ExamSchedule GetAirConditionerByID(int id);
        void RemoveAirConditioner(int id);
        void UpdateAirConditioner(ExamSchedule AirConditioner);
        void AddNewAirConditioner(ExamSchedule AirConditioner);
        IEnumerable<ExamSchedule> SearchByRoom(string room);
        IEnumerable<ExamSchedule> SearchByCourse(string course);

    }
}
