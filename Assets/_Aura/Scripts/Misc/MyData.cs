using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyData 
{
    private double D1;
    private double D2;
    private double D3;

    public MyData(double d1, double d2,double d3)
    {
        D1 = d1;
        D2 = d2;
        D3 = d3;
    }

    public double Sum()
    {
        return D1 + D2 + D3;
    }
}

//one solution, on our way to an extension method
static class ExtendMyData
{
    public static double Average(this MyData md)
    {
        return md.Sum() / 3;
    }
}
