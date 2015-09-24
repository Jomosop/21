namespace _21
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
            this.flowLayoutPanelDealer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelSpelaren = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonKort = new System.Windows.Forms.Button();
            this.buttonStanna = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDealerPoäng = new System.Windows.Forms.Label();
            this.labelSpelarPoäng = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSatsa = new System.Windows.Forms.Button();
            this.buttonInsats3 = new System.Windows.Forms.Button();
            this.buttonInsats2 = new System.Windows.Forms.Button();
            this.buttonInsats1 = new System.Windows.Forms.Button();
            this.labelInsats = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelDealer
            // 
            this.flowLayoutPanelDealer.Location = new System.Drawing.Point(150, 12);
            this.flowLayoutPanelDealer.Name = "flowLayoutPanelDealer";
            this.flowLayoutPanelDealer.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelDealer.Size = new System.Drawing.Size(488, 100);
            this.flowLayoutPanelDealer.TabIndex = 0;
            // 
            // flowLayoutPanelSpelaren
            // 
            this.flowLayoutPanelSpelaren.Location = new System.Drawing.Point(150, 311);
            this.flowLayoutPanelSpelaren.Name = "flowLayoutPanelSpelaren";
            this.flowLayoutPanelSpelaren.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelSpelaren.Size = new System.Drawing.Size(488, 100);
            this.flowLayoutPanelSpelaren.TabIndex = 1;
            // 
            // buttonKort
            // 
            this.buttonKort.Location = new System.Drawing.Point(206, 10);
            this.buttonKort.Name = "buttonKort";
            this.buttonKort.Size = new System.Drawing.Size(75, 23);
            this.buttonKort.TabIndex = 2;
            this.buttonKort.Text = "Ett kort till";
            this.buttonKort.UseVisualStyleBackColor = true;
            this.buttonKort.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStanna
            // 
            this.buttonStanna.Location = new System.Drawing.Point(297, 10);
            this.buttonStanna.Name = "buttonStanna";
            this.buttonStanna.Size = new System.Drawing.Size(75, 23);
            this.buttonStanna.TabIndex = 3;
            this.buttonStanna.Text = "Stanna";
            this.buttonStanna.UseVisualStyleBackColor = true;
            this.buttonStanna.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelDealerPoäng
            // 
            this.labelDealerPoäng.AutoSize = true;
            this.labelDealerPoäng.BackColor = System.Drawing.Color.White;
            this.labelDealerPoäng.Location = new System.Drawing.Point(109, 51);
            this.labelDealerPoäng.Name = "labelDealerPoäng";
            this.labelDealerPoäng.Size = new System.Drawing.Size(35, 13);
            this.labelDealerPoäng.TabIndex = 4;
            this.labelDealerPoäng.Text = "label1";
            // 
            // labelSpelarPoäng
            // 
            this.labelSpelarPoäng.AutoSize = true;
            this.labelSpelarPoäng.BackColor = System.Drawing.Color.White;
            this.labelSpelarPoäng.Location = new System.Drawing.Point(109, 357);
            this.labelSpelarPoäng.Name = "labelSpelarPoäng";
            this.labelSpelarPoäng.Size = new System.Drawing.Size(35, 13);
            this.labelSpelarPoäng.TabIndex = 5;
            this.labelSpelarPoäng.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonSatsa);
            this.panel1.Controls.Add(this.buttonInsats3);
            this.panel1.Controls.Add(this.buttonInsats2);
            this.panel1.Controls.Add(this.buttonInsats1);
            this.panel1.Controls.Add(this.labelInsats);
            this.panel1.Controls.Add(this.labelSaldo);
            this.panel1.Controls.Add(this.buttonKort);
            this.panel1.Controls.Add(this.buttonStanna);
            this.panel1.Location = new System.Drawing.Point(-3, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 41);
            this.panel1.TabIndex = 6;
            // 
            // buttonSatsa
            // 
            this.buttonSatsa.Location = new System.Drawing.Point(384, 10);
            this.buttonSatsa.Name = "buttonSatsa";
            this.buttonSatsa.Size = new System.Drawing.Size(75, 23);
            this.buttonSatsa.TabIndex = 9;
            this.buttonSatsa.Text = "Satsa";
            this.buttonSatsa.UseVisualStyleBackColor = true;
            this.buttonSatsa.Click += new System.EventHandler(this.buttonSatsa_Click);
            // 
            // buttonInsats3
            // 
            this.buttonInsats3.Location = new System.Drawing.Point(662, 10);
            this.buttonInsats3.Name = "buttonInsats3";
            this.buttonInsats3.Size = new System.Drawing.Size(37, 23);
            this.buttonInsats3.TabIndex = 8;
            this.buttonInsats3.Text = "100";
            this.buttonInsats3.UseVisualStyleBackColor = true;
            this.buttonInsats3.Click += new System.EventHandler(this.buttonInsats_Click);
            // 
            // buttonInsats2
            // 
            this.buttonInsats2.Location = new System.Drawing.Point(619, 10);
            this.buttonInsats2.Name = "buttonInsats2";
            this.buttonInsats2.Size = new System.Drawing.Size(37, 23);
            this.buttonInsats2.TabIndex = 7;
            this.buttonInsats2.Text = "50";
            this.buttonInsats2.UseVisualStyleBackColor = true;
            this.buttonInsats2.Click += new System.EventHandler(this.buttonInsats_Click);
            // 
            // buttonInsats1
            // 
            this.buttonInsats1.Location = new System.Drawing.Point(576, 10);
            this.buttonInsats1.Name = "buttonInsats1";
            this.buttonInsats1.Size = new System.Drawing.Size(37, 23);
            this.buttonInsats1.TabIndex = 6;
            this.buttonInsats1.Text = "10";
            this.buttonInsats1.UseVisualStyleBackColor = true;
            this.buttonInsats1.Click += new System.EventHandler(this.buttonInsats_Click);
            // 
            // labelInsats
            // 
            this.labelInsats.AutoSize = true;
            this.labelInsats.Location = new System.Drawing.Point(465, 15);
            this.labelInsats.Name = "labelInsats";
            this.labelInsats.Size = new System.Drawing.Size(35, 13);
            this.labelInsats.TabIndex = 5;
            this.labelInsats.Text = "label2";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(15, 15);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(35, 13);
            this.labelSaldo.TabIndex = 4;
            this.labelSaldo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(708, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSpelarPoäng);
            this.Controls.Add(this.labelDealerPoäng);
            this.Controls.Add(this.flowLayoutPanelSpelaren);
            this.Controls.Add(this.flowLayoutPanelDealer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kortspel 21";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDealer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSpelaren;
        private System.Windows.Forms.Button buttonKort;
        private System.Windows.Forms.Button buttonStanna;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDealerPoäng;
        private System.Windows.Forms.Label labelSpelarPoäng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonInsats3;
        private System.Windows.Forms.Button buttonInsats2;
        private System.Windows.Forms.Button buttonInsats1;
        private System.Windows.Forms.Label labelInsats;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Button buttonSatsa;
    }
}

