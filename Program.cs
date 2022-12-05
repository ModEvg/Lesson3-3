// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int [] tochkaA = new int[3];
int [] tochkaB = new int[3];
double [] d = new double [3];
double dist = 0;
int n1 = 0;
while (n1<3)
{Console.Write($"Введите координату точки А x{n1+1}=");
tochkaA[n1] = int.Parse(Console.ReadLine());
Console.Write($"Введите координату точки B x{n1+1}=");
tochkaB[n1] = int.Parse(Console.ReadLine());
d[n1] = Math.Pow((tochkaA[n1]-tochkaB[n1]),2);
dist = dist + d[n1];
n1++;}
//d[n1] = Math.Pow((tochkaA[n1]-tochkaB[n1]),2);
//d2 = Math.Pow((tochkaA[1]-tochkaB[1]),2);
//d3 = Math.Pow((tochkaA[2]-tochkaB[2]),2);
dist = Math.Round(Math.Sqrt(dist),2);
Console.Write($"Расстояние между точкой А и точкой В равно {dist}");
