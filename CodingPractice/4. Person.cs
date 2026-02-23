using System;
using System.Collections.Generic;
using System.Text;

class Person
{
    public string name;
    public int age;

    public void Introduce()
    {
        Console.WriteLine($"안녕하세요, {name}입니다. {age}살 입니다.");
    }
}