﻿// See https://aka.ms/new-console-template for more information
using Moamen.Training.DataStructures.Stack;

Console.WriteLine("Hello, World!");
var st = new LStack<int>();
st.Push(5);
st.Push(4);
st.Push(3);
st.Push(2);
st.Push(1);

foreach (var item in st)
{
    Console.WriteLine(item);
}
Console.WriteLine(st.Peek());
Console.Read();