using NUnit.Framework;
using System;

namespace Task1;

[TestFixture]
public class SphereTests
{
    [TestCase(2.5, 78.53981634, 65.44984695)]
    [TestCase(0, 0, 0)]
    [TestCase(1, 4 * Math.PI, (4.0 / 3.0) * Math.PI)]
    [TestCase(-1, 4 * Math.PI, -(4.0 / 3.0) * Math.PI)]
    public void TestSphere(double radius, double area, double volume)
    {
        var sphere = new Sphere(radius);

        Assert.That(sphere.CalculateArea(), Is.EqualTo(area).Within(0.001));
        Assert.That(sphere.CalculateVolume(), Is.EqualTo(volume).Within(0.001));
    }
}

[TestFixture]
public class CylinderTests
{
    [TestCase(2.5, 5, 117.80972, 98.17477)]
    [TestCase(0, 3, 0, 0)]
    [TestCase(2, 0, 25.132741229, 0)]
    [TestCase(0, 0, 0, 0)]
    [TestCase(1, 1, 4 * Math.PI, Math.PI)]
    [TestCase(-1, -1, 4 * Math.PI, -Math.PI)]
    public void TestCylinder(double radius, double height, double area, double volume)
    {
        var cylinder = new Cylinder(radius, height);

        Assert.That(cylinder.CalculateArea(), Is.EqualTo(area).Within(0.001));
        Assert.That(cylinder.CalculateVolume(), Is.EqualTo(volume).Within(0.001));
    }
}

[TestFixture]
public class RectangleTests
{
    [TestCase(6, 2, 12)]
    [TestCase(0, 3, 0)]
    [TestCase(2, 0, 0)]
    [TestCase(-4, 5, -20)]
    public void TestRectangle(double length, double width, double area, double volume = 0)
    {
        var rectangle = new Rectangle(length, width);

        Assert.That(rectangle.CalculateArea(), Is.EqualTo(area).Within(0.001));
        Assert.That(rectangle.CalculateVolume(), Is.EqualTo(volume).Within(0.001));
    }
}

[TestFixture]
public class CubeTests
{
    [TestCase(4, 96, 64)]
    [TestCase(0, 0, 0)]
    [TestCase(1, 6, 1)]
    [TestCase(2.5, 37.5, 15.625)]
    [TestCase(-4, 96, -64)]
    public void TestCube(double side, double area, double volume)
    {
        var cube = new Cube(side);

        Assert.That(cube.CalculateArea(), Is.EqualTo(area).Within(0.001));
        Assert.That(cube.CalculateVolume(), Is.EqualTo(volume).Within(0.001));
    }
}