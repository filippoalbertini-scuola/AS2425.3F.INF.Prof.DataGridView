namespace AS2425._3F.INF.Prof.DataGridView
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
            groupBox1 = new GroupBox();
            btnAssegnaValori = new Button();
            label1 = new Label();
            txtRigheColonne = new TextBox();
            btnVisualizzaMatrice = new Button();
            dgvValori = new System.Windows.Forms.DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvValori).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAssegnaValori);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtRigheColonne);
            groupBox1.Location = new Point(33, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 104);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Matrice";
            // 
            // btnAssegnaValori
            // 
            btnAssegnaValori.Location = new Point(228, 33);
            btnAssegnaValori.Name = "btnAssegnaValori";
            btnAssegnaValori.Size = new Size(127, 47);
            btnAssegnaValori.TabIndex = 2;
            btnAssegnaValori.Text = "Assegna valori";
            btnAssegnaValori.UseVisualStyleBackColor = true;
            btnAssegnaValori.Click += btnAssegnaValori_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 46);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 1;
            label1.Text = "Righe/Colonne";
            // 
            // txtRigheColonne
            // 
            txtRigheColonne.Location = new Point(130, 43);
            txtRigheColonne.Name = "txtRigheColonne";
            txtRigheColonne.Size = new Size(72, 27);
            txtRigheColonne.TabIndex = 0;
            // 
            // btnVisualizzaMatrice
            // 
            btnVisualizzaMatrice.Location = new Point(33, 145);
            btnVisualizzaMatrice.Name = "btnVisualizzaMatrice";
            btnVisualizzaMatrice.Size = new Size(382, 43);
            btnVisualizzaMatrice.TabIndex = 2;
            btnVisualizzaMatrice.Text = "Visualizza matrice";
            btnVisualizzaMatrice.UseVisualStyleBackColor = true;
            btnVisualizzaMatrice.Click += btnVisualizzaMatrice_Click;
            // 
            // dgvValori
            // 
            dgvValori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvValori.Location = new Point(39, 205);
            dgvValori.Name = "dgvValori";
            dgvValori.RowHeadersWidth = 51;
            dgvValori.Size = new Size(692, 233);
            dgvValori.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvValori);
            Controls.Add(btnVisualizzaMatrice);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Prof;Lab2.11 3F; 31/03/25; Esempio utilizzo DataGridView con matrici";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvValori).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAssegnaValori;
        private Label label1;
        private TextBox txtRigheColonne;
        private Button btnVisualizzaMatrice;
        private System.Windows.Forms.DataGridView dgvValori;
    }
}
