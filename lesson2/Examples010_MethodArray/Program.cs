int[] array={1,24,35,88,44,57,66,77,88};

int n=array.Length;
int find = 88;

int index = 0;
 while (index<n)
 {
     if(array[index]==find)
     {
         Console.WriteLine(index);
         break;
     }
     //index=index+ 1;
     index++;
 }