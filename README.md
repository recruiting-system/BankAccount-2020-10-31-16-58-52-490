# Business Requirement
https://docs.microsoft.com/zh-cn/dotnet/csharp/tutorials/intro-to-csharp/introduction-to-classes

https://docs.microsoft.com/zh-cn/dotnet/csharp/tutorials/intro-to-csharp/object-oriented-programming

## Bank account supports this behavior:
1. It has a 10-digit number that uniquely identifies the bank account.
2. It has a string that stores the name or names of the owners.
3. The balance can be retrieved.
4. It accepts deposits.
5. It accepts withdrawals.
6. The initial balance must be positive.
7. Withdrawals cannot result in a negative balance.

### Practice Requirement:
- Define the bank account type: Create a new file, Name it `BankAccount.cs`
- Open a new account: When a customer opens an account, they must supply an **initial balance**, and information about the **owner or owners** of that account.
- Create deposits and withdrawals: The bank account needs to accept deposits and withdrawals to work correctly. Let's implement deposits and withdrawals by creating a journal of every transaction for the account. That has a few advantages over simply updating the balance on each transaction. The history can be used to audit all transactions and manage daily balances. By computing the balance from the history of all transactions when needed, any errors in a single transaction that are fixed will be correctly reflected in the balance on the next computation.
  - Create a new file named `Transaction.cs`, it has 3 properties:
    - Amount: Deposits or withdrawals amount of the transaction.
    - Date: The datetime of the tansaction occured.
    - Notes: Notes of the transaction  
- Log all transactions: You can write the `GetAccountHistory` method that creates a `string` for the transaction history. Add this method to the `BankAccount` type:
- Create different types of accounts: After building this program, you get requests to add features to it. It works great in the situation where there is only one bank account type. Over time, needs change, and related account types are requested:
    - An interest earning account that accrues interest at the end of each month. 
      - Will get a credit of 2% of the month-ending-balance.
    - A line of credit that can have a negative balance, but when there's a balance, there's an interest charge each month.
      - Can have a negative balance, but not be greater in absolute value than the credit limit.
      - Will incur an interest charge each month where the end of month balance isn't 0.
      - Will incur a fee on each withdrawal that goes over the credit limit.
    - A pre-paid gift card account that starts with a single deposit, and only can be paid off. It can be refilled once at the start of each month.
      - Can be refilled with a specified amount once each month, on the last day of the month.