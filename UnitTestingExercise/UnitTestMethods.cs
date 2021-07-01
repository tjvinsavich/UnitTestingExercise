﻿using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Right-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int x, int y)
        {
            return x - y;
        }

        // Create a Multiply method that passes 2 integers
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        // Create a Divide method that passes 2 integers
        public int Divide(int x, int y)
        {
            return x / y;
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string Laugh()
        {
            return "Ha ha!";
        }

        public string Yell()
        {
            return "Hey!";
        }

    }
}
