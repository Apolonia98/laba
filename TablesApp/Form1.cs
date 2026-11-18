using System;
using System.Drawing;
using System.Windows.Forms;
using TablesLibrary;

namespace TablesApp
{
    public class Form1 : Form
    {
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Label label1;
        private Label label2;

        private TableWorkshop[] workshops;
        private int total;

        public Form1()
        {
            Text = "Фабричний метод. Майстерні столів";
            Width = 860;
            Height = 500;
            StartPosition = FormStartPosition.CenterScreen;
            Font = new Font("Segoe UI", 10);

            workshops = new TableWorkshop[]
            {
                new DiningTableWorkshop(),
                new DeskWorkshop(),
                new CoffeeTableWorkshop()
            };

            label1 = new Label { Text = "Майстерня:", Left = 15, Top = 18, AutoSize = true };
            comboBox1 = new ComboBox { Left = 120, Top = 14, Width = 300, DropDownStyle = ComboBoxStyle.DropDownList };
            foreach (TableWorkshop w in workshops)
                comboBox1.Items.Add(w.workshopName);
            comboBox1.SelectedIndex = 0;

            button1 = new Button { Text = "Замовити стіл", Left = 440, Top = 12, Width = 160, Height = 32 };
            button2 = new Button { Text = "Очистити", Left = 615, Top = 12, Width = 120, Height = 32 };
            button1.Click += button1_Click;
            button2.Click += button2_Click;

            listBox1 = new ListBox { Left = 15, Top = 60, Width = 810, Height = 300, HorizontalScrollbar = true };
            label2 = new Label { Left = 15, Top = 375, Width = 810, Height = 60 };

            Controls.AddRange(new Control[] { label1, comboBox1, button1, button2, listBox1, label2 });
            ShowTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableWorkshop workshop = workshops[comboBox1.SelectedIndex];
            Table table = workshop.Order();
            total += table.price;
            listBox1.Items.Add(workshop.workshopName + ": " + table.Info());
            ShowTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            total = 0;
            foreach (TableWorkshop w in workshops)
                w.madeCount = 0;
            ShowTotal();
        }

        private void ShowTotal()
        {
            label2.Text = "Замовлено столів: " + listBox1.Items.Count + ", загальна сума: " + total + " грн\n"
                + "Обідніх: " + workshops[0].madeCount + ", письмових: " + workshops[1].madeCount
                + ", журнальних: " + workshops[2].madeCount;
        }
    }
}
