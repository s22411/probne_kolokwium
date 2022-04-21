using System;

namespace Models.DTOs
{
    public class AnimalsGET
    {
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public DateTime DateOfAdmission { get; set; }
        public string LastNameOfOwner { get; set; }
    }
}