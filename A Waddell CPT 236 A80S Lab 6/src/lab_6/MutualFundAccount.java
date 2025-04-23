package lab_6;
import javax.swing.*;

public class MutualFundAccount extends BankAccount {
    private double investedBalance;
    private String riskLevel;

    public MutualFundAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance, double investedAmount, String riskLevel) 
    {
        super(accountNumber, ownerName, email, phoneNumber, balance);
        this.investedBalance = investedAmount;
        this.riskLevel = riskLevel;
    }
    
    @Override
    public void displayAccountInfo()
    {
        super.displayAccountInfo();
        String info = String.format("\nInvested Amount: $%.2f\nRisk Level: %s", investedBalance, riskLevel);
        JOptionPane.showMessageDialog(null, info, "Mutual Fund Account Information", JOptionPane.INFORMATION_MESSAGE);
    }
    
    public String getRiskLevel()
    {
        return riskLevel;
    }
}