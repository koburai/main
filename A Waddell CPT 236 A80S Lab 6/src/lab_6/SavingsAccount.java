package lab_6;
import javax.swing.*;

public class SavingsAccount extends BankAccount
{
	private double interestRate;

	public SavingsAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance, double interestRate) {
        super(accountNumber, ownerName, email, phoneNumber, balance); // bank acct constructor
        this.interestRate = interestRate; // featuring the new stuff
	}
	
	public double getInterestRate()
	{
		return interestRate;
	}
	
	@Override // add this to the default bankaccount
	public void displayAccountInfo()
	{
        super.displayAccountInfo();
        String info = String.format("\nInterest Rate: %.2f%%", interestRate);
        JOptionPane.showMessageDialog(null, info, "Savings Account Information", JOptionPane.INFORMATION_MESSAGE);
	}
}
