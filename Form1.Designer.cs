namespace Caculator
{
    partial class calculatoryForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            infoPanel = new Panel();
            menuGbx = new GroupBox();
            HistoryLb = new Button();
            resultLb = new Label();
            toolPanel = new Panel();
            DeviBtn = new Button();
            MulBtn = new Button();
            SubBtn = new Button();
            AddBtn = new Button();
            numberPanel = new Panel();
            num2Lb = new Label();
            num2Txb = new TextBox();
            num1Lb = new Label();
            num1Txb = new TextBox();
            tablePanel = new Panel();
            HistoryDGV = new DataGridView();
            num1Error = new ErrorProvider(components);
            num2Error = new ErrorProvider(components);
            infoPanel.SuspendLayout();
            menuGbx.SuspendLayout();
            toolPanel.SuspendLayout();
            numberPanel.SuspendLayout();
            tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HistoryDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num1Error).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num2Error).BeginInit();
            SuspendLayout();
            // 
            // infoPanel
            // 
            infoPanel.Controls.Add(menuGbx);
            infoPanel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infoPanel.Location = new Point(12, 12);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(548, 448);
            infoPanel.TabIndex = 0;
            // 
            // menuGbx
            // 
            menuGbx.Controls.Add(HistoryLb);
            menuGbx.Controls.Add(resultLb);
            menuGbx.Controls.Add(toolPanel);
            menuGbx.Controls.Add(numberPanel);
            menuGbx.Location = new Point(3, 3);
            menuGbx.Name = "menuGbx";
            menuGbx.Size = new Size(542, 439);
            menuGbx.TabIndex = 0;
            menuGbx.TabStop = false;
            menuGbx.Text = "Menu";
            // 
            // HistoryLb
            // 
            HistoryLb.Location = new Point(367, 372);
            HistoryLb.Name = "HistoryLb";
            HistoryLb.Size = new Size(94, 29);
            HistoryLb.TabIndex = 3;
            HistoryLb.Text = "Lịch sử";
            HistoryLb.UseVisualStyleBackColor = true;
            HistoryLb.Click += HistoryLb_Click;
            // 
            // resultLb
            // 
            resultLb.AutoSize = true;
            resultLb.Location = new Point(52, 317);
            resultLb.Name = "resultLb";
            resultLb.Size = new Size(86, 22);
            resultLb.TabIndex = 2;
            resultLb.Text = "Kết Quả: ";
            // 
            // toolPanel
            // 
            toolPanel.Controls.Add(DeviBtn);
            toolPanel.Controls.Add(MulBtn);
            toolPanel.Controls.Add(SubBtn);
            toolPanel.Controls.Add(AddBtn);
            toolPanel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolPanel.Location = new Point(0, 193);
            toolPanel.Name = "toolPanel";
            toolPanel.Size = new Size(536, 84);
            toolPanel.TabIndex = 1;
            // 
            // DeviBtn
            // 
            DeviBtn.Location = new Point(366, 28);
            DeviBtn.Name = "DeviBtn";
            DeviBtn.Size = new Size(81, 32);
            DeviBtn.TabIndex = 3;
            DeviBtn.Text = "/";
            DeviBtn.UseVisualStyleBackColor = true;
            DeviBtn.Click += DeviBtn_Click;
            // 
            // MulBtn
            // 
            MulBtn.Location = new Point(265, 28);
            MulBtn.Name = "MulBtn";
            MulBtn.Size = new Size(81, 32);
            MulBtn.TabIndex = 2;
            MulBtn.Text = "*";
            MulBtn.UseVisualStyleBackColor = true;
            MulBtn.Click += MulBtn_Click;
            // 
            // SubBtn
            // 
            SubBtn.Location = new Point(167, 28);
            SubBtn.Name = "SubBtn";
            SubBtn.Size = new Size(81, 32);
            SubBtn.TabIndex = 1;
            SubBtn.Text = "-";
            SubBtn.UseVisualStyleBackColor = true;
            SubBtn.Click += SubBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(66, 28);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(81, 32);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "+";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // numberPanel
            // 
            numberPanel.Controls.Add(num2Lb);
            numberPanel.Controls.Add(num2Txb);
            numberPanel.Controls.Add(num1Lb);
            numberPanel.Controls.Add(num1Txb);
            numberPanel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberPanel.Location = new Point(0, 26);
            numberPanel.Name = "numberPanel";
            numberPanel.Size = new Size(536, 162);
            numberPanel.TabIndex = 0;
            // 
            // num2Lb
            // 
            num2Lb.AutoSize = true;
            num2Lb.Location = new Point(66, 101);
            num2Lb.Name = "num2Lb";
            num2Lb.Size = new Size(92, 23);
            num2Lb.TabIndex = 3;
            num2Lb.Text = "Number 2";
            // 
            // num2Txb
            // 
            num2Txb.Location = new Point(188, 98);
            num2Txb.Name = "num2Txb";
            num2Txb.Size = new Size(273, 30);
            num2Txb.TabIndex = 2;
            // 
            // num1Lb
            // 
            num1Lb.AutoSize = true;
            num1Lb.Location = new Point(66, 42);
            num1Lb.Name = "num1Lb";
            num1Lb.Size = new Size(92, 23);
            num1Lb.TabIndex = 1;
            num1Lb.Text = "Number 1";
            // 
            // num1Txb
            // 
            num1Txb.Location = new Point(188, 39);
            num1Txb.Name = "num1Txb";
            num1Txb.Size = new Size(273, 30);
            num1Txb.TabIndex = 0;
            // 
            // tablePanel
            // 
            tablePanel.Controls.Add(HistoryDGV);
            tablePanel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tablePanel.Location = new Point(566, 12);
            tablePanel.Name = "tablePanel";
            tablePanel.Size = new Size(645, 448);
            tablePanel.TabIndex = 1;
            // 
            // HistoryDGV
            // 
            HistoryDGV.AllowUserToAddRows = false;
            HistoryDGV.AllowUserToDeleteRows = false;
            HistoryDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HistoryDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            HistoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            HistoryDGV.DefaultCellStyle = dataGridViewCellStyle1;
            HistoryDGV.Location = new Point(3, 0);
            HistoryDGV.Name = "HistoryDGV";
            HistoryDGV.RowHeadersWidth = 51;
            HistoryDGV.Size = new Size(639, 442);
            HistoryDGV.TabIndex = 0;
            HistoryDGV.CellEndEdit += HistoryDGV_CellEndEdit;
            HistoryDGV.CellValueChanged += HistoryDGV_CellValueChanged;
            // 
            // num1Error
            // 
            num1Error.ContainerControl = this;
            // 
            // num2Error
            // 
            num2Error.ContainerControl = this;
            // 
            // calculatoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1223, 472);
            Controls.Add(tablePanel);
            Controls.Add(infoPanel);
            Name = "calculatoryForm";
            Text = "Calculatory";
            FormClosing += calculatoryForm_FormClosing;
            Load += calculatoryForm_Load;
            infoPanel.ResumeLayout(false);
            menuGbx.ResumeLayout(false);
            menuGbx.PerformLayout();
            toolPanel.ResumeLayout(false);
            numberPanel.ResumeLayout(false);
            numberPanel.PerformLayout();
            tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HistoryDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)num1Error).EndInit();
            ((System.ComponentModel.ISupportInitialize)num2Error).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel infoPanel;
        private GroupBox menuGbx;
        private Panel numberPanel;
        private Panel toolPanel;
        private Button DeviBtn;
        private Button MulBtn;
        private Button SubBtn;
        private Button AddBtn;
        private Label num2Lb;
        private TextBox num2Txb;
        private Label num1Lb;
        private TextBox num1Txb;
        private Button HistoryLb;
        private Label resultLb;
        private Panel tablePanel;
        private DataGridView HistoryDGV;
        private ErrorProvider num1Error;
        private ErrorProvider num2Error;
    }
}
