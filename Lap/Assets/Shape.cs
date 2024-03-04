using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape 
{
    public abstract float CalculateArea();
}

public class Rectagle : Shape
{
    public float Width;
    public float Height;
    
    public override float CalculateArea()
    {
        return Width * Height;
    }
}

public class Circle1 : Shape
{
    public float radius;
    
    public override float CalculateArea()
    {
        return Mathf.PI * radius * radius;
    }
}
