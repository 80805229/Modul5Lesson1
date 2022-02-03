int a = 2;
int b = 6;
int c = 9;
int d = 1;
int e = 4;

int max = a;

if (max < a) max = a;
if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;

Console.Write("Максимальное число равно ");
Console.WriteLine(max);