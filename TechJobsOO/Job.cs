using System;
using System.Reflection;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employer, Location location, PositionType positionType, CoreCompetency competency) : this()
        {
            Name = name;
            EmployerName = employer;
            EmployerLocation = location;
            JobType = positionType;
            JobCoreCompetency = competency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            bool isNull = false;

            foreach(PropertyInfo property in this.GetType().GetProperties())
            {
                if (this.EmployerName.Value == null || this.EmployerLocation.Value == null || this.JobType.Value == null || this.JobCoreCompetency == null)
                {
                    isNull = true;
                }
            }

            if (isNull == true)
            {
                return "OOPS! This job does not seem to exist.";
            }
            else
            {
                return $"ID:  {this.Id}\nName: {this.Name}\nEmployer: {this.EmployerName}\nLocation: {this.EmployerLocation}\nPosition Type: {this.JobType}\nCore Competency: {this.JobCoreCompetency}";
            }

        }
    }
}
