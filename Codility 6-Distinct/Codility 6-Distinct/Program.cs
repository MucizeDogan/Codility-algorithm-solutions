


int[] A = new int[] { 2, 1, 1, 2, 3, 1 };


int result = 0;



HashSet<int> set = new HashSet<int>();


for (int i = 0; i < A.Length; i++)
{
   
    set.Add(A[i]);


}

result = set.Count();


Console.WriteLine("Result= " + result);