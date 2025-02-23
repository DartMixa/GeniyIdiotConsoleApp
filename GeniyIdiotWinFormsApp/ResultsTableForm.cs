using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
	public partial class ResultsTableForm : Form
	{
		public ResultsTableForm()
		{
			InitializeComponent();
		}
		public void UpdateTable(List<List<string>> results)
		{
			for (int i = 0; i < results.Count; i++)
			{
				resultTableDataGridView.Rows.Add();
				resultTableDataGridView.Rows[i].Cells[0].Value = results[i][0];
                resultTableDataGridView.Rows[i].Cells[1].Value = results[i][1];
                resultTableDataGridView.Rows[i].Cells[2].Value = results[i][2];
            }
        }
	}
}
