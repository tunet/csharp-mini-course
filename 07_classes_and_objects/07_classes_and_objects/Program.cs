var rect = new Rectangle(10, 20);

//rect.SetSize(100);
//Console.WriteLine($"Width is {rect.GetWidth()}, height is {rect.GetHeight()}");

//rect.SetSize(100, 17);
//Console.WriteLine($"Width is {rect.GetWidth()}, height is {rect.GetHeight()}");

class Square
{
    protected int _width;

    public Square(int width)
    {
        _width = width;
    }

    public int GetWidth() => _width;

    public void SetWdith(int width)
    {
        if (width > 0)
        {
            _width = width;
        }
    }
}

class Rectangle : Square
{
    private int _height;

    //public Rectangle(int width)
    //{
    //    _width = width;
    //    _height = 25;
    //}

    public Rectangle(int width, int height) : base(width)
    {
        _height = height;
    }

    public int GetHeight() => _height;

    public void SetHeight(int height)
    {
        if (height > 0)
        {
            _height = height;
        }
    }

    public void SetSize(int width)
    {
        SetWdith(width);
    }

    public void SetSize(int width, int height)
    {
        SetWdith(width);
        SetHeight(height);
    }
}
