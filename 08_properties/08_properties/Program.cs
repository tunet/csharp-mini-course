var rectangle = new Rectangle(10, 20);
Console.WriteLine($"Width: {rectangle.Width}, height: {rectangle.Height}");

rectangle.Width = -5;
rectangle.Height = 2;
Console.WriteLine($"Width: {rectangle.Width}, height: {rectangle.Height}");

class Rectangle
{
    private int _width;
    private int _height;

    public int Width
    {
        get => _width;
        set
        {
            if (value > 0)
            {
                _width = value;
            }
        }
    }

    public int Height
    {
        get => _height;
        set
        {
            if (value > 0)
            {
                _height = value;
            }
        }
    }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}
















//var rectangle = new Rectangle
//{
//    Width = 10,
//    Height = 20
//};

//Console.WriteLine($"Width: {rectangle.Width}, height: {rectangle.Height}");

//class Rectangle
//{
//    public int Width { get; init; }
//    public int Height { get; init; }
//    public int Area
//    {
//        get => Width * Height;
//    }

//    //public Rectangle()
//    //{
//    //    Area = Width * Height;
//    //}
//}
















//var rectangle = new Rectangle
//{
//    Width = 10,
//    Height = 20
//};

//Console.WriteLine($"Width: {rectangle.Width}, height: {rectangle.Height}");

//class Rectangle
//{
//    public int Width { get; init; }
//    public int Height { get; init; }

//    //    public Rectangle(int width, int height)
//    //    {
//    //        Width = width;
//    //        Height = height;
//    //    }
//}













//var rectangle = new Rectangle(10, 20);
//Console.WriteLine($"Width: {rectangle.Width}, height: {rectangle.Height}");

//rectangle.Width = 73;
//Console.WriteLine($"Width: {rectangle.Width}, height: {rectangle.Height}");

//class Rectangle
//{
//    public int Width { get; private set; }
//    public int Height { get; private set; }

//    public Rectangle(int width, int height)
//    {
//        Width = width;
//        Height = height;
//    }
//}













//var rectangle = new Rectangle();
//Console.WriteLine($"Width: {rectangle.Width}, height: {rectangle.Height}");

//class Rectangle
//{
//    public int Width { get; set; } = 30;
//    public int Height { get; set; }
//}













//var rectangle = new Rectangle(10, 20);
//Console.WriteLine($"Width: {rectangle.Width}, height: {rectangle.Height}");

//rectangle.Width = 73;
//Console.WriteLine($"Width: {rectangle.Width}, height: {rectangle.Height}");

//class Rectangle
//{
//    public int Width { get; set; }
//    public int Height { get; set; }

//    public Rectangle(int width, int height)
//    {
//        Width = width;
//        Height = height;
//    }
//}












//class Rectangle
//{
//    private int _width;
//    private int _height;

//    public Rectangle(int width, int height)
//    {
//        _width = width;
//        _height = height;
//    }

//    public int GetWidth() => _width;
//    public int GetHeight() => _height;

//    public void SetWidth(int width)
//    {
//        if (width > 0)
//        {
//            _width = width;
//        }
//    }

//    public void SetHeight(int height)
//    {
//        if (height > 0)
//        {
//            _height = height;
//        }
//    }
//}
