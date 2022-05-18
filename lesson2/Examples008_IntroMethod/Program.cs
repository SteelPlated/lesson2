//Найдем наибольшее из 9

int a1 = 13;
int a2 = 14;
int a3 = 199996;
int b1 = 66;
int b2 = 2343;
int b3 = 324;
int c1 = 13243;
int c2 = 1253;
int c3 = 123;

int max = a1;
if(b1>max) max=b1;
if(c1>max) max=c1;

if(a2>max) max=a2;
if(b2>max) max=b2;
if(c2>max) max=c2;

if(a3>max) max=a3;
if(b3>max) max=b3;
if(c3>max) max=c3;

Console.WriteLine(max);


