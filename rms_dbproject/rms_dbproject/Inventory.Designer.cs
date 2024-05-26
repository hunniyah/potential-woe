namespace rms_dbproject
{
    partial class Inventory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            topbar = new Panel();
            btn_back = new button();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel1 = new Panel();
            inventory_panel = new ReaLTaiizor.Controls.PoisonPanel();
            inventoryData = new ReaLTaiizor.Controls.PoisonDataGridView();
            lbl_inventoryDetails = new Label();
            pName = new DataGridViewTextBoxColumn();
            pPrice = new DataGridViewTextBoxColumn();
            prodColor = new DataGridViewTextBoxColumn();
            pQuantity = new DataGridViewTextBoxColumn();
            topbar.SuspendLayout();
            panel1.SuspendLayout();
            inventory_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inventoryData).BeginInit();
            SuspendLayout();
            // 
            // topbar
            // 
            topbar.BackColor = Color.FromArgb(36, 36, 36);
            topbar.Controls.Add(btn_back);
            topbar.Controls.Add(nightControlBox1);
            topbar.Dock = DockStyle.Top;
            topbar.Location = new Point(0, 0);
            topbar.Name = "topbar";
            topbar.Size = new Size(1425, 56);
            topbar.TabIndex = 2;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(36, 36, 36);
            btn_back.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.White;
            btn_back.Hoverforecolor1 = Color.FromArgb(1, 20, 37);
            btn_back.HoverImage1 = null;
            btn_back.Location = new Point(24, 3);
            btn_back.Name = "btn_back";
            btn_back.Normalforecolor1 = Color.White;
            btn_back.NormalImage1 = null;
            btn_back.Size = new Size(71, 41);
            btn_back.TabIndex = 6;
            btn_back.Text = "<";
            btn_back.Tooltip1 = null;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1286, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 124, 137);
            panel1.Controls.Add(inventory_panel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 231);
            panel1.Name = "panel1";
            panel1.Size = new Size(1425, 422);
            panel1.TabIndex = 4;
            // 
            // inventory_panel
            // 
            inventory_panel.BackColor = Color.FromArgb(92, 124, 137);
            inventory_panel.Controls.Add(inventoryData);
            inventory_panel.Dock = DockStyle.Fill;
            inventory_panel.HorizontalScrollbarBarColor = true;
            inventory_panel.HorizontalScrollbarHighlightOnWheel = false;
            inventory_panel.HorizontalScrollbarSize = 10;
            inventory_panel.Location = new Point(0, 0);
            inventory_panel.Name = "inventory_panel";
            inventory_panel.Size = new Size(1425, 422);
            inventory_panel.TabIndex = 0;
            inventory_panel.VerticalScrollbarBarColor = true;
            inventory_panel.VerticalScrollbarHighlightOnWheel = false;
            inventory_panel.VerticalScrollbarSize = 10;
            // 
            // inventoryData
            // 
            inventoryData.AllowUserToOrderColumns = true;
            inventoryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventoryData.BackgroundColor = Color.LightSteelBlue;
            inventoryData.BorderStyle = BorderStyle.None;
            inventoryData.CellBorderStyle = DataGridViewCellBorderStyle.None;
            inventoryData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            inventoryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            inventoryData.ColumnHeadersHeight = 40;
            inventoryData.Columns.AddRange(new DataGridViewColumn[] { pName, pPrice, prodColor, pQuantity });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            inventoryData.DefaultCellStyle = dataGridViewCellStyle2;
            inventoryData.Dock = DockStyle.Fill;
            inventoryData.EnableHeadersVisualStyles = false;
            inventoryData.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            inventoryData.GridColor = Color.White;
            inventoryData.ImeMode = ImeMode.NoControl;
            inventoryData.Location = new Point(0, 0);
            inventoryData.Name = "inventoryData";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            inventoryData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            inventoryData.RowHeadersWidth = 62;
            inventoryData.RowTemplate.Height = 50;
            inventoryData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inventoryData.Size = new Size(1425, 422);
            inventoryData.TabIndex = 5;
            inventoryData.UseCustomBackColor = true;
            inventoryData.UseCustomForeColor = true;
            // 
            // lbl_inventoryDetails
            // 
            lbl_inventoryDetails.Anchor = AnchorStyles.Top;
            lbl_inventoryDetails.AutoSize = true;
            lbl_inventoryDetails.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_inventoryDetails.Location = new Point(562, 108);
            lbl_inventoryDetails.Name = "lbl_inventoryDetails";
            lbl_inventoryDetails.Size = new Size(293, 41);
            lbl_inventoryDetails.TabIndex = 5;
            lbl_inventoryDetails.Text = "Inventory Details";
            // 
            // pName
            // 
            pName.HeaderText = "NAME";
            pName.MinimumWidth = 10;
            pName.Name = "pName";
            // 
            // pPrice
            // 
            pPrice.HeaderText = "PRICE";
            pPrice.MinimumWidth = 8;
            pPrice.Name = "pPrice";
            // 
            // prodColor
            // 
            prodColor.HeaderText = "COLOR";
            prodColor.MinimumWidth = 8;
            prodColor.Name = "prodColor";
            // 
            // pQuantity
            // 
            pQuantity.HeaderText = "QUANTITY";
            pQuantity.MinimumWidth = 8;
            pQuantity.Name = "pQuantity";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1425, 653);
            Controls.Add(lbl_inventoryDetails);
            Controls.Add(panel1);
            Controls.Add(topbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            topbar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            inventory_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inventoryData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel topbar;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panel1;
        private Label lbl_inventoryDetails;
        private ReaLTaiizor.Controls.PoisonPanel inventory_panel;
        private ReaLTaiizor.Controls.PoisonDataGridView inventoryData;
        private button btn_back;
        private DataGridViewTextBoxColumn pName;
        private DataGridViewTextBoxColumn pPrice;
        private DataGridViewTextBoxColumn prodColor;
        private DataGridViewTextBoxColumn pQuantity;
    }
}