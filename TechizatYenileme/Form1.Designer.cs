namespace TechizatYenileme
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
            this.labelReplacementAge = new System.Windows.Forms.Label();
            this.textBoxReplacementAge = new System.Windows.Forms.TextBox();
            this.labelEquipmentPrice = new System.Windows.Forms.Label();
            this.textBoxEquipmentPrice = new System.Windows.Forms.TextBox();
            this.buttonTable = new System.Windows.Forms.Button();
            this.labelEquipmentAge = new System.Windows.Forms.Label();
            this.textBoxEquipmentAge = new System.Windows.Forms.TextBox();
            this.labelReplacementSpan = new System.Windows.Forms.Label();
            this.textBoxReplacementSpan = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelRevenue = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelSalvage = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelReplacementAge
            // 
            this.labelReplacementAge.AutoSize = true;
            this.labelReplacementAge.Location = new System.Drawing.Point(12, 9);
            this.labelReplacementAge.Name = "labelReplacementAge";
            this.labelReplacementAge.Size = new System.Drawing.Size(166, 17);
            this.labelReplacementAge.TabIndex = 0;
            this.labelReplacementAge.Text = "Zorunlu Yenilenme Yasi: ";
            // 
            // textBoxReplacementAge
            // 
            this.textBoxReplacementAge.Location = new System.Drawing.Point(176, 6);
            this.textBoxReplacementAge.Name = "textBoxReplacementAge";
            this.textBoxReplacementAge.Size = new System.Drawing.Size(100, 22);
            this.textBoxReplacementAge.TabIndex = 1;
            // 
            // labelEquipmentPrice
            // 
            this.labelEquipmentPrice.AutoSize = true;
            this.labelEquipmentPrice.Location = new System.Drawing.Point(34, 93);
            this.labelEquipmentPrice.Name = "labelEquipmentPrice";
            this.labelEquipmentPrice.Size = new System.Drawing.Size(144, 17);
            this.labelEquipmentPrice.TabIndex = 2;
            this.labelEquipmentPrice.Text = "Yeni Makine Maliyeti: ";
            // 
            // textBoxEquipmentPrice
            // 
            this.textBoxEquipmentPrice.Location = new System.Drawing.Point(176, 90);
            this.textBoxEquipmentPrice.Name = "textBoxEquipmentPrice";
            this.textBoxEquipmentPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxEquipmentPrice.TabIndex = 4;
            // 
            // buttonTable
            // 
            this.buttonTable.Location = new System.Drawing.Point(176, 118);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(100, 23);
            this.buttonTable.TabIndex = 5;
            this.buttonTable.Text = "Tablo Getir";
            this.buttonTable.UseVisualStyleBackColor = true;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // labelEquipmentAge
            // 
            this.labelEquipmentAge.AutoSize = true;
            this.labelEquipmentAge.Location = new System.Drawing.Point(86, 65);
            this.labelEquipmentAge.Name = "labelEquipmentAge";
            this.labelEquipmentAge.Size = new System.Drawing.Size(92, 17);
            this.labelEquipmentAge.TabIndex = 5;
            this.labelEquipmentAge.Text = "Makine Yasi: ";
            // 
            // textBoxEquipmentAge
            // 
            this.textBoxEquipmentAge.Location = new System.Drawing.Point(176, 62);
            this.textBoxEquipmentAge.Name = "textBoxEquipmentAge";
            this.textBoxEquipmentAge.Size = new System.Drawing.Size(100, 22);
            this.textBoxEquipmentAge.TabIndex = 3;
            // 
            // labelReplacementSpan
            // 
            this.labelReplacementSpan.AutoSize = true;
            this.labelReplacementSpan.Location = new System.Drawing.Point(66, 34);
            this.labelReplacementSpan.Name = "labelReplacementSpan";
            this.labelReplacementSpan.Size = new System.Drawing.Size(112, 17);
            this.labelReplacementSpan.TabIndex = 7;
            this.labelReplacementSpan.Text = "Problem Suresi: ";
            // 
            // textBoxReplacementSpan
            // 
            this.textBoxReplacementSpan.Location = new System.Drawing.Point(176, 34);
            this.textBoxReplacementSpan.Name = "textBoxReplacementSpan";
            this.textBoxReplacementSpan.Size = new System.Drawing.Size(100, 22);
            this.textBoxReplacementSpan.TabIndex = 2;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(379, 6);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(71, 17);
            this.labelAge.TabIndex = 9;
            this.labelAge.Text = "Yas, t (yil)";
            this.labelAge.Visible = false;
            // 
            // labelRevenue
            // 
            this.labelRevenue.Location = new System.Drawing.Point(529, 6);
            this.labelRevenue.Name = "labelRevenue";
            this.labelRevenue.Size = new System.Drawing.Size(110, 23);
            this.labelRevenue.TabIndex = 10;
            this.labelRevenue.Text = "Gelir, r(t) (pb)";
            this.labelRevenue.Visible = false;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(645, 6);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(162, 17);
            this.labelCost.TabIndex = 11;
            this.labelCost.Text = "Isletme Maliyeti, c(t) (pb)";
            this.labelCost.Visible = false;
            // 
            // labelSalvage
            // 
            this.labelSalvage.AutoSize = true;
            this.labelSalvage.Location = new System.Drawing.Point(823, 6);
            this.labelSalvage.Name = "labelSalvage";
            this.labelSalvage.Size = new System.Drawing.Size(152, 17);
            this.labelSalvage.TabIndex = 12;
            this.labelSalvage.Text = "Hurda Degeri, s(t) (pb)";
            this.labelSalvage.Visible = false;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(1000, 37);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(100, 32);
            this.buttonCalc.TabIndex = 13;
            this.buttonCalc.Text = "Hesapla";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Visible = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(997, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.labelSalvage);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelRevenue);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxReplacementSpan);
            this.Controls.Add(this.labelReplacementSpan);
            this.Controls.Add(this.textBoxEquipmentAge);
            this.Controls.Add(this.labelEquipmentAge);
            this.Controls.Add(this.buttonTable);
            this.Controls.Add(this.textBoxEquipmentPrice);
            this.Controls.Add(this.labelEquipmentPrice);
            this.Controls.Add(this.textBoxReplacementAge);
            this.Controls.Add(this.labelReplacementAge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReplacementAge;
        private System.Windows.Forms.TextBox textBoxReplacementAge;
        private System.Windows.Forms.Label labelEquipmentPrice;
        private System.Windows.Forms.TextBox textBoxEquipmentPrice;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.Label labelEquipmentAge;
        private System.Windows.Forms.TextBox textBoxEquipmentAge;
        private System.Windows.Forms.Label labelReplacementSpan;
        private System.Windows.Forms.TextBox textBoxReplacementSpan;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelRevenue;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelSalvage;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label label1;
    }
}

