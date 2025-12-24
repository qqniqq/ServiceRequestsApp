using System;

namespace ServiceRequestsLib
{
    public class ServiceRequest
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public string Contact { get; set; }
        public DateTime DateCreated { get; set; }
        public string ProblemType { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Specialist { get; set; }
        public string Status { get; set; }
    }
}
