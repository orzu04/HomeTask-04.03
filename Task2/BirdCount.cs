namespace Task2;

public class BirdCount
{

  List<int> _birdCount= new List<int>();

  public void AddBirdCount(List<int> birdCount)
  {
   
   _birdCount = birdCount;

     
  }

  public void TakeLast( )
  {
        var tac= _birdCount.TakeLast(7);
       
       foreach (var item in tac)
       {
        
      System.Console.WriteLine(item);

       }
  }


public void BirdParday()
{

var bp = _birdCount.TakeLast(1);
foreach (var item in bp)
{
   System.Console.WriteLine(item); 
}
      
}

public int BirdCountIncrement()
{
    return _birdCount[_birdCount.Count-1]+1;
    
}



}
