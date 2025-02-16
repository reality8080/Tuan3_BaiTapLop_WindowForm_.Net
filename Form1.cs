using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Caculator
{
    public partial class calculatoryForm : Form
    {
        //Them radio button de hien thi datagridview

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Calculate_History;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private Size originalSize;
        private Size smallerSize;
        public calculatoryForm()
        {
            InitializeComponent();
            // An label
            resultLb.Hide();
            // An panel
            tablePanel.Visible = false;

            // Luu thong tin kich thuoc
            originalSize = this.Size;
            smallerSize = new Size(this.Size.Width - tablePanel.Width, this.Size.Height);
            this.Size = smallerSize;


            //var num1Column = HistoryDGV.Columns["Num1"];
            //if ( num1Column!= null)
            //{
            //    num1Column.ReadOnly = false;
            //}

            //var num2Col = HistoryDGV.Columns["Num2"];
            //if (num2Col != null)
            //{
            //    num2Col.ReadOnly = false;
            //}

            //var resultCol = HistoryDGV.Columns["Result"];
            //if (resultCol != null)
            //{
            //    resultCol.ReadOnly = false;
            //}

            //DataGridViewComboBoxColumn operatorCol = new DataGridViewComboBoxColumn();
            //operatorCol.Name = "Operator";
            //operatorCol.HeaderText = "Operator";
            //operatorCol.Items.AddRange(new String[] { "+", "-", "*", "/" });
            //HistoryDGV.Columns.Add(operatorCol);

            // Them su kien
            HistoryDGV.CellEndEdit += HistoryDGV_CellEndEdit;
            HistoryDGV.CellValueChanged += HistoryDGV_CellValueChanged;
        }

        private void calculatoryForm_Load(object sender, EventArgs e)
        {

        }

        #region methodCal
        // Them cac phep toan
        private Double addCal(Double a, Double b)
        {
            return a + b;
        }

        private Double subCal(Double a, Double b)
        {
            return a - b;
        }

        private Double mulCal(Double a, Double b)
        {
            return a * b;
        }

        private Double deviCal(Double a, Double b)
        {
            return b!=0 ? a / b:0;
        }
        #endregion

        #region MethodSQL
        private void LoadStoredProcedure()
        {
            try
            {
                // Tai Table tu SQL
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    // Dung giao thuc Stored Procedure
                    SqlCommand cmd = new SqlCommand("GetHistory", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Cap quyen cmd cho adapter
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    //Dua du lieu tu Database vao dataTable
                    adapter.Fill(dt);
                    // Chuyen duu lieu datatable vao DGV
                    HistoryDGV.DataSource = dt;
                    connect.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        private void Insert(double num1, double num2, double result, String Operator)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    // Tuong tu Load Stored Procedure
                    SqlCommand cmd = new SqlCommand("InsertCal", connect);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Time", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Num1", num1);
                    cmd.Parameters.AddWithValue("@num2", num2);
                    cmd.Parameters.AddWithValue("@Result", result);
                    cmd.Parameters.AddWithValue("@Operator", Operator);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Customer added successfully.");
                        LoadStoredProcedure();
                    }
                    else
                    {
                        MessageBox.Show("Fail");
                    }
                    connect.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void updateSql(int id,Double num1,Double num2, Double result, Char op)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("updateHistory", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@Num1", num1);
                    cmd.Parameters.AddWithValue("@Num2", num2);
                    cmd.Parameters.AddWithValue("@Result", result);
                    cmd.Parameters.AddWithValue("@Operator", op);

                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Winform
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Double num1, num2;
                if (!Double.TryParse(num1Txb.Text, out num1) || !Double.TryParse(num2Txb.Text, out num2))
                {
                    MessageBox.Show("Gia tri num1, num2 khong phai so", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //if (!Double.TryParse(num1Txb.Text, out num1))
                //{
                //    num1Error.SetError(num1Txb, "Khong phai so");
                //    return;
                //}

                //if(!Double.TryParse(num2Txb.Text, out num2))
                //{
                //    num2Error.SetError(num2Txb, "Khong phai so");
                //}

                Double result = addCal(num1, num2);
                resultLb.Text = $"Result: {num1} + {num2} = {result}";
                resultLb.Show();
                Insert(num1, num2, result, "+");
                num1Txb.Clear();
                num2Txb.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh bao", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void SubBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Double num1, num2;
                if (!Double.TryParse(num1Txb.Text, out num1) || !Double.TryParse(num2Txb.Text, out num2))
                {
                    MessageBox.Show("a,b khong phai so", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Double result = subCal(num1, num2);
                resultLb.Text = $"Result: {num1} - {num2} = {result}";
                resultLb.Show();
                Insert(num1, num2, result, "-");
                num1Txb.Clear();
                num2Txb.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh bao", MessageBoxButtons.OK);
            }

        }

        private void MulBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Double num1, num2;
                if (!Double.TryParse(num1Txb.Text, out num1) || !Double.TryParse(num2Txb.Text, out num2))
                {
                    MessageBox.Show("a,b khong phai so", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Double result = mulCal(num1, num2);
                resultLb.Text = $"Result: {num1} x {num2} = {result}";
                resultLb.Show();
                Insert(num1, num2, result, "*");
                num1Txb.Clear();
                num2Txb.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh bao", MessageBoxButtons.OK);
            }
        }

        private void DeviBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Double num1, num2;
                if (!Double.TryParse(num1Txb.Text, out num1) || !Double.TryParse(num2Txb.Text, out num2))
                {
                    MessageBox.Show("a,b khong phai so", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Double result = deviCal(num1, num2);
                resultLb.Text = $"Result: {num1} / {num2} = {result}";
                resultLb.Show();
                Insert(num1, num2, result, "/");
                num1Txb.Clear();
                num2Txb.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh bao", MessageBoxButtons.OK);
            }

        }

        private void calculatoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Ban co muon thoat", "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void HistoryLb_Click(object sender, EventArgs e)
        {
            if (!tablePanel.Visible)
            {
                tablePanel.Visible = true;
                this.Size = originalSize;
            }
            LoadStoredProcedure();
        }

        private void HistoryDGV_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == HistoryDGV.Columns["Num1"]?.Index ||
                    e.ColumnIndex == HistoryDGV.Columns["Num2"]?.Index ||
                    e.ColumnIndex == HistoryDGV.Columns["Operator"]?.Index)
                {
                    String Oper = HistoryDGV.Rows[e.RowIndex].Cells["Operator"].Value?.ToString()??"+";
                    Double num1, num2,result=0;
                    if (!Double.TryParse(HistoryDGV.Rows[e.RowIndex].Cells["Num1"].Value?.ToString(),out num1)||
                        !Double.TryParse(HistoryDGV.Rows[e.RowIndex].Cells["Num2"].Value?.ToString(), out num2))
                    {
                        MessageBox.Show("Gia tri ban dua vao khong dung", "Canh Bao", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                    switch (Oper)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num2!=0 ? num1 / num2:0;
                            break;
                    }
                    HistoryDGV.Rows[e.RowIndex].Cells["Result"].Value = result;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Canh bao", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void HistoryDGV_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id;
                Double num1, num2, result;
                string op=HistoryDGV.Rows[e.RowIndex].Cells["Operator"].Value?.ToString()??"+";
                int.TryParse(HistoryDGV.Rows[e.RowIndex].Cells["id"].Value?.ToString(), out id);
                Double.TryParse(HistoryDGV.Rows[e.RowIndex].Cells["Num1"].Value?.ToString(), out num1);
                Double.TryParse(HistoryDGV.Rows[e.RowIndex].Cells["Num2"].Value?.ToString(), out num2);
                Double.TryParse(HistoryDGV.Rows[e.RowIndex].Cells["Result"].Value?.ToString(), out result);

                updateSql(id, num1, num2, result, op[0]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
