namespace Task1;

class Student : Person

{

  const int  _numCourses=0;
  List<string> _couses = new List<string>();
  List<int> _grade = new List<int>();


    public Student(string name, string address) : base(name, address)
    {


    }
        
    public void AddCourseGrade(string course,int grade)
    {

        _couses.Add(course);
        _grade.Add(grade);
    }


    public override string ToString()
    {
        return base.ToString();
    }

    
  

    public double GetGradeAvarege()
    {

      return _grade.Average();     
          
    }

    public void PrintGrade()
    {

            foreach (var item in _grade)
            {
                System.Console.WriteLine(item);
                
            }

    }
 

}



