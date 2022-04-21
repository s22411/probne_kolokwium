using System;

namespace Models
{
    public class Animal
    {
        public int IdAnima { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime AdmissionDate { get; set; }
        public int IdOwner { get; set; }
    }
}