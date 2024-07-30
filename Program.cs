using System;
using System.Collections.Generic;
using System.Linq;

namespace QLHS
{
    class Program
    {
        static void Main()
        {
            // Tạo danh sách học sinh
            List<Student> students = new List<Student>
            {
                new Student(1, "Nguyen Van A", 17, "Male", 8.5),
                new Student(2, "Nguyen Van B", 16, "Female", 7.2),
                new Student(3, "Nguyen Van C", 19, "Male", 6.8),
                new Student(4, "Nguyen Van D", 18, "Female", 9.0),
                new Student(5, "Nguyen Van Em", 20, "Male", 5.6)
            };

            // 1. In ra toàn bộ danh sách học sinh
            Console.WriteLine("Danh sách toàn bộ học sinh:");
            foreach (var student in students)
            {
                student.PrintInfo();
            }

            // 2. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            Console.WriteLine("\nDanh sách học sinh có tuổi từ 15 đến 18:");
            var studentsAge15To18 = students.Where(s => s.IsEligible(15, 18));
            foreach (var student in studentsAge15To18)
            {
                student.PrintInfo();
            }

            // 3. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            Console.WriteLine("\nDanh sách học sinh có tên bắt đầu bằng chữ 'A':");
            var studentsWithNameStartingWithA = students.Where(s => s.NameStartsWith("A"));
            foreach (var student in studentsWithNameStartingWithA)
            {
                student.PrintInfo();
            }

            // 4. Tính tổng tuổi của tất cả học sinh trong danh sách
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {totalAge}");

            // 5. Tính tổng điểm trung bình của tất cả học sinh
            double totalGPA = students.Sum(s => s.GPA);
            Console.WriteLine($"\nTổng điểm trung bình của tất cả học sinh: {totalGPA}");

            Console.ReadLine();
        }
    }
}
