using System;
using BankkontoGUI;
public class Bankkonto
{
    public string Kontonummer { get; private set; }
    public decimal Kontostand { get; private set; }

    public Bankkonto(string kontonummer, decimal anfangsBetrag)
    {
        Kontonummer = kontonummer;
        Kontostand = anfangsBetrag;
    }

    public void Einzahlen(decimal betrag)
    {
        if (betrag > 0)
            Kontostand += betrag;
        else
            throw new ArgumentException("Der Einzahlungsbetrag muss größer als 0 sein.");
    }

    public void Abheben(decimal betrag)
    {
        if (betrag > 0 && betrag <= Kontostand)
            Kontostand -= betrag;
        else
            throw new ArgumentException("Ungültiger Abhebungsbetrag oder nicht genügend Guthaben.");
    }

    public decimal KontostandAbfragen()
    {
        return Kontostand;
    }
}

