
namespace ExamenForm
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
            this.BTN_Cotizar = new System.Windows.Forms.Button();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_Chupin = new System.Windows.Forms.CheckBox();
            this.CB_MangaCorta = new System.Windows.Forms.CheckBox();
            this.RB_Pantalon = new System.Windows.Forms.RadioButton();
            this.RB_Camisa = new System.Windows.Forms.RadioButton();
            this.CB_Mao = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB_Premium = new System.Windows.Forms.RadioButton();
            this.RB_Standard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.num_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.num_Precio = new System.Windows.Forms.NumericUpDown();
            this.lbl_Tienda = new System.Windows.Forms.Label();
            this.lbl_Vendedor = new System.Windows.Forms.Label();
            this.BTN_Historial = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lista_His = new System.Windows.Forms.ListView();
            this.H_Vend = new System.Windows.Forms.ColumnHeader();
            this.H_Tienda = new System.Windows.Forms.ColumnHeader();
            this.H_Prenda = new System.Windows.Forms.ColumnHeader();
            this.H_Cant = new System.Windows.Forms.ColumnHeader();
            this.H_Total = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Precio)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Cotizar
            // 
            this.BTN_Cotizar.Location = new System.Drawing.Point(12, 285);
            this.BTN_Cotizar.Name = "BTN_Cotizar";
            this.BTN_Cotizar.Size = new System.Drawing.Size(127, 153);
            this.BTN_Cotizar.TabIndex = 0;
            this.BTN_Cotizar.Text = "COTIZAR";
            this.BTN_Cotizar.UseVisualStyleBackColor = true;
            this.BTN_Cotizar.Click += new System.EventHandler(this.BTN_Cotizar_Click);
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Precio.Location = new System.Drawing.Point(151, 371);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(92, 37);
            this.lbl_Precio.TabIndex = 1;
            this.lbl_Precio.Text = "$0000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_Chupin);
            this.groupBox1.Controls.Add(this.CB_MangaCorta);
            this.groupBox1.Controls.Add(this.RB_Pantalon);
            this.groupBox1.Controls.Add(this.RB_Camisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda";
            // 
            // CB_Chupin
            // 
            this.CB_Chupin.AutoSize = true;
            this.CB_Chupin.Location = new System.Drawing.Point(102, 66);
            this.CB_Chupin.Name = "CB_Chupin";
            this.CB_Chupin.Size = new System.Drawing.Size(65, 19);
            this.CB_Chupin.TabIndex = 5;
            this.CB_Chupin.Text = "Chupin";
            this.CB_Chupin.UseVisualStyleBackColor = true;
            // 
            // CB_MangaCorta
            // 
            this.CB_MangaCorta.AutoSize = true;
            this.CB_MangaCorta.Location = new System.Drawing.Point(102, 24);
            this.CB_MangaCorta.Name = "CB_MangaCorta";
            this.CB_MangaCorta.Size = new System.Drawing.Size(95, 19);
            this.CB_MangaCorta.TabIndex = 3;
            this.CB_MangaCorta.Text = "Manga Corta";
            this.CB_MangaCorta.UseVisualStyleBackColor = true;
            // 
            // RB_Pantalon
            // 
            this.RB_Pantalon.AutoSize = true;
            this.RB_Pantalon.Location = new System.Drawing.Point(7, 66);
            this.RB_Pantalon.Name = "RB_Pantalon";
            this.RB_Pantalon.Size = new System.Drawing.Size(72, 19);
            this.RB_Pantalon.TabIndex = 1;
            this.RB_Pantalon.TabStop = true;
            this.RB_Pantalon.Text = "Pantalon";
            this.RB_Pantalon.UseVisualStyleBackColor = true;
            // 
            // RB_Camisa
            // 
            this.RB_Camisa.AutoSize = true;
            this.RB_Camisa.Location = new System.Drawing.Point(7, 23);
            this.RB_Camisa.Name = "RB_Camisa";
            this.RB_Camisa.Size = new System.Drawing.Size(64, 19);
            this.RB_Camisa.TabIndex = 0;
            this.RB_Camisa.TabStop = true;
            this.RB_Camisa.Text = "Camisa";
            this.RB_Camisa.UseVisualStyleBackColor = true;
            // 
            // CB_Mao
            // 
            this.CB_Mao.AutoSize = true;
            this.CB_Mao.Location = new System.Drawing.Point(215, 106);
            this.CB_Mao.Name = "CB_Mao";
            this.CB_Mao.Size = new System.Drawing.Size(87, 19);
            this.CB_Mao.TabIndex = 4;
            this.CB_Mao.Text = "Cuello Mao";
            this.CB_Mao.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB_Premium);
            this.groupBox2.Controls.Add(this.RB_Standard);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 82);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de prenda";
            // 
            // RB_Premium
            // 
            this.RB_Premium.AutoSize = true;
            this.RB_Premium.Location = new System.Drawing.Point(7, 32);
            this.RB_Premium.Name = "RB_Premium";
            this.RB_Premium.Size = new System.Drawing.Size(74, 19);
            this.RB_Premium.TabIndex = 1;
            this.RB_Premium.TabStop = true;
            this.RB_Premium.Text = "Premium";
            this.RB_Premium.UseVisualStyleBackColor = true;
            // 
            // RB_Standard
            // 
            this.RB_Standard.AutoSize = true;
            this.RB_Standard.Location = new System.Drawing.Point(7, 57);
            this.RB_Standard.Name = "RB_Standard";
            this.RB_Standard.Size = new System.Drawing.Size(72, 19);
            this.RB_Standard.TabIndex = 0;
            this.RB_Standard.TabStop = true;
            this.RB_Standard.Text = "Standard";
            this.RB_Standard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.num_Cantidad);
            this.groupBox3.Controls.Add(this.num_Precio);
            this.groupBox3.Location = new System.Drawing.Point(151, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 142);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio y cantidad";
            // 
            // num_Cantidad
            // 
            this.num_Cantidad.Location = new System.Drawing.Point(6, 101);
            this.num_Cantidad.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_Cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Cantidad.Name = "num_Cantidad";
            this.num_Cantidad.Size = new System.Drawing.Size(144, 23);
            this.num_Cantidad.TabIndex = 9;
            this.num_Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_Precio
            // 
            this.num_Precio.Location = new System.Drawing.Point(6, 53);
            this.num_Precio.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_Precio.Name = "num_Precio";
            this.num_Precio.Size = new System.Drawing.Size(144, 23);
            this.num_Precio.TabIndex = 8;
            // 
            // lbl_Tienda
            // 
            this.lbl_Tienda.AutoSize = true;
            this.lbl_Tienda.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tienda.Location = new System.Drawing.Point(19, 13);
            this.lbl_Tienda.Name = "lbl_Tienda";
            this.lbl_Tienda.Size = new System.Drawing.Size(90, 37);
            this.lbl_Tienda.TabIndex = 7;
            this.lbl_Tienda.Text = "label1";
            // 
            // lbl_Vendedor
            // 
            this.lbl_Vendedor.AutoSize = true;
            this.lbl_Vendedor.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Vendedor.Location = new System.Drawing.Point(19, 50);
            this.lbl_Vendedor.Name = "lbl_Vendedor";
            this.lbl_Vendedor.Size = new System.Drawing.Size(59, 25);
            this.lbl_Vendedor.TabIndex = 8;
            this.lbl_Vendedor.Text = "label1";
            // 
            // BTN_Historial
            // 
            this.BTN_Historial.Location = new System.Drawing.Point(235, 53);
            this.BTN_Historial.Name = "BTN_Historial";
            this.BTN_Historial.Size = new System.Drawing.Size(75, 23);
            this.BTN_Historial.TabIndex = 9;
            this.BTN_Historial.Text = "Historial";
            this.BTN_Historial.UseVisualStyleBackColor = true;
            this.BTN_Historial.Click += new System.EventHandler(this.BTN_Historial_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lista_His);
            this.groupBox4.Location = new System.Drawing.Point(322, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 428);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // lista_His
            // 
            this.lista_His.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.H_Vend,
            this.H_Tienda,
            this.H_Prenda,
            this.H_Cant,
            this.H_Total});
            this.lista_His.FullRowSelect = true;
            this.lista_His.GridLines = true;
            this.lista_His.HideSelection = false;
            this.lista_His.Location = new System.Drawing.Point(6, 22);
            this.lista_His.Name = "lista_His";
            this.lista_His.Size = new System.Drawing.Size(404, 400);
            this.lista_His.TabIndex = 0;
            this.lista_His.UseCompatibleStateImageBehavior = false;
            this.lista_His.View = System.Windows.Forms.View.Details;
            // 
            // H_Vend
            // 
            this.H_Vend.Text = "Vendedor";
            this.H_Vend.Width = 80;
            // 
            // H_Tienda
            // 
            this.H_Tienda.Text = "Tienda";
            this.H_Tienda.Width = 80;
            // 
            // H_Prenda
            // 
            this.H_Prenda.Text = "Prenda";
            this.H_Prenda.Width = 80;
            // 
            // H_Cant
            // 
            this.H_Cant.Text = "Cantidad";
            // 
            // H_Total
            // 
            this.H_Total.Text = "Total";
            this.H_Total.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "PRECIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "CANTIDAD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BTN_Historial);
            this.Controls.Add(this.lbl_Vendedor);
            this.Controls.Add(this.lbl_Tienda);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CB_Mao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.BTN_Cotizar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Precio)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Cotizar;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_Pantalon;
        private System.Windows.Forms.RadioButton RB_Camisa;
        private System.Windows.Forms.CheckBox CB_Chupin;
        private System.Windows.Forms.CheckBox CB_MangaCorta;
        private System.Windows.Forms.CheckBox CB_Mao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB_Premium;
        private System.Windows.Forms.RadioButton RB_Standard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown num_Precio;
        private System.Windows.Forms.NumericUpDown num_Cantidad;
        private System.Windows.Forms.Label lbl_Tienda;
        private System.Windows.Forms.Label lbl_Vendedor;
        private System.Windows.Forms.Button BTN_Historial;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lista_His;
        private System.Windows.Forms.ColumnHeader H_Vend;
        private System.Windows.Forms.ColumnHeader H_Tienda;
        private System.Windows.Forms.ColumnHeader H_Prenda;
        private System.Windows.Forms.ColumnHeader H_Cant;
        private System.Windows.Forms.ColumnHeader H_Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

