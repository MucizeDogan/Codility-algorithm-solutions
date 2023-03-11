
int[] A = new int[] {0,1,0,1,1};

int eastBound = 0;

int westBound = 0;

for(int i = 0; i < A.Length; i++)
{
    if(A[i] == 0)
        eastBound++;


    if(A[i] == 1)
        westBound+=eastBound;

}

Console.WriteLine("number of passing vehicles: " + westBound);











