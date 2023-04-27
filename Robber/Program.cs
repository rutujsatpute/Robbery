Console.WriteLine("Enter No. of Robbers: ");
int num = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter The Robber with whom Sam will start shooting: ");
int start = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the gap between the robbers: ");
int gap = Convert.ToInt16(Console.ReadLine());

int target = start;
int present = start - 1;
int shot = 0;

int[] arr = new int[num];
for (int i = 0; i < num; i++)
{
    arr[i] = i + 1;
}

while (num != 0)
{
    if (present >= num)
    {
        present = present % num;
    }
    Console.WriteLine($"Target ={arr[present]}, {++shot} shots Completed");

    for (int i = present; i < num - 1; i++)
    {
        arr[i] = arr[i + 1];
    }
    num--;
    present += gap;
}