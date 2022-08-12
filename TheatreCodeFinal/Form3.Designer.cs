namespace TheatreCodeFinal
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.rowtextbox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.seatnumbertextox = new System.Windows.Forms.TextBox();
            this.buy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.totalsal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available seats";
            // 
            // datagridview
            // 
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Location = new System.Drawing.Point(17, 51);
            this.datagridview.Name = "datagridview";
            this.datagridview.Size = new System.Drawing.Size(823, 440);
            this.datagridview.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(112, 426);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(196, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 16);
            this.label20.TabIndex = 20;
            this.label20.Text = "Enter Row Number";
            // 
            // rowtextbox
            // 
            this.rowtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowtextbox.Location = new System.Drawing.Point(338, 26);
            this.rowtextbox.Name = "rowtextbox";
            this.rowtextbox.Size = new System.Drawing.Size(100, 22);
            this.rowtextbox.TabIndex = 21;
            this.rowtextbox.Validating += new System.ComponentModel.CancelEventHandler(this.rowtextbox_Validating);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(205, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(133, 16);
            this.label21.TabIndex = 22;
            this.label21.Text = "Enter seatnumber ";
            // 
            // seatnumbertextox
            // 
            this.seatnumbertextox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatnumbertextox.Location = new System.Drawing.Point(338, 63);
            this.seatnumbertextox.Name = "seatnumbertextox";
            this.seatnumbertextox.Size = new System.Drawing.Size(100, 22);
            this.seatnumbertextox.TabIndex = 23;
            this.seatnumbertextox.Validating += new System.ComponentModel.CancelEventHandler(this.rowtextbox_Validating);
            // 
            // buy
            // 
            this.buy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buy.Location = new System.Drawing.Point(504, 58);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(75, 30);
            this.buy.TabIndex = 24;
            this.buy.Text = "BUY";
            this.buy.UseVisualStyleBackColor = false;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(846, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 25;
            this.button1.Text = "TOTAL SALES";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(846, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 30);
            this.button2.TabIndex = 26;
            this.button2.Text = "SEAT RECORD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // totalsal
            // 
            this.totalsal.AutoSize = true;
            this.totalsal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.totalsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsal.Location = new System.Drawing.Point(402, 23);
            this.totalsal.Name = "totalsal";
            this.totalsal.Size = new System.Drawing.Size(42, 16);
            this.totalsal.TabIndex = 27;
            this.totalsal.Text = "sdas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rowtextbox);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.seatnumbertextox);
            this.groupBox1.Controls.Add(this.buy);
            this.groupBox1.Location = new System.Drawing.Point(17, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 100);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1035, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.totalsal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox rowtextbox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox seatnumbertextox;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label totalsal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}