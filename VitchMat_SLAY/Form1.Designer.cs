
namespace VitchMat_SLAY
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.t_raz = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.t_e = new DarkUI.Controls.DarkTextBox();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.Alpha = new System.Windows.Forms.DataGridView();
            this.Beta = new System.Windows.Forms.DataGridView();
            this.TempX = new System.Windows.Forms.DataGridView();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.darkButton3 = new DarkUI.Controls.DarkButton();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.l_k = new DarkUI.Controls.DarkLabel();
            this.TempX_Zeid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Beta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempX_Zeid)).BeginInit();
            this.SuspendLayout();
            // 
            // t_raz
            // 
            this.t_raz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.t_raz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_raz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.t_raz.Location = new System.Drawing.Point(96, 16);
            this.t_raz.Name = "t_raz";
            this.t_raz.Size = new System.Drawing.Size(51, 20);
            this.t_raz.TabIndex = 0;
            this.t_raz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_raz_KeyPress);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(12, 18);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(78, 13);
            this.darkLabel1.TabIndex = 1;
            this.darkLabel1.Text = "Размерность:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(474, 203);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(391, 13);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(94, 23);
            this.darkButton1.TabIndex = 50;
            this.darkButton1.Text = "Создать СЛАУ";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(498, 41);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(73, 203);
            this.dataGridView2.TabIndex = 51;
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(495, 23);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(41, 13);
            this.darkLabel2.TabIndex = 54;
            this.darkLabel2.Text = "Корни:";
            // 
            // darkButton2
            // 
            this.darkButton2.Enabled = false;
            this.darkButton2.Location = new System.Drawing.Point(383, 283);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(102, 23);
            this.darkButton2.TabIndex = 55;
            this.darkButton2.Text = "Метод Прост. Ит";
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click_1);
            // 
            // t_e
            // 
            this.t_e.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.t_e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_e.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.t_e.Location = new System.Drawing.Point(264, 16);
            this.t_e.Name = "t_e";
            this.t_e.Size = new System.Drawing.Size(51, 20);
            this.t_e.TabIndex = 62;
            this.t_e.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_e_KeyPress);
            // 
            // darkLabel6
            // 
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(159, 18);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(105, 13);
            this.darkLabel6.TabIndex = 63;
            this.darkLabel6.Text = "Погрешность e = 0,";
            // 
            // Alpha
            // 
            this.Alpha.AllowUserToAddRows = false;
            this.Alpha.AllowUserToDeleteRows = false;
            this.Alpha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Alpha.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Alpha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Alpha.ColumnHeadersVisible = false;
            this.Alpha.Location = new System.Drawing.Point(34, 255);
            this.Alpha.Margin = new System.Windows.Forms.Padding(2);
            this.Alpha.Name = "Alpha";
            this.Alpha.ReadOnly = true;
            this.Alpha.RowHeadersVisible = false;
            this.Alpha.RowHeadersWidth = 51;
            this.Alpha.RowTemplate.Height = 24;
            this.Alpha.Size = new System.Drawing.Size(203, 203);
            this.Alpha.TabIndex = 64;
            // 
            // Beta
            // 
            this.Beta.AllowUserToAddRows = false;
            this.Beta.AllowUserToDeleteRows = false;
            this.Beta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Beta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Beta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Beta.ColumnHeadersVisible = false;
            this.Beta.Location = new System.Drawing.Point(282, 255);
            this.Beta.Margin = new System.Windows.Forms.Padding(2);
            this.Beta.Name = "Beta";
            this.Beta.ReadOnly = true;
            this.Beta.RowHeadersVisible = false;
            this.Beta.RowHeadersWidth = 51;
            this.Beta.RowTemplate.Height = 24;
            this.Beta.Size = new System.Drawing.Size(73, 203);
            this.Beta.TabIndex = 65;
            // 
            // TempX
            // 
            this.TempX.AllowUserToAddRows = false;
            this.TempX.AllowUserToDeleteRows = false;
            this.TempX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TempX.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TempX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TempX.ColumnHeadersVisible = false;
            this.TempX.Location = new System.Drawing.Point(603, 41);
            this.TempX.Margin = new System.Windows.Forms.Padding(2);
            this.TempX.Name = "TempX";
            this.TempX.ReadOnly = true;
            this.TempX.RowHeadersVisible = false;
            this.TempX.RowHeadersWidth = 51;
            this.TempX.RowTemplate.Height = 24;
            this.TempX.Size = new System.Drawing.Size(73, 203);
            this.TempX.TabIndex = 66;
            this.TempX.Visible = false;
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(12, 255);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(17, 13);
            this.darkLabel3.TabIndex = 67;
            this.darkLabel3.Text = "α:";
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(261, 255);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(16, 13);
            this.darkLabel4.TabIndex = 68;
            this.darkLabel4.Text = "β:";
            // 
            // darkButton3
            // 
            this.darkButton3.Enabled = false;
            this.darkButton3.Location = new System.Drawing.Point(383, 312);
            this.darkButton3.Name = "darkButton3";
            this.darkButton3.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton3.Size = new System.Drawing.Size(102, 23);
            this.darkButton3.TabIndex = 69;
            this.darkButton3.Text = "Метод Зейделя";
            this.darkButton3.Click += new System.EventHandler(this.darkButton3_Click);
            // 
            // darkLabel5
            // 
            this.darkLabel5.AutoSize = true;
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(380, 255);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(94, 13);
            this.darkLabel5.TabIndex = 70;
            this.darkLabel5.Text = "Число Итераций:";
            // 
            // l_k
            // 
            this.l_k.AutoSize = true;
            this.l_k.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.l_k.Location = new System.Drawing.Point(480, 255);
            this.l_k.Name = "l_k";
            this.l_k.Size = new System.Drawing.Size(10, 13);
            this.l_k.TabIndex = 71;
            this.l_k.Text = "-";
            // 
            // TempX_Zeid
            // 
            this.TempX_Zeid.AllowUserToAddRows = false;
            this.TempX_Zeid.AllowUserToDeleteRows = false;
            this.TempX_Zeid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TempX_Zeid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TempX_Zeid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TempX_Zeid.ColumnHeadersVisible = false;
            this.TempX_Zeid.Location = new System.Drawing.Point(703, 41);
            this.TempX_Zeid.Margin = new System.Windows.Forms.Padding(2);
            this.TempX_Zeid.Name = "TempX_Zeid";
            this.TempX_Zeid.ReadOnly = true;
            this.TempX_Zeid.RowHeadersVisible = false;
            this.TempX_Zeid.RowHeadersWidth = 51;
            this.TempX_Zeid.RowTemplate.Height = 24;
            this.TempX_Zeid.Size = new System.Drawing.Size(73, 203);
            this.TempX_Zeid.TabIndex = 72;
            this.TempX_Zeid.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 471);
            this.Controls.Add(this.TempX_Zeid);
            this.Controls.Add(this.l_k);
            this.Controls.Add(this.darkLabel5);
            this.Controls.Add(this.darkButton3);
            this.Controls.Add(this.darkLabel4);
            this.Controls.Add(this.darkLabel3);
            this.Controls.Add(this.TempX);
            this.Controls.Add(this.Beta);
            this.Controls.Add(this.Alpha);
            this.Controls.Add(this.darkLabel6);
            this.Controls.Add(this.t_e);
            this.Controls.Add(this.darkButton2);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.t_raz);
            this.Name = "Form1";
            this.Text = "Решение СЛАУ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Beta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempX_Zeid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkTextBox t_raz;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DarkUI.Controls.DarkButton darkButton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkButton darkButton2;
        private DarkUI.Controls.DarkTextBox t_e;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private System.Windows.Forms.DataGridView Alpha;
        private System.Windows.Forms.DataGridView Beta;
        private System.Windows.Forms.DataGridView TempX;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkButton darkButton3;
        private DarkUI.Controls.DarkLabel darkLabel5;
        private DarkUI.Controls.DarkLabel l_k;
        private System.Windows.Forms.DataGridView TempX_Zeid;
    }
}

