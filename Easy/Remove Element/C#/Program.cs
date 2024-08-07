using Remove_Element;

Solution task = new();

//* CASE 1
int[] nums = [2,2,2];
int len = task.RemoveElement(nums, 0);

Console.WriteLine("CASE 1");
Console.WriteLine(string.Join(", ", nums));
Console.WriteLine(len);

//* CASE 2
nums = [0,1,2,2,3,0,4,2];
len = task.RemoveElement(nums, 2);

Console.WriteLine("\nCASE 2");
Console.WriteLine(string.Join(", ", nums));
Console.WriteLine(len);
