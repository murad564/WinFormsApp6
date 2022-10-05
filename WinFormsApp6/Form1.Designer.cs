namespace WinFormsApp6
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.btn1_AddProduct = new System.Windows.Forms.Button();
            this.btn2_EditProduct = new System.Windows.Forms.Button();
            this.btn3_RemoveProduct = new System.Windows.Forms.Button();
            this.btn4_ClearList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(12, 21);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(215, 199);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // btn1_AddProduct
            // 
            this.btn1_AddProduct.Location = new System.Drawing.Point(12, 226);
            this.btn1_AddProduct.Name = "btn1_AddProduct";
            this.btn1_AddProduct.Size = new System.Drawing.Size(215, 23);
            this.btn1_AddProduct.TabIndex = 1;
            this.btn1_AddProduct.Text = "Add Product";
            this.btn1_AddProduct.UseVisualStyleBackColor = true;
            this.btn1_AddProduct.Click += new System.EventHandler(this.btn1_AddProduct_Click);
            // 
            // btn2_EditProduct
            // 
            this.btn2_EditProduct.Location = new System.Drawing.Point(12, 255);
            this.btn2_EditProduct.Name = "btn2_EditProduct";
            this.btn2_EditProduct.Size = new System.Drawing.Size(215, 23);
            this.btn2_EditProduct.TabIndex = 2;
            this.btn2_EditProduct.Text = "Edit Product";
            this.btn2_EditProduct.UseVisualStyleBackColor = true;
            this.btn2_EditProduct.Click += new System.EventHandler(this.btn2_EditProduct_Click);
            // 
            // btn3_RemoveProduct
            // 
            this.btn3_RemoveProduct.Location = new System.Drawing.Point(12, 284);
            this.btn3_RemoveProduct.Name = "btn3_RemoveProduct";
            this.btn3_RemoveProduct.Size = new System.Drawing.Size(215, 23);
            this.btn3_RemoveProduct.TabIndex = 3;
            this.btn3_RemoveProduct.Text = "Remove Product";
            this.btn3_RemoveProduct.UseVisualStyleBackColor = true;
            this.btn3_RemoveProduct.Click += new System.EventHandler(this.btn3_RemoveProduct_Click);
            // 
            // btn4_ClearList
            // 
            this.btn4_ClearList.Location = new System.Drawing.Point(12, 313);
            this.btn4_ClearList.Name = "btn4_ClearList";
            this.btn4_ClearList.Size = new System.Drawing.Size(215, 23);
            this.btn4_ClearList.TabIndex = 4;
            this.btn4_ClearList.Text = "ClearList";
            this.btn4_ClearList.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn4_ClearList);
            this.Controls.Add(this.btn3_RemoveProduct);
            this.Controls.Add(this.btn2_EditProduct);
            this.Controls.Add(this.btn1_AddProduct);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox;
        private Button btn1_AddProduct;
        private Button btn2_EditProduct;
        private Button btn3_RemoveProduct;
        private Button btn4_ClearList;
    }
}