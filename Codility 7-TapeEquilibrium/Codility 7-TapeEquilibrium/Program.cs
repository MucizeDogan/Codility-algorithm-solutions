//TapeEquilibrium


int[] A = new int[] { 3, 1, 2, 4, 3 };


int TotalToplam = 0;

int left = 0;
int right = 0;
int minDifference = Int32.MaxValue;

for (int i = 0; i < A.Length; i++)
{
  
    TotalToplam += A[i];

}


int result = 0;


for (int i = 1; i < A.Length; i++)
{

    left += A[i];
    right = TotalToplam - left;
    
    result = Math.Abs(left - right);
    
    if (result < minDifference)
        
        minDifference = result;

}
Console.WriteLine("Minimum difference: " + minDifference);








