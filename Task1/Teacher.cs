namespace Task1;

class Teacher : Person
{
       const int  _numCourses=0;
  List<string> _couses = new List<string>(); 


    public Teacher(string name, string address) : base(name, address)
    {
    }
     public Boolean AddCourse(string course)
    {


      _couses.Add(course);
      if(_couses!=null)
      {
        return true;
      }

    return false;        
    }


public Boolean RemoveCourse(string course)
{

   _couses.Remove(course);

 if(_couses!=null)
      {
        return true;
      }

   return false;

}
    public override string ToString()
    {
        return base.ToString();
    }


}
