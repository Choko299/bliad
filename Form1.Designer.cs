namespace LaptopManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtCPU = new TextBox();
            txtRAM = new TextBox();
            txtStorage = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(30, 20);
            txtBrand.Name = "txtBrand";
            txtBrand.PlaceholderText = "Brand";
            txtBrand.Size = new Size(200, 23);
            txtBrand.TabIndex = 0;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(30, 50);
            txtModel.Name = "txtModel";
            txtModel.PlaceholderText = "Model";
            txtModel.Size = new Size(200, 23);
            txtModel.TabIndex = 1;
            // 
            // txtCPU
            // 
            txtCPU.Location = new Point(30, 80);
            txtCPU.Name = "txtCPU";
            txtCPU.PlaceholderText = "CPU";
            txtCPU.Size = new Size(200, 23);
            txtCPU.TabIndex = 2;
            // 
            // txtRAM
            // 
            txtRAM.Location = new Point(30, 110);
            txtRAM.Name = "txtRAM";
            txtRAM.PlaceholderText = "RAM (GB)";
            txtRAM.Size = new Size(200, 23);
            txtRAM.TabIndex = 3;
            // 
            // txtStorage
            // 
            txtStorage.Location = new Point(30, 140);
            txtStorage.Name = "txtStorage";
            txtStorage.PlaceholderText = "Storage (GB)";
            txtStorage.Size = new Size(200, 23);
            txtStorage.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(30, 170);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(250, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "დამატება";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(250, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "წაშლა";
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Location = new Point(30, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(600, 200);
            dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            ClientSize = new Size(700, 450);
            Controls.Add(txtBrand);
            Controls.Add(txtModel);
            Controls.Add(txtCPU);
            Controls.Add(txtRAM);
            Controls.Add(txtStorage);
            Controls.Add(txtPrice);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Laptop Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
