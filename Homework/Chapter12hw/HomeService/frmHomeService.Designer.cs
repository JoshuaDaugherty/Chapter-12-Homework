namespace HomeService
{
    partial class frmHomeService
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblWash = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblRates = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblFeePrint = new System.Windows.Forms.Label();
            this.lblRatePrint = new System.Windows.Forms.Label();
            this.lblHoursPrint = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(74, 103);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            // 
            // lblWash
            // 
            this.lblWash.AutoSize = true;
            this.lblWash.Location = new System.Drawing.Point(488, 103);
            this.lblWash.Name = "lblWash";
            this.lblWash.Size = new System.Drawing.Size(0, 20);
            this.lblWash.TabIndex = 1;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(74, 256);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(80, 20);
            this.lblFee.TabIndex = 2;
            this.lblFee.Text = "Total Fee:";
            // 
            // lblRates
            // 
            this.lblRates.AutoSize = true;
            this.lblRates.Location = new System.Drawing.Point(74, 201);
            this.lblRates.Name = "lblRates";
            this.lblRates.Size = new System.Drawing.Size(97, 20);
            this.lblRates.TabIndex = 3;
            this.lblRates.Text = "Hourly Rate:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(74, 152);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(146, 20);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "Hours to Complete:";
            // 
            // lblFeePrint
            // 
            this.lblFeePrint.AutoSize = true;
            this.lblFeePrint.Location = new System.Drawing.Point(488, 256);
            this.lblFeePrint.Name = "lblFeePrint";
            this.lblFeePrint.Size = new System.Drawing.Size(51, 20);
            this.lblFeePrint.TabIndex = 5;
            this.lblFeePrint.Text = "label6";
            // 
            // lblRatePrint
            // 
            this.lblRatePrint.AutoSize = true;
            this.lblRatePrint.Location = new System.Drawing.Point(488, 201);
            this.lblRatePrint.Name = "lblRatePrint";
            this.lblRatePrint.Size = new System.Drawing.Size(51, 20);
            this.lblRatePrint.TabIndex = 6;
            this.lblRatePrint.Text = "label7";
            // 
            // lblHoursPrint
            // 
            this.lblHoursPrint.AutoSize = true;
            this.lblHoursPrint.Location = new System.Drawing.Point(488, 152);
            this.lblHoursPrint.Name = "lblHoursPrint";
            this.lblHoursPrint.Size = new System.Drawing.Size(51, 20);
            this.lblHoursPrint.TabIndex = 7;
            this.lblHoursPrint.Text = "label8";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(216, 103);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(156, 26);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(216, 201);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(156, 26);
            this.txtRate.TabIndex = 9;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(216, 149);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(156, 26);
            this.txtHours.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Fuchsia;
            this.lblTotal.Location = new System.Drawing.Point(212, 256);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(160, 23);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "label9";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(78, 310);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(464, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(247, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmHomeService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblHoursPrint);
            this.Controls.Add(this.lblRatePrint);
            this.Controls.Add(this.lblFeePrint);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblRates);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblWash);
            this.Controls.Add(this.lblDescription);
            this.Name = "frmHomeService";
            this.Text = "Home Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblWash;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label lblRates;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblFeePrint;
        private System.Windows.Forms.Label lblRatePrint;
        private System.Windows.Forms.Label lblHoursPrint;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

