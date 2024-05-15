using System.Windows;
namespace BankkontoApp
{
    public partial class MainWindow : Window
    {
        private Bankkonto konto;

        public MainWindow()
        {
            InitializeComponent();
            konto = new Bankkonto("123456789", 100); // Beispielkontonummer | Anfangsguthaben
        }

        private void Einzahlen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal betrag = decimal.Parse(txtBetrag.Text);
                konto.Einzahlen(betrag);
                AktualisiereKontostandAnzeige();
                MessageBox.Show("Einzahlung erfolgreich.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Abheben_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal betrag = decimal.Parse(txtBetrag.Text);
                konto.Abheben(betrag);
                AktualisiereKontostandAnzeige();
                MessageBox.Show("Abhebung erfolgreich.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Abfragen_Click(object sender, RoutedEventArgs e)
        {
            AktualisiereKontostandAnzeige();
        }

        private void AktualisiereKontostandAnzeige()
        {
            txtKontostand.Text = konto.KontostandAbfragen().ToString();
        }
    }
}