# DesignByContract

I've tried to make a simple main program that demonstrate the Code Contract in C#

the requirements was simply this:

#Consider an Account class. It should have two methods:

  <h3>Deposit(double amount)</h3>
  which should increase the account’s balance with
the amount, the amount should always be positive

  <h3>Withdraw(double amount)</h3>
  which on the other hand should decrease the
account’s balance. Also this amount should be positive. If the amount
exceeds the balance, the balance should be left untouched and an exception
should be thrown.


#My implementation

I've installed Code Contracts.
I created an interface called IfAccount
I created an abstract class called AccountContract
I created a class called Account.

the Account class implements IfAccount.

the AccountContract class define the constraints described above.
and implements the IfAccount as well.

all in all the code should speak for it self. 
The simple concept is that if my Account class implement the IfAccount Interface it will at compile time
and run time tell me where and why I'm violating the contract defined in the AccountContract. 
This behavior is great when implementing a contract recived by third part because it will quickly tell you 
when and where you are violating the contract supplied by that third part. In Design by Contract this is
a very usable functionality that vill enable the designers to make a formal contract that binds the developers tightly
to a specific contract interface.
