using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningJSON.StudentsFile;

namespace LearningJSON
{
    public class workers : User, Iworkers
    {
        public string workLocation { get; set; }
    }
}
