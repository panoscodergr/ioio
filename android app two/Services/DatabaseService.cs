using JobApp.Models;
using System.Collections.Generic;

namespace JobApp.Services
{
    public class DatabaseService
    {
        private static List<Job> jobList = new List<Job>();

        public void AddJob(Job job)
        {
            jobList.Add(job);
        }

        public List<Job> GetAllJobs()
        {
            return jobList;
        }
    }
}
