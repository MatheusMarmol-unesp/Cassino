namespace Cassino
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btGirar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tmrGiro = new System.Windows.Forms.Timer(this.components);
            this.lbxUltimos = new System.Windows.Forms.ListBox();
            this.chbVitorias = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btGirar
            // 
            this.btGirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGirar.Location = new System.Drawing.Point(54, 146);
            this.btGirar.Name = "btGirar";
            this.btGirar.Size = new System.Drawing.Size(151, 49);
            this.btGirar.TabIndex = 1;
            this.btGirar.Text = "&Girar";
            this.btGirar.UseVisualStyleBackColor = true;
            this.btGirar.Click += new System.EventHandler(this.btGirar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lbl1.Location = new System.Drawing.Point(38, 58);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(36, 39);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lbl2.Location = new System.Drawing.Point(115, 58);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(36, 39);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "0";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lbl3.Location = new System.Drawing.Point(190, 58);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(36, 39);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "0";
            // 
            // tmrGiro
            // 
            this.tmrGiro.Tick += new System.EventHandler(this.tmrGiro_Tick);
            // 
            // lbxUltimos
            // 
            this.lbxUltimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxUltimos.FormattingEnabled = true;
            this.lbxUltimos.ItemHeight = 33;
            this.lbxUltimos.Location = new System.Drawing.Point(12, 210);
            this.lbxUltimos.Name = "lbxUltimos";
            this.lbxUltimos.Size = new System.Drawing.Size(236, 202);
            this.lbxUltimos.TabIndex = 2;
            // 
            // chbVitorias
            // 
            this.chbVitorias.AutoSize = true;
            this.chbVitorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbVitorias.Location = new System.Drawing.Point(21, 420);
            this.chbVitorias.Name = "chbVitorias";
            this.chbVitorias.Size = new System.Drawing.Size(101, 24);
            this.chbVitorias.TabIndex = 3;
            this.chbVitorias.Text = "Só &vitórias";
            this.chbVitorias.UseVisualStyleBackColor = true;
            this.chbVitorias.CheckedChanged += new System.EventHandler(this.chbVitorias_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 456);
            this.Controls.Add(this.chbVitorias);
            this.Controls.Add(this.lbxUltimos);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btGirar);
            this.Name = "Form1";
            this.Text = "Cassino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGirar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Timer tmrGiro;
        private System.Windows.Forms.ListBox lbxUltimos;
        private System.Windows.Forms.CheckBox chbVitorias;
    }
}

