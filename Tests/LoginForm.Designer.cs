namespace Tests
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idTicherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTicherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsDataSet = new Tests.TestsDataSet();
            this.ticherTableAdapter1 = new Tests.TestsDataSetTableAdapters.TicherTableAdapter();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(67, 126);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(66, 52);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Войти";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxPas
            // 
            this.textBoxPas.Location = new System.Drawing.Point(21, 100);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.Size = new System.Drawing.Size(169, 20);
            this.textBoxPas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(72, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(21, 54);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(169, 20);
            this.textBoxLog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTicherDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameTicherDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticherBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(228, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // idTicherDataGridViewTextBoxColumn
            // 
            this.idTicherDataGridViewTextBoxColumn.DataPropertyName = "idTicher";
            this.idTicherDataGridViewTextBoxColumn.HeaderText = "idTicher";
            this.idTicherDataGridViewTextBoxColumn.Name = "idTicherDataGridViewTextBoxColumn";
            this.idTicherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // nameTicherDataGridViewTextBoxColumn
            // 
            this.nameTicherDataGridViewTextBoxColumn.DataPropertyName = "nameTicher";
            this.nameTicherDataGridViewTextBoxColumn.HeaderText = "nameTicher";
            this.nameTicherDataGridViewTextBoxColumn.Name = "nameTicherDataGridViewTextBoxColumn";
            // 
            // ticherBindingSource
            // 
            this.ticherBindingSource.DataMember = "Ticher";
            this.ticherBindingSource.DataSource = this.testsDataSetBindingSource;
            // 
            // testsDataSetBindingSource
            // 
            this.testsDataSetBindingSource.DataSource = this.testsDataSet;
            this.testsDataSetBindingSource.Position = 0;
            // 
            // testsDataSet
            // 
            this.testsDataSet.DataSetName = "TestsDataSet";
            this.testsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticherTableAdapter1
            // 
            this.ticherTableAdapter1.ClearBeforeFill = true;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(3, 178);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(107, 13);
            this.linkLabel.TabIndex = 7;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Зарегистрироватса";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(196, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 200);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPas);
            this.MinimumSize = new System.Drawing.Size(232, 239);
            this.Name = "LoginForm";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label1;
        private TestsDataSetTableAdapters.TicherTableAdapter ticherTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTicherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTicherDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ticherBindingSource;
        private System.Windows.Forms.BindingSource testsDataSetBindingSource;
        private TestsDataSet testsDataSet;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}