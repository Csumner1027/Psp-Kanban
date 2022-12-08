namespace PSP_KanBan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kit_csv_quantity = new System.Windows.Forms.Label();
            this.clear_kit = new System.Windows.Forms.Button();
            this.remove_kit = new System.Windows.Forms.Button();
            this.add_Kit = new System.Windows.Forms.Button();
            this.kits_kitLabel = new System.Windows.Forms.Label();
            this.kits_comboBox = new System.Windows.Forms.ComboBox();
            this.kit_quantityLabel = new System.Windows.Forms.Label();
            this.kits_upDown = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.psp_quantity = new System.Windows.Forms.Label();
            this.psp_csv_quantity = new System.Windows.Forms.Label();
            this.psp_quantityLabel = new System.Windows.Forms.Label();
            this.psp_pspLabel = new System.Windows.Forms.Label();
            this.clear_psp = new System.Windows.Forms.Button();
            this.remove_psp = new System.Windows.Forms.Button();
            this.add_psp = new System.Windows.Forms.Button();
            this.psp_upDown = new System.Windows.Forms.NumericUpDown();
            this.psp_comboBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.plates_quantityLabel = new System.Windows.Forms.Label();
            this.plates_plateLabel = new System.Windows.Forms.Label();
            this.plates_clear = new System.Windows.Forms.Button();
            this.plates_remove = new System.Windows.Forms.Button();
            this.plates_add = new System.Windows.Forms.Button();
            this.plates_upDown = new System.Windows.Forms.NumericUpDown();
            this.plates_comboBox = new System.Windows.Forms.ComboBox();
            this.plates_csv_quantity = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinStartLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kits_upDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psp_upDown)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plates_upDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(379, 260);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.kit_csv_quantity);
            this.tabPage1.Controls.Add(this.clear_kit);
            this.tabPage1.Controls.Add(this.remove_kit);
            this.tabPage1.Controls.Add(this.add_Kit);
            this.tabPage1.Controls.Add(this.kits_kitLabel);
            this.tabPage1.Controls.Add(this.kits_comboBox);
            this.tabPage1.Controls.Add(this.kit_quantityLabel);
            this.tabPage1.Controls.Add(this.kits_upDown);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(371, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kits";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // kit_csv_quantity
            // 
            this.kit_csv_quantity.AutoSize = true;
            this.kit_csv_quantity.Location = new System.Drawing.Point(108, 86);
            this.kit_csv_quantity.Name = "kit_csv_quantity";
            this.kit_csv_quantity.Size = new System.Drawing.Size(0, 21);
            this.kit_csv_quantity.TabIndex = 7;
            // 
            // clear_kit
            // 
            this.clear_kit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear_kit.Location = new System.Drawing.Point(195, 110);
            this.clear_kit.Name = "clear_kit";
            this.clear_kit.Size = new System.Drawing.Size(120, 29);
            this.clear_kit.TabIndex = 6;
            this.clear_kit.Text = "Clear";
            this.clear_kit.UseVisualStyleBackColor = true;
            this.clear_kit.Click += new System.EventHandler(this.clear_kit_Click);
            // 
            // remove_kit
            // 
            this.remove_kit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove_kit.Location = new System.Drawing.Point(185, 161);
            this.remove_kit.Name = "remove_kit";
            this.remove_kit.Size = new System.Drawing.Size(152, 55);
            this.remove_kit.TabIndex = 5;
            this.remove_kit.Text = "Remove";
            this.remove_kit.UseVisualStyleBackColor = true;
            this.remove_kit.Click += new System.EventHandler(this.remove_kit_Click);
            // 
            // add_Kit
            // 
            this.add_Kit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_Kit.Location = new System.Drawing.Point(19, 161);
            this.add_Kit.Name = "add_Kit";
            this.add_Kit.Size = new System.Drawing.Size(152, 55);
            this.add_Kit.TabIndex = 4;
            this.add_Kit.Text = "Add";
            this.add_Kit.UseVisualStyleBackColor = true;
            this.add_Kit.Click += new System.EventHandler(this.add_Kit_Click);
            // 
            // kits_kitLabel
            // 
            this.kits_kitLabel.AutoSize = true;
            this.kits_kitLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kits_kitLabel.Location = new System.Drawing.Point(18, 18);
            this.kits_kitLabel.Name = "kits_kitLabel";
            this.kits_kitLabel.Size = new System.Drawing.Size(119, 21);
            this.kits_kitLabel.TabIndex = 3;
            this.kits_kitLabel.Text = "Select a PSP Kit:";
            // 
            // kits_comboBox
            // 
            this.kits_comboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kits_comboBox.FormattingEnabled = true;
            this.kits_comboBox.Location = new System.Drawing.Point(19, 42);
            this.kits_comboBox.Name = "kits_comboBox";
            this.kits_comboBox.Size = new System.Drawing.Size(296, 23);
            this.kits_comboBox.TabIndex = 2;
            this.kits_comboBox.Text = "Select a PSP Kit...";
            this.kits_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kit_quantityLabel
            // 
            this.kit_quantityLabel.AutoSize = true;
            this.kit_quantityLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kit_quantityLabel.Location = new System.Drawing.Point(20, 82);
            this.kit_quantityLabel.Name = "kit_quantityLabel";
            this.kit_quantityLabel.Size = new System.Drawing.Size(88, 25);
            this.kit_quantityLabel.TabIndex = 1;
            this.kit_quantityLabel.Text = "Quantity:";
            // 
            // kits_upDown
            // 
            this.kits_upDown.Location = new System.Drawing.Point(19, 110);
            this.kits_upDown.Name = "kits_upDown";
            this.kits_upDown.Size = new System.Drawing.Size(152, 29);
            this.kits_upDown.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.psp_quantity);
            this.tabPage2.Controls.Add(this.psp_csv_quantity);
            this.tabPage2.Controls.Add(this.psp_quantityLabel);
            this.tabPage2.Controls.Add(this.psp_pspLabel);
            this.tabPage2.Controls.Add(this.clear_psp);
            this.tabPage2.Controls.Add(this.remove_psp);
            this.tabPage2.Controls.Add(this.add_psp);
            this.tabPage2.Controls.Add(this.psp_upDown);
            this.tabPage2.Controls.Add(this.psp_comboBox);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(371, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PSPs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // psp_quantity
            // 
            this.psp_quantity.AutoSize = true;
            this.psp_quantity.Location = new System.Drawing.Point(110, 88);
            this.psp_quantity.Name = "psp_quantity";
            this.psp_quantity.Size = new System.Drawing.Size(0, 21);
            this.psp_quantity.TabIndex = 10;
            // 
            // psp_csv_quantity
            // 
            this.psp_csv_quantity.AutoSize = true;
            this.psp_csv_quantity.Location = new System.Drawing.Point(112, 85);
            this.psp_csv_quantity.Name = "psp_csv_quantity";
            this.psp_csv_quantity.Size = new System.Drawing.Size(0, 21);
            this.psp_csv_quantity.TabIndex = 9;
            // 
            // psp_quantityLabel
            // 
            this.psp_quantityLabel.AutoSize = true;
            this.psp_quantityLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.psp_quantityLabel.Location = new System.Drawing.Point(18, 82);
            this.psp_quantityLabel.Name = "psp_quantityLabel";
            this.psp_quantityLabel.Size = new System.Drawing.Size(88, 25);
            this.psp_quantityLabel.TabIndex = 1;
            this.psp_quantityLabel.Text = "Quantity:";
            // 
            // psp_pspLabel
            // 
            this.psp_pspLabel.AutoSize = true;
            this.psp_pspLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.psp_pspLabel.Location = new System.Drawing.Point(18, 18);
            this.psp_pspLabel.Name = "psp_pspLabel";
            this.psp_pspLabel.Size = new System.Drawing.Size(121, 21);
            this.psp_pspLabel.TabIndex = 7;
            this.psp_pspLabel.Text = "Select PSP Type:";
            // 
            // clear_psp
            // 
            this.clear_psp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear_psp.Location = new System.Drawing.Point(195, 110);
            this.clear_psp.Name = "clear_psp";
            this.clear_psp.Size = new System.Drawing.Size(120, 29);
            this.clear_psp.TabIndex = 6;
            this.clear_psp.Text = "Clear";
            this.clear_psp.UseVisualStyleBackColor = true;
            this.clear_psp.Click += new System.EventHandler(this.clear_psp_Click);
            // 
            // remove_psp
            // 
            this.remove_psp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove_psp.Location = new System.Drawing.Point(185, 161);
            this.remove_psp.Name = "remove_psp";
            this.remove_psp.Size = new System.Drawing.Size(152, 55);
            this.remove_psp.TabIndex = 5;
            this.remove_psp.Text = "Remove";
            this.remove_psp.UseVisualStyleBackColor = true;
            this.remove_psp.Click += new System.EventHandler(this.remove_psp_Click);
            // 
            // add_psp
            // 
            this.add_psp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_psp.Location = new System.Drawing.Point(19, 161);
            this.add_psp.Name = "add_psp";
            this.add_psp.Size = new System.Drawing.Size(152, 55);
            this.add_psp.TabIndex = 4;
            this.add_psp.Text = "Add";
            this.add_psp.UseVisualStyleBackColor = true;
            this.add_psp.Click += new System.EventHandler(this.add_psp_Click);
            // 
            // psp_upDown
            // 
            this.psp_upDown.Location = new System.Drawing.Point(19, 110);
            this.psp_upDown.Name = "psp_upDown";
            this.psp_upDown.Size = new System.Drawing.Size(152, 29);
            this.psp_upDown.TabIndex = 3;
            // 
            // psp_comboBox
            // 
            this.psp_comboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.psp_comboBox.FormattingEnabled = true;
            this.psp_comboBox.Location = new System.Drawing.Point(19, 42);
            this.psp_comboBox.Name = "psp_comboBox";
            this.psp_comboBox.Size = new System.Drawing.Size(296, 23);
            this.psp_comboBox.TabIndex = 1;
            this.psp_comboBox.Text = "Select PSP Type...";
            this.psp_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.plates_quantityLabel);
            this.tabPage3.Controls.Add(this.plates_plateLabel);
            this.tabPage3.Controls.Add(this.plates_clear);
            this.tabPage3.Controls.Add(this.plates_remove);
            this.tabPage3.Controls.Add(this.plates_add);
            this.tabPage3.Controls.Add(this.plates_upDown);
            this.tabPage3.Controls.Add(this.plates_comboBox);
            this.tabPage3.Controls.Add(this.plates_csv_quantity);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(371, 232);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Plates";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // plates_quantityLabel
            // 
            this.plates_quantityLabel.AutoSize = true;
            this.plates_quantityLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plates_quantityLabel.Location = new System.Drawing.Point(18, 82);
            this.plates_quantityLabel.Name = "plates_quantityLabel";
            this.plates_quantityLabel.Size = new System.Drawing.Size(88, 25);
            this.plates_quantityLabel.TabIndex = 8;
            this.plates_quantityLabel.Text = "Quantity:";
            // 
            // plates_plateLabel
            // 
            this.plates_plateLabel.AutoSize = true;
            this.plates_plateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plates_plateLabel.Location = new System.Drawing.Point(18, 18);
            this.plates_plateLabel.Name = "plates_plateLabel";
            this.plates_plateLabel.Size = new System.Drawing.Size(128, 21);
            this.plates_plateLabel.TabIndex = 7;
            this.plates_plateLabel.Text = "Select Plate Type:";
            // 
            // plates_clear
            // 
            this.plates_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plates_clear.Location = new System.Drawing.Point(195, 110);
            this.plates_clear.Name = "plates_clear";
            this.plates_clear.Size = new System.Drawing.Size(120, 29);
            this.plates_clear.TabIndex = 6;
            this.plates_clear.Text = "Clear";
            this.plates_clear.UseVisualStyleBackColor = true;
            this.plates_clear.Click += new System.EventHandler(this.plates_clear_Click);
            // 
            // plates_remove
            // 
            this.plates_remove.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plates_remove.Location = new System.Drawing.Point(185, 161);
            this.plates_remove.Name = "plates_remove";
            this.plates_remove.Size = new System.Drawing.Size(152, 55);
            this.plates_remove.TabIndex = 5;
            this.plates_remove.Text = "Remove";
            this.plates_remove.UseVisualStyleBackColor = true;
            this.plates_remove.Click += new System.EventHandler(this.plates_remove_Click);
            // 
            // plates_add
            // 
            this.plates_add.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plates_add.Location = new System.Drawing.Point(19, 161);
            this.plates_add.Name = "plates_add";
            this.plates_add.Size = new System.Drawing.Size(152, 55);
            this.plates_add.TabIndex = 4;
            this.plates_add.Text = "Add";
            this.plates_add.UseVisualStyleBackColor = true;
            this.plates_add.Click += new System.EventHandler(this.plates_add_Click);
            // 
            // plates_upDown
            // 
            this.plates_upDown.Location = new System.Drawing.Point(19, 110);
            this.plates_upDown.Name = "plates_upDown";
            this.plates_upDown.Size = new System.Drawing.Size(152, 29);
            this.plates_upDown.TabIndex = 3;
            // 
            // plates_comboBox
            // 
            this.plates_comboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plates_comboBox.FormattingEnabled = true;
            this.plates_comboBox.Location = new System.Drawing.Point(19, 42);
            this.plates_comboBox.Name = "plates_comboBox";
            this.plates_comboBox.Size = new System.Drawing.Size(296, 23);
            this.plates_comboBox.TabIndex = 1;
            this.plates_comboBox.Text = "Select Plate Type...";
            this.plates_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // plates_csv_quantity
            // 
            this.plates_csv_quantity.AutoSize = true;
            this.plates_csv_quantity.Location = new System.Drawing.Point(111, 86);
            this.plates_csv_quantity.Name = "plates_csv_quantity";
            this.plates_csv_quantity.Size = new System.Drawing.Size(0, 21);
            this.plates_csv_quantity.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pinStartLocationToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // pinStartLocationToolStripMenuItem
            // 
            this.pinStartLocationToolStripMenuItem.Name = "pinStartLocationToolStripMenuItem";
            this.pinStartLocationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pinStartLocationToolStripMenuItem.Text = "Pin Start Location";
            this.pinStartLocationToolStripMenuItem.Click += new System.EventHandler(this.pinStartLocationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 290);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PSP Kanban";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.saveSizeAndPosition);
            this.Load += new System.EventHandler(this.saveSizeAndPosition);
            this.LocationChanged += new System.EventHandler(this.saveSizeAndPosition);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kits_upDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psp_upDown)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plates_upDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label kits_kitLabel;
        private ComboBox kits_comboBox;
        private Label kit_quantityLabel;
        private NumericUpDown kits_upDown;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private Button clear_kit;
        private Button remove_kit;
        private Button add_Kit;
        private TabPage tabPage3;
        private ComboBox psp_comboBox;
        private Button clear_psp;
        private Button remove_psp;
        private Button add_psp;
        private NumericUpDown psp_upDown;
        private Button plates_clear;
        private Button plates_remove;
        private Button plates_add;
        private NumericUpDown plates_upDown;
        private ComboBox plates_comboBox;
        private Label psp_quantityLabel;
        private Label psp_pspLabel;
        private Label plates_quantityLabel;
        private Label plates_plateLabel;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Label kit_csv_quantity;
        private Label psp_csv_quantity;
        private Label psp_quantity;
        private Label plates_csv_quantity;

        private ToolStripMenuItem pinStartLocationToolStripMenuItem;
        
    }
}