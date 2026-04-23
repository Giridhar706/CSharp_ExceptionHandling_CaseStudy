# CSharp_ExceptionHandling_CaseStudy

📌 Problem Statement

Design a simple banking system using C# that allows a user to:

Create a bank account with an initial balance
Deposit money into the account
Withdraw money while maintaining a minimum balance of ₹1000
Check current account balance
Handle invalid inputs and errors using exception handling

The system should be interactive and menu-driven.

⚠️ Exception Types Used
1. InvalidAmountException
     Thrown when the deposit amount is less than or equal to 0
     Defined in: InvalidAmountException
2. InsufficientBalanceException
     Thrown when:
        Withdrawal amount exceeds balance
        Withdrawal causes balance to go below ₹1000
     Defined in: InsufficientBalanceException
3. ArgumentException
     Thrown when user selects an invalid menu option
4. Generic Exception
     Handles any unexpected errors

     Sample Output:

   <img width="1423" height="903" alt="image" src="https://github.com/user-attachments/assets/f6077387-8395-4990-8d93-bf25b836083d" />

   ▶️ How to Run the Code
   
   Step 1: Open Project
      Open Visual Studio
      Click on Open Project/Solution
      Select your project file (BankingSystem.csproj)
   
  Step 2: Check Files
  Make sure these files exist:
    Program.cs 
    BankAccount.cs 
    InvalidAmountException.cs 
    InsufficientBalanceException.cs 

Step 3: Build the Project
   Click Build → Build Solution
   (or press Ctrl + Shift + B)

Step 4: Run the Project
   Click Start
   (or press F5)
   
Step 5: Interact
   Enter your name and balance
   Choose options from the menu
