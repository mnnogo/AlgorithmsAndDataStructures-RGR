namespace RGR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            label1 = new Label();
            textBoxBruteForceSeconds = new TextBox();
            textBoxKadaneSeconds = new TextBox();
            label2 = new Label();
            textBoxBruteForceResult = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxKadaneResult = new TextBox();
            buttonAddRow = new Button();
            buttonDeleteRow = new Button();
            buttonDeleteColumn = new Button();
            buttonAddColumn = new Button();
            buttonCount = new Button();
            buttonGenerate50x50 = new Button();
            buttonGenerate25x25 = new Button();
            buttonGenerate100x100 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.Location = new Point(24, 27);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(570, 325);
            dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 396);
            label1.Name = "label1";
            label1.Size = new Size(226, 15);
            label1.TabIndex = 1;
            label1.Text = "Затраченное время методом перебора:";
            // 
            // textBoxBruteForceSeconds
            // 
            textBoxBruteForceSeconds.Location = new Point(244, 393);
            textBoxBruteForceSeconds.Name = "textBoxBruteForceSeconds";
            textBoxBruteForceSeconds.ReadOnly = true;
            textBoxBruteForceSeconds.Size = new Size(147, 23);
            textBoxBruteForceSeconds.TabIndex = 2;
            // 
            // textBoxKadaneSeconds
            // 
            textBoxKadaneSeconds.Location = new Point(244, 432);
            textBoxKadaneSeconds.Name = "textBoxKadaneSeconds";
            textBoxKadaneSeconds.ReadOnly = true;
            textBoxKadaneSeconds.Size = new Size(147, 23);
            textBoxKadaneSeconds.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 435);
            label2.Name = "label2";
            label2.Size = new Size(231, 15);
            label2.TabIndex = 3;
            label2.Text = "Затраченное время алгоритмом Кадане:";
            // 
            // textBoxBruteForceResult
            // 
            textBoxBruteForceResult.Location = new Point(659, 393);
            textBoxBruteForceResult.Name = "textBoxBruteForceResult";
            textBoxBruteForceResult.ReadOnly = true;
            textBoxBruteForceResult.Size = new Size(114, 23);
            textBoxBruteForceResult.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 396);
            label3.Name = "label3";
            label3.Size = new Size(191, 15);
            label3.TabIndex = 5;
            label3.Text = "Максимальный вес подматрицы:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 435);
            label4.Name = "label4";
            label4.Size = new Size(191, 15);
            label4.TabIndex = 7;
            label4.Text = "Максимальный вес подматрицы:";
            // 
            // textBoxKadaneResult
            // 
            textBoxKadaneResult.Location = new Point(659, 430);
            textBoxKadaneResult.Name = "textBoxKadaneResult";
            textBoxKadaneResult.ReadOnly = true;
            textBoxKadaneResult.Size = new Size(114, 23);
            textBoxKadaneResult.TabIndex = 8;
            // 
            // buttonAddRow
            // 
            buttonAddRow.Location = new Point(630, 39);
            buttonAddRow.Name = "buttonAddRow";
            buttonAddRow.Size = new Size(143, 23);
            buttonAddRow.TabIndex = 9;
            buttonAddRow.Text = "Добавить строку";
            buttonAddRow.UseVisualStyleBackColor = true;
            buttonAddRow.Click += buttonAddRow_Click;
            // 
            // buttonDeleteRow
            // 
            buttonDeleteRow.Location = new Point(630, 68);
            buttonDeleteRow.Name = "buttonDeleteRow";
            buttonDeleteRow.Size = new Size(143, 23);
            buttonDeleteRow.TabIndex = 10;
            buttonDeleteRow.Text = "Удалить строку";
            buttonDeleteRow.UseVisualStyleBackColor = true;
            buttonDeleteRow.Click += buttonDeleteRow_Click;
            // 
            // buttonDeleteColumn
            // 
            buttonDeleteColumn.Location = new Point(630, 143);
            buttonDeleteColumn.Name = "buttonDeleteColumn";
            buttonDeleteColumn.Size = new Size(143, 23);
            buttonDeleteColumn.TabIndex = 11;
            buttonDeleteColumn.Text = "Удалить столбец";
            buttonDeleteColumn.UseVisualStyleBackColor = true;
            buttonDeleteColumn.Click += buttonDeleteColumn_Click;
            // 
            // buttonAddColumn
            // 
            buttonAddColumn.Location = new Point(630, 114);
            buttonAddColumn.Name = "buttonAddColumn";
            buttonAddColumn.Size = new Size(143, 23);
            buttonAddColumn.TabIndex = 12;
            buttonAddColumn.Text = "Добавить столбец";
            buttonAddColumn.UseVisualStyleBackColor = true;
            buttonAddColumn.Click += buttonAddColumn_Click;
            // 
            // buttonCount
            // 
            buttonCount.Location = new Point(630, 300);
            buttonCount.Name = "buttonCount";
            buttonCount.Size = new Size(143, 42);
            buttonCount.TabIndex = 13;
            buttonCount.Text = "Посчитать";
            buttonCount.UseVisualStyleBackColor = true;
            buttonCount.Click += buttonCount_Click;
            // 
            // buttonGenerate50x50
            // 
            buttonGenerate50x50.Location = new Point(630, 218);
            buttonGenerate50x50.Name = "buttonGenerate50x50";
            buttonGenerate50x50.Size = new Size(143, 25);
            buttonGenerate50x50.TabIndex = 14;
            buttonGenerate50x50.Text = "Сгенерировать 50х50";
            buttonGenerate50x50.UseVisualStyleBackColor = true;
            buttonGenerate50x50.Click += buttonGenerate50x50_Click;
            // 
            // buttonGenerate25x25
            // 
            buttonGenerate25x25.Location = new Point(630, 187);
            buttonGenerate25x25.Name = "buttonGenerate25x25";
            buttonGenerate25x25.Size = new Size(143, 25);
            buttonGenerate25x25.TabIndex = 15;
            buttonGenerate25x25.Text = "Сгенерировать 25х25";
            buttonGenerate25x25.UseVisualStyleBackColor = true;
            buttonGenerate25x25.Click += buttonGenerate25x25_Click;
            // 
            // buttonGenerate100x100
            // 
            buttonGenerate100x100.Location = new Point(630, 249);
            buttonGenerate100x100.Name = "buttonGenerate100x100";
            buttonGenerate100x100.Size = new Size(143, 25);
            buttonGenerate100x100.TabIndex = 16;
            buttonGenerate100x100.Text = "Сгенерировать 100х100";
            buttonGenerate100x100.UseVisualStyleBackColor = true;
            buttonGenerate100x100.Click += buttonGenerate100x100_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(buttonGenerate100x100);
            Controls.Add(buttonGenerate25x25);
            Controls.Add(buttonGenerate50x50);
            Controls.Add(buttonCount);
            Controls.Add(buttonAddColumn);
            Controls.Add(buttonDeleteColumn);
            Controls.Add(buttonDeleteRow);
            Controls.Add(buttonAddRow);
            Controls.Add(textBoxKadaneResult);
            Controls.Add(label4);
            Controls.Add(textBoxBruteForceResult);
            Controls.Add(label3);
            Controls.Add(textBoxKadaneSeconds);
            Controls.Add(label2);
            Controls.Add(textBoxBruteForceSeconds);
            Controls.Add(label1);
            Controls.Add(dataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Самая тяжелая подтаблица";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label label1;
        private TextBox textBoxBruteForceSeconds;
        private TextBox textBoxKadaneSeconds;
        private Label label2;
        private TextBox textBoxBruteForceResult;
        private Label label3;
        private Label label4;
        private TextBox textBoxKadaneResult;
        private Button buttonAddRow;
        private Button buttonDeleteRow;
        private Button buttonDeleteColumn;
        private Button buttonAddColumn;
        private Button buttonCount;
        private Button buttonGenerate50x50;
        private Button buttonGenerate25x25;
        private Button buttonGenerate100x100;
    }
}
