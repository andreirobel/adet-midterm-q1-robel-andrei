using app.domain;
using app.repository;
using app.service.Students.Commands.CreateStudent;
using app.service.Students.Query.GetStudentByNumber;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace app.service.Students
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> studentRepo;
        public StudentService(IRepository<Student> studentRepo)
        {
            this.studentRepo = studentRepo;
        }
        public CreateStudentResult CreateStudent(Student student)
        {
            var entity = new Student
            {
                Person = new Person
                {
                    Name = student.Name
                },
                StudentNumber = student.StudentNumber
            };

            studentRepo.Create(entity);
            studentRepo.SaveChanges();

            return new CreateStudentResult
            {
                ID = entity.ID
            };
        }

        public GetStudentByNumberResult GetStudentByNumber(GetStudentByNumberQuery query)
        {
            var student = studentRepo.GetAll()
                    .Include(x => x.Person)
                    .FirstOrDefault(x => x.StudentNumber == query.StudentNumber);
            
            if (student == null) return null;

            return new GetStudentByNumberResult
            {
                ID = student.ID,
                StudentNumber = student.StudentNumber,
                Name = student.Person.Name
            };
        }
    }
}
