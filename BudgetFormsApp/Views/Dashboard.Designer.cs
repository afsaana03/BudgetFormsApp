namespace BudgetFormsApp
{
    partial class Dashboard
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
            this.dtgExpenses = new System.Windows.Forms.DataGridView();
            this.dtgGeneralExpenses = new System.Windows.Forms.DataGridView();
            this.dtgRentalExpenses = new System.Windows.Forms.DataGridView();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txbIncome = new System.Windows.Forms.TextBox();
            this.btnAffordability = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneralExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRentalExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgExpenses
            // 
            this.dtgExpenses.AllowUserToAddRows = false;
            this.dtgExpenses.AllowUserToDeleteRows = false;
            this.dtgExpenses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgExpenses.Location = new System.Drawing.Point(12, 67);
            this.dtgExpenses.Name = "dtgExpenses";
            this.dtgExpenses.ReadOnly = true;
            this.dtgExpenses.RowHeadersVisible = false;
            this.dtgExpenses.RowTemplate.Height = 25;
            this.dtgExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgExpenses.ShowCellErrors = false;
            this.dtgExpenses.ShowCellToolTips = false;
            this.dtgExpenses.ShowEditingIcon = false;
            this.dtgExpenses.ShowRowErrors = false;
            this.dtgExpenses.Size = new System.Drawing.Size(705, 152);
            this.dtgExpenses.TabIndex = 0;
            // 
            // dtgGeneralExpenses
            // 
            this.dtgGeneralExpenses.AllowUserToAddRows = false;
            this.dtgGeneralExpenses.AllowUserToDeleteRows = false;
            this.dtgGeneralExpenses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgGeneralExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGeneralExpenses.Location = new System.Drawing.Point(12, 236);
            this.dtgGeneralExpenses.Name = "dtgGeneralExpenses";
            this.dtgGeneralExpenses.ReadOnly = true;
            this.dtgGeneralExpenses.RowHeadersVisible = false;
            this.dtgGeneralExpenses.RowTemplate.Height = 25;
            this.dtgGeneralExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGeneralExpenses.ShowCellErrors = false;
            this.dtgGeneralExpenses.ShowCellToolTips = false;
            this.dtgGeneralExpenses.ShowEditingIcon = false;
            this.dtgGeneralExpenses.ShowRowErrors = false;
            this.dtgGeneralExpenses.Size = new System.Drawing.Size(343, 152);
            this.dtgGeneralExpenses.TabIndex = 1;
            // 
            // dtgRentalExpenses
            // 
            this.dtgRentalExpenses.AllowUserToAddRows = false;
            this.dtgRentalExpenses.AllowUserToDeleteRows = false;
            this.dtgRentalExpenses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgRentalExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRentalExpenses.Location = new System.Drawing.Point(374, 236);
            this.dtgRentalExpenses.Name = "dtgRentalExpenses";
            this.dtgRentalExpenses.ReadOnly = true;
            this.dtgRentalExpenses.RowHeadersVisible = false;
            this.dtgRentalExpenses.RowTemplate.Height = 25;
            this.dtgRentalExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRentalExpenses.ShowCellErrors = false;
            this.dtgRentalExpenses.ShowCellToolTips = false;
            this.dtgRentalExpenses.ShowEditingIcon = false;
            this.dtgRentalExpenses.ShowRowErrors = false;
            this.dtgRentalExpenses.Size = new System.Drawing.Size(343, 152);
            this.dtgRentalExpenses.TabIndex = 2;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(601, 23);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(116, 23);
            this.btnTotal.TabIndex = 3;
            this.btnTotal.Text = "Total Expenses";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txbIncome
            // 
            this.txbIncome.Location = new System.Drawing.Point(12, 23);
            this.txbIncome.Name = "txbIncome";
            this.txbIncome.Size = new System.Drawing.Size(100, 23);
            this.txbIncome.TabIndex = 4;
            // 
            // btnAffordability
            // 
            this.btnAffordability.Location = new System.Drawing.Point(147, 23);
            this.btnAffordability.Name = "btnAffordability";
            this.btnAffordability.Size = new System.Drawing.Size(165, 23);
            this.btnAffordability.TabIndex = 5;
            this.btnAffordability.Text = "Determine Affordabilty";
            this.btnAffordability.UseVisualStyleBackColor = true;
            this.btnAffordability.Click += new System.EventHandler(this.btnAffordability_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 483);
            this.Controls.Add(this.btnAffordability);
            this.Controls.Add(this.txbIncome);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.dtgRentalExpenses);
            this.Controls.Add(this.dtgGeneralExpenses);
            this.Controls.Add(this.dtgExpenses);
            this.Name = "Dashboard";
            this.Text = "BudgetApp";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneralExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRentalExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgExpenses;
        private DataGridView dtgGeneralExpenses;
        private DataGridView dtgRentalExpenses;
        private Button btnTotal;
        private TextBox txbIncome;
        private Button btnAffordability;
    }
}