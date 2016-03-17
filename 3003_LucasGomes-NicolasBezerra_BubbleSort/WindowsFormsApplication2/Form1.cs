using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private BubbleSorting Bubble = new BubbleSorting();
        public List<int> Vetor = new List<int>();
        public Random numbers = new Random();
        public Stopwatch timer = new Stopwatch();
        public int elapsed;

        public void Add(List<int> Vetor, int a){
            for (int i = 0; i < a; i++)
                Vetor.Add(numbers.Next());
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            if (Vetor.Count < 10)
                Add(Vetor, 10);

            while (Vetor.Count <= 2000){
                Bubble.Sort(Vetor, numbers, timer);
                elapsed += timer.Elapsed.Milliseconds;
                chart1.Series["Tempo"].Points.AddXY(Vetor.Count,elapsed);
                Add(Vetor, 5);
            }
        }
    }
}
