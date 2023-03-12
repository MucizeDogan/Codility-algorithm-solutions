
int[] A = new int[] { 9, 3, 9, 3, 9, 9, 9, 7, 7 };


HashSet<int> hashset = new HashSet<int>();

int unique = 0;


for (int i = 0; i < A.Length; i++)
{
    if (hashset.Equals(A[i]))
    {
       
        hashset.Remove(A[i]);

    }
    else
    {
       
        hashset.Add(A[i]);

        unique = A[i];

    }



}


Console.WriteLine("Result: " + unique);





