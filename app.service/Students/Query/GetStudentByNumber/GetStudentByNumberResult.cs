using System;

namespace app.service.Students.Query.GetStudentByNumber
{
    public class GetStudentByNumberResult
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string StudentNumber { get; set; }
    }
}
