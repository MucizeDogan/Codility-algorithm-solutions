
int[] A = new int[] { -3, 1, 2, -2, 5, 6 };

Array.Sort(A);


for (int i = 0; i < A.Length; i++)  //to show the array in a sorted way
    {

    Console.WriteLine(A[i]);

    }
    

int result3 = 0;

int result1 = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];

int result2 = A[0] * A[1] * A[A.Length - 1];

result3 = Math.Max(result1, result2);


Console.WriteLine("Result = " + result3);




