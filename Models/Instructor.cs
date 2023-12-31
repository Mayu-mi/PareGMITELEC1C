﻿namespace PareITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorLastName{ get; set; }
        public Boolean IsTenured { get; set; }

        public DateTime DateHired{ get; set; }
        public Rank InstructorRank { get; set; }
    }
}