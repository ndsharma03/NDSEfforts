using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
// Declare the English units interface:
interface IEnglishDimensions
{
    float Length();
    float Width();
}

// Declare the metric units interface:
interface IMetricDimensions
{
    float Length();
    float Width();
}

// Declare the Box class that implements the two interfaces:
// IEnglishDimensions and IMetricDimensions:
class Box : IEnglishDimensions, IMetricDimensions
{
    float lengthInches;
    float widthInches;

    public Box(float length, float width)
    {
        lengthInches = length;
        widthInches = width;
    }

    public float Length()
    {
        return 9.0f;
    }

   public float Width()
    {
        return 9.0f;
    }

    // Explicitly implement the members of IEnglishDimensions:
    // float IEnglishDimensions.Length()
    //{
    //    return lengthInches;
    //}

    // float IEnglishDimensions.Width()
    //{
    //    return widthInches;
    //}
   public void getlenth()
   {
       
   }
    // Explicitly implement the members of IMetricDimensions:
    // float IMetricDimensions.Length()
    //{
    //    return lengthInches * 2.54f;
    //}

    //float IMetricDimensions.Width()
    //{
    //    return widthInches * 2.54f;
    //}

   
}

class deriver
{
    //public static void Main()
    //{
    //    // Declare a class instance box1:
    //    Box box1 = new Box(30.0f, 20.0f);
    //    box1.Length();
    //    box1.Width();
    //    // Declare an instance of the English units interface:
    //    IEnglishDimensions eDimensions = (IEnglishDimensions)box1;

    //    // Declare an instance of the metric units interface:
    //    IMetricDimensions mDimensions = (IMetricDimensions)box1;

    //    // Print dimensions in English units:
    //    System.Console.WriteLine("box Length(in): {0}",  box1.Length());
    //    System.Console.WriteLine("box Width (in): {0}", box1.Width());

    //    // Print dimensions in English units:
    //    System.Console.WriteLine("Length(in): {0}", eDimensions.Length());
    //    System.Console.WriteLine("Width (in): {0}", eDimensions.Width());

    //    // Print dimensions in metric units:
    //    System.Console.WriteLine("Length(cm): {0}", mDimensions.Length());
    //    System.Console.WriteLine("Width (cm): {0}", mDimensions.Width());
    //    box1.getlenth();
        
    //    System.Console.ReadKey();
    //}
}
}

