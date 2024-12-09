using System.Diagnostics;

namespace RGR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[][] firstArray =
            [
                [6, -5, -7, 4, -4],
                [-9, 3, -6, 5, 2],
                [-10, 4, 7, -6, 3],
                [-8, 9, -3, 3, -7]
            ];

            InitializeStartingGrid(firstArray);

            CountResults(firstArray);
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            ResetField();

            dataGridView.Rows.Add();
        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            ResetField();

            if (dataGridView.Rows.Count > 1)
            {
                dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 1);
            }
        }

        private void buttonAddColumn_Click(object sender, EventArgs e)
        {
            ResetField();

            dataGridView.Columns.Add("", "");
        }

        private void buttonDeleteColumn_Click(object sender, EventArgs e)
        {
            ResetField();

            if (dataGridView.ColumnCount > 1)
            {
                dataGridView.Columns.RemoveAt(dataGridView.ColumnCount - 1);
            }
        }

        private void buttonGenerate25x25_Click(object sender, EventArgs e)
        {
            ResetField();

            GenerateXbyX(25, 25);
        }

        private void buttonGenerate50x50_Click(object sender, EventArgs e)
        {
            ResetField();

            GenerateXbyX(50, 50);
        }

        private void buttonGenerate100x100_Click(object sender, EventArgs e)
        {
            ResetField();

            GenerateXbyX(100, 100);
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            int[][] array;

            try
            {
                array = ParseArrayFromDataGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("¬ведены некорректные значени€ €чеек", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            CountResults(array);
        }

        private void InitializeStartingGrid(int[][] array)
        {
            int columnsCount = array[0].Length;
            for (int i = 0; i < columnsCount; i++)
            {
                dataGridView.Columns.Add("", "");
            }

            // добавл€ем строки с данными
            foreach (var row in array)
            {
                dataGridView.Rows.Add(row.Cast<object>().ToArray());
            }
        }

        private int[][] ParseArrayFromDataGridView()
        {
            int[][] result = new int[dataGridView.Rows.Count][];

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                result[i] = new int[dataGridView.ColumnCount];

                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    result[i][j] = Convert.ToInt32(dataGridView.Rows[i].Cells[j].Value);
                }
            }

            return result;
        }

        private void CountResults(int[][] array)
        {
            Stopwatch sw = new();

            sw.Start();
            int sumBF = MaxWeightSubmatrix.FindMaxWeigthBruteForce(array,
                                                                   out int maxRecLeft,
                                                                   out int maxRecRight,
                                                                   out int maxRecTop,
                                                                   out int maxRecBottom);
            sw.Stop();

            textBoxBruteForceSeconds.Text = $"{(double)sw.ElapsedTicks / Stopwatch.Frequency * 1_000_000_000} нс";
            textBoxBruteForceResult.Text = sumBF.ToString();

            sw.Restart();
            int sumKanade = MaxWeightSubmatrix.FindMaxWeigthKadane(array,
                                                                   out maxRecLeft,
                                                                   out maxRecRight,
                                                                   out maxRecTop,
                                                                   out maxRecBottom);
            sw.Stop();

            textBoxKadaneSeconds.Text = $"{(double)sw.ElapsedTicks / Stopwatch.Frequency * 1_000_000_000} нс";
            textBoxKadaneResult.Text = sumKanade.ToString();

            // закрашиваем €чейки в найденной подматрице с макс. весом
            DrawColoredResultCells(maxRecLeft, maxRecRight, maxRecTop, maxRecBottom);
        }

        private void DrawColoredResultCells(int maxRecLeft, int maxRecRight, int maxRecTop, int maxRecBottom)
        {
            var highlightColor = Color.LightGreen;

            // очистка закраски €чеек, если они были закрашены
            ResetGridColor();

            // цикл по строкам и столбцам внутри заданных границ
            for (int i = maxRecTop; i <= maxRecBottom; i++)
            {
                for (int j = maxRecLeft; j <= maxRecRight; j++)
                {
                    // закрашиваем €чейку
                    dataGridView.Rows[i].Cells[j].Style.BackColor = highlightColor;
                }
            }
        }

        private void ResetField()
        {
            textBoxBruteForceSeconds.Text = string.Empty;
            textBoxBruteForceResult.Text = string.Empty;
            textBoxKadaneSeconds.Text = string.Empty;
            textBoxKadaneResult.Text = string.Empty;

            ResetGridColor();
        }

        private void ResetGridColor()
        {
            var defaultColor = Color.White;

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    dataGridView.Rows[i].Cells[j].Style.BackColor = defaultColor;
                }
            }
        }

        private void GenerateXbyX(int rows, int columns)
        {
            // создаем массив
            int[][] array = new int[rows][];
            Random random = new();

            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    array[i][j] = random.Next(-40, 41);
                }
            }

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // добавл€ем столбцы
            for (int i = 0; i < columns; i++)
            {
                dataGridView.Columns.Add("", "");
            }

            // заполн€ем DataGridView значени€ми из массива
            foreach (var row in array)
            {
                dataGridView.Rows.Add(row.Cast<object>().ToArray());
            }
        }
    }
}
