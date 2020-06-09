using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IStudent
    {
        public struct CentralizeTesting
        {
            public ushort language, mathematic, physics, sertificate;
        }
        public string Specialty { get; set; }
        public string Curator { get; set; }
        public string Allocation { get; set; }
        public bool IsWinnerOlympiad { get; set; }
        public float AverageRating { get; set; }
        public bool IsSetteled { get; set; }
        public bool IsBuget { get; set; }
        public ushort YearOfEntering { get; set; }
        public ushort Grade { get; set; }
        public string GroupNumber { get; set; }
        public string StudentNumber { get; set; }
        public string Status { get; set; }
        public (ushort, ushort, ushort, ushort) Testing { get; set; }

        void CheckStudentData();
        void AddSession();
        void SetExpelled();
        void GetExpelled();
        public void SetReturn();
        public void GetReturn();
    }
}
