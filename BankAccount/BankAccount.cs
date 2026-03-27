using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using static System.Console;


class BankAccount
{
    int AccountNumber {get;}
    string OwnerName {get;}
    int Balance {get;}


    public BankAccount(int accountnum, string name) // 계좌 생성자
    {
        OwnerName = name;
        AccountNumber = accountnum;
        Balance = 0;
    }

    public void Deposit(int amount) // 입금 메서드
    {
        if (amount <= 0)
        {
            WriteLine($"입금 금액은 0보다 커야 합니다.");
        }
        Balance += amount;
        WriteLine($"{amount}원 입금 완료. 잔액: {Balance}");
    }
    public void WithDraw(int amount)  // 출금 메서드
    {
        if (amount > Balance)
        {
            WriteLine($"잔액이 부족합니다.");
        }
        Balance -= amount;
        WriteLine($"{amount}원 출금 완료. 잔액: {Balance}");
    }
    public void ShowInfo()
    {
        WriteLine($"[계좌 정보]: {AccountNumber} ({OwnerName}) - 잔액: {Balance}원");
    }
}