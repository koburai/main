package lab_6;

import javax.swing.*;

public class BankAccount
{
	// declare
	private String accountNumber;
    private String ownerName;
    private String email;
    private String phoneNumber;
    private double balance;
    
    // o	Constructor to initialize values
    public BankAccount(String accNum, String ownerName, String email, String phoneNum, double balance)
    {
    	// and then. this..
    	this.accountNumber = accNum;
    	this.ownerName = ownerName;
    	this.email = email;
    	this.phoneNumber = phoneNum;
    	this.balance = balance;
    }
    
    // the getterrrsss
    public String getAcctNum() // have i ever mentione dhow much i hate string needing to be capitalized in java??
    {
    	return accountNumber;
    }
    public String getOwnerName()
    {
    	return ownerName;
    }
    public String getEmail()
    {
    	return email;
    }
    public String getPhonenum()
    {
    	return phoneNumber;
    }
    public double getBalance()
    {
    	return balance;
    }
    
    // the setterssss which is like. partial construction ngl. hate this
    public void setOwner(String ownerName)
    {
    	this.ownerName = ownerName;
    }
    public void setEmail(String email)
    {
    	this.email = email;
    }
    public void setPhonenum(String phoneNum)
    {
    	this.phoneNumber = phoneNum;
    }
    public void setBalance(double balance)
    {
    	this.balance = balance;
    }
    
    public static BankAccount createAccount() //•	Step 1: The user selects an account type (JOptionPane menu).
    //Step 2: The user creates an account by entering details.
    {
    	// request user inpit
        String accountNumber = JOptionPane.showInputDialog("Enter Account Number:");
        String ownerName = JOptionPane.showInputDialog("Enter Owner Name:");
        String email = JOptionPane.showInputDialog("Enter Email:");
        String phoneNumber = JOptionPane.showInputDialog("Enter Phone Number:");
        String[] accountTypes = {"Savings Account", "Checking Account", "Mutual Fund Account", "Crypto Account"}; 
        int choice = JOptionPane.showOptionDialog( // assign the choice of account type as an int bc spellcheck yike
                null,
                "Select Account Type:",
                "Account Type Selection",
                JOptionPane.DEFAULT_OPTION,
                JOptionPane.QUESTION_MESSAGE,
                null,
                accountTypes,
                accountTypes[0]
                );

        double balance = 0.0; // default balance is 0
        try 
        {
            balance = Double.parseDouble(JOptionPane.showInputDialog("Enter Initial Balance:"));
            if (balance < 0) 
            {
            	// if they try to do that one infinite ssn glitch
                JOptionPane.showMessageDialog(null, "Initial balance cannot be negative. Setting to $0.", "Warning", JOptionPane.WARNING_MESSAGE);
                balance = 0.0;
            }
        } 
        catch (NumberFormatException e) 
        {
            JOptionPane.showMessageDialog(null, "Invalid balance input. Setting to $0.", "Error", JOptionPane.ERROR_MESSAGE);
        }
        
        // now to set the specifics for each bankacc type
        switch (choice)
        {
        case 0:
            double interestRate = Double.parseDouble(JOptionPane.showInputDialog("Enter Interest Rate:"));
            return new SavingsAccount(accountNumber, ownerName, email, phoneNumber, balance, interestRate);
        case 1:
            double overdraftLimit = Double.parseDouble(JOptionPane.showInputDialog("Enter Overdraft Limit:"));
            return new CheckingAccount(accountNumber, ownerName, email, phoneNumber, balance, overdraftLimit);
        case 2:
            double investedBalance = Double.parseDouble(JOptionPane.showInputDialog("Enter Invested Balance:"));
            String riskLevel = JOptionPane.showInputDialog("Enter Risk Level (Low, Medium, High):");
            return new MutualFundAccount(accountNumber, ownerName, email, phoneNumber, balance, investedBalance, riskLevel);
        case 3:
            double cryptoBalance = Double.parseDouble(JOptionPane.showInputDialog("Enter Crypto Balance:"));
            String cryptoType = JOptionPane.showInputDialog("Enter Crypto Type: ");
            return new CryptoAccount(accountNumber, ownerName, email, phoneNumber, balance, cryptoBalance, cryptoType);
        default:
            return null;
        }
    }
    
    public void withdraw(double amount)   //  o	withdraw(double amount): Deducts from balance (with validation)
    {
    	// i don't know what validation means so im just gonna assume that means 'has to be more than 0/cant be negative money'
    	String input = JOptionPane.showInputDialog(null, "Enter withdrawal amount:", "Withdraw", JOptionPane.QUESTION_MESSAGE);
        try
        {
            double amt = Double.parseDouble(input);
            if (amt > 0 && amt <= balance) 
            {
                balance -= amt;
                JOptionPane.showMessageDialog(null, "Withdrawn: $" + amt, "Success", JOptionPane.INFORMATION_MESSAGE);
            } 
            else if (amt > balance) 
            {
                JOptionPane.showMessageDialog(null, "Insufficient funds.", "Error", JOptionPane.ERROR_MESSAGE);
            } 
            else 
            {
                JOptionPane.showMessageDialog(null, "Withdrawal amount must be positive.", "Error", JOptionPane.ERROR_MESSAGE);
            }
        } 
        catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Invalid input. Please enter a valid number.", "Error", JOptionPane.ERROR_MESSAGE);
        }
    }
    
    public void displayAccountInfo()  //   o	displayAccountInfo(): Displays account details

    {
    	String info = String.format(
    	        "Account Number: %s\nOwner Name: %s\nEmail: %s\nPhone Number: %s\nBalance: %.2f",
    	        accountNumber, ownerName, email, phoneNumber, balance); // this is just $"account number: {acctNumber}" but java.
    	JOptionPane.showMessageDialog(null, info);
    }

	public void deposit(double amount) 
	{
		String input = JOptionPane.showInputDialog(null, "Enter deposit amount:", "Deposit", JOptionPane.QUESTION_MESSAGE);
    try 
    {
        double amt = Double.parseDouble(input);
        if (amt > 0)
        {
            balance += amt;
            JOptionPane.showMessageDialog(null, "Deposited: $" + amt, "Success", JOptionPane.INFORMATION_MESSAGE);
        } 
        else
        {
            JOptionPane.showMessageDialog(null, "Deposit amount must be positive.", "Error", JOptionPane.ERROR_MESSAGE);
        }
    } 
    catch (NumberFormatException e) 
    {
        JOptionPane.showMessageDialog(null, "Invalid input. Please enter a valid number.", "Error", JOptionPane.ERROR_MESSAGE);
    }
}
}
