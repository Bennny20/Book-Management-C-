
namespace ManagerBook
{
    partial class frmMainTainBook
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
            this.lbTotalQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitleFilter = new System.Windows.Forms.TextBox();
            this.txtBookQuantity = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Manage = new System.Windows.Forms.Label();
            this.BookQuantity = new System.Windows.Forms.Label();
            this.BookPrice = new System.Windows.Forms.Label();
            this.BookTitle = new System.Windows.Forms.Label();
            this.BookID = new System.Windows.Forms.Label();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTotalQuantity
            // 
            this.lbTotalQuantity.AutoSize = true;
            this.lbTotalQuantity.Location = new System.Drawing.Point(1028, 1078);
            this.lbTotalQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalQuantity.Name = "lbTotalQuantity";
            this.lbTotalQuantity.Size = new System.Drawing.Size(161, 29);
            this.lbTotalQuantity.TabIndex = 33;
            this.lbTotalQuantity.Text = "Total Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 1083);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Enter title";
            // 
            // txtTitleFilter
            // 
            this.txtTitleFilter.Location = new System.Drawing.Point(251, 1075);
            this.txtTitleFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitleFilter.Name = "txtTitleFilter";
            this.txtTitleFilter.Size = new System.Drawing.Size(715, 35);
            this.txtTitleFilter.TabIndex = 31;
            this.txtTitleFilter.TextChanged += new System.EventHandler(this.txtTitleFilter_TextChanged);
            // 
            // txtBookQuantity
            // 
            this.txtBookQuantity.Location = new System.Drawing.Point(420, 372);
            this.txtBookQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.Size = new System.Drawing.Size(790, 35);
            this.txtBookQuantity.TabIndex = 30;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(420, 291);
            this.txtBookPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(790, 35);
            this.txtBookPrice.TabIndex = 29;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(420, 198);
            this.txtBookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(790, 35);
            this.txtBookTitle.TabIndex = 28;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(420, 109);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(790, 35);
            this.txtBookID.TabIndex = 27;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1095, 460);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(198, 59);
            this.btnLoad.TabIndex = 26;
            this.btnLoad.Text = "Refersh";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(787, 460);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(198, 59);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(481, 460);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 59);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(167, 460);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 59);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Manage
            // 
            this.Manage.AutoSize = true;
            this.Manage.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Manage.Location = new System.Drawing.Point(577, 19);
            this.Manage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(412, 62);
            this.Manage.TabIndex = 22;
            this.Manage.Text = "Book Manager ";
            // 
            // BookQuantity
            // 
            this.BookQuantity.AutoSize = true;
            this.BookQuantity.Location = new System.Drawing.Point(126, 380);
            this.BookQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookQuantity.Name = "BookQuantity";
            this.BookQuantity.Size = new System.Drawing.Size(162, 29);
            this.BookQuantity.TabIndex = 21;
            this.BookQuantity.Text = "Book Quantity";
            // 
            // BookPrice
            // 
            this.BookPrice.AutoSize = true;
            this.BookPrice.Location = new System.Drawing.Point(126, 291);
            this.BookPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Size = new System.Drawing.Size(131, 29);
            this.BookPrice.TabIndex = 20;
            this.BookPrice.Text = "Book Price";
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSize = true;
            this.BookTitle.Location = new System.Drawing.Point(126, 198);
            this.BookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(123, 29);
            this.BookTitle.TabIndex = 19;
            this.BookTitle.Text = "Book Title";
            // 
            // BookID
            // 
            this.BookID.AutoSize = true;
            this.BookID.Location = new System.Drawing.Point(126, 117);
            this.BookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(92, 29);
            this.BookID.TabIndex = 18;
            this.BookID.Text = "BookID";
            // 
            // dgvBookList
            // 
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(51, 564);
            this.dgvBookList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.RowHeadersWidth = 92;
            this.dgvBookList.RowTemplate.Height = 37;
            this.dgvBookList.Size = new System.Drawing.Size(1352, 495);
            this.dgvBookList.TabIndex = 17;
            // 
            // frmMainTainBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 1141);
            this.Controls.Add(this.lbTotalQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitleFilter);
            this.Controls.Add(this.txtBookQuantity);
            this.Controls.Add(this.txtBookPrice);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Manage);
            this.Controls.Add(this.BookQuantity);
            this.Controls.Add(this.BookPrice);
            this.Controls.Add(this.BookTitle);
            this.Controls.Add(this.BookID);
            this.Controls.Add(this.dgvBookList);
            this.Name = "frmMainTainBook";
            this.Text = "Book Manager ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTotalQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitleFilter;
        private System.Windows.Forms.TextBox txtBookQuantity;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label Manage;
        private System.Windows.Forms.Label BookQuantity;
        private System.Windows.Forms.Label BookPrice;
        private System.Windows.Forms.Label BookTitle;
        private System.Windows.Forms.Label BookID;
        private System.Windows.Forms.DataGridView dgvBookList;
    }
}

