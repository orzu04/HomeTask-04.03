



using Task2;

var birdCount = new BirdCount();
List<int> birdCount1 = new List<int>(){1,23,34,22,33,43,56,55,1};
birdCount.AddBirdCount(birdCount1);


birdCount.TakeLast();
System.Console.WriteLine($"_______________________");
birdCount.BirdParday();
System.Console.WriteLine(birdCount.BirdCountIncrement());
