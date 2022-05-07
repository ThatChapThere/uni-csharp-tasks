namespace Week_1_Challenge_1Library;

public class Point
{
    public Point(int xPos, int yPos){
        X = xPos;
        Y = yPos;
    }
    public static double Distance(Point point1, Point point2){
        int rise = Rise(point1, point2);
        int run = Run(point1, point2);

        return Math.Sqrt(rise * rise + run* run);
    }
    public static double Slope(Point point1, Point point2) => Rise(point1, point2) / Run(point1, point2);
    public static int Rise(Point point1, Point point2) => point2.Y - point1.Y;
    public static int Run(Point point1, Point point2) => point2.X - point1.X;
    public int X, Y;
}