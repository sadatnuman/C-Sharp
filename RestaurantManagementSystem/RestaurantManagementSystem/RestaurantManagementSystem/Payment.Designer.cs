namespace RestaurantManagementSystem
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnNagad = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnBkash = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPaymentPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblPaymentMethod);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnProceed);
            this.panel1.Controls.Add(this.btnCash);
            this.panel1.Controls.Add(this.btnNagad);
            this.panel1.Controls.Add(this.btnCard);
            this.panel1.Controls.Add(this.btnBkash);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(272, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 537);
            this.panel1.TabIndex = 0;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPaymentMethod.Location = new System.Drawing.Point(197, 499);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(0, 25);
            this.lblPaymentMethod.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(8, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Payment Method :";
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProceed.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.Location = new System.Drawing.Point(495, 491);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 33);
            this.btnProceed.TabIndex = 21;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCash.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.R__2_;
            this.btnCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCash.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(10, 416);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(562, 69);
            this.btnCash.TabIndex = 20;
            this.btnCash.Text = "                       Cash";
            this.btnCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnNagad
            // 
            this.btnNagad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNagad.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.nagad;
            this.btnNagad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNagad.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNagad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNagad.Location = new System.Drawing.Point(10, 266);
            this.btnNagad.Name = "btnNagad";
            this.btnNagad.Size = new System.Drawing.Size(562, 69);
            this.btnNagad.TabIndex = 19;
            this.btnNagad.Text = "                       Nagad digital payment\r\n";
            this.btnNagad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNagad.UseVisualStyleBackColor = false;
            this.btnNagad.Click += new System.EventHandler(this.btnNagad_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCard.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.card__1_;
            this.btnCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCard.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCard.Location = new System.Drawing.Point(10, 341);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(562, 69);
            this.btnCard.TabIndex = 18;
            this.btnCard.Text = "                       Credit or Debit Card";
            this.btnCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnBkash
            // 
            this.btnBkash.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBkash.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.bkash;
            this.btnBkash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBkash.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBkash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBkash.Location = new System.Drawing.Point(10, 191);
            this.btnBkash.Name = "btnBkash";
            this.btnBkash.Size = new System.Drawing.Size(562, 69);
            this.btnBkash.TabIndex = 17;
            this.btnBkash.Text = "                       bKash mobile wallet\r\n";
            this.btnBkash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBkash.UseVisualStyleBackColor = false;
            this.btnBkash.Click += new System.EventHandler(this.btnBkash_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(8, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Select a Payment Method";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblPaymentPrice);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 136);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(535, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Complete Payment";
            // 
            // lblPaymentPrice
            // 
            this.lblPaymentPrice.AutoSize = true;
            this.lblPaymentPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPaymentPrice.Location = new System.Drawing.Point(481, 94);
            this.lblPaymentPrice.Name = "lblPaymentPrice";
            this.lblPaymentPrice.Size = new System.Drawing.Size(51, 22);
            this.lblPaymentPrice.TabIndex = 15;
            this.lblPaymentPrice.Text = "৳ 0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(23, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 50);
            this.label6.TabIndex = 17;
            this.label6.Text = "where every bite\r\n                           tells a story";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ink Free", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(-9, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 79);
            this.label7.TabIndex = 16;
            this.label7.Text = "Arayes";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.delicious_meal__1_;
            this.ClientSize = new System.Drawing.Size(848, 537);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Payment_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPaymentPrice;
        private System.Windows.Forms.Button btnBkash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnNagad;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}