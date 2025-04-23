package lab_6;
import javax.swing.*;
public class CheckingAccount extends BankAccount
{
	private double overdraftLimit;
	public CheckingAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance, double overdraftLimit)
	{
        super(accountNumber, ownerName, email, phoneNumber, balance); // old stuff
        this.overdraftLimit = overdraftLimit; // and the new
    }
	
	@Override // add to displayAccoutnInfo
	public void displayAccountInfo()
	{
		super.displayAccountInfo();// include regular stuff
        String info = String.format("\nOverdraft Limit: $%.2f", overdraftLimit);
        JOptionPane.showMessageDialog(null, info, "Checking Account Information", JOptionPane.INFORMATION_MESSAGE);
    }
}
