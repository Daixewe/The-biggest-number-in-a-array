Console.WriteLine("Select length of the list");

int size = int.Parse(Console.ReadLine());
int[] list = new int [size];

for (int i = 0;i < size; i++)
{
 Console.Write("Insert the number: ");
 string input = Console.ReadLine() ?? "0";
 list[i] = Int32.Parse(input);
}
  int maxElement = list[0];
    for (int index = 1; index < list.Length; index++)
    {
        if (list[index] > maxElement)
            maxElement = list[index];
    }
    Console.Write("The biggest number in the list is; "+maxElement);