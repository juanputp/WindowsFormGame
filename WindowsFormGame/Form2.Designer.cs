namespace WindowsFormGame
{
    partial class Form2
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
            this.a = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(183, 245);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(250, 56);
            this.a.TabIndex = 0;
            this.a.Text = "button1";
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(770, 245);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(250, 56);
            this.b.TabIndex = 1;
            this.b.Text = "button2";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(183, 391);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(250, 56);
            this.c.TabIndex = 2;
            this.c.Text = "button3";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(770, 391);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(250, 56);
            this.d.TabIndex = 3;
            this.d.Text = "button4";
            this.d.UseVisualStyleBackColor = true;
            this.d.Click += new System.EventHandler(this.d_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblQuestion.Location = new System.Drawing.Point(226, 119);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(95, 45);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "label1";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "CambioPregunta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Puntos:";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(773, 9);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(0, 20);
            this.lblPuntos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(877, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Intentos restantes:";
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Location = new System.Drawing.Point(1022, 9);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(0, 20);
            this.lblIntentos.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 643);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "Form2";
            this.Text = "¿Quién Quiere Ser Millonario?";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIntentos;
    }
}