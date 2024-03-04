





using Task1;

var srd = new Student("djkeg","qdwehw");

srd.AddCourseGrade("C#",1);
srd.AddCourseGrade("c",2);
srd.AddCourseGrade("c++",3);
System.Console.WriteLine($"__________________");
srd.PrintGrade();
System.Console.WriteLine($"____________________");
System.Console.WriteLine(srd.GetGradeAvarege());
System.Console.WriteLine(srd.ToString());


var teach = new Teacher("hf.d","ewgy");
System.Console.WriteLine(teach.AddCourse("Js"));
System.Console.WriteLine(teach.ToString());
System.Console.WriteLine(teach.RemoveCourse("C#"));