namespace CRUD
{
    partial class Form1
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
            this.lbl_connection = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblAngkatanCreate = new System.Windows.Forms.Label();
            this.txtAngkatanCreate = new System.Windows.Forms.TextBox();
            this.lblNamaCreate = new System.Windows.Forms.Label();
            this.lblNimCreate = new System.Windows.Forms.Label();
            this.txtNamaCreate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNimCreate = new System.Windows.Forms.MaskedTextBox();
            this.tabRead = new System.Windows.Forms.TabPage();
            this.lblDataCenterRead = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.listDataRead = new System.Windows.Forms.ListBox();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.btnFind = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAngkatanUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNamaUpdate = new System.Windows.Forms.TextBox();
            this.txtNimUpdate = new System.Windows.Forms.MaskedTextBox();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.btnFindDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAngkatanDelete = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNamaDelete = new System.Windows.Forms.TextBox();
            this.txtNimDelete = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabCreate.SuspendLayout();
            this.tabRead.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_connection
            // 
            this.lbl_connection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_connection.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connection.Location = new System.Drawing.Point(529, 474);
            this.lbl_connection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_connection.Name = "lbl_connection";
            this.lbl_connection.Size = new System.Drawing.Size(297, 22);
            this.lbl_connection.TabIndex = 0;
            this.lbl_connection.Text = "-Connection";
            this.lbl_connection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCreate);
            this.tabControl1.Controls.Add(this.tabRead);
            this.tabControl1.Controls.Add(this.tabUpdate);
            this.tabControl1.Controls.Add(this.tabDelete);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(15, 80);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 390);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.listView1);
            this.tabCreate.Controls.Add(this.label6);
            this.tabCreate.Controls.Add(this.btnCreate);
            this.tabCreate.Controls.Add(this.lblAngkatanCreate);
            this.tabCreate.Controls.Add(this.txtAngkatanCreate);
            this.tabCreate.Controls.Add(this.lblNamaCreate);
            this.tabCreate.Controls.Add(this.lblNimCreate);
            this.tabCreate.Controls.Add(this.txtNamaCreate);
            this.tabCreate.Controls.Add(this.label3);
            this.tabCreate.Controls.Add(this.label4);
            this.tabCreate.Controls.Add(this.label2);
            this.tabCreate.Controls.Add(this.label1);
            this.tabCreate.Controls.Add(this.txtNimCreate);
            this.tabCreate.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCreate.Location = new System.Drawing.Point(4, 32);
            this.tabCreate.Margin = new System.Windows.Forms.Padding(4);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Padding = new System.Windows.Forms.Padding(4);
            this.tabCreate.Size = new System.Drawing.Size(803, 354);
            this.tabCreate.TabIndex = 0;
            this.tabCreate.Text = "Create";
            this.tabCreate.UseVisualStyleBackColor = true;
            this.tabCreate.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 41);
            this.label6.TabIndex = 15;
            this.label6.Text = "CREATE DATA";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(512, 290);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(283, 46);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblAngkatanCreate
            // 
            this.lblAngkatanCreate.AutoSize = true;
            this.lblAngkatanCreate.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngkatanCreate.Location = new System.Drawing.Point(519, 144);
            this.lblAngkatanCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAngkatanCreate.Name = "lblAngkatanCreate";
            this.lblAngkatanCreate.Size = new System.Drawing.Size(95, 23);
            this.lblAngkatanCreate.TabIndex = 13;
            this.lblAngkatanCreate.Text = "ANGKATAN";
            // 
            // txtAngkatanCreate
            // 
            this.txtAngkatanCreate.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngkatanCreate.Location = new System.Drawing.Point(627, 138);
            this.txtAngkatanCreate.Margin = new System.Windows.Forms.Padding(4);
            this.txtAngkatanCreate.Name = "txtAngkatanCreate";
            this.txtAngkatanCreate.Size = new System.Drawing.Size(168, 30);
            this.txtAngkatanCreate.TabIndex = 12;
            // 
            // lblNamaCreate
            // 
            this.lblNamaCreate.AutoSize = true;
            this.lblNamaCreate.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaCreate.Location = new System.Drawing.Point(519, 100);
            this.lblNamaCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamaCreate.Name = "lblNamaCreate";
            this.lblNamaCreate.Size = new System.Drawing.Size(59, 23);
            this.lblNamaCreate.TabIndex = 11;
            this.lblNamaCreate.Text = "NAMA";
            // 
            // lblNimCreate
            // 
            this.lblNimCreate.AutoSize = true;
            this.lblNimCreate.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNimCreate.Location = new System.Drawing.Point(519, 58);
            this.lblNimCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNimCreate.Name = "lblNimCreate";
            this.lblNimCreate.Size = new System.Drawing.Size(41, 23);
            this.lblNimCreate.TabIndex = 10;
            this.lblNimCreate.Text = "NIM";
            // 
            // txtNamaCreate
            // 
            this.txtNamaCreate.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaCreate.Location = new System.Drawing.Point(627, 93);
            this.txtNamaCreate.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamaCreate.Name = "txtNamaCreate";
            this.txtNamaCreate.Size = new System.Drawing.Size(168, 30);
            this.txtNamaCreate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 9;
            // 
            // txtNimCreate
            // 
            this.txtNimCreate.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNimCreate.Location = new System.Drawing.Point(627, 51);
            this.txtNimCreate.Margin = new System.Windows.Forms.Padding(4);
            this.txtNimCreate.Mask = "##,##,####";
            this.txtNimCreate.Name = "txtNimCreate";
            this.txtNimCreate.Size = new System.Drawing.Size(168, 30);
            this.txtNimCreate.TabIndex = 0;
            // 
            // tabRead
            // 
            this.tabRead.Controls.Add(this.lblDataCenterRead);
            this.tabRead.Controls.Add(this.btnRefresh);
            this.tabRead.Controls.Add(this.listDataRead);
            this.tabRead.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRead.Location = new System.Drawing.Point(4, 32);
            this.tabRead.Margin = new System.Windows.Forms.Padding(4);
            this.tabRead.Name = "tabRead";
            this.tabRead.Padding = new System.Windows.Forms.Padding(4);
            this.tabRead.Size = new System.Drawing.Size(803, 354);
            this.tabRead.TabIndex = 1;
            this.tabRead.Text = "Read";
            this.tabRead.UseVisualStyleBackColor = true;
            // 
            // lblDataCenterRead
            // 
            this.lblDataCenterRead.AutoSize = true;
            this.lblDataCenterRead.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCenterRead.Location = new System.Drawing.Point(8, 26);
            this.lblDataCenterRead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataCenterRead.Name = "lblDataCenterRead";
            this.lblDataCenterRead.Size = new System.Drawing.Size(154, 32);
            this.lblDataCenterRead.TabIndex = 2;
            this.lblDataCenterRead.Text = "DATA CENTER";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(684, 41);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 34);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // listDataRead
            // 
            this.listDataRead.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDataRead.FormattingEnabled = true;
            this.listDataRead.ItemHeight = 23;
            this.listDataRead.Location = new System.Drawing.Point(8, 82);
            this.listDataRead.Margin = new System.Windows.Forms.Padding(4);
            this.listDataRead.Name = "listDataRead";
            this.listDataRead.Size = new System.Drawing.Size(783, 257);
            this.listDataRead.TabIndex = 0;
            // 
            // tabUpdate
            // 
            this.tabUpdate.Controls.Add(this.btnFind);
            this.tabUpdate.Controls.Add(this.label5);
            this.tabUpdate.Controls.Add(this.btnUpdate);
            this.tabUpdate.Controls.Add(this.label7);
            this.tabUpdate.Controls.Add(this.txtAngkatanUpdate);
            this.tabUpdate.Controls.Add(this.label8);
            this.tabUpdate.Controls.Add(this.label9);
            this.tabUpdate.Controls.Add(this.txtNamaUpdate);
            this.tabUpdate.Controls.Add(this.txtNimUpdate);
            this.tabUpdate.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUpdate.Location = new System.Drawing.Point(4, 32);
            this.tabUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Size = new System.Drawing.Size(803, 354);
            this.tabUpdate.TabIndex = 2;
            this.tabUpdate.Text = "Update";
            this.tabUpdate.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(273, 42);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(73, 25);
            this.btnFind.TabIndex = 24;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(595, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "UPDATE DATA";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(511, 282);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(259, 46);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "ANGKATAN";
            // 
            // txtAngkatanUpdate
            // 
            this.txtAngkatanUpdate.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngkatanUpdate.Location = new System.Drawing.Point(164, 128);
            this.txtAngkatanUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtAngkatanUpdate.Name = "txtAngkatanUpdate";
            this.txtAngkatanUpdate.Size = new System.Drawing.Size(100, 30);
            this.txtAngkatanUpdate.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "NAMA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "NIM";
            // 
            // txtNamaUpdate
            // 
            this.txtNamaUpdate.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaUpdate.Location = new System.Drawing.Point(164, 84);
            this.txtNamaUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamaUpdate.Name = "txtNamaUpdate";
            this.txtNamaUpdate.Size = new System.Drawing.Size(257, 30);
            this.txtNamaUpdate.TabIndex = 17;
            // 
            // txtNimUpdate
            // 
            this.txtNimUpdate.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNimUpdate.Location = new System.Drawing.Point(164, 42);
            this.txtNimUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtNimUpdate.Mask = "##,##,####";
            this.txtNimUpdate.Name = "txtNimUpdate";
            this.txtNimUpdate.Size = new System.Drawing.Size(100, 30);
            this.txtNimUpdate.TabIndex = 16;
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.btnFindDelete);
            this.tabDelete.Controls.Add(this.label10);
            this.tabDelete.Controls.Add(this.btnDelete);
            this.tabDelete.Controls.Add(this.label11);
            this.tabDelete.Controls.Add(this.txtAngkatanDelete);
            this.tabDelete.Controls.Add(this.label12);
            this.tabDelete.Controls.Add(this.label13);
            this.tabDelete.Controls.Add(this.txtNamaDelete);
            this.tabDelete.Controls.Add(this.txtNimDelete);
            this.tabDelete.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDelete.Location = new System.Drawing.Point(4, 32);
            this.tabDelete.Margin = new System.Windows.Forms.Padding(4);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(803, 354);
            this.tabDelete.TabIndex = 3;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // btnFindDelete
            // 
            this.btnFindDelete.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindDelete.Location = new System.Drawing.Point(273, 42);
            this.btnFindDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindDelete.Name = "btnFindDelete";
            this.btnFindDelete.Size = new System.Drawing.Size(73, 25);
            this.btnFindDelete.TabIndex = 33;
            this.btnFindDelete.Text = "Find";
            this.btnFindDelete.UseVisualStyleBackColor = true;
            this.btnFindDelete.Click += new System.EventHandler(this.btnFindDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(601, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 23);
            this.label10.TabIndex = 32;
            this.label10.Text = "DELETE DATA";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(511, 282);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(259, 46);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "ANGKATAN";
            // 
            // txtAngkatanDelete
            // 
            this.txtAngkatanDelete.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngkatanDelete.Location = new System.Drawing.Point(164, 128);
            this.txtAngkatanDelete.Margin = new System.Windows.Forms.Padding(4);
            this.txtAngkatanDelete.Name = "txtAngkatanDelete";
            this.txtAngkatanDelete.Size = new System.Drawing.Size(100, 30);
            this.txtAngkatanDelete.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 87);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 23);
            this.label12.TabIndex = 28;
            this.label12.Text = "NAMA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 23);
            this.label13.TabIndex = 27;
            this.label13.Text = "NIM";
            // 
            // txtNamaDelete
            // 
            this.txtNamaDelete.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaDelete.Location = new System.Drawing.Point(164, 84);
            this.txtNamaDelete.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamaDelete.Name = "txtNamaDelete";
            this.txtNamaDelete.Size = new System.Drawing.Size(257, 30);
            this.txtNamaDelete.TabIndex = 26;
            // 
            // txtNimDelete
            // 
            this.txtNimDelete.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNimDelete.Location = new System.Drawing.Point(164, 42);
            this.txtNimDelete.Margin = new System.Windows.Forms.Padding(4);
            this.txtNimDelete.Mask = "##,##,####";
            this.txtNimDelete.Name = "txtNimDelete";
            this.txtNimDelete.Size = new System.Drawing.Size(100, 30);
            this.txtNimDelete.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 21);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(269, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "KARDUSINFO - CANDRAPRASETYA";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(493, 278);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 508);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_connection);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CRUD Basic C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCreate.ResumeLayout(false);
            this.tabCreate.PerformLayout();
            this.tabRead.ResumeLayout(false);
            this.tabRead.PerformLayout();
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdate.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_connection;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtNimCreate;
        private System.Windows.Forms.TabPage tabRead;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaCreate;
        private System.Windows.Forms.Label lblNamaCreate;
        private System.Windows.Forms.Label lblNimCreate;
        private System.Windows.Forms.Label lblAngkatanCreate;
        private System.Windows.Forms.TextBox txtAngkatanCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox listDataRead;
        private System.Windows.Forms.Label lblDataCenterRead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAngkatanUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNamaUpdate;
        private System.Windows.Forms.MaskedTextBox txtNimUpdate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFindDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAngkatanDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNamaDelete;
        private System.Windows.Forms.MaskedTextBox txtNimDelete;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView listView1;
    }
}

