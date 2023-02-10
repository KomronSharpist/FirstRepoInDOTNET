using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningJSON.StudentsFile;

namespace LearningJSON
{
    public class Student : User, IStudent
    {
        public int grade { get; set; }
    }
}
