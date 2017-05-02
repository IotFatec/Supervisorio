namespace Supervisorio
{
    partial class FormDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEst1 = new System.Windows.Forms.Button();
            this.btnEst2 = new System.Windows.Forms.Button();
            this.btnEst3 = new System.Windows.Forms.Button();
            this.btnEst4 = new System.Windows.Forms.Button();
            this.btnEst5 = new System.Windows.Forms.Button();
            this.btnEst6 = new System.Windows.Forms.Button();
            this.btnEst7 = new System.Windows.Forms.Button();
            this.btnEst8 = new System.Windows.Forms.Button();
            this.btnEst9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richInformacoes = new System.Windows.Forms.RichTextBox();
            this.chGrafGeral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrateleira = new System.Windows.Forms.Label();
            this.chGrafIndivid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGrafGeral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGrafIndivid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(791, 520);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(331, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(246, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ATUALIZAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEst1);
            this.flowLayoutPanel1.Controls.Add(this.btnEst2);
            this.flowLayoutPanel1.Controls.Add(this.btnEst3);
            this.flowLayoutPanel1.Controls.Add(this.btnEst4);
            this.flowLayoutPanel1.Controls.Add(this.btnEst5);
            this.flowLayoutPanel1.Controls.Add(this.btnEst6);
            this.flowLayoutPanel1.Controls.Add(this.btnEst7);
            this.flowLayoutPanel1.Controls.Add(this.btnEst8);
            this.flowLayoutPanel1.Controls.Add(this.btnEst9);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 166);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(321, 320);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnEst1
            // 
            this.btnEst1.BackColor = System.Drawing.Color.Silver;
            this.btnEst1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEst1.FlatAppearance.BorderSize = 0;
            this.btnEst1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEst1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEst1.ForeColor = System.Drawing.Color.White;
            this.btnEst1.Location = new System.Drawing.Point(3, 3);
            this.btnEst1.Name = "btnEst1";
            this.btnEst1.Size = new System.Drawing.Size(100, 100);
            this.btnEst1.TabIndex = 0;
            this.btnEst1.Text = "0";
            this.btnEst1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEst1.UseVisualStyleBackColor = false;
            this.btnEst1.Click += new System.EventHandler(this.btnEst1_Click);
            // 
            // btnEst2
            // 
            this.btnEst2.BackColor = System.Drawing.Color.Silver;
            this.btnEst2.FlatAppearance.BorderSize = 0;
            this.btnEst2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEst2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEst2.ForeColor = System.Drawing.Color.White;
            this.btnEst2.Location = new System.Drawing.Point(109, 3);
            this.btnEst2.Name = "btnEst2";
            this.btnEst2.Size = new System.Drawing.Size(100, 100);
            this.btnEst2.TabIndex = 1;
            this.btnEst2.Text = "0";
            this.btnEst2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEst2.UseVisualStyleBackColor = false;
            this.btnEst2.Click += new System.EventHandler(this.btnEst2_Click);
            // 
            // btnEst3
            // 
            this.btnEst3.BackColor = System.Drawing.Color.Silver;
            this.btnEst3.FlatAppearance.BorderSize = 0;
            this.btnEst3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEst3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEst3.ForeColor = System.Drawing.Color.White;
            this.btnEst3.Location = new System.Drawing.Point(215, 3);
            this.btnEst3.Name = "btnEst3";
            this.btnEst3.Size = new System.Drawing.Size(100, 100);
            this.btnEst3.TabIndex = 2;
            this.btnEst3.Text = "0";
            this.btnEst3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEst3.UseVisualStyleBackColor = false;
            this.btnEst3.Click += new System.EventHandler(this.btnEst3_Click);
            // 
            // btnEst4
            // 
            this.btnEst4.BackColor = System.Drawing.Color.Silver;
            this.btnEst4.FlatAppearance.BorderSize = 0;
            this.btnEst4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEst4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEst4.ForeColor = System.Drawing.Color.White;
            this.btnEst4.Location = new System.Drawing.Point(3, 109);
            this.btnEst4.Name = "btnEst4";
            this.btnEst4.Size = new System.Drawing.Size(100, 100);
            this.btnEst4.TabIndex = 3;
            this.btnEst4.Text = "0";
            this.btnEst4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEst4.UseVisualStyleBackColor = false;
            this.btnEst4.Click += new System.EventHandler(this.btnEst4_Click);
            // 
            // btnEst5
            // 
            this.btnEst5.BackColor = System.Drawing.Color.Silver;
            this.btnEst5.FlatAppearance.BorderSize = 0;
            this.btnEst5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEst5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEst5.ForeColor = System.Drawing.Color.White;
            this.btnEst5.Location = new System.Drawing.Point(109, 109);
            this.btnEst5.Name = "btnEst5";
            this.btnEst5.Size = new System.Drawing.Size(100, 100);
            this.btnEst5.TabIndex = 4;
            this.btnEst5.Text = "0";
            this.btnEst5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEst5.UseVisualStyleBackColor = false;
            this.btnEst5.Click += new System.EventHandler(this.btnEst5_Click);
            // 
            // btnEst6
            // 
            this.btnEst6.BackColor = System.Drawing.Color.Silver;
            this.btnEst6.FlatAppearance.BorderSize = 0;
            this.btnEst6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEst6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEst6.ForeColor = System.Drawing.Color.White;
            this.btnEst6.Location = new System.Drawing.Point(215, 109);
            this.btnEst6.Name = "btnEst6";
            this.btnEst6.Size = new System.Drawing.Size(100, 100);
            this.btnEst6.TabIndex = 5;
            this.btnEst6.Text = "0";
            this.btnEst6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEst6.UseVisualStyleBackColor = false;
            this.btnEst6.Click += new System.EventHandler(this.btnEst6_Click);
            // 
            // btnEst7
            // 
            this.btnEst7.BackColor = System.Drawing.Color.Silver;
            this.btnEst7.FlatAppearance.BorderSize = 0;
            this.btnEst7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEst7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEst7.ForeColor = System.Drawing.Color.White;
            this.btnEst7.Location = new System.Drawing.Point(3, 215);
            this.btnEst7.Name = "btnEst7";
            this.btnEst7.Size = new System.Drawing.Size(100, 100);
            this.btnEst7.TabIndex = 6;
            this.btnEst7.Text = "0";
            this.btnEst7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEst7.UseVisualStyleBackColor = false;
            this.btnEst7.Click += new System.EventHandler(this.btnEst7_Click);
            // 
            // btnEst8
            // 
            this.btnEst8.BackColor = System.Drawing.Color.Silver;
            this.btnEst8.FlatAppearance.BorderSize = 0;
            this.btnEst8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEst8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEst8.ForeColor = System.Drawing.Color.White;
            this.btnEst8.Location = new System.Drawing.Point(109, 215);
            this.btnEst8.Name = "btnEst8";
            this.btnEst8.Size = new System.Drawing.Size(100, 100);
            this.btnEst8.TabIndex = 7;
            this.btnEst8.Text = "0";
            this.btnEst8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEst8.UseVisualStyleBackColor = false;
            this.btnEst8.Click += new System.EventHandler(this.btnEst8_Click);
            // 
            // btnEst9
            // 
            this.btnEst9.BackColor = System.Drawing.Color.Silver;
            this.btnEst9.FlatAppearance.BorderSize = 0;
            this.btnEst9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEst9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEst9.ForeColor = System.Drawing.Color.White;
            this.btnEst9.Location = new System.Drawing.Point(215, 215);
            this.btnEst9.Name = "btnEst9";
            this.btnEst9.Size = new System.Drawing.Size(100, 100);
            this.btnEst9.TabIndex = 8;
            this.btnEst9.Text = "0";
            this.btnEst9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEst9.UseVisualStyleBackColor = false;
            this.btnEst9.Click += new System.EventHandler(this.btnEst9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 114);
            this.label1.TabIndex = 3;
            this.label1.Text = "DADOS ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.richInformacoes);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(31, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMAÇÕES";
            // 
            // richInformacoes
            // 
            this.richInformacoes.BackColor = System.Drawing.SystemColors.Control;
            this.richInformacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richInformacoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richInformacoes.ForeColor = System.Drawing.Color.Black;
            this.richInformacoes.Location = new System.Drawing.Point(6, 28);
            this.richInformacoes.Name = "richInformacoes";
            this.richInformacoes.Size = new System.Drawing.Size(542, 137);
            this.richInformacoes.TabIndex = 0;
            this.richInformacoes.Text = "";
            // 
            // chGrafGeral
            // 
            chartArea7.Name = "ChartArea1";
            this.chGrafGeral.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chGrafGeral.Legends.Add(legend7);
            this.chGrafGeral.Location = new System.Drawing.Point(400, 166);
            this.chGrafGeral.Name = "chGrafGeral";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chGrafGeral.Series.Add(series7);
            this.chGrafGeral.Size = new System.Drawing.Size(331, 320);
            this.chGrafGeral.TabIndex = 5;
            this.chGrafGeral.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(34, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "TRANSELEVADOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(396, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "DADOS GERAIS";
            // 
            // lblPrateleira
            // 
            this.lblPrateleira.AutoSize = true;
            this.lblPrateleira.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrateleira.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrateleira.Location = new System.Drawing.Point(787, 141);
            this.lblPrateleira.Name = "lblPrateleira";
            this.lblPrateleira.Size = new System.Drawing.Size(293, 22);
            this.lblPrateleira.TabIndex = 9;
            this.lblPrateleira.Text = "SELECIONE UMA PRATELEIRA";
            // 
            // chGrafIndivid
            // 
            chartArea8.Name = "ChartArea1";
            this.chGrafIndivid.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chGrafIndivid.Legends.Add(legend8);
            this.chGrafIndivid.Location = new System.Drawing.Point(791, 166);
            this.chGrafIndivid.Name = "chGrafIndivid";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chGrafIndivid.Series.Add(series8);
            this.chGrafIndivid.Size = new System.Drawing.Size(331, 320);
            this.chGrafIndivid.TabIndex = 8;
            this.chGrafIndivid.Text = "chart2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(787, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "TABELA DE DADOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(554, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 151);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 675);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrateleira);
            this.Controls.Add(this.chGrafIndivid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chGrafGeral);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDados";
            this.Text = "Graficos";
            this.Load += new System.EventHandler(this.FormDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chGrafGeral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGrafIndivid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEst1;
        private System.Windows.Forms.Button btnEst2;
        private System.Windows.Forms.Button btnEst3;
        private System.Windows.Forms.Button btnEst4;
        private System.Windows.Forms.Button btnEst5;
        private System.Windows.Forms.Button btnEst6;
        private System.Windows.Forms.Button btnEst7;
        private System.Windows.Forms.Button btnEst8;
        private System.Windows.Forms.Button btnEst9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGrafGeral;
        private System.Windows.Forms.RichTextBox richInformacoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrateleira;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGrafIndivid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}