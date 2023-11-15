using ESMSBusinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESMSDataAccess
{
    public class ExamScheduleDAO
    {
        private static ExamScheduleDAO instance = null;
        private static readonly object instanceLock = new object();

        public static ExamScheduleDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ExamScheduleDAO();
                    }
                    return instance;
                }
            }
        }

        //get AirConditioner list

        public IEnumerable<ExamSchedule> GetAirConditioners()
        {
            var AirConditioners = new List<ExamSchedule>();
            try
            {
                using var context = new EsmsContext();
                AirConditioners = context.ExamSchedules.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return AirConditioners;
        }

        //get AirConditioners by ID

        public ExamSchedule GetAirConditionerByID(int id)
        {
            ExamSchedule AirConditioner = null;
            try
            {
                using var context = new EsmsContext();
                AirConditioner = context.ExamSchedules.SingleOrDefault(AirConditioner => AirConditioner.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return AirConditioner;
        }

        //add new AirConditioner

        public void AddNewAirConditioner(ExamSchedule AirConditioner)
        {
            try
            {
                ExamSchedule _AirConditioner = GetAirConditionerByID(AirConditioner.Id);
                if (_AirConditioner == null)
                {
                    using var context = new EsmsContext();
                    context.ExamSchedules.Add(AirConditioner);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The AirConditioner is already exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        //remove AirConditioner

        public void RemoveAirConditioner(int id)
        {
            try
            {
                ExamSchedule AirConditioner = GetAirConditionerByID(id);
                if (AirConditioner != null)
                {
                    using var context = new EsmsContext();
                    context.ExamSchedules.Remove(AirConditioner);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The AirConditioner does not exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        //update AirConditioner

        public void UpdateAirConditioner(ExamSchedule AirConditioner)
        {
            try
            {
                ExamSchedule _AirConditioner = GetAirConditionerByID(AirConditioner.Id);
                if (_AirConditioner != null)
                {
                    using var context = new EsmsContext();
                    context.ExamSchedules.Update(AirConditioner);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The AirConditioner does not exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public IEnumerable<ExamSchedule> SearchByRoom(string keyword)
        {
            var AirConditioners = new List<ExamSchedule>();
            try
            {
                using var context = new EsmsContext();
                AirConditioners = context.ExamSchedules.Where(AirConditioner => AirConditioner.Room.Contains(keyword)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return AirConditioners;
        }

        public IEnumerable<ExamSchedule> SearchByCourse(string keyword)
        {
            var AirConditioners = new List<ExamSchedule>();
            try
            {
                using var context = new EsmsContext();
                AirConditioners = context.ExamSchedules.Where(AirConditioner => AirConditioner.Course.Contains(keyword)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return AirConditioners;
        }
    }
}
