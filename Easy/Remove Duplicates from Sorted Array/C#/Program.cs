using Remove_Duplicates_from_Sorted_Array;

Solution task = new();
int[] nums = [0,0,1,1,1,2,2,3,3,4];

int len = task.RemoveDuplicates(nums);
Console.WriteLine(string.Join(", ", nums));
Console.WriteLine(len);
