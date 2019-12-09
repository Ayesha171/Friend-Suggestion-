 private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0)
            {
                dataGridView2.DataSource = "";
                dataGridView2.DataSource = personStore[e.RowIndex].Suguestions;
                dataGridView2.Show();
            }
        }