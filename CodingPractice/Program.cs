using System;
using System.Runtime.CompilerServices;

// 1
ClassName.MemberName();

Console.WriteLine();

// 2
Square.GetName();

Console.WriteLine();

// 3
MyFirstClass.StaticMethod();
// 인스턴스 메서드는 불러오기 위해 개체 하나를 생성해야함
MyFirstClass my = new MyFirstClass();
my.InstanceMethod();

Console.WriteLine();

// 4
Person person1 = new Person();
person1.name = "홍길동";
person1.age = 25;
person1.Introduce();

Person person2 = new Person();
person2.name = "김철수";
person2.age = 30;
person2.Introduce();

Console.WriteLine();

//5
// class는 "참조" 타입이기때문에 변수에는 개체 메모리의 값이 아닌 주소가 저장됨
Point point1 = new Point();
point1.X = 10;
point1.Y = 10;

Point point2 = point1;
point2.X = 100;
Console.WriteLine($"point1.X = {point1.X}");
Console.WriteLine($"point2.X = {point2.X}");

Console.WriteLine();

//6
PointStruct ps1 = new PointStruct();
ps1.X = 10;
PointStruct ps2 = ps1;
ps2.X = 1000;

PointClass pc1 = new PointClass();
pc1.X = 10;
PointClass pc2 = pc1;
pc2.X = 1000;

Console.WriteLine($"구조체: ps1.X = {ps1.X}, ps2.X = {ps2.X}");
Console.WriteLine($"클래스: pc1.X = {pc1.X}, pc2.X = {pc2.X}");
