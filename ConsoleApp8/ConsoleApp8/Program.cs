using ConsoleApp8;

Class1<int> numb = new();
numb.Clear();
numb.Add(1);
numb.Add(2);
numb.Add(3);
List<int> list1 = new List<int>();
list1.Add(4);
list1.Add(2);
list1.Add(5);
list1.Add(6);
list1.Add(2);
numb.CustomAddRange(list1);
//Console.WriteLine(numb.CustomContains(2));
//numb.FirstIndexOf(2);
numb.Remove(2);
numb.ShowAll();