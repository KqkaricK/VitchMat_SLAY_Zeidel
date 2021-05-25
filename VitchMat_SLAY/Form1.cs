using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
                                                                             // для теста:
namespace VitchMat_SLAY                                                      // 5  -1  3
{                                                                            // 2   3  25
    public partial class Form1 : DarkForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Razmer()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = Convert.ToInt32(t_raz.Text);
            dataGridView1.ColumnCount = Convert.ToInt32(t_raz.Text) + 1;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - 1].Style.BackColor = Color.LightGreen;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = 0;
                }
            }
            Cleaner();
        }
        double Slay(int i, int j)
        {
            return Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value.ToString());
        }
        void Cleaner()
        {
            dataGridView2.Rows.Clear();
            Alpha.Rows.Clear();
            Beta.Rows.Clear();
            TempX.Rows.Clear();
            TempX_Zeid.Rows.Clear();
            dataGridView2.RowCount = dataGridView1.RowCount;
            TempX.RowCount = dataGridView1.RowCount;
            TempX_Zeid.RowCount = dataGridView1.RowCount;
            Alpha.RowCount = dataGridView1.RowCount;
            Alpha.ColumnCount = dataGridView1.RowCount;
            Beta.RowCount = dataGridView1.RowCount;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = 0;
                TempX.Rows[i].Cells[0].Value = 0;
                TempX_Zeid.Rows[i].Cells[0].Value = 0;
            }
        }
        private void darkButton1_Click(object sender, EventArgs e)
        {
            if (Chek() == false)
            {
                MessageBox.Show("Размерность должна быть больше 1 и меньше 11");
            }
            else
            {
                Razmer();
                darkButton2.Enabled = true;
                darkButton3.Enabled = true;
            }
        }

        /*Ниже куча проверок*/

        bool IsNumber()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    double d;
                    if (Double.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out d) == false)
                    {
                        MessageBox.Show("Ошибка! Коэффициенты должны быть числами");
                        return false;
                    }
                }
            }
            return true;
        }
        bool Chek()
        {
            if (t_raz.Text == "")
            {
                return false;
            }
            else if (Convert.ToInt32(t_raz.Text) < 2 || Convert.ToInt32(t_raz.Text) > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void t_raz_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
        }
        private void t_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }
        bool ChekEpsilon(double E, DataGridView A)
        {
            double s = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                s += (Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value.ToString()) - Convert.ToDouble(A.Rows[i].Cells[0].Value.ToString())) * (Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value.ToString()) - Convert.ToDouble(A.Rows[i].Cells[0].Value.ToString()));
            }
            if (Math.Sqrt(s) < E)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*Куча проверок закончена*/

        private void darkButton2_Click_1(object sender, EventArgs e)
        {
           // Cleaner();
            int k = 1;
            if (IsNumber() == true)
            {
                if (t_e.Text == "")
                {
                    MessageBox.Show("Ошибка ввода E");
                }
                else
                {
                    double E = Convert.ToDouble("0," + t_e.Text);
                    for (int i = 0; i < dataGridView1.RowCount; i++) //Alpha i Beta
                    {
                        Beta.Rows[i].Cells[0].Value = Slay(i, dataGridView1.RowCount) / Slay(i, i);
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if (i == j)
                            {
                                Alpha.Rows[i].Cells[j].Value = 0;
                            }
                            else
                            {
                                Alpha.Rows[i].Cells[j].Value = -1 * (Slay(i, j) / Slay(i, i));
                            }
                        }
                    }
                    for (int i = 0; i < dataGridView1.RowCount; i++)  //1 raz
                    {
                        dataGridView2.Rows[i].Cells[0].Value = Beta.Rows[i].Cells[0].Value;
                    }
                    while (ChekEpsilon(E, TempX) == false)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            TempX.Rows[i].Cells[0].Value = dataGridView2.Rows[i].Cells[0].Value;
                        }
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            dataGridView2.Rows[i].Cells[0].Value = 0;
                            for (int j = 0; j < dataGridView1.RowCount; j++)
                            {
                                dataGridView2.Rows[i].Cells[0].Value = Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value.ToString()) + (Convert.ToDouble(Alpha.Rows[i].Cells[j].Value.ToString()) * Convert.ToDouble(TempX.Rows[j].Cells[0].Value.ToString()));
                            }
                            dataGridView2.Rows[i].Cells[0].Value = Convert.ToDouble(Beta.Rows[i].Cells[0].Value.ToString()) + Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value.ToString());
                        }
                        k++;
                    }
                    l_k.Text = k.ToString();
                }
            }
        }

        private void darkButton3_Click(object sender, EventArgs e)
        {
            Cleaner();
            int k = 1;
            if (IsNumber() == true)
            {
                if (t_e.Text == "")
                {
                    MessageBox.Show("Ошибка ввода E");
                }
                else
                {
                    double E = Convert.ToDouble("0," + t_e.Text);
                    for (int i = 0; i < dataGridView1.RowCount; i++) //Alpha i Beta
                    {
                        Beta.Rows[i].Cells[0].Value = Slay(i, dataGridView1.RowCount) / Slay(i, i);
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if (i == j)
                            {
                                Alpha.Rows[i].Cells[j].Value = 0;
                            }
                            else
                            {
                                Alpha.Rows[i].Cells[j].Value = -1 * (Slay(i, j) / Slay(i, i));
                            }
                        }
                    }
                    for (int i = 0; i < dataGridView1.RowCount; i++) // 1 raz
                    {
                        TempX_Zeid.Rows[i].Cells[0].Value = dataGridView2.Rows[i].Cells[0].Value;
                        dataGridView2.Rows[i].Cells[0].Value = 0;
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            dataGridView2.Rows[i].Cells[0].Value = Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value.ToString()) + (Convert.ToDouble(Alpha.Rows[i].Cells[j].Value.ToString()) * Convert.ToDouble(TempX.Rows[j].Cells[0].Value.ToString()));
                        }
                        dataGridView2.Rows[i].Cells[0].Value = Convert.ToDouble(Beta.Rows[i].Cells[0].Value.ToString()) + Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value.ToString());
                        TempX.Rows[i].Cells[0].Value = dataGridView2.Rows[i].Cells[0].Value;
                    }
                    while (ChekEpsilon(E, TempX_Zeid) == false)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            TempX_Zeid.Rows[i].Cells[0].Value = dataGridView2.Rows[i].Cells[0].Value;
                            dataGridView2.Rows[i].Cells[0].Value = 0;
                            for (int j = 0; j < dataGridView1.RowCount; j++)
                            {
                                dataGridView2.Rows[i].Cells[0].Value = Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value.ToString()) + (Convert.ToDouble(Alpha.Rows[i].Cells[j].Value.ToString()) * Convert.ToDouble(TempX.Rows[j].Cells[0].Value.ToString()));
                            }
                            dataGridView2.Rows[i].Cells[0].Value = Convert.ToDouble(Beta.Rows[i].Cells[0].Value.ToString()) + Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value.ToString());
                            TempX.Rows[i].Cells[0].Value = dataGridView2.Rows[i].Cells[0].Value;
                        }
                        k++;
                    }
                    l_k.Text = k.ToString();
                }
            }
        }
    }
}
