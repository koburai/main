package lab_6;
import javax.swing.*; //there has to be a better way then importing on EVERY SINGLE CLASS

public class CryptoAccount extends BankAccount 
{
    private double cryptoBalance;
    private String cryptoType;

    public CryptoAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance, double cryptoBalance, String cryptoType) {
        super(accountNumber, ownerName, email, phoneNumber, balance); // old
        this.cryptoBalance = cryptoBalance; // new
        this.cryptoType = cryptoType;
    }
    
    @Override
    public void displayAccountInfo()
    {
        super.displayAccountInfo();
        String info = String.format("\nCrypto Type: %s\nCrypto Balance: %.4f %s", cryptoType, cryptoBalance, cryptoType);
        JOptionPane.showMessageDialog(null, info, "Crypto Account Information", JOptionPane.INFORMATION_MESSAGE);
    }
    
    public String getCryptoType()
    {
        return cryptoType;
    }
}