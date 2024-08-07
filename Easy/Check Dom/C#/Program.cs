using Check_Dom;

var task = new Solution();
Console.WriteLine(task.CheckDOM("<div><div><b></b></div></p>"));
Console.WriteLine(task.CheckDOM("<div>abc</div><p><em><i>test test test</b></em></p>"));
