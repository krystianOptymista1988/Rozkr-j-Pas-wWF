using Rozkrój_Pasów;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class Program
{
    public static void CountsStart(string[] args)
    {
        // Długości sznurka
        var dlugosci = new List<int> { 1, 2, 3, 4, 5 };

        List<List<int>> wyniki = GenerujKombinacje(dlugosci);

        // Tworzenie formularza
        Application.EnableVisualStyles();
        Application.Run(new MainForm(wyniki));
    }
    public static void AddListItem()
    {
        List<int> list = new List<int>();
        foreach (Height item in Enum.GetValues(typeof(Height)))
        {
            list.Add((int)item);
        }

        var values = list;

    }
    // Funkcja rekurencyjna do generowania wszystkich możliwych kombinacji
    public static List<List<int>> GenerujKombinacje(List<int> dlugosci)
    {
        List<List<int>> kombinacje = new List<List<int>>();
        WypiszKombinacje(dlugosci, new List<int>(), 0, kombinacje);
        return kombinacje;
    }

    public static void WypiszKombinacje(List<int> dlugosci, List<int> kombinacja, int start, List<List<int>> wyniki)
    {
        // Jeśli suma długości w kombinacji wynosi 1250, dodaj kombinację do listy wyników
        int suma = Suma(kombinacja);
        if (suma == 1250)
        {
            wyniki.Add(new List<int>(kombinacja));
            return;
        }

        // Przeglądaj długości, począwszy od indeksu start
        for (int i = start; i < dlugosci.Count; i++)
        {
            // Sprawdź, czy dodanie długości nie przekroczy 1250
            if (suma + dlugosci[i] <= 1250)
            {
                // Dodaj długość do kombinacji
                kombinacja.Add(dlugosci[i]);
                // Wywołaj rekurencyjnie dla następnych długości, zaczynając od bieżącego indeksu
                WypiszKombinacje(dlugosci, kombinacja, i, wyniki);
                // Usuń dodaną długość przed sprawdzeniem kolejnych kombinacji
                kombinacja.RemoveAt(kombinacja.Count - 1);
            }
        }
    }

    // Funkcja do obliczania sumy długości w kombinacji
    public static int Suma(List<int> kombinacja)
    {
        int suma = 0;
        foreach (int dlugosc in kombinacja)
        {
            suma += dlugosc;
        }
        return suma;
    }
}

public class MainForm : Form
{
    private DataGridView dataGridView;

    public MainForm(List<List<int>> wyniki)
    {
        InitializeComponents();
        WyswietlWyniki(wyniki);
    }

    private void InitializeComponents()
    {
        dataGridView = new DataGridView();
        dataGridView.Dock = DockStyle.Fill;
        dataGridView.ReadOnly = true;
        dataGridView.AllowUserToAddRows = false;

        Controls.Add(dataGridView);
    }

    private void WyswietlWyniki(List<List<int>> wyniki)
    {
        // Ustawienie kolumny dla danych
        dataGridView.ColumnCount = 1;
        dataGridView.Columns[0].Name = "Kombinacje";

        // Wstawienie danych do DataGridView
        foreach (var kombinacja in wyniki)
        {
            dataGridView.Rows.Add(string.Join(", ", kombinacja));
        }
    }
}

