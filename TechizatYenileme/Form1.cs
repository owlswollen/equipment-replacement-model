using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechizatYenileme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int replacementAge;
        double equipmentPrice;
        int age;
        int replacementSpan;
        int vertical, horizontal;
        TextBox[,] inputs;
        double[] r;
        double[] c;
        double[] s;
        double[,] f;
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double[,] keepResults = new double[replacementSpan+1, replacementAge + 2];
            double[,] replaceResults = new double[replacementSpan+1, replacementAge + 2];
            Array.Clear(keepResults, 0, keepResults.Length);
            Array.Clear(replaceResults, 0, replaceResults.Length);

            r = new double[replacementAge + 1];
            c = new double[replacementAge + 1];
            s = new double[replacementAge + 1];
            for (int i = 0; i < replacementAge + 1; i++)
            {
                r[i] = Convert.ToDouble(inputs[i, 1].Text);
                c[i] = Convert.ToDouble(inputs[i, 2].Text);
                s[i] = Convert.ToDouble(inputs[i, 3].Text);
            }

            f = new double[replacementSpan+1, replacementAge + 2];

            for (int i = replacementSpan - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == replacementSpan - 1)
                    {
                        if (j != replacementAge)
                        {
                            keepResults[i, j] = r[j] - c[j] + s[j+1];
                        }
                        replaceResults[i, j] = r[0] + s[j] + s[1] - c[0] - equipmentPrice;
                        f[i, j] = Math.Max(keepResults[i, j], replaceResults[i, j]);
                    }
                    else
                    {
                        keepResults[i, j] = r[j] - c[j] + f[i + 1, j + 1];
                        replaceResults[i, j] = r[0] + f[i + 1, 1] + s[j] - c[0] - equipmentPrice;
                        f[i, j] = Math.Max(keepResults[i, j], replaceResults[i, j]);
                    }
                }
                if (i + age <= replacementAge)
                {
                    if (i == replacementSpan - 1)
                    {
                        if (i + age != replacementAge)
                        {
                            keepResults[i, i + age] = r[i + age] - c[i + age] + s[i + age + 1];
                        }
                        replaceResults[i, i + age] = r[0] + s[i + age] + s[1] - c[0] - equipmentPrice;
                        f[i, i + age] = Math.Max(keepResults[i, i + age], replaceResults[i, i + age]);
                    }
                    else
                    {
                        keepResults[i, i + age] = r[i + age] - c[i + age] + f[i + 1, i + age + 1];
                        replaceResults[i, i + age] = r[0] + f[i + 1, 1] + s[i + age] - c[0] - equipmentPrice;
                        f[i, i + age] = Math.Max(keepResults[i, i + age], replaceResults[i, i + age]);
                    }
                }
            }
            int yas = age;
            int yil = 0;
            label1.Text = "Karar degiskenleri:\n";
            while (yil < replacementSpan)
            {
                if (keepResults[yil, yas] > replaceResults[yil, yas])
                {
                    yas++;
                    label1.Text += "K";
                }
                else
                {
                    yas = 1;
                    label1.Text += "R";
                }
                yil++;
            }
            label1.Text += "\nSonuc: " +  f[0,age];
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            replacementAge = Convert.ToInt32(textBoxReplacementAge.Text);
            equipmentPrice = Convert.ToDouble(textBoxEquipmentPrice.Text);
            age = Convert.ToInt32(textBoxEquipmentAge.Text);
            replacementSpan = Convert.ToInt32(textBoxReplacementSpan.Text);
            labelAge.Visible = true;
            labelRevenue.Visible = true;
            labelCost.Visible = true;
            labelSalvage.Visible = true;
            buttonCalc.Visible = true;

            inputs = new TextBox[replacementAge + 1, 4];

            vertical = 30;
            for (int i = 0; i < replacementAge + 1; i++)
            {
                horizontal = 280;
                for (int j = 0; j < 4; j++)
                {
                    inputs[i, j] = new TextBox();
                    inputs[i, j].Size = new Size(60, 60);
                    inputs[i, j].Location = new Point(horizontal, vertical);
                    horizontal += 120;
                    this.Controls.Add(inputs[i, j]);

                    if (j == 0)
                    {
                        inputs[i, j].Text = i.ToString();

                        inputs[i, j].Enabled = false;
                    }
                    
                }
                vertical += 30;
            }
            inputs[0, 3].Text = "0";
            inputs[0, 3].Enabled = false;
        }
    }
}
