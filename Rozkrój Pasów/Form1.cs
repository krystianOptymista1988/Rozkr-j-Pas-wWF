using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozkrój_Pasów
{
    public partial class Form1 : Form
    {
       public int arkusz;
       public bool czjest = false;
      public List<string> grubosc = new List<string> { "0,6", "1,0", "1,5", "2,0" };
       public List<string> material = new List<string> { "STAL", "Aluminium" };
       public List<string> arkuszlist = new List<string> { "1250", "1500" };
       public List<string> kolor = new List<string> { "7016", "8017", "8019", "9005", "9010", "9016", "9006", "9007", "7024", "ZŁ.DĄB", "WINCHESTER", "ORZECH", "SUROWY" };
       public List<int> dlugosci = new List<int>();
       public List<int> ilosciPasow = new List<int>();
       private List<Pasy> listapasów = new List<Pasy> { };
       private List<Rozkroj> rozkroje = new List<Rozkroj>();
        public List<int> referencelist2 = new List<int> { 305, 330, 355, 380, 280, 255, 405, 430, 455, 230, 205, 480, 505 };
        public List<string> referencelist4 = new List<string> { "brak", "145", "175", "205", "235", "255", "280", "305", "330", "355", "380", "405", "430", "455", "480", "505" };
        List<string> categories = new List<string> { "brak", "145", "175", "205", "235", "255", "280", "305", "330", "355", "380", "405", "430", "455", "480", "505" };
        List<string> categories1 = new List<string> { "brak", "145", "175", "205", "235", "255", "280", "305", "330", "355", "380", "405", "430", "455", "480", "505" };
        List<string> categories2 = new List<string> { "brak", "145", "175", "205", "235", "255", "280", "305", "330", "355", "380", "405", "430", "455", "480", "505" };
        List<string> categories3 = new List<string> { "brak", "145", "175", "205", "235", "255", "280", "305", "330", "355", "380", "405", "430", "455", "480", "505" };
        List<string> categories4 = new List<string> { "brak", "145", "175", "205", "235", "255", "280", "305", "330", "355", "380", "405", "430", "455", "480", "505" };
        List<string> categories5 = new List<string> { "brak", "145", "175", "205", "235", "255", "280", "305", "330", "355", "380", "405", "430", "455", "480", "505" };
        List<string> categories6 = new List<string> { "brak", "145", "175", "205", "235", "255", "280", "305", "330", "355", "380", "405", "430", "455", "480", "505" };
        List<string> categories7 = new List<string> { "brak", "145", "175", "205", "235", "255", "280", "305", "330", "355", "380", "405", "430", "455", "480", "505" };
        public Form1()
        {
            InitializeComponent();
            InitGroupCombobox();

        }
        public void InitGroupCombobox()
        {


      
            cbPas1.DataSource = categories;
            cbPas1.DisplayMember = "Name";
            cbItem2.DataSource = categories1;
            cbItem2.DisplayMember = "Name";
            cbItem3.DataSource = categories2;
            cbItem3.DisplayMember = "Name";
            cbItem4.DataSource = categories3;
            cbItem4.DisplayMember = "Name";
            cbItem5.DataSource = categories4;
            cbItem5.DisplayMember = "Name";
            cbItem6.DataSource = categories5;
            cbItem6.DisplayMember = "Name";
            cbItem7.DataSource = categories6;
            cbItem7.DisplayMember = "Name";
            cbItem8.DataSource = categories7;
            cbItem8.DisplayMember = "Name";
            cbMaterial.DataSource = material;
            cbKolor.DataSource = kolor;
            cbGrubosc.DataSource = grubosc;
            cbArkusz.DataSource = arkuszlist;
            cbGrubosc.SelectedItem = 1;
            cbArkusz.SelectedItem = 1;
            cbKolor.SelectedItem = 1;
            cbMaterial.SelectedItem = 1;


        }



        public void cbItem1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void btGeneruj_Click(object sender, EventArgs e)
        {
            DGVClear();
            CreateList();
            DataGridViewuse();

        }

        private void DGVClear()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void DataGridViewuse()
        {
            string rozkrojDGV;
            // Tworzenie kolumn dla DataGridView
            dataGridView1.Columns.Add("Rozkrój", "Rozkrój");
            dataGridView1.Columns.Add("Przejazdy", "Przejazdy");
            dataGridView1.Columns.Add("Materiał", "Materiał");
            dataGridView1.Columns.Add("Grubość", "Grubość");
            dataGridView1.Columns.Add("Kolor", "Kolor");

            string material = cbMaterial.Text;
            string grubosc = cbGrubosc.Text;
            string kolor = cbKolor.Text;
            
            foreach (Rozkroj wyswietl in rozkroje)
            {
                rozkrojDGV = "";
                foreach (var rozkroj in wyswietl.rozkroj)
                {
                    rozkrojDGV = string.Join(", ", wyswietl.rozkroj);
                }
                dataGridView1.Rows.Add(rozkrojDGV, wyswietl.przejazdy, material, grubosc, kolor);
            }


        }

        public void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("W tej wersji programu ta opcja nie działa, poczekaj na aktualizacje do wersji 2.0");
        }

        public void button2_Click(object sender, EventArgs e)
        {

            DrukujTabele();


            MessageBox.Show("Wiem, trzeba to dopracować, poczekaj na aktualizacje do wersji 2.0 :)");
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            for (int col = 0; col < dataGridView1.Columns.Count; col++)
            {
                int maxWidth = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[col].Value != null)
                    {
                        SizeF size = e.Graphics.MeasureString(row.Cells[col].Value.ToString(), dataGridView1.Font);
                        maxWidth = Math.Max(maxWidth, (int)size.Width);
                    }
                }
                dataGridView1.Columns[col].Width = maxWidth + 10; 
            }
          
            int marginesGorny = 30;
            int marginesLewy = 30;
            int gornyPoczatek = 50;

           
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);

           
            for (int col = 0; col < dataGridView1.Columns.Count; col++)
            {
             
                e.Graphics.DrawString(dataGridView1.Columns[col].HeaderText, headerFont, Brushes.Black, marginesLewy + (col * 100), marginesGorny);
            }

      
            int tabelaSzerokosc = dataGridView1.Columns.Count * 100;
            int tabelaWysokosc = dataGridView1.Rows.Count * 20;

            for (int row = 0; row <= dataGridView1.Rows.Count; row++)
            {
                e.Graphics.DrawLine(Pens.Black, marginesLewy, gornyPoczatek + (row * 20), marginesLewy + tabelaSzerokosc, gornyPoczatek + (row * 20));
            }

            for (int col = 0; col <= dataGridView1.Columns.Count; col++)
            {
                e.Graphics.DrawLine(Pens.Black, marginesLewy + (col * 100), gornyPoczatek, marginesLewy + (col * 100), gornyPoczatek + tabelaWysokosc);
            }

          
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
             
                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    object cellValue = dataGridView1.Rows[row].Cells[col].Value;
                    string stringValue = (cellValue != null && cellValue.GetType() == typeof(int)) ? cellValue.ToString() : Convert.ToString(cellValue);
                    e.Graphics.DrawString(stringValue, new Font("Arial", 12), Brushes.Black, marginesLewy + (col * 100), gornyPoczatek + ((row + 1) * 20));
                }
            }
        }
        private void DrukujTabele()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CreateList()
        {
            arkusz = int.Parse(cbArkusz.Text);

            if (cbPas1.SelectedItem.ToString() != "brak")
            {
                Pasy szerokosci = new Pasy();
                szerokosci.szerokosc = int.Parse(cbPas1.SelectedItem.ToString());
                szerokosci.ilosc = int.Parse(tbPas1.Text);
                
                dlugosci.Add(szerokosci.szerokosc);
                ilosciPasow.Add(szerokosci.ilosc);
                listapasów.Add(szerokosci);
            }
            if (cbItem2.SelectedItem.ToString() != "brak")
            {
                Pasy szerokosci = new Pasy();
                szerokosci.szerokosc = int.Parse(cbItem2.SelectedItem.ToString());
                szerokosci.ilosc = int.Parse(tbItem2.Text);
                dlugosci.Add(szerokosci.szerokosc);
                ilosciPasow.Add(szerokosci.ilosc);
                listapasów.Add(szerokosci);
            }
            if (cbItem3.SelectedItem.ToString() != "brak")
            {
                Pasy szerokosci = new Pasy();
                szerokosci.szerokosc = int.Parse(cbItem3.SelectedItem.ToString());
                szerokosci.ilosc = int.Parse(tbItem3.Text);
                dlugosci.Add(szerokosci.szerokosc);
                ilosciPasow.Add(szerokosci.ilosc);
                listapasów.Add(szerokosci);
            }
            if (cbItem4.SelectedItem.ToString() != "brak")
            {
                Pasy szerokosci = new Pasy();
                szerokosci.szerokosc = int.Parse(cbItem4.SelectedItem.ToString());
                szerokosci.ilosc = int.Parse(tbItem4.Text);
                dlugosci.Add(szerokosci.szerokosc);
                ilosciPasow.Add(szerokosci.ilosc);
                listapasów.Add(szerokosci);
            }
            if (cbItem5.SelectedItem.ToString() != "brak")
            {
                Pasy szerokosci = new Pasy();
                szerokosci.szerokosc = int.Parse(cbItem5.SelectedItem.ToString());
                szerokosci.ilosc = int.Parse(tbItem5.Text);
                dlugosci.Add(szerokosci.szerokosc);
                ilosciPasow.Add(szerokosci.ilosc);
                listapasów.Add(szerokosci);
            }
            if (cbItem6.SelectedItem.ToString() != "brak")
            {
                Pasy szerokosci = new Pasy();
                szerokosci.szerokosc = int.Parse(cbItem6.SelectedItem.ToString());
                szerokosci.ilosc = int.Parse(tbItem6.Text);
                dlugosci.Add(szerokosci.szerokosc);
                ilosciPasow.Add(szerokosci.ilosc);
                listapasów.Add(szerokosci);
            }
            if (cbItem7.SelectedItem.ToString() != "brak")
            {
                Pasy szerokosci = new Pasy();
                szerokosci.szerokosc = int.Parse(cbItem7.SelectedItem.ToString());
                szerokosci.ilosc = int.Parse(tbItem7.Text);
                dlugosci.Add(szerokosci.szerokosc);
                ilosciPasow.Add(szerokosci.ilosc);
                listapasów.Add(szerokosci);
            }
            if (cbItem8.SelectedItem.ToString() != "brak")
            {
                Pasy szerokosci = new Pasy();
                szerokosci.szerokosc = int.Parse(cbItem8.SelectedItem.ToString());
                szerokosci.ilosc = int.Parse(tbItem8.Text);
                dlugosci.Add(szerokosci.szerokosc);
                ilosciPasow.Add(szerokosci.ilosc);
                listapasów.Add(szerokosci);
            }

            Obliczenia(dlugosci, referencelist2, arkusz);

        }
        public void Obliczenia(List<int> dlugosci, List<int> referencelist2, int arkusz)
        {
            List<int> referencelist = dlugosci;
            referencelist.AddRange(referencelist2);

            var allCombinations = GenerateAllCombinations(referencelist, arkusz);
            List<int> remainingLengths = new List<int>();
            List<int> remainingQuantities = new List<int>();
            foreach (Pasy pasy in listapasów)
            {
                remainingLengths.Add(pasy.szerokosc);
                remainingQuantities.Add(pasy.ilosc);
            }

            while (remainingLengths.Any(l => l > 0))
            {
                czjest = false;
                List<int> referencelist3 = new List<int> { 305, 330, 355, 380, 280, 255, 405, 430, 455, 230, 205, 480, 505 };
                var mostMatchingCombination = FindMostMatchingCombination(allCombinations, remainingLengths);
                if (mostMatchingCombination != null)
                {
                    //int repetitions = CalculateRepetitions(mostMatchingCombination, remainingQuantities, remainingLengths);
                    int repetitions = IloscPrzejazdowObiekty(listapasów, mostMatchingCombination);
                    if (repetitions == 0) { break; }
                    // Console.WriteLine("Rozkrój:");
                    // foreach (var number in mostMatchingCombination)
                    //  {
                    //       Console.Write(number + " ");
                    //   }
                    //   Console.WriteLine($"\nIlość przejazdów: {repetitions}");
                    foreach (Rozkroj rozkroj1 in rozkroje)
                    {
                        int repeats = 0;
                        if (rozkroj1.rozkroj.Count == mostMatchingCombination.Count)
                        {


                            for (int i = 0; i < rozkroj1.rozkroj.Count; i++)
                            {
                                if (rozkroj1.rozkroj[i] != mostMatchingCombination[i])
                                {

                                    czjest = false;
                                    break;
                                }
                                repeats++;
                            }
                        }
                        else
                        {
                            czjest = false;

                        }

                        if (czjest == true || repeats == rozkroj1.rozkroj.Count)
                        {
                            rozkroj1.przejazdy += repetitions;
                            czjest = true;
                        }
                    }
                    if (czjest == false)
                    {
                        Rozkroj rozkroj = new Rozkroj();
                        rozkroj.rozkroj = mostMatchingCombination;
                        rozkroj.przejazdy = repetitions;
                        rozkroj.grubosc = cbGrubosc.SelectedItem.ToString();
                        rozkroj.kolor = cbKolor.SelectedItem.ToString();
                        rozkroj.material = cbMaterial.SelectedItem.ToString();
                        rozkroje.Add(rozkroj);
                    }
                    // UpdateRemainingLengthsAndQuantities(mostMatchingCombination, repetitions, remainingLengths, remainingQuantities);
                    listapasów = UpdatePasowObiekty(listapasów, repetitions, mostMatchingCombination);
                    remainingLengths.Clear();
                    remainingQuantities.Clear();
                    foreach (Pasy pasy in listapasów)
                    {

                        remainingLengths.Add(pasy.szerokosc);
                        remainingQuantities.Add(pasy.ilosc);

                    }
                    referencelist.Clear();
                    referencelist.AddRange(remainingLengths);
                    referencelist.AddRange(referencelist3);
                    allCombinations = GenerateAllCombinations(referencelist, arkusz);
                    dlugosci = remainingLengths;
                }
                else
                {
                    MessageBox.Show("Nie znaleziono pasującego rozkroju.");
                    break;
                }
            }
            MessageBox.Show("Kalkulacja zakończona powodzeniem");
            foreach (Rozkroj wyswietl in rozkroje)
            {
                Console.WriteLine("Rozkrój:");
                foreach (int pasy in wyswietl.rozkroj)
                {
                    Console.Write(pasy + ", ");
                }
                Console.WriteLine("\nIlość przejazdów: " + wyswietl.przejazdy);
            }
        }
        public static List<List<int>> GenerateAllCombinations(List<int> referencelist, int arkusz)
        {
            List<List<int>> allCombinations = new List<List<int>>();
            GenerateCombinations(new List<int>(), referencelist, arkusz, allCombinations);
            return allCombinations;
        }
        public static void GenerateCombinations(List<int> current, List<int> referencelist, int arkusz, List<List<int>> allCombinations)
        {
            int currentSum = current.Sum();
            if (currentSum <= arkusz && currentSum >= arkusz - 10)
            {
                allCombinations.Add(new List<int>(current));
            }
            if (currentSum >= arkusz) return;

            foreach (int item in referencelist)
            {
                List<int> newCombination = new List<int>(current) { item };
                GenerateCombinations(newCombination, referencelist, arkusz, allCombinations);
            }
        }
        public static List<int> FindMostMatchingCombination(List<List<int>> allCombinations, List<int> dlugosci)
        {
            List<int> mostMatchingCombination = null;
            int maxMatches = 0;

            foreach (var combination in allCombinations)
            {
                var matchingElements = combination.Intersect(dlugosci).Count();
                if (matchingElements > maxMatches)
                {
                    maxMatches = matchingElements;
                    mostMatchingCombination = combination;
                }
            }

            return mostMatchingCombination;
        }
        public static int CalculateRepetitions(List<int> combination, List<int> ilosciPasow, List<int> dlugosci)
        {
            int totalRepetitions = int.MaxValue;
            for (int i = 0; i < combination.Count; i++)
            {
                int index = dlugosci.IndexOf(combination[i]);
                if (index != -1)
                {
                    int repetitions = ilosciPasow[index] / combination.Count(x => x == combination[i]);
                    if (repetitions < totalRepetitions)
                    {
                        totalRepetitions = repetitions;
                    }
                }
            }
            return totalRepetitions;
        }
        public static void UpdateRemainingLengthsAndQuantities(List<int> combination, int repetitions, List<int> remainingLengths, List<int> remainingQuantities)
        {

            foreach (int item in combination)
            {
                int index = remainingLengths.IndexOf(item);
                if (index != -1)
                {
                    remainingQuantities[index] -= repetitions;
                    if (remainingQuantities[index] <= 0)
                    {
                        remainingQuantities[index] = 0;
                        remainingLengths[index] = 0;
                    }
                }
            }
        }
        private static List<Pasy> UpdatePasowObiekty(List<Pasy> listapasów, int repetitions, List<int> MostMatchingCombination)
        {

            List<Pasy> listapasów2 = new List<Pasy>();

            foreach (Pasy pasy in listapasów)
            {
                foreach (int length in MostMatchingCombination)
                {
                    if (pasy.szerokosc == length)
                    {
                        if (repetitions <= pasy.ilosc)
                            pasy.ilosc -= repetitions;
                        else
                            pasy.ilosc = 0;
                    }

                }
                if (pasy.ilosc > 0)
                {
                    Pasy pas = new Pasy();
                    pas.szerokosc = pasy.szerokosc;
                    pas.ilosc = pasy.ilosc;
                    listapasów2.Add(pas);
                }

            }


            return listapasów2;

        }
        private int IloscPrzejazdowObiekty(List<Pasy> listapasów, List<int> MostMatchingCombination)
        {
            int przejazdy = listapasów[0].ilosc;
            int dzielnik = 1;
            var duplikaty = MostMatchingCombination.GroupBy(x => x).Where(g => g.Count() == 2).Select(y => y.Key);

            if (duplikaty.Any())
            {
                dzielnik++;
             
            }
            var duplikaty2 = MostMatchingCombination.GroupBy(x => x).Where(g => g.Count() == 3).Select(y => y.Key);

            if (duplikaty.Any())
            {
                dzielnik++;
               
            }
            var duplikaty3 = MostMatchingCombination.GroupBy(x => x).Where(g => g.Count() == 4).Select(y => y.Key);

            if (duplikaty.Any())
            {
                dzielnik++;
               
            }

            foreach (Pasy pasy in listapasów)
            {
                foreach (int length in MostMatchingCombination)
                {
                    if (pasy.szerokosc == length)
                    {
                        if (przejazdy >= pasy.ilosc)
                            przejazdy = pasy.ilosc;

                    }
                }
            }
            if (dzielnik > 1)
            { przejazdy = przejazdy / dzielnik + 1; }



            return przejazdy;

        }
    }
}
