namespace ManageToolApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtInventoryNumber = new System.Windows.Forms.TextBox();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtProfessionalLevel = new System.Windows.Forms.TextBox();
            this.txtWearPercentage = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(777, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(777, 58);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(777, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtInventoryNumber
            // 
            this.txtInventoryNumber.Location = new System.Drawing.Point(149, 21);
            this.txtInventoryNumber.Name = "txtInventoryNumber";
            this.txtInventoryNumber.Size = new System.Drawing.Size(99, 20);
            this.txtInventoryNumber.TabIndex = 4;
            // 
            // txtShortName
            // 
            this.txtShortName.Location = new System.Drawing.Point(254, 21);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(91, 20);
            this.txtShortName.TabIndex = 5;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(351, 21);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 6;
            // 
            // txtProfessionalLevel
            // 
            this.txtProfessionalLevel.Location = new System.Drawing.Point(457, 21);
            this.txtProfessionalLevel.Name = "txtProfessionalLevel";
            this.txtProfessionalLevel.Size = new System.Drawing.Size(91, 20);
            this.txtProfessionalLevel.TabIndex = 7;
            // 
            // txtWearPercentage
            // 
            this.txtWearPercentage.Location = new System.Drawing.Point(554, 21);
            this.txtWearPercentage.Name = "txtWearPercentage";
            this.txtWearPercentage.Size = new System.Drawing.Size(91, 20);
            this.txtWearPercentage.TabIndex = 8;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(651, 21);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 609);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtWearPercentage);
            this.Controls.Add(this.txtProfessionalLevel);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtShortName);
            this.Controls.Add(this.txtInventoryNumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtInventoryNumber;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtProfessionalLevel;
        private System.Windows.Forms.TextBox txtWearPercentage;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}

