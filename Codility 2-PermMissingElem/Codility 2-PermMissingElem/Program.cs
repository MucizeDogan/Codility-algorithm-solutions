

int[] A = new int[] { 2, 1, 5, 3 };

int B = A.Length + 1;

int sum = B * (B + 1) / 2;
for (int i = 0; i < A.Length; i++)
{
	sum -= A[i];
}
Console.WriteLine("Missing number= " + sum);
