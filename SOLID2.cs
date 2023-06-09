public class Rectangle{
   public double Height {get;set;}
   public double Wight {get;set; }
}

public class Circle{
   public double Radius {get;set;}
}

public class AreaCalculator
{
   public double TotalArea(object[] arrObjects)
   {
      double area = 0;
      Rectangle objRectangle;
      Circle objCircle;
      foreach(var obj in arrObjects)
      {
         if(obj is Rectangle)
         {
            area += obj.Height * obj.Width;
         }
         else
         {
            objCircle = (Circle)obj;
            area += objCircle.Radius * objCircle.Radius * Math.PI;
         }
      }
      return area;
   }
}

public abstract class Shape
{
   public abstract double Area();
}

public class Rectangle: Shape
{
   public double Height {get;set;}
   public double Width {get;set;}
   public override double Area()
   {
      return Height * Width;
   }
}

public class Circle: Shape
{
   public double Radius {get;set;}
   public override double Area()
   {
      return Radius * Radus * Math.PI;
   }
}

public class Triangulo: Shape
{
   public double Base {get;set;}
   public double Height {get;set;}
   public override double Area()
   {
      return Base * Height;
   }
}

public class AreaCalculator
{
   public double TotalArea(Shape[] arrShapes)
   {
      double area=0;
      foreach(var objShape in arrShapes)
      {
         area += objShape.Area();
      }
      return area;
   }
}

