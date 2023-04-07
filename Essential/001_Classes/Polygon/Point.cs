namespace Polygon;

internal class Point
{
    private int x;
    private int y;
    private string title;

    public Point(int x, int y, string title)
    {
        this.x = x;
        this.y = y;
        this.title = title;
    }

    public int X { get { return x; } }

    public int Y { get { return y; } }

    public string Title { get { return title; } }
}
