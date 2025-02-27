namespace GeniyIdiotWinFormsApp
{
	partial class ResultsTableForm
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
            resultTableDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultTableDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultTableDataGridView
            // 
            resultTableDataGridView.AllowUserToAddRows = false;
            resultTableDataGridView.AllowUserToDeleteRows = false;
            resultTableDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            resultTableDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            resultTableDataGridView.GridColor = SystemColors.Window;
            resultTableDataGridView.Location = new Point(45, 37);
            resultTableDataGridView.Name = "resultTableDataGridView";
            resultTableDataGridView.ReadOnly = true;
            resultTableDataGridView.Size = new Size(643, 375);
            resultTableDataGridView.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Имя";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Количество верных ответов";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Диагноз";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 200;
            // 
            // ResultsTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 450);
            Controls.Add(resultTableDataGridView);
            Name = "ResultsTableForm";
            Text = "Таблица результатов";
            ((System.ComponentModel.ISupportInitialize)resultTableDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultTableDataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}