using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<StudentInfo> studentList = new List<StudentInfo>();

        StudentInfo student1 = new StudentInfo();
        student1.StudentId = 1;
        student1.Name = "Kelsey";
        student1.MarksList.Add(new Mark { Subject = "Social Studies", Score = 90 });
        student1.MarksList.Add(new Mark { Subject = "Science", Score = 85 });
        student1.MarksList.Add(new Mark { Subject = "Math", Score = 92 });
        student1.MarksList.Add(new Mark { Subject = "Phys Ed", Score = 88 });
        student1.MarksList.Add(new Mark { Subject = "Religion", Score = 95 });
        student1.FirstTermScore = 80.5f;
        student1.SecondTermScore = 85.5f;
        student1.ThirdTermScore = 90.0f;
        studentList.Add(student1);

        foreach (StudentInfo student in studentList) {
            Console.WriteLine("Student ID: {0}", student.StudentId);
            Console.WriteLine("Name: {0}", student.Name);
            Console.WriteLine("First Term Score: {0}", student.FirstTermScore);
            Console.WriteLine("Second Term Score: {0}", student.SecondTermScore);
            Console.WriteLine("Third Term Score: {0}", student.ThirdTermScore);
            Console.WriteLine("Marks:");
            foreach (Mark mark in student.MarksList) {
                Console.WriteLine("{0}: {1}", mark.Subject, mark.Score);
            }
            Console.WriteLine();
        }
    }
    
    public class StudentInfo {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Mark> MarksList { get; set; } = new List<Mark>();
        public float FirstTermScore { get; set; }
        public float SecondTermScore { get; set; }
        public float ThirdTermScore { get; set; }
        public float FinalScore { get; set; }
        public char PassingGrade { get; set; }
    }

    public class Mark {
        public string Subject { get; set; }
        public float Score { get; set; }
    }
}