namespace Household
{
    partial class frmHousehold
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
            this.panelmain = new System.Windows.Forms.Panel();
            this.cboage = new System.Windows.Forms.ComboBox();
            this.householdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new Household.AppData();
            this.cbostatus = new System.Windows.Forms.ComboBox();
            this.txtprovince = new System.Windows.Forms.TextBox();
            this.txttown = new System.Windows.Forms.TextBox();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.txtresidence = new System.Windows.Forms.TextBox();
            this.lblprovince = new System.Windows.Forms.Label();
            this.lbltown = new System.Windows.Forms.Label();
            this.lblstreet = new System.Windows.Forms.Label();
            this.lblresidence = new System.Windows.Forms.Label();
            this.cbogender = new System.Windows.Forms.ComboBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblnationality = new System.Windows.Forms.Label();
            this.txtnationality = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblmiddlename = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtmiddlename = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.householdidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residdenceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.householdTableAdapter = new Household.AppDataTableAdapters.HouseholdTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.householdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelmain.Controls.Add(this.cboage);
            this.panelmain.Controls.Add(this.cbostatus);
            this.panelmain.Controls.Add(this.txtprovince);
            this.panelmain.Controls.Add(this.txttown);
            this.panelmain.Controls.Add(this.txtstreet);
            this.panelmain.Controls.Add(this.txtresidence);
            this.panelmain.Controls.Add(this.lblprovince);
            this.panelmain.Controls.Add(this.lbltown);
            this.panelmain.Controls.Add(this.lblstreet);
            this.panelmain.Controls.Add(this.lblresidence);
            this.panelmain.Controls.Add(this.cbogender);
            this.panelmain.Controls.Add(this.lblgender);
            this.panelmain.Controls.Add(this.lblnationality);
            this.panelmain.Controls.Add(this.txtnationality);
            this.panelmain.Controls.Add(this.lblstatus);
            this.panelmain.Controls.Add(this.lblage);
            this.panelmain.Controls.Add(this.lblmiddlename);
            this.panelmain.Controls.Add(this.lblfirstname);
            this.panelmain.Controls.Add(this.lbllastname);
            this.panelmain.Controls.Add(this.txtlastname);
            this.panelmain.Controls.Add(this.txtfirstname);
            this.panelmain.Controls.Add(this.txtmiddlename);
            this.panelmain.Location = new System.Drawing.Point(12, 12);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(770, 204);
            this.panelmain.TabIndex = 0;
            // 
            // cboage
            // 
            this.cboage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.householdBindingSource, "Age", true));
            this.cboage.FormattingEnabled = true;
            this.cboage.Items.AddRange(new object[] {
            ""});
            this.cboage.Location = new System.Drawing.Point(111, 110);
            this.cboage.Name = "cboage";
            this.cboage.Size = new System.Drawing.Size(65, 21);
            this.cboage.TabIndex = 3;
            // 
            // householdBindingSource
            // 
            this.householdBindingSource.DataMember = "Household";
            this.householdBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbostatus
            // 
            this.cbostatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.householdBindingSource, "Status", true));
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Devorced",
            "Seperated"});
            this.cbostatus.Location = new System.Drawing.Point(492, 30);
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(121, 21);
            this.cbostatus.TabIndex = 4;
            // 
            // txtprovince
            // 
            this.txtprovince.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.householdBindingSource, "Province", true));
            this.txtprovince.Location = new System.Drawing.Point(492, 165);
            this.txtprovince.Name = "txtprovince";
            this.txtprovince.Size = new System.Drawing.Size(257, 20);
            this.txtprovince.TabIndex = 10;
            // 
            // txttown
            // 
            this.txttown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.householdBindingSource, "Town", true));
            this.txttown.Location = new System.Drawing.Point(492, 139);
            this.txttown.Name = "txttown";
            this.txttown.Size = new System.Drawing.Size(257, 20);
            this.txttown.TabIndex = 9;
            // 
            // txtstreet
            // 
            this.txtstreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.householdBindingSource, "Street", true));
            this.txtstreet.Location = new System.Drawing.Point(111, 165);
            this.txtstreet.Name = "txtstreet";
            this.txtstreet.Size = new System.Drawing.Size(257, 20);
            this.txtstreet.TabIndex = 8;
            // 
            // txtresidence
            // 
            this.txtresidence.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.householdBindingSource, "Residdence_Number", true));
            this.txtresidence.Location = new System.Drawing.Point(111, 139);
            this.txtresidence.Name = "txtresidence";
            this.txtresidence.Size = new System.Drawing.Size(257, 20);
            this.txtresidence.TabIndex = 7;
            // 
            // lblprovince
            // 
            this.lblprovince.AutoSize = true;
            this.lblprovince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprovince.Location = new System.Drawing.Point(421, 166);
            this.lblprovince.Name = "lblprovince";
            this.lblprovince.Size = new System.Drawing.Size(61, 16);
            this.lblprovince.TabIndex = 19;
            this.lblprovince.Text = "Province";
            // 
            // lbltown
            // 
            this.lbltown.AutoSize = true;
            this.lbltown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltown.Location = new System.Drawing.Point(442, 140);
            this.lbltown.Name = "lbltown";
            this.lbltown.Size = new System.Drawing.Size(41, 16);
            this.lbltown.TabIndex = 18;
            this.lbltown.Text = "Town";
            // 
            // lblstreet
            // 
            this.lblstreet.AutoSize = true;
            this.lblstreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstreet.Location = new System.Drawing.Point(58, 166);
            this.lblstreet.Name = "lblstreet";
            this.lblstreet.Size = new System.Drawing.Size(43, 16);
            this.lblstreet.TabIndex = 17;
            this.lblstreet.Text = "Street";
            // 
            // lblresidence
            // 
            this.lblresidence.AutoSize = true;
            this.lblresidence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblresidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresidence.Location = new System.Drawing.Point(17, 139);
            this.lblresidence.Name = "lblresidence";
            this.lblresidence.Size = new System.Drawing.Size(84, 16);
            this.lblresidence.TabIndex = 16;
            this.lblresidence.Text = "Residence #";
            // 
            // cbogender
            // 
            this.cbogender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.householdBindingSource, "Gender", true));
            this.cbogender.FormattingEnabled = true;
            this.cbogender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbogender.Location = new System.Drawing.Point(492, 86);
            this.cbogender.Name = "cbogender";
            this.cbogender.Size = new System.Drawing.Size(121, 21);
            this.cbogender.TabIndex = 6;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(415, 86);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(53, 16);
            this.lblgender.TabIndex = 14;
            this.lblgender.Text = "Gender";
            // 
            // lblnationality
            // 
            this.lblnationality.AutoSize = true;
            this.lblnationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnationality.Location = new System.Drawing.Point(415, 59);
            this.lblnationality.Name = "lblnationality";
            this.lblnationality.Size = new System.Drawing.Size(71, 16);
            this.lblnationality.TabIndex = 12;
            this.lblnationality.Text = "Nationality";
            // 
            // txtnationality
            // 
            this.txtnationality.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.householdBindingSource, "Nationality", true));
            this.txtnationality.Location = new System.Drawing.Point(492, 58);
            this.txtnationality.Name = "txtnationality";
            this.txtnationality.Size = new System.Drawing.Size(197, 20);
            this.txtnationality.TabIndex = 5;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(415, 32);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(45, 16);
            this.lblstatus.TabIndex = 10;
            this.lblstatus.Text = "Status";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(68, 113);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(33, 16);
            this.lblage.TabIndex = 8;
            this.lblage.Text = "Age";
            // 
            // lblmiddlename
            // 
            this.lblmiddlename.AutoSize = true;
            this.lblmiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmiddlename.Location = new System.Drawing.Point(12, 84);
            this.lblmiddlename.Name = "lblmiddlename";
            this.lblmiddlename.Size = new System.Drawing.Size(89, 16);
            this.lblmiddlename.TabIndex = 6;
            this.lblmiddlename.Text = "Middle Name";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(28, 57);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(73, 16);
            this.lblfirstname.TabIndex = 4;
            this.lblfirstname.Text = "First Name";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbllastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(28, 31);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(73, 16);
            this.lbllastname.TabIndex = 1;
            this.lbllastname.Text = "Last Name";
            // 
            // txtlastname
            // 
            this.txtlastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.householdBindingSource, "Last_Name", true));
            this.txtlastname.Location = new System.Drawing.Point(111, 31);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(257, 20);
            this.txtlastname.TabIndex = 0;
            // 
            // txtfirstname
            // 
            this.txtfirstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.householdBindingSource, "First_Name", true));
            this.txtfirstname.Location = new System.Drawing.Point(111, 57);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(257, 20);
            this.txtfirstname.TabIndex = 1;
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.householdBindingSource, "Middle_Name", true));
            this.txtmiddlename.Location = new System.Drawing.Point(111, 83);
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.Size = new System.Drawing.Size(257, 20);
            this.txtmiddlename.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.householdidDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.residdenceNumberDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.townDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.householdBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(13, 248);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(770, 225);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // householdidDataGridViewTextBoxColumn
            // 
            this.householdidDataGridViewTextBoxColumn.DataPropertyName = "Household_id";
            this.householdidDataGridViewTextBoxColumn.HeaderText = "Household_id";
            this.householdidDataGridViewTextBoxColumn.Name = "householdidDataGridViewTextBoxColumn";
            this.householdidDataGridViewTextBoxColumn.Width = 80;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle_Name";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle_Name";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 50;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // residdenceNumberDataGridViewTextBoxColumn
            // 
            this.residdenceNumberDataGridViewTextBoxColumn.DataPropertyName = "Residdence_Number";
            this.residdenceNumberDataGridViewTextBoxColumn.HeaderText = "Residdence_Number";
            this.residdenceNumberDataGridViewTextBoxColumn.Name = "residdenceNumberDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // townDataGridViewTextBoxColumn
            // 
            this.townDataGridViewTextBoxColumn.DataPropertyName = "Town";
            this.townDataGridViewTextBoxColumn.HeaderText = "Town";
            this.townDataGridViewTextBoxColumn.Name = "townDataGridViewTextBoxColumn";
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "Province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "Province";
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Search";
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(12, 479);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 1;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(93, 479);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(255, 478);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(174, 478);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // householdTableAdapter
            // 
            this.householdTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(73, 222);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // frmHousehold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(796, 515);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "frmHousehold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Household";
            this.Load += new System.EventHandler(this.frmHousehold_Load);
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.householdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtmiddlename;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lblmiddlename;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblnationality;
        private System.Windows.Forms.TextBox txtnationality;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.ComboBox cbogender;
        private System.Windows.Forms.TextBox txtresidence;
        private System.Windows.Forms.Label lblprovince;
        private System.Windows.Forms.Label lbltown;
        private System.Windows.Forms.Label lblstreet;
        private System.Windows.Forms.Label lblresidence;
        private System.Windows.Forms.TextBox txtprovince;
        private System.Windows.Forms.TextBox txttown;
        private System.Windows.Forms.TextBox txtstreet;
        private System.Windows.Forms.ComboBox cbostatus;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ComboBox cboage;
        private AppData appData;
        private System.Windows.Forms.BindingSource householdBindingSource;
        private AppDataTableAdapters.HouseholdTableAdapter householdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn householdidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residdenceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn townDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

