using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;



namespace QLHS
{
    public class Student
    {
        // Thuộc tính
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; } // Giới tính
        public double GPA { get; set; } // Điểm trung bình

        // Phương thức khởi tạo (constructor)
        public Student(int id, string name, int age, string gender, double gpa)
        {
            ID = id;
            Name = name;
            Age = age;
            Gender = gender;
            GPA = gpa;
        }

        // Phương thức để in thông tin học sinh
        public void PrintInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}, Gender: {Gender}, GPA: {GPA}");
        }

        // Phương thức để kiểm tra học sinh có đủ tuổi hay không
        public bool IsEligible(int minAge, int maxAge)
        {
            return Age >= minAge && Age <= maxAge;
        }

        // Phương thức để kiểm tra học sinh có tên bắt đầu bằng chữ cái cụ thể hay không
        public bool NameStartsWith(string letter)
        {
            return Name.StartsWith(letter, StringComparison.OrdinalIgnoreCase);
        }
    }
}