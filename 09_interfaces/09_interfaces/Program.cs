var shape = new Rectangle { Width = 10, Height = 20 };

DisplayInfo(shape);

void DisplayInfo(IRectangle rectangle)
{
    rectangle.ShowInfo("some information");
}

class Rectangle : IRectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int Area => Width * Height;
}

interface IRectangle
{
    int Width { get; }
    int Height { get; }
    int Area { get; }
}

static class ShapeHelper
{
    public static void ShowInfo(this IRectangle rectangle, string text)
    {
        Console.WriteLine($"Width: {rectangle.Width}, height: {rectangle.Height}, area: {rectangle.Area}");
        Console.WriteLine(text);
    }
}







//var shape = new Rectangle { Width = 10, Height = 20 };

//DisplayInfo(shape);

//void DisplayInfo(Rectangle rectangle)
//{
//    rectangle.ShowInfo();
//}

//class Rectangle : IRectangle
//{
//    public int Width { get; set; }
//    public int Height { get; set; }
//    public int Area => Width * Height;
//}

//interface IRectangle
//{
//    int Width { get; }
//    int Height { get; }
//    int Area { get; }
//}

//static class ShapeHelper
//{
//    public static void ShowInfo(this Rectangle rectangle)
//    {
//        Console.WriteLine($"Width: {rectangle.Width}, height: {rectangle.Height}, area: {rectangle.Area}");
//    }
//}








//var shape = new Rectangle { Width = 10, Height = 20 };

//DisplayInfo(shape);

//void DisplayInfo(Rectangle rectangle)
//{
//    ShapeHelper.ShowInfo(rectangle);
//}

//class Rectangle : IRectangle
//{
//    public int Width { get; set; }
//    public int Height { get; set; }
//    public int Area => Width * Height;
//}

//class ShapeHelper
//{
//    public static void ShowInfo(Rectangle rectangle)
//    {
//        Console.WriteLine($"Width: {rectangle.Width}, height: {rectangle.Height}, area: {rectangle.Area}");
//    }
//}

//interface IRectangle
//{
//    int Width { get; }
//    int Height { get; }
//    int Area { get; }
//}














//var reactangle = new Rectangle { Width = 5, Height = 10 };

//DisplaySidesInfo(reactangle);
//DisplayAreaInfo(reactangle);

//void DisplaySidesInfo(IRectangle rectangle)
//{
//    Console.WriteLine($"Width is: {rectangle.Width}");
//    Console.WriteLine($"Height is: {rectangle.Height}");
//}

//void DisplayAreaInfo(IArea shape)
//{
//    Console.WriteLine($"Area is: {shape.GetArea()}");
//}

//class Rectangle : IRectangle, IArea
//{
//    public int Width { get; set; }
//    public int Height { get; set; }
//    public int GetArea() => Width * Height;
//}

//interface IRectangle
//{
//    int Width { get; }
//    int Height { get; }
//}

//interface IArea
//{
//    int GetArea();
//}












//var reactangle = new Rectangle { Width = 5, Height = 10 };

//DisplayInfo(reactangle);

//void DisplayInfo(IRectangle rectangle)
//{
//    Console.WriteLine($"Width is: {rectangle.Width}");
//    Console.WriteLine($"Height is: {rectangle.Height}");
//    Console.WriteLine($"Area is: {rectangle.GetArea()}");
//}

//class Rectangle : IRectangle
//{
//    public int Width { get; set; }
//    public int Height { get; set; }
//    public int GetArea() => Width * Height;
//}

//interface IRectangle
//{
//    int Width { get; }
//    int Height { get; }
//    int GetArea();
//}









//var reactangle = new Rectangle { Width = 5, Height = 10 };

//DisplayInfo(reactangle);

//void DisplayInfo(Rectangle rectangle)
//{
//    Console.WriteLine($"Width is: {rectangle.Width}");
//    Console.WriteLine($"Height is: {rectangle.Height}");
//    Console.WriteLine($"Area is: {rectangle.GetArea()}");
//}

//class Rectangle
//{
//    public int Width { get; set; }
//    public int Height { get; set; }
//    public int GetArea() => Width * Height;
//}
