using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

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
            Console.WriteLine("Subject Code: " + mySubject.SubjectSubjectCode);
            Console.WriteLine("Subject Name: " + mySubject.SubjectSubjectName);
            Console.WriteLine("Cost: " + mySubject.SubjectCost);
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
            Console.WriteLine("Date Enrolled: " + myEnrollment.EnrollmentDateEnrolled);
            Console.WriteLine("Grade: " + myEnrollment.EnrollmentGrade);
            Console.WriteLine("Semester: " + myEnrollment.EnrollmentSemester);
            Enrollment myEnrollment2 = new Enrollment(new DateTime(2024,5,30), "PA", 2);    // create a new enrollment using all-arg
            Console.WriteLine("\n");
            Console.WriteLine(myEnrollment2);
            Subject mySubject3 = new Subject("BSBXCS402", "Promote cyber security", 150.00);
            Enrollment myEnrollment3 = new Enrollment(new DateTime(2024, 5, 13), "CS", 1, mySubject3);    // create a new enrollment using all-arg
            Console.WriteLine("\n");
            Console.WriteLine(myEnrollment3);
            Console.ReadKey();

            Address myAddress = new Address();    // create a new using no-arg
            Console.WriteLine("\n");
            Console.WriteLine(myAddress);
            // test Property Accessor Methods 
            myAddress.AddressStreetNum = "1313";
            myAddress.AddressStreetName = "Mocking Bird Lane";
            myAddress.AddressSuburb = "Grimsby";
            myAddress.AddressPostcode = "1313";
            myAddress.AddressState = "Virginia";
            Console.WriteLine("\n");
            Console.WriteLine("Street Num: " + myAddress.AddressStreetNum);
            Console.WriteLine("Street Name: " + myAddress.AddressStreetName);
            Console.WriteLine("Suburb: " + myAddress.AddressSuburb);
            Console.WriteLine("Postcode: " + myAddress.AddressPostcode);
            Console.WriteLine("State: " + myAddress.AddressState);
            Console.WriteLine("\n");
            Address myAddress2 = new Address("347", "Military Road", "Henley Beach", "5022", "South Australia");    // create a new using all-arg
            Console.WriteLine(myAddress2);
            Console.ReadKey();

            Person myPerson = new Person();    // create a new person using no-arg
            Console.WriteLine("\n");
            Console.WriteLine(myPerson);
            // test Property Accessor Methods 
            Console.WriteLine("\n");
            myPerson.PersonName = "David Ikey";
            myPerson.PersonEmail = "grigand@hotmail.com";
            myPerson.PersonPhoneNumber = "0404-548-638";
            Console.WriteLine("Name: " + myPerson.PersonName);
            Console.WriteLine("Email: " + myPerson.PersonEmail);
            Console.WriteLine("Phone Number: " + myPerson.PersonPhoneNumber);
            Console.WriteLine("\n");
            Person myPerson2 = new Person("John Smith", "john@hotmail.com", "0414-123-456");    // create a new person using all-arg
            Console.WriteLine(myPerson2);
            Address myAddress3 = new Address("14", "East Street", "Henley Beach", "5022", "South Australia");
            Person myPerson3 = new Person("Nick Crouch", "nick@hotmail.com", "0414-120-140", myAddress3);            
            Console.WriteLine("\n");
            Console.WriteLine(myPerson3);
            Console.ReadKey();

            Student myStudent = new Student();    // create a new using no-arg
            Console.WriteLine("\n");
            Console.WriteLine(myStudent);
            // test Property Accessor Methods 
            myStudent.StudentStudentID = "00055566";
            myStudent.StudentProgram = "Programming";
            myStudent.StudentDateRegistered = new DateTime(2024, 5, 30);
            Console.WriteLine("\n");
            Console.WriteLine("Student ID: " + myStudent.StudentStudentID);
            Console.WriteLine("Program: " + myStudent.StudentProgram);
            Console.WriteLine("Date Registered: " + myStudent.StudentDateRegistered);
            Console.WriteLine("\n");
            Student myStudent2 = new Student("111222333", "Business", new DateTime(2024, 5, 30));    // create a new using all-arg
            Console.WriteLine(myStudent2);
            Console.WriteLine("\n");
            Enrollment myEnrollment4 = new Enrollment(new DateTime(2024, 5, 13), "CS", 1, mySubject3);    // create a new using all-arg            
            Address myAddress4 = new Address("14", "East Street", "Henley Beach", "5022", "South Australia");
            Student myStudent3 = new Student("222333444", "Web Business", new DateTime(2024, 5, 13), "Nick Crouch", "nick@hotmail.com", "0414-120-140", myEnrollment4, myAddress4);    // create a new using all-arg                       
            Console.WriteLine(myStudent3);
            Console.ReadKey();

            Student student1 = new Student();
            student1.StudentStudentID = "000222333";
            Student student2 = new Student();
            student2.StudentStudentID = "999777545";            
            Console.WriteLine("\n");
            Console.WriteLine("Comparing object strings using == operator: " + (student1 == student2));
            Console.WriteLine("Comparing object strings using != operator: " + (student1 != student2));
            Console.ReadKey();
            Console.WriteLine("\n");
            Console.WriteLine(student1.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(student2.ToString());
            Console.ReadKey();
            Console.WriteLine("\n");
            Console.WriteLine("Student 1 hashcode: " + student1.GetHashCode());
            Console.WriteLine("Student 2 hashcode: " + student2.GetHashCode());
            Console.ReadKey();
        }
    }
}
