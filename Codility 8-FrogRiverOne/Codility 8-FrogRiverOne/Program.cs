

int[] A = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };

int MaxStep = 5;

int result = 0;

HashSet<int> set = new HashSet<int>();

for (int i = 0; i < A.Length; i++)
{

    // set.Add(A[i]);
    if (A[i] == MaxStep)

        result = i;

}

Console.WriteLine("earliest time= " + result);



