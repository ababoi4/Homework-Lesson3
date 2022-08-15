// Задача 2

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int aX = 3;
int aY = 6;
int aZ = 8;
int bX = 2;
int bY = 1;
int bZ = -7;

double result = Math.Sqrt((bX - aX)*(bX - aX) + (bY - aY)*(bY - aY) + (bZ - aZ)*(bZ - aZ));
System.Console.WriteLine(result);