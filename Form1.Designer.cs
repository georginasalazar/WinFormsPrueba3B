namespace WinFormsPrueba3B
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
            panelPrincipal = new Panel();
            labelTitulo = new Label();
            textBoxCaptura = new TextBox();
            buttonSaludar = new Button();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(255, 224, 192);
            panelPrincipal.Controls.Add(buttonSaludar);
            panelPrincipal.Controls.Add(textBoxCaptura);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Location = new Point(29, 24);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(759, 414);
            panelPrincipal.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(66, 36);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(272, 36);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Mi primer programa";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxCaptura
            // 
            textBoxCaptura.Location = new Point(88, 101);
            textBoxCaptura.Name = "textBoxCaptura";
            textBoxCaptura.Size = new Size(125, 27);
            textBoxCaptura.TabIndex = 1;
            // 
            // buttonSaludar
            // 
            buttonSaludar.Location = new Point(88, 158);
            buttonSaludar.Name = "buttonSaludar";
            buttonSaludar.Size = new Size(94, 29);
            buttonSaludar.TabIndex = 2;
            buttonSaludar.Text = "Saludo";
            buttonSaludar.UseVisualStyleBackColor = true;
            buttonSaludar.Click += buttonSaludar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Button buttonSaludar;
        private TextBox textBoxCaptura;
        private Label labelTitulo;
    }
}
