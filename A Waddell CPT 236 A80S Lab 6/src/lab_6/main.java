package lab_6;
import javax.swing.*;
import java.awt.*;

// there are many cons to naming your class main. why did i do this.
public class main extends JFrame {
    private BankAccount userAccount;
    private JTextField inputField;
    private JTextArea outputArea;

    public main() {
        setTitle("Bank System");
        setSize(800, 300);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new BorderLayout());

        //account info display
        outputArea = new JTextArea();
        outputArea.setEditable(false);
        add(new JScrollPane(outputArea), BorderLayout.CENTER);

        // the buttons on the bottom of the pain
        JPanel buttonPanel = new JPanel();
        buttonPanel.setLayout(new GridLayout(1, 5));

        // and then put in the buttons
        JButton createButton = new JButton("Create Account");
        JButton depositButton = new JButton("Deposit");
        JButton withdrawButton = new JButton("Withdraw");
        JButton viewButton = new JButton("View Account");
        JButton exitButton = new JButton("Exit");

        // add to cart
        buttonPanel.add(createButton);
        buttonPanel.add(depositButton);
        buttonPanel.add(withdrawButton);
        buttonPanel.add(viewButton);
        buttonPanel.add(exitButton);

        add(buttonPanel, BorderLayout.SOUTH);

        // button do ing
        // button name.addActionListener(does the thing)(e = mc 2)(put into the method)
        createButton.addActionListener(e -> createAccount());
        depositButton.addActionListener(e -> deposit());
        withdrawButton.addActionListener(e -> withdraw());
        viewButton.addActionListener(e -> viewAccount());
        exitButton.addActionListener(e -> System.exit(0)); // LEAVE!!!!!

        setVisible(true);
    }

    // and then the stuff from lab 6. just change nearly nothing other than where it goes
    private void createAccount() {
        userAccount = BankAccount.createAccount();
        outputArea.setText("Account created successfully!\n" + userAccount.toString()); // put this in the output area. same thing that gets used everywhere.
    }

    private void deposit() {
        if (userAccount != null) {
            try {
                double amount = Double.parseDouble(inputField.getText());
                userAccount.deposit(amount);
                outputArea.setText("Deposited: $" + amount + "\n" + userAccount.toString());
                inputField.setText("");
            } catch (NumberFormatException e) {
                JOptionPane.showMessageDialog(this, "Invalid input. Please enter a valid number.", "Error", JOptionPane.ERROR_MESSAGE);
            }
        } else {
            JOptionPane.showMessageDialog(this, "Please create an account first.", "Error", JOptionPane.ERROR_MESSAGE);
        }
    }

    private void withdraw() {
        if (userAccount != null) {
            try {
                double amount = Double.parseDouble(inputField.getText());
                userAccount.withdraw(amount);
                outputArea.setText("Withdrawn: $" + amount + "\n" + userAccount.toString());
                inputField.setText("");
            } catch (NumberFormatException e) {
                JOptionPane.showMessageDialog(this, "Invalid input. Please enter a valid number.", "Error", JOptionPane.ERROR_MESSAGE);
            }
        } else {
            JOptionPane.showMessageDialog(this, "Please create an account first.", "Error", JOptionPane.ERROR_MESSAGE);
        }
    }

    private void viewAccount() {
        if (userAccount != null) {
            outputArea.setText(userAccount.toString());
        } else {
            JOptionPane.showMessageDialog(this, "Please create an account first.", "Error", JOptionPane.ERROR_MESSAGE);
        }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(main::new); // trip and actually RUN
    }
}