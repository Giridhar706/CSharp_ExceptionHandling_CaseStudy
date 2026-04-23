# CSharp_ExceptionHandling_CaseStudy

# 🏦 Banking System (C#)

## 📌 Problem Statement

Design a Banking System in C# that allows users to perform basic banking operations while handling errors using **custom exceptions**.

The system should:

* Deposit money
* Withdraw money
* Check balance
* Handle invalid inputs and insufficient balance

---

## ⚙️ Concepts Used

* Exception Handling (try-catch-finally)
* Custom Exceptions
* Classes & Objects
* Encapsulation
* User Input (Console)

---

## 📂 Project Structure

* `BankAccount.cs` → Handles account operations 
* `InvalidAmountException.cs` → Handles invalid deposit/amount errors 
* `InsufficientBalanceException.cs` → Handles low balance errors 
* `Program.cs` → Main execution logic with menu 

---

## 🔁 How It Works

1. User enters:

   * Account holder name
   * Initial balance

2. Menu is displayed:

   * Deposit
   * Withdraw
   * Check Balance
   * Exit

3. Based on user input:

   * Deposit adds money
   * Withdraw deducts money (with conditions)
   * Balance is displayed

4. Exceptions handled:

   * Invalid amount
   * Insufficient balance
   * Invalid choice

---

## ▶️ How to Run

1. Open project in **Visual Studio**
2. Build the solution
3. Run the program
4. Enter inputs as asked

---

## 💻 Sample Output

```id="u1z8qk"
Enter account holder name: Giridhar
Enter initial balance: 5000

1. Deposit
2. Withdraw
3. Check Balance
4. Exit
Choose option: 2
Enter amount: 4500
Error: Minimum ₹1000 balance required!
Transaction done.

1. Deposit
2. Withdraw
3. Check Balance
4. Exit
Choose option: 3
Current Balance: ₹5000
Transaction done.
```

---

## ⚠️ Exception Types Used

* `InvalidAmountException` → When amount ≤ 0
* `InsufficientBalanceException` → When balance is too low
* `ArgumentException` → Invalid menu choice
* General `Exception` → Unexpected errors

---

## 🚀 Future Improvements

* Add PIN authentication
* Store data in file/database
* Add multiple accounts
* GUI-based application

---

## 📌 Author

Giridhar Gopal
