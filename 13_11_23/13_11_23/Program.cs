using _13_11_23.Models;

namespace _13_11_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentService = new StudentService();

            var newStudent = new Student
            {
                Name = "Ryan",
                Surname = "Gosling",
                AvgPoint = 86.9
            };
            var newStudent2 = new Student
            {
                Name = "Patrick",
                Surname = "Star",
                AvgPoint = 60.5
            };
            var newStudent3 = new Student
            {
                Name = "Spanch",
                Surname = "Bob",
                AvgPoint = 71.6
            };
            var newStudent4 = new Student
            {
                Name = "Rick",
                Surname = "Sanchez",
                AvgPoint = 100
            };
            studentService.Create(newStudent);
            studentService.Create(newStudent2); 
            studentService.Create(newStudent3);
            studentService.Create(newStudent4);

            var allStudents = studentService.GetAll();
            Console.WriteLine("All Students:");
            foreach (var student in allStudents)
            {
                Console.WriteLine($"{student.Id}: {student.Name} {student.Surname} - Avg Point: {student.AvgPoint}");
            }

            int studentIdToDelete = 1; 
            studentService.Delete(studentIdToDelete);

            var deletedStudent = studentService.GetById(studentIdToDelete);
            if (deletedStudent == null)
            {
                Console.WriteLine($"Student with ID {studentIdToDelete} successfully deleted.");
            }
            else
            {
                Console.WriteLine($"Student with ID {studentIdToDelete} still exists.");
            }
        }
    }
}