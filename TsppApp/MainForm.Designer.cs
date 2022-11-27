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
            ((System.ComponentModel.ISupportInitialize)(this.poductDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // poductDataGrid
            // 
            this.poductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poductDataGrid.Location = new System.Drawing.Point(12, 12);
            this.poductDataGrid.Name = "poductDataGrid";
            this.poductDataGrid.RowHeadersWidth = 51;
            this.poductDataGrid.RowTemplate.Height = 29;
            this.poductDataGrid.Size = new System.Drawing.Size(776, 369);
            this.poductDataGrid.TabIndex = 0;
            // 
            // getProductsBtn
            // 
            this.getProductsBtn.Location = new System.Drawing.Point(12, 387);
            this.getProductsBtn.Name = "getProductsBtn";
            this.getProductsBtn.Size = new System.Drawing.Size(155, 51);
            this.getProductsBtn.TabIndex = 1;
            this.getProductsBtn.Text = "Get Products";
            this.getProductsBtn.UseVisualStyleBackColor = true;
            this.getProductsBtn.Click += new System.EventHandler(this.getProductsBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.Location = new System.Drawing.Point(217, 387);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(155, 51);
            this.DeleteProductBtn.TabIndex = 2;
            this.DeleteProductBtn.Text = "Delete product";
            this.DeleteProductBtn.UseVisualStyleBackColor = true;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // UpdateProductBtn
            // 
            this.UpdateProductBtn.Location = new System.Drawing.Point(429, 387);
            this.UpdateProductBtn.Name = "UpdateProductBtn";
            this.UpdateProductBtn.Size = new System.Drawing.Size(155, 51);
            this.UpdateProductBtn.TabIndex = 3;
            this.UpdateProductBtn.Text = "Update product";
            this.UpdateProductBtn.UseVisualStyleBackColor = true;
            this.UpdateProductBtn.Click += new System.EventHandler(this.UpdateProductBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(633, 387);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(155, 51);
            this.AddProductBtn.TabIndex = 4;
            this.AddProductBtn.Text = "Add product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.UpdateProductBtn);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.getProductsBtn);
            this.Controls.Add(this.poductDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.poductDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView poductDataGrid;
        private Button getProductsBtn;
        private Button DeleteProductBtn;
        private Button UpdateProductBtn;
        private Button AddProductBtn;
    }
}