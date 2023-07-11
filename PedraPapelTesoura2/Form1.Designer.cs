namespace PedraPapelTesoura2
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
            Pedra = new Button();
            Papel = new Button();
            Tesoura = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            Escolha = new Label();
            SuspendLayout();
            // 
            // Pedra
            // 
            Pedra.Location = new Point(158, 80);
            Pedra.Name = "Pedra";
            Pedra.Size = new Size(109, 32);
            Pedra.TabIndex = 0;
            Pedra.Text = "Pedra";
            Pedra.UseVisualStyleBackColor = true;
            Pedra.Click += Pedra_Click;
            // 
            // Papel
            // 
            Papel.Location = new Point(158, 160);
            Papel.Name = "Papel";
            Papel.Size = new Size(109, 32);
            Papel.TabIndex = 1;
            Papel.Text = "Papel";
            Papel.UseVisualStyleBackColor = true;
            Papel.Click += Papel_Click;
            // 
            // Tesoura
            // 
            Tesoura.Location = new Point(158, 122);
            Tesoura.Name = "Tesoura";
            Tesoura.Size = new Size(109, 32);
            Tesoura.TabIndex = 2;
            Tesoura.Text = "Tesoura";
            Tesoura.UseVisualStyleBackColor = true;
            Tesoura.Click += Tesoura_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(329, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 84);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 4;
            label1.Text = "Maquina";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(536, 84);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 5;
            label2.Text = "ganhador";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(508, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 6;
            // 
            // Escolha
            // 
            Escolha.AutoSize = true;
            Escolha.Location = new Point(134, 44);
            Escolha.Name = "Escolha";
            Escolha.Size = new Size(166, 25);
            Escolha.TabIndex = 7;
            Escolha.Text = "Escolha uma opção";
            Escolha.Click += Escolha_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Escolha);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Tesoura);
            Controls.Add(Papel);
            Controls.Add(Pedra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Pedra;
        private Button Papel;
        private Button Tesoura;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label Escolha;
    }
}