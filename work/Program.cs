void SortArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3)
        Console.Write (array[i] + " ");
        else
        Console.Write (" ");
    }
}

string [] array = {"1234", "76", "-22","58673", "3555", "24234"};
SortArray (array);