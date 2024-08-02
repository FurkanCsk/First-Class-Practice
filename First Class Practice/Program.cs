using First_Class_Practice;

Person student = new Person();       // Add person to class
student.Name = "Furkan";
student.Surname = "Coşkun";
student.Role = "Öğrenci";
student.Birthday = new DateTime(1999,02,24);

Person student2 = new Person();
student2.Name = "Canberk";
student2.Surname = "Doğan";
student2.Role = "Öğrenci";
student2.Birthday = new DateTime(1999,05,05);

Person teacher = new Person();
teacher.Name = "Necmettin";
teacher.Surname = "Yılmaz";
teacher.Role = "Öğretmen";
teacher.Birthday = new DateTime(1993,12,14);

student.Print();     // Print saved persons
student2.Print();
teacher.Print();