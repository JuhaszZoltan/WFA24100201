namespace WFA24100201
{
    partial class FrmAlapmuveletek
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
            lblUI01 = new Label();
            txbAdat01 = new TextBox();
            btnOsszeadas = new Button();
            btnKivonas = new Button();
            btnSzorzas = new Button();
            btnOsztas = new Button();
            lblUI02 = new Label();
            txbAdat02 = new TextBox();
            txbEredmeny = new TextBox();
            label3 = new Label();
            lblMuvelet = new Label();
            btnTorles = new Button();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Font = new Font("Segoe UI", 10F);
            lblUI01.Location = new Point(14, 30);
            lblUI01.Margin = new Padding(5, 0, 5, 0);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(54, 19);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "1. adat:";
            // 
            // txbAdat01
            // 
            txbAdat01.Location = new Point(14, 54);
            txbAdat01.Margin = new Padding(5);
            txbAdat01.Name = "txbAdat01";
            txbAdat01.Size = new Size(117, 32);
            txbAdat01.TabIndex = 1;
            // 
            // btnOsszeadas
            // 
            btnOsszeadas.Font = new Font("Segoe UI", 20F);
            btnOsszeadas.Location = new Point(141, 14);
            btnOsszeadas.Margin = new Padding(5);
            btnOsszeadas.Name = "btnOsszeadas";
            btnOsszeadas.Size = new Size(50, 50);
            btnOsszeadas.TabIndex = 2;
            btnOsszeadas.Text = "+";
            btnOsszeadas.UseVisualStyleBackColor = true;
            // 
            // btnKivonas
            // 
            btnKivonas.Font = new Font("Segoe UI", 20F);
            btnKivonas.Location = new Point(201, 14);
            btnKivonas.Margin = new Padding(5);
            btnKivonas.Name = "btnKivonas";
            btnKivonas.Size = new Size(50, 50);
            btnKivonas.TabIndex = 2;
            btnKivonas.Text = "-";
            btnKivonas.UseVisualStyleBackColor = true;
            // 
            // btnSzorzas
            // 
            btnSzorzas.Font = new Font("Segoe UI", 20F);
            btnSzorzas.Location = new Point(141, 74);
            btnSzorzas.Margin = new Padding(5);
            btnSzorzas.Name = "btnSzorzas";
            btnSzorzas.Size = new Size(50, 50);
            btnSzorzas.TabIndex = 2;
            btnSzorzas.Text = "*";
            btnSzorzas.UseVisualStyleBackColor = true;
            // 
            // btnOsztas
            // 
            btnOsztas.Font = new Font("Segoe UI", 20F);
            btnOsztas.Location = new Point(201, 74);
            btnOsztas.Margin = new Padding(5);
            btnOsztas.Name = "btnOsztas";
            btnOsztas.Size = new Size(50, 50);
            btnOsztas.TabIndex = 2;
            btnOsztas.Text = "/";
            btnOsztas.UseVisualStyleBackColor = true;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Font = new Font("Segoe UI", 10F);
            lblUI02.Location = new Point(261, 30);
            lblUI02.Margin = new Padding(5, 0, 5, 0);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(54, 19);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "2. adat:";
            // 
            // txbAdat02
            // 
            txbAdat02.Location = new Point(261, 54);
            txbAdat02.Margin = new Padding(5);
            txbAdat02.Name = "txbAdat02";
            txbAdat02.Size = new Size(117, 32);
            txbAdat02.TabIndex = 1;
            // 
            // txbEredmeny
            // 
            txbEredmeny.Location = new Point(427, 54);
            txbEredmeny.Margin = new Padding(5);
            txbEredmeny.Name = "txbEredmeny";
            txbEredmeny.Size = new Size(117, 32);
            txbEredmeny.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 57);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(25, 25);
            label3.TabIndex = 0;
            label3.Text = "=";
            // 
            // lblMuvelet
            // 
            lblMuvelet.AutoSize = true;
            lblMuvelet.Font = new Font("Segoe UI", 10F);
            lblMuvelet.Location = new Point(427, 30);
            lblMuvelet.Margin = new Padding(5, 0, 5, 0);
            lblMuvelet.Name = "lblMuvelet";
            lblMuvelet.Size = new Size(73, 19);
            lblMuvelet.TabIndex = 0;
            lblMuvelet.Text = "eredmény:";
            // 
            // btnTorles
            // 
            btnTorles.Font = new Font("Segoe UI", 12F);
            btnTorles.Location = new Point(427, 96);
            btnTorles.Margin = new Padding(5);
            btnTorles.Name = "btnTorles";
            btnTorles.Size = new Size(117, 29);
            btnTorles.TabIndex = 2;
            btnTorles.Text = "törlés";
            btnTorles.UseVisualStyleBackColor = true;
            // 
            // FrmAlapmuveletek
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 139);
            Controls.Add(btnTorles);
            Controls.Add(btnOsztas);
            Controls.Add(btnSzorzas);
            Controls.Add(btnKivonas);
            Controls.Add(btnOsszeadas);
            Controls.Add(txbEredmeny);
            Controls.Add(txbAdat02);
            Controls.Add(label3);
            Controls.Add(lblMuvelet);
            Controls.Add(lblUI02);
            Controls.Add(txbAdat01);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FrmAlapmuveletek";
            Text = "Alapműveletek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox txbAdat01;
        private Button btnOsszeadas;
        private Button btnKivonas;
        private Button btnSzorzas;
        private Button btnOsztas;
        private Label lblUI02;
        private TextBox txbAdat02;
        private TextBox txbEredmeny;
        private Label label3;
        private Label lblMuvelet;
        private Button btnTorles;
    }
}
