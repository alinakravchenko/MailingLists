﻿namespace MailingLists
{
    partial class MailingLists
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
            this.buttonCountry = new System.Windows.Forms.Button();
            this.buttonCity = new System.Windows.Forms.Button();
            this.buttonBuyers = new System.Windows.Forms.Button();
            this.buttonGroupProduct = new System.Windows.Forms.Button();
            this.buttonInfoHelp = new System.Windows.Forms.Button();
            this.buttonStockProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCountry
            // 
            this.buttonCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCountry.Location = new System.Drawing.Point(45, 27);
            this.buttonCountry.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCountry.Name = "buttonCountry";
            this.buttonCountry.Size = new System.Drawing.Size(487, 55);
            this.buttonCountry.TabIndex = 0;
            this.buttonCountry.Text = "Справочник стран";
            this.buttonCountry.UseVisualStyleBackColor = true;
            this.buttonCountry.Click += new System.EventHandler(this.buttonCountry_Click);
            // 
            // buttonCity
            // 
            this.buttonCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCity.Location = new System.Drawing.Point(45, 90);
            this.buttonCity.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCity.Name = "buttonCity";
            this.buttonCity.Size = new System.Drawing.Size(487, 51);
            this.buttonCity.TabIndex = 1;
            this.buttonCity.Text = "Справочник городов";
            this.buttonCity.UseVisualStyleBackColor = true;
            this.buttonCity.Click += new System.EventHandler(this.buttonCity_Click);
            // 
            // buttonBuyers
            // 
            this.buttonBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyers.Location = new System.Drawing.Point(45, 149);
            this.buttonBuyers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuyers.Name = "buttonBuyers";
            this.buttonBuyers.Size = new System.Drawing.Size(487, 51);
            this.buttonBuyers.TabIndex = 2;
            this.buttonBuyers.Text = "Справочник покупателей";
            this.buttonBuyers.UseVisualStyleBackColor = true;
            this.buttonBuyers.Click += new System.EventHandler(this.buttonBuyers_Click);
            // 
            // buttonGroupProduct
            // 
            this.buttonGroupProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGroupProduct.Location = new System.Drawing.Point(45, 208);
            this.buttonGroupProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGroupProduct.Name = "buttonGroupProduct";
            this.buttonGroupProduct.Size = new System.Drawing.Size(487, 51);
            this.buttonGroupProduct.TabIndex = 3;
            this.buttonGroupProduct.Text = "Справочник разделов/групп товаров";
            this.buttonGroupProduct.UseVisualStyleBackColor = true;
            this.buttonGroupProduct.Click += new System.EventHandler(this.buttonGroupProduct_Click);
            // 
            // buttonInfoHelp
            // 
            this.buttonInfoHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfoHelp.Location = new System.Drawing.Point(45, 326);
            this.buttonInfoHelp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInfoHelp.Name = "buttonInfoHelp";
            this.buttonInfoHelp.Size = new System.Drawing.Size(487, 51);
            this.buttonInfoHelp.TabIndex = 4;
            this.buttonInfoHelp.Text = "Справочная информация";
            this.buttonInfoHelp.UseVisualStyleBackColor = true;
            this.buttonInfoHelp.Click += new System.EventHandler(this.buttonInfoHelp_Click);
            // 
            // buttonStockProduct
            // 
            this.buttonStockProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStockProduct.Location = new System.Drawing.Point(45, 267);
            this.buttonStockProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStockProduct.Name = "buttonStockProduct";
            this.buttonStockProduct.Size = new System.Drawing.Size(487, 51);
            this.buttonStockProduct.TabIndex = 5;
            this.buttonStockProduct.Text = "Акционные товары";
            this.buttonStockProduct.UseVisualStyleBackColor = true;
            this.buttonStockProduct.Click += new System.EventHandler(this.buttonStockProduct_Click);
            // 
            // FormMailingLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 436);
            this.Controls.Add(this.buttonStockProduct);
            this.Controls.Add(this.buttonInfoHelp);
            this.Controls.Add(this.buttonGroupProduct);
            this.Controls.Add(this.buttonBuyers);
            this.Controls.Add(this.buttonCity);
            this.Controls.Add(this.buttonCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMailingLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список рассылок";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCountry;
        private System.Windows.Forms.Button buttonCity;
        private System.Windows.Forms.Button buttonBuyers;
        private System.Windows.Forms.Button buttonGroupProduct;
        private System.Windows.Forms.Button buttonInfoHelp;
        private System.Windows.Forms.Button buttonStockProduct;
    }
}