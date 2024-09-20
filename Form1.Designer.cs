namespace MaquinaAdecimal
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
            lblResultado = new Label();
            txtMachineCode = new TextBox();
            btnConvertir = new Button();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(28, 134);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(64, 15);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultados";
            lblResultado.Click += lblResultado_Click;
            // 
            // txtMachineCode
            // 
            txtMachineCode.Location = new Point(28, 28);
            txtMachineCode.Name = "txtMachineCode";
            txtMachineCode.Size = new Size(100, 23);
            txtMachineCode.TabIndex = 1;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(28, 77);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 2;
            btnConvertir.Text = "Convertir ";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(168, 255);
            Controls.Add(btnConvertir);
            Controls.Add(txtMachineCode);
            Controls.Add(lblResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private TextBox txtMachineCode;
        private Button btnConvertir;
    }
}
