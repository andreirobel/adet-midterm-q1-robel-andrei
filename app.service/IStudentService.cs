using app.domain;
using app.service.Students.Commands.CreateStudent;
using app.service.Students.Query.GetStudentByNumber;
using System;

namespace app.service
{
    public interface IStudentService
    {
        CreateStudentResult CreateStudent(Student student);
        
        GetStudentByNumberResult GetStudentByNumber(GetStudentByNumberQuery studentNumber);
    }
}
