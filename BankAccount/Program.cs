using System;

// BankAccount

BankAccount ba = new("123-456-789", "홍길동");

ba.ShowInfo();
ba.Deposit(50000);
ba.Deposit(30000);
ba.WithDraw(20000);
ba.WithDraw(10000000);
ba.Deposit(-1000);

ba.ShowInfo();

