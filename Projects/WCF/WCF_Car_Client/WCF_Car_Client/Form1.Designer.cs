namespace WCF_Car_Client
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.buttonSearchCarById = new System.Windows.Forms.Button();
            this.buttonDeleteCar = new System.Windows.Forms.Button();
            this.buttonListAllCar = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.plateNumber = new System.Windows.Forms.Label();
            this.textBoxPlateNumber = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonYoungest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(710, 311);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(339, 340);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(86, 43);
            this.buttonAddCar.TabIndex = 1;
            this.buttonAddCar.Text = "AddCar";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // buttonSearchCarById
            // 
            this.buttonSearchCarById.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSearchCarById.Location = new System.Drawing.Point(30, 340);
            this.buttonSearchCarById.Name = "buttonSearchCarById";
            this.buttonSearchCarById.Size = new System.Drawing.Size(70, 43);
            this.buttonSearchCarById.TabIndex = 2;
            this.buttonSearchCarById.Text = "SearchCarById";
            this.buttonSearchCarById.UseVisualStyleBackColor = false;
            this.buttonSearchCarById.Click += new System.EventHandler(this.buttonSearchCarById_Click);
            // 
            // buttonDeleteCar
            // 
            this.buttonDeleteCar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDeleteCar.Location = new System.Drawing.Point(106, 340);
            this.buttonDeleteCar.Name = "buttonDeleteCar";
            this.buttonDeleteCar.Size = new System.Drawing.Size(68, 43);
            this.buttonDeleteCar.TabIndex = 3;
            this.buttonDeleteCar.Text = "DeleteCarById";
            this.buttonDeleteCar.UseVisualStyleBackColor = false;
            this.buttonDeleteCar.Click += new System.EventHandler(this.buttonDeleteCar_Click);
            // 
            // buttonListAllCar
            // 
            this.buttonListAllCar.Location = new System.Drawing.Point(605, 340);
            this.buttonListAllCar.Name = "buttonListAllCar";
            this.buttonListAllCar.Size = new System.Drawing.Size(70, 43);
            this.buttonListAllCar.TabIndex = 4;
            this.buttonListAllCar.Text = "ListAllCar";
            this.buttonListAllCar.UseVisualStyleBackColor = true;
            this.buttonListAllCar.Click += new System.EventHandler(this.buttonListAllCar_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(53, 404);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(93, 388);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 6;
            this.Id.Text = "Id";
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(298, 388);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(35, 13);
            this.Brand.TabIndex = 8;
            this.Brand.Text = "Brand";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(267, 404);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrand.TabIndex = 7;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(426, 388);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 10;
            this.Type.Text = "Type";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(395, 404);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 9;
            // 
            // plateNumber
            // 
            this.plateNumber.AutoSize = true;
            this.plateNumber.Location = new System.Drawing.Point(283, 442);
            this.plateNumber.Name = "plateNumber";
            this.plateNumber.Size = new System.Drawing.Size(69, 13);
            this.plateNumber.TabIndex = 12;
            this.plateNumber.Text = "Plate number";
            // 
            // textBoxPlateNumber
            // 
            this.textBoxPlateNumber.Location = new System.Drawing.Point(267, 458);
            this.textBoxPlateNumber.Name = "textBoxPlateNumber";
            this.textBoxPlateNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlateNumber.TabIndex = 11;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(426, 442);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(26, 13);
            this.age.TabIndex = 14;
            this.age.Text = "Age";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(395, 458);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 13;
            // 
            // buttonYoungest
            // 
            this.buttonYoungest.Location = new System.Drawing.Point(247, 340);
            this.buttonYoungest.Name = "buttonYoungest";
            this.buttonYoungest.Size = new System.Drawing.Size(86, 43);
            this.buttonYoungest.TabIndex = 15;
            this.buttonYoungest.Text = "YoungestCar";
            this.buttonYoungest.UseVisualStyleBackColor = true;
            this.buttonYoungest.Click += new System.EventHandler(this.buttonYoungest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "OldestCar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Red;
            this.buttonLogout.Location = new System.Drawing.Point(644, 447);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(70, 41);
            this.buttonLogout.TabIndex = 18;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(202, 429);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(43, 38);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "ClearField";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonLogin.Location = new System.Drawing.Point(568, 447);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(70, 39);
            this.buttonLogin.TabIndex = 20;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 497);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonYoungest);
            this.Controls.Add(this.age);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.plateNumber);
            this.Controls.Add(this.textBoxPlateNumber);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonListAllCar);
            this.Controls.Add(this.buttonDeleteCar);
            this.Controls.Add(this.buttonSearchCarById);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "CarForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Button buttonSearchCarById;
        private System.Windows.Forms.Button buttonDeleteCar;
        private System.Windows.Forms.Button buttonListAllCar;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label plateNumber;
        private System.Windows.Forms.TextBox textBoxPlateNumber;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonYoungest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLogin;
    }
}

