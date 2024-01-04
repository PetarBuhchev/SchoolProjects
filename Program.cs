using PointProject;
using ProjectLine;

Point p = new Point(10, 30);
PointProject.Center c = new PointProject.Center(0, 0);

Line line = new Line(p, c);
Console.WriteLine(line.a.x);

