// See https://aka.ms/new-console-template for more information
using SingletonBreak;

SingletonClone singleton = SingletonClone.Instance;
SingletonClone clone = (SingletonClone)singleton.Clone();

Console.WriteLine(singleton.GetHashCode());
Console.WriteLine(clone.GetHashCode()); 

Console.ReadLine();
