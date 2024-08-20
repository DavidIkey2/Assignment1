using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject mySubject = new Subject();    // create a new subject using no-arg
            Console.WriteLine("\n");
            Console.WriteLine(mySubject);
            // test Property Accessor Methods 
            Console.WriteLine("\n");
            mySubject.SubjectSubjectCode = "BSBXTW401";
            mySubject.SubjectSubjectName = "Lead and Facilitate";
            mySubject.SubjectCost = 150.00;
            Console.WriteLine("mySubject Code: " + mySubject.SubjectSubjectCode);
            Console.WriteLine("mySubject Name: " + mySubject.SubjectSubjectName);
            Console.WriteLine("mySubject Cost: " + mySubject.SubjectCost);
            Console.WriteLine("\n");
            Subject mySubject2 = new Subject("BSBXCS402", "Promote cyber security", 150.00);    // create a new subject using all-arg
            Console.WriteLine(mySubject2);
            Console.ReadKey();

            Enrollment myEnrollment = new Enrollment();    // create a new enrollment using no-arg
            Console.WriteLine("\n");
            Console.WriteLine(myEnrollment);
            // test Property Accessor Methods 
            Console.WriteLine("\n");
            myEnrollment.EnrollmentDateEnrolled = new DateTime(2024, 5, 30);
            myEnrollment.EnrollmentGrade = "CS";
            myEnrollment.EnrollmentSemester = 1;
            Console.WriteLine("\n");
            Console.WriteLine("myEnrollment Date Enrolled: " + myEnrollment.EnrollmentDateEnrolled);
            Console.WriteLine("myEnrollment Grade: " + myEnrollment.EnrollmentGrade);
            Console.WriteLine("myEnrollment Semester: " + myEnrollment.EnrollmentSemester);
            Enrollment myEnrollment2 = new Enrollment(new DateTime(2024,5,30), "PA", 2);    // create a new enrollment using all-arg
            Console.WriteLine("\n");
            Console.WriteLine(myEnrollment2);
            Subject mySubject3 = new Subject("BSBXCS402", "Promote cyber security", 150.00);
            Enrollment myEnrollment3 = new Enrollment(new DateTime(2024, 5, 13), "CS", 1, mySubject3);    // create a new enrollment using all-arg
            Console.WriteLine("\n");
            Console.WriteLine(myEnrollment3);
            Console.ReadKey();

            Student myStudent = new Student();    // create a new enrollment using no-arg
            Console.WriteLine("\n");
            Console.WriteLine(myStudent);
            // test Property Accessor Methods 
            myStudent.StudentStudentID = "00055566";
            myStudent.StudentProgram = "Programming";
            myStudent.StudentDateRegistered = new DateTime(2024, 5, 30);
            Console.WriteLine("\n");
            Console.WriteLine("myStudent Student ID: " + myStudent.StudentStudentID);
            Console.WriteLine("mymyStudent Program: " + myStudent.StudentProgram);
            Console.WriteLine("myStudent Date Registered: " + myStudent.StudentDateRegistered);
            Console.WriteLine("\n");
            Student myStudent2 = new Student("111222333", "Business", new DateTime(2024, 5, 30));    // create a new enrollment using all-arg
            Console.WriteLine(myStudent2);
            Enrollment myEnrollment4 = new Enrollment(new DateTime(2024, 5, 13), "CS", 1, mySubject3);    // create a new enrollment using all-arg
            Console.WriteLine("\n");
            Student myStudent3 = new Student("222333444", "Web Business", new DateTime(2024, 5, 13), myEnrollment4);    // create a new enrollment using all-arg
            Console.WriteLine(myStudent3);
            Console.ReadKey();

            Person myPerson = new Person();    // create a new person using no-arg
            Console.WriteLine("\n");
            Console.WriteLine(myPerson);
            // test Property Accessor Methods 
            Console.WriteLine("\n");
            myPerson.PersonName = "David Ikey";
            myPerson.PersonEmail = "grigand@hotmail.com";
            myPerson.PersonPhoneNumber = "0404-548-638";
            Console.WriteLine("myPerson name: " + myPerson.PersonName);
            Console.WriteLine("myPerson email: " + myPerson.PersonEmail);
            Console.WriteLine("myPerson phone number: " + myPerson.PersonPhoneNumber);
            Console.WriteLine("\n");
            Person myPerson2 = new Person("John Smith", "john@hotmail.com", "0414-123-456");    // create a new person using all-arg
            Console.WriteLine(myPerson2);            
            Console.ReadKey();

        }
    }
}
