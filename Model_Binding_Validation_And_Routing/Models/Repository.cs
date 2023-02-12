using System.Collections.Generic;

namespace Model_Binding_Validation_And_Routing.Models
{
    public static class Repository
    {
        //lưu data list student
        private static List<Student> _student = new List<Student>();
        //lấy data của list student
        public static List<Student> GetStudent()
        {
            return _student;
        }
        //thêm data cho list student
        public static void SetStudent(Student student)
        {
            _student.Add(student);
        }
    }
}
