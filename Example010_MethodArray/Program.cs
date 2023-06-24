int[] array = { 71, 62, 13, 43, 225, 13, 56, 57, 87, 96 };

int n = array.Length;
int find = 13;

int index = 0;

while(index < n) 
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
    
    
