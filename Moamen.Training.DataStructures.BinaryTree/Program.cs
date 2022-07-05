// See https://aka.ms/new-console-template for more information
using Moamen.Training.DataStructures.BinaryTree;

Console.WriteLine("Hello, World!");
var bt = new BinaryTree<int>();
bt.Add(5);
bt.Add(4);
bt.Add(6);
var match = bt.Find(5);
Console.ReadLine();