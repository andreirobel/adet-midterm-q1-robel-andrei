using System;

namespace app.domain
{
    public class Student : BaseEntity
    {
        public string StudentNumber { get; set; }
        public Guid PersonID { get; set; }
        public Person Person { get; set; }
        public string Name { get; set; }
    }
}
