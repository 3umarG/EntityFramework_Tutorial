﻿namespace WF_From_DB
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
            gvProducts = new DataGridView();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)gvProducts).BeginInit();
            SuspendLayout();
            // 
            // gvProducts
            // 
            gvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvProducts.Dock = DockStyle.Fill;
            gvProducts.Location = new Point(0, 0);
            gvProducts.Name = "gvProducts";
            gvProducts.RowTemplate.Height = 25;
            gvProducts.Size = new Size(800, 450);
            gvProducts.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(370, 308);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(gvProducts);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gvProducts;
        private Button btnLoad;
    }
}