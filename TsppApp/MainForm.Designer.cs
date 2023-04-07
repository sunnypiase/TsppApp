namespace TsppApp
{
    partial class MainForm
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
            this.poductDataGrid = new System.Windows.Forms.DataGridView();
            this.getProductsBtn = new System.Windows.Forms.Button();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.UpdateProductBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.priceFilterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productPrecentageTextBox = new System.Windows.Forms.TextBox();
            this.GetProductDtermBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.poductDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // poductDataGrid
            // 
            this.poductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poductDataGrid.Location = new System.Drawing.Point(10, 30);
            this.poductDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.poductDataGrid.Name = "poductDataGrid";
            this.poductDataGrid.RowHeadersWidth = 51;
            this.poductDataGrid.RowTemplate.Height = 29;
            this.poductDataGrid.Size = new System.Drawing.Size(679, 256);
            this.poductDataGrid.TabIndex = 0;
            // 
            // getProductsBtn
            // 
            this.getProductsBtn.Location = new System.Drawing.Point(10, 290);
            this.getProductsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getProductsBtn.Name = "getProductsBtn";
            this.getProductsBtn.Size = new System.Drawing.Size(136, 38);
            this.getProductsBtn.TabIndex = 1;
            this.getProductsBtn.Text = "Get Products";
            this.getProductsBtn.UseVisualStyleBackColor = true;
            this.getProductsBtn.Click += new System.EventHandler(this.getProductsBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.Location = new System.Drawing.Point(168, 290);
            this.DeleteProductBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(111, 38);
            this.DeleteProductBtn.TabIndex = 2;
            this.DeleteProductBtn.Text = "Delete product";
            this.DeleteProductBtn.UseVisualStyleBackColor = true;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // UpdateProductBtn
            // 
            this.UpdateProductBtn.Location = new System.Drawing.Point(304, 290);
            this.UpdateProductBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateProductBtn.Name = "UpdateProductBtn";
            this.UpdateProductBtn.Size = new System.Drawing.Size(103, 38);
            this.UpdateProductBtn.TabIndex = 3;
            this.UpdateProductBtn.Text = "Update product";
            this.UpdateProductBtn.UseVisualStyleBackColor = true;
            this.UpdateProductBtn.Click += new System.EventHandler(this.UpdateProductBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(438, 290);
            this.AddProductBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(110, 38);
            this.AddProductBtn.TabIndex = 4;
            this.AddProductBtn.Text = "Add product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // priceFilterTextBox
            // 
            this.priceFilterTextBox.Location = new System.Drawing.Point(554, 3);
            this.priceFilterTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceFilterTextBox.Name = "priceFilterTextBox";
            this.priceFilterTextBox.Size = new System.Drawing.Size(110, 23);
            this.priceFilterTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price filter bigger than";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Displayed products prcentage";
            // 
            // productPrecentageTextBox
            // 
            this.productPrecentageTextBox.Location = new System.Drawing.Point(182, 3);
            this.productPrecentageTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productPrecentageTextBox.Name = "productPrecentageTextBox";
            this.productPrecentageTextBox.ReadOnly = true;
            this.productPrecentageTextBox.Size = new System.Drawing.Size(61, 23);
            this.productPrecentageTextBox.TabIndex = 8;
            // 
            // GetProductDtermBtn
            // 
            this.GetProductDtermBtn.Location = new System.Drawing.Point(578, 290);
            this.GetProductDtermBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetProductDtermBtn.Name = "GetProductDtermBtn";
            this.GetProductDtermBtn.Size = new System.Drawing.Size(110, 38);
            this.GetProductDtermBtn.TabIndex = 9;
            this.GetProductDtermBtn.Text = "GetProductDterm";
            this.GetProductDtermBtn.UseVisualStyleBackColor = true;
            this.GetProductDtermBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.GetProductDtermBtn);
            this.Controls.Add(this.productPrecentageTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceFilterTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.UpdateProductBtn);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.getProductsBtn);
            this.Controls.Add(this.poductDataGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.poductDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView poductDataGrid;
        private Button getProductsBtn;
        private Button DeleteProductBtn;
        private Button UpdateProductBtn;
        private Button AddProductBtn;
        private TextBox priceFilterTextBox;
        private Label label2;
        private Label label1;
        private TextBox productPrecentageTextBox;
        private Button GetProductDtermBtn;
    }
}