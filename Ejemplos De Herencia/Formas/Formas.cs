public class Shape{
    public virtual double width {get; set;}
    public virtual double height {get; set;}

    public Shape(double width, double height){
        this.width = width;
        this.height = height;
    }

    public virtual double Area(){
        return width * height;
    }
}

public class Circle : Shape {

    public Circle(double radius) : base(radius, radius){

    }

    public override double Area()
    {
        return Math.PI * Math.Pow(width, 2);
    }
}

public class Rectangle : Shape
{
    public Rectangle(double width, double height) : base(width, height)
    {

    }

    public override double Area()
    {
        return base.Area();
    }
}

public class Square : Shape
{
    public Square(double lengths) : base(lengths, lengths)
    {

    }

    public override double Area()
    {
        return base.Area();
    }
}