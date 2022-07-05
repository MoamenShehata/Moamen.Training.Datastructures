// See https://aka.ms/new-console-template for more information
using Moamen.Training.DataStructures.BinaryTree;

Console.WriteLine("Hello, World!");
var bt = new BinaryTree<int>();
bt.Add(4);
bt.Add(2);
bt.Add(6);
bt.Add(1);
bt.Add(3);
bt.Add(7);
bt.Add(5);

Console.WriteLine("Pre Order");
foreach (var item in bt.PreOrder())
    Console.WriteLine(item);
Console.WriteLine("///////////////////////");

Console.WriteLine("In Order");
foreach (var item in bt.InOrder())
    Console.WriteLine(item);
Console.WriteLine("///////////////////////");

Console.WriteLine("Post Order");
foreach (var item in bt.PostOrder())
    Console.WriteLine(item);
Console.WriteLine("///////////////////////");

Console.ReadLine();