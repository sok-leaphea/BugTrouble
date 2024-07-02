namespace BugTrouble
{
    partial class frmBugTrouble
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVolumeOfYourHouseInCubicFeet = new System.Windows.Forms.TextBox();
            this.txtNumberOfRoachesInYourHouse = new System.Windows.Forms.TextBox();
            this.txtWeeksUntilHouseIsFull = new System.Windows.Forms.TextBox();
            this.txtTotalNumberOfRoaches = new System.Windows.Forms.TextBox();
            this.btnCalculateWhenHouseIsFull = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volume of your house in cubic feet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of roaches in your house";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Weeks until house is full";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total number of roaches";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVolumeOfYourHouseInCubicFeet
            // 
            this.txtVolumeOfYourHouseInCubicFeet.Location = new System.Drawing.Point(458, 80);
            this.txtVolumeOfYourHouseInCubicFeet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVolumeOfYourHouseInCubicFeet.Name = "txtVolumeOfYourHouseInCubicFeet";
            this.txtVolumeOfYourHouseInCubicFeet.Size = new System.Drawing.Size(148, 26);
            this.txtVolumeOfYourHouseInCubicFeet.TabIndex = 1;
            // 
            // txtNumberOfRoachesInYourHouse
            // 
            this.txtNumberOfRoachesInYourHouse.Location = new System.Drawing.Point(458, 163);
            this.txtNumberOfRoachesInYourHouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumberOfRoachesInYourHouse.Name = "txtNumberOfRoachesInYourHouse";
            this.txtNumberOfRoachesInYourHouse.Size = new System.Drawing.Size(148, 26);
            this.txtNumberOfRoachesInYourHouse.TabIndex = 3;
            // 
            // txtWeeksUntilHouseIsFull
            // 
            this.txtWeeksUntilHouseIsFull.Location = new System.Drawing.Point(458, 235);
            this.txtWeeksUntilHouseIsFull.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWeeksUntilHouseIsFull.Name = "txtWeeksUntilHouseIsFull";
            this.txtWeeksUntilHouseIsFull.ReadOnly = true;
            this.txtWeeksUntilHouseIsFull.Size = new System.Drawing.Size(148, 26);
            this.txtWeeksUntilHouseIsFull.TabIndex = 6;
            this.txtWeeksUntilHouseIsFull.TabStop = false;
            // 
            // txtTotalNumberOfRoaches
            // 
            this.txtTotalNumberOfRoaches.Location = new System.Drawing.Point(458, 312);
            this.txtTotalNumberOfRoaches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalNumberOfRoaches.Name = "txtTotalNumberOfRoaches";
            this.txtTotalNumberOfRoaches.ReadOnly = true;
            this.txtTotalNumberOfRoaches.Size = new System.Drawing.Size(148, 26);
            this.txtTotalNumberOfRoaches.TabIndex = 7;
            this.txtTotalNumberOfRoaches.TabStop = false;
            // 
            // btnCalculateWhenHouseIsFull
            // 
            this.btnCalculateWhenHouseIsFull.Location = new System.Drawing.Point(99, 429);
            this.btnCalculateWhenHouseIsFull.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculateWhenHouseIsFull.Name = "btnCalculateWhenHouseIsFull";
            this.btnCalculateWhenHouseIsFull.Size = new System.Drawing.Size(154, 75);
            this.btnCalculateWhenHouseIsFull.TabIndex = 4;
            this.btnCalculateWhenHouseIsFull.Text = "&Calculate when house is full";
            this.btnCalculateWhenHouseIsFull.UseVisualStyleBackColor = true;
            this.btnCalculateWhenHouseIsFull.Click += new System.EventHandler(this.btnCalculateWhenHouseIsFull_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(453, 429);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 75);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBugTrouble
            // 
            this.AcceptButton = this.btnCalculateWhenHouseIsFull;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(723, 692);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateWhenHouseIsFull);
            this.Controls.Add(this.txtTotalNumberOfRoaches);
            this.Controls.Add(this.txtWeeksUntilHouseIsFull);
            this.Controls.Add(this.txtNumberOfRoachesInYourHouse);
            this.Controls.Add(this.txtVolumeOfYourHouseInCubicFeet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBugTrouble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Trouble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVolumeOfYourHouseInCubicFeet;
        private System.Windows.Forms.TextBox txtNumberOfRoachesInYourHouse;
        private System.Windows.Forms.TextBox txtWeeksUntilHouseIsFull;
        private System.Windows.Forms.TextBox txtTotalNumberOfRoaches;
        private System.Windows.Forms.Button btnCalculateWhenHouseIsFull;
        private System.Windows.Forms.Button btnExit;
    }
}

