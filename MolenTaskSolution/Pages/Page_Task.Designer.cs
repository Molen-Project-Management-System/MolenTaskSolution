namespace MolenTaskSolution.Pages
{
    partial class Page_Task
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Task));
            this.searchBoxTask = new System.Windows.Forms.TextBox();
            this.btnSearchTask = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbProjectName = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbProjectOwnerID = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbDocument = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbCompletionDate = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTask)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBoxTask
            // 
            this.searchBoxTask.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.searchBoxTask.Location = new System.Drawing.Point(15, 19);
            this.searchBoxTask.Name = "searchBoxTask";
            this.searchBoxTask.Size = new System.Drawing.Size(208, 27);
            this.searchBoxTask.TabIndex = 2;
            this.searchBoxTask.Text = "Search..";
            // 
            // btnSearchTask
            // 
            this.btnSearchTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchTask.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTask.Image")));
            this.btnSearchTask.Location = new System.Drawing.Point(229, 19);
            this.btnSearchTask.Name = "btnSearchTask";
            this.btnSearchTask.Size = new System.Drawing.Size(67, 27);
            this.btnSearchTask.TabIndex = 3;
            this.btnSearchTask.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Status (All)",
            "On Hold",
            "In Progress",
            "Completed"});
            this.comboBox1.Location = new System.Drawing.Point(263, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Employee(All)"});
            this.comboBox2.Location = new System.Drawing.Point(448, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(179, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Controls.Add(this.lbProjectName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbDescription, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbProjectOwnerID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbStatus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbStartDate, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbCompletionDate, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbDocument, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1310, 35);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lbProjectName
            // 
            this.lbProjectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProjectName.ForeColor = System.Drawing.Color.White;
            this.lbProjectName.Location = new System.Drawing.Point(26, 6);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(118, 23);
            this.lbProjectName.TabIndex = 0;
            this.lbProjectName.Text = "Project Name";
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescription.ForeColor = System.Drawing.Color.White;
            this.lbDescription.Location = new System.Drawing.Point(204, 3);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(115, 28);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Task Name";
            // 
            // lbProjectOwnerID
            // 
            this.lbProjectOwnerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProjectOwnerID.AutoSize = true;
            this.lbProjectOwnerID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProjectOwnerID.ForeColor = System.Drawing.Color.White;
            this.lbProjectOwnerID.Location = new System.Drawing.Point(423, 3);
            this.lbProjectOwnerID.Name = "lbProjectOwnerID";
            this.lbProjectOwnerID.Size = new System.Drawing.Size(74, 28);
            this.lbProjectOwnerID.TabIndex = 0;
            this.lbProjectOwnerID.Text = "Owner";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(618, 3);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(71, 28);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Status";
            // 
            // lbDocument
            // 
            this.lbDocument.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDocument.AutoSize = true;
            this.lbDocument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDocument.ForeColor = System.Drawing.Color.White;
            this.lbDocument.Location = new System.Drawing.Point(1159, 3);
            this.lbDocument.Name = "lbDocument";
            this.lbDocument.Size = new System.Drawing.Size(58, 28);
            this.lbDocument.TabIndex = 0;
            this.lbDocument.Text = "Days";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStartDate.ForeColor = System.Drawing.Color.White;
            this.lbStartDate.Location = new System.Drawing.Point(754, 3);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(110, 28);
            this.lbStartDate.TabIndex = 0;
            this.lbStartDate.Text = "Start Date";
            // 
            // lbCompletionDate
            // 
            this.lbCompletionDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCompletionDate.AutoSize = true;
            this.lbCompletionDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCompletionDate.ForeColor = System.Drawing.Color.White;
            this.lbCompletionDate.Location = new System.Drawing.Point(887, 3);
            this.lbCompletionDate.Name = "lbCompletionDate";
            this.lbCompletionDate.Size = new System.Drawing.Size(172, 28);
            this.lbCompletionDate.TabIndex = 0;
            this.lbCompletionDate.Text = "Completion Date";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(934, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 35);
            this.button2.TabIndex = 36;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1085, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 35);
            this.button1.TabIndex = 37;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.completionDateDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.projectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1274, 457);
            this.dataGridView1.TabIndex = 38;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(MolenTaskSolution.Models.Task);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // completionDateDataGridViewTextBoxColumn
            // 
            this.completionDateDataGridViewTextBoxColumn.DataPropertyName = "CompletionDate";
            this.completionDateDataGridViewTextBoxColumn.HeaderText = "CompletionDate";
            this.completionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.completionDateDataGridViewTextBoxColumn.Name = "completionDateDataGridViewTextBoxColumn";
            this.completionDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            this.dateAddedDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(MolenTaskSolution.Models.Project);
            // 
            // Page_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSearchTask);
            this.Controls.Add(this.searchBoxTask);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Page_Task";
            this.Size = new System.Drawing.Size(1316, 785);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTask)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox searchBoxTask;
        private PictureBox btnSearchTask;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbProjectName;
        private Label lbDescription;
        private Label lbProjectOwnerID;
        private Label lbStatus;
        private Label lbDocument;
        private Label lbStartDate;
        private Label lbCompletionDate;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn completionDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private BindingSource taskBindingSource;
        private BindingSource projectBindingSource;
    }
}
