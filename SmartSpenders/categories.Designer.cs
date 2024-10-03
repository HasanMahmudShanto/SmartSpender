
namespace SmartSpenders
{
    partial class categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet4 = new SmartSpenders.Database1DataSet4();
            this.categoriesTableAdapter = new SmartSpenders.Database1DataSet4TableAdapters.categoriesTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.transactionButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.expireDateLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bankBalanceLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.cardTypeLabel = new System.Windows.Forms.Label();
            this.bankNameLabel = new System.Windows.Forms.Label();
            this.debitLabel = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.Label();
            this.bankBalanceLabel1 = new System.Windows.Forms.Label();
            this.cashInHandLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.banknameLabel1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.loggedOutButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Spending,
            this.Id});
            this.dataGridView1.DataSource = this.categoriesBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(36)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(330, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 5;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(478, 477);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Spending
            // 
            this.Spending.DataPropertyName = "Spending";
            this.Spending.HeaderText = "Spending";
            this.Spending.Name = "Spending";
            this.Spending.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.database1DataSet4;
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(302, 666);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(142, 31);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editButton.Location = new System.Drawing.Point(501, 666);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(124, 31);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.BackColor = System.Drawing.Color.Transparent;
            this.addCategoryButton.FlatAppearance.BorderSize = 0;
            this.addCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCategoryButton.Location = new System.Drawing.Point(679, 666);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(135, 31);
            this.addCategoryButton.TabIndex = 5;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = false;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.dashboardButton.ForeColor = System.Drawing.Color.Transparent;
            this.dashboardButton.Location = new System.Drawing.Point(58, 135);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(151, 32);
            this.dashboardButton.TabIndex = 32;
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // transactionButton
            // 
            this.transactionButton.BackColor = System.Drawing.Color.Transparent;
            this.transactionButton.FlatAppearance.BorderSize = 0;
            this.transactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.transactionButton.ForeColor = System.Drawing.Color.Transparent;
            this.transactionButton.Location = new System.Drawing.Point(57, 250);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(151, 32);
            this.transactionButton.TabIndex = 33;
            this.transactionButton.UseVisualStyleBackColor = false;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.logoutButton.ForeColor = System.Drawing.Color.Transparent;
            this.logoutButton.Location = new System.Drawing.Point(1149, 42);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(38, 32);
            this.logoutButton.TabIndex = 34;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.fullnameLabel.ForeColor = System.Drawing.Color.White;
            this.fullnameLabel.Location = new System.Drawing.Point(864, 282);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(95, 25);
            this.fullnameLabel.TabIndex = 41;
            this.fullnameLabel.Text = "FullName";
            // 
            // expireDateLabel
            // 
            this.expireDateLabel.AutoSize = true;
            this.expireDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.expireDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.expireDateLabel.ForeColor = System.Drawing.Color.White;
            this.expireDateLabel.Location = new System.Drawing.Point(864, 247);
            this.expireDateLabel.Name = "expireDateLabel";
            this.expireDateLabel.Size = new System.Drawing.Size(108, 25);
            this.expireDateLabel.TabIndex = 40;
            this.expireDateLabel.Text = "expire date";
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(866, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "Expire date:";
            // 
            // bankBalanceLabel
            // 
            this.bankBalanceLabel.AutoSize = true;
            this.bankBalanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.bankBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bankBalanceLabel.ForeColor = System.Drawing.Color.White;
            this.bankBalanceLabel.Location = new System.Drawing.Point(864, 191);
            this.bankBalanceLabel.Name = "bankBalanceLabel";
            this.bankBalanceLabel.Size = new System.Drawing.Size(160, 29);
            this.bankBalanceLabel.TabIndex = 38;
            this.bankBalanceLabel.Text = "Bank Balance";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.cardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cardNumberLabel.ForeColor = System.Drawing.Color.White;
            this.cardNumberLabel.Location = new System.Drawing.Point(865, 172);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(91, 18);
            this.cardNumberLabel.TabIndex = 37;
            this.cardNumberLabel.Text = "card number";
            // 
            // cardTypeLabel
            // 
            this.cardTypeLabel.AutoSize = true;
            this.cardTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.cardTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cardTypeLabel.ForeColor = System.Drawing.Color.White;
            this.cardTypeLabel.Location = new System.Drawing.Point(862, 132);
            this.cardTypeLabel.Name = "cardTypeLabel";
            this.cardTypeLabel.Size = new System.Drawing.Size(92, 25);
            this.cardTypeLabel.TabIndex = 36;
            this.cardTypeLabel.Text = "card type";
            // 
            // bankNameLabel
            // 
            this.bankNameLabel.AutoSize = true;
            this.bankNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.bankNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bankNameLabel.ForeColor = System.Drawing.Color.White;
            this.bankNameLabel.Location = new System.Drawing.Point(1016, 132);
            this.bankNameLabel.Name = "bankNameLabel";
            this.bankNameLabel.Size = new System.Drawing.Size(109, 25);
            this.bankNameLabel.TabIndex = 35;
            this.bankNameLabel.Text = "bank name";
            // 
            // debitLabel
            // 
            this.debitLabel.AutoSize = true;
            this.debitLabel.BackColor = System.Drawing.Color.Transparent;
            this.debitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.debitLabel.ForeColor = System.Drawing.Color.White;
            this.debitLabel.Location = new System.Drawing.Point(886, 653);
            this.debitLabel.Name = "debitLabel";
            this.debitLabel.Size = new System.Drawing.Size(56, 25);
            this.debitLabel.TabIndex = 49;
            this.debitLabel.Text = "$$$$";
            this.debitLabel.Click += new System.EventHandler(this.debitLabel_Click);
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.BackColor = System.Drawing.Color.Transparent;
            this.creditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.creditLabel.ForeColor = System.Drawing.Color.White;
            this.creditLabel.Location = new System.Drawing.Point(886, 575);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(56, 25);
            this.creditLabel.TabIndex = 48;
            this.creditLabel.Text = "$$$$";
            // 
            // bankBalanceLabel1
            // 
            this.bankBalanceLabel1.AutoSize = true;
            this.bankBalanceLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bankBalanceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bankBalanceLabel1.ForeColor = System.Drawing.Color.White;
            this.bankBalanceLabel1.Location = new System.Drawing.Point(886, 500);
            this.bankBalanceLabel1.Name = "bankBalanceLabel1";
            this.bankBalanceLabel1.Size = new System.Drawing.Size(56, 25);
            this.bankBalanceLabel1.TabIndex = 47;
            this.bankBalanceLabel1.Text = "$$$$";
            // 
            // cashInHandLabel
            // 
            this.cashInHandLabel.AutoSize = true;
            this.cashInHandLabel.BackColor = System.Drawing.Color.Transparent;
            this.cashInHandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cashInHandLabel.ForeColor = System.Drawing.Color.White;
            this.cashInHandLabel.Location = new System.Drawing.Point(886, 426);
            this.cashInHandLabel.Name = "cashInHandLabel";
            this.cashInHandLabel.Size = new System.Drawing.Size(56, 25);
            this.cashInHandLabel.TabIndex = 46;
            this.cashInHandLabel.Text = "$$$$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(881, 613);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 25);
            this.label13.TabIndex = 45;
            this.label13.Text = "Debit";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(881, 541);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 25);
            this.label12.TabIndex = 44;
            this.label12.Text = "Credit";
            // 
            // banknameLabel1
            // 
            this.banknameLabel1.AutoSize = true;
            this.banknameLabel1.BackColor = System.Drawing.Color.Transparent;
            this.banknameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.banknameLabel1.ForeColor = System.Drawing.Color.White;
            this.banknameLabel1.Location = new System.Drawing.Point(881, 464);
            this.banknameLabel1.Name = "banknameLabel1";
            this.banknameLabel1.Size = new System.Drawing.Size(114, 25);
            this.banknameLabel1.TabIndex = 43;
            this.banknameLabel1.Text = "Bank Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(881, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = "Cash In Hand";
            // 
            // loggedOutButton
            // 
            this.loggedOutButton.BackColor = System.Drawing.Color.Transparent;
            this.loggedOutButton.FlatAppearance.BorderSize = 0;
            this.loggedOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loggedOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.loggedOutButton.ForeColor = System.Drawing.Color.Transparent;
            this.loggedOutButton.Location = new System.Drawing.Point(1058, 42);
            this.loggedOutButton.Name = "loggedOutButton";
            this.loggedOutButton.Size = new System.Drawing.Size(35, 32);
            this.loggedOutButton.TabIndex = 50;
            this.loggedOutButton.UseVisualStyleBackColor = false;
            this.loggedOutButton.Click += new System.EventHandler(this.loggedOutButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(1099, 44);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(42, 30);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 51;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartSpenders.Properties.Resources.Transaction__5_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 739);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.loggedOutButton);
            this.Controls.Add(this.debitLabel);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.bankBalanceLabel1);
            this.Controls.Add(this.cashInHandLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.banknameLabel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.expireDateLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bankBalanceLabel);
            this.Controls.Add(this.cardNumberLabel);
            this.Controls.Add(this.cardTypeLabel);
            this.Controls.Add(this.bankNameLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.dashboardButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "categories";
            this.Text = "categories";
            this.Load += new System.EventHandler(this.categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Database1DataSet4TableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spending;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button transactionButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Label expireDateLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label bankBalanceLabel;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.Label cardTypeLabel;
        private System.Windows.Forms.Label bankNameLabel;
        private System.Windows.Forms.Label debitLabel;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label bankBalanceLabel1;
        private System.Windows.Forms.Label cashInHandLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label banknameLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button loggedOutButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
    }
}