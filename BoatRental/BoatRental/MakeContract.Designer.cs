namespace BoatRental
{
    partial class MakeContract
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
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.FriescheLakesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.LakesListBox = new System.Windows.Forms.ListBox();
            this.AddLakeButton = new System.Windows.Forms.Button();
            this.ChosenLakesListBox = new System.Windows.Forms.ListBox();
            this.ChosenBoatsListBox = new System.Windows.Forms.ListBox();
            this.AddBoatButton = new System.Windows.Forms.Button();
            this.BoatsListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChosenItemsListBox = new System.Windows.Forms.ListBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CancelContractButton = new System.Windows.Forms.Button();
            this.AcceptContractButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LakePriceLabel = new System.Windows.Forms.Label();
            this.BoatPriceLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PaysLockLabel = new System.Windows.Forms.Label();
            this.MotorNameLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MayTraverseLakes = new System.Windows.Forms.Label();
            this.ActionRadiusLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ItemPriceLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DeleteLakeButton = new System.Windows.Forms.Button();
            this.DeleteBoatButton = new System.Windows.Forms.Button();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FriescheLakesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateTimePicker.Location = new System.Drawing.Point(109, 12);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(130, 22);
            this.StartDateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Einde datum:";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Location = new System.Drawing.Point(109, 41);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(130, 22);
            this.EndDateTimePicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aantal te varen Friese meren:";
            // 
            // FriescheLakesNumericUpDown
            // 
            this.FriescheLakesNumericUpDown.Location = new System.Drawing.Point(245, 69);
            this.FriescheLakesNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.FriescheLakesNumericUpDown.Name = "FriescheLakesNumericUpDown";
            this.FriescheLakesNumericUpDown.Size = new System.Drawing.Size(193, 22);
            this.FriescheLakesNumericUpDown.TabIndex = 5;
            this.FriescheLakesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Speciale te varen meren:";
            // 
            // LakesListBox
            // 
            this.LakesListBox.FormattingEnabled = true;
            this.LakesListBox.ItemHeight = 16;
            this.LakesListBox.Location = new System.Drawing.Point(16, 113);
            this.LakesListBox.Name = "LakesListBox";
            this.LakesListBox.Size = new System.Drawing.Size(120, 116);
            this.LakesListBox.TabIndex = 7;
            this.LakesListBox.SelectedIndexChanged += new System.EventHandler(this.LakesListBox_SelectedIndexChanged);
            // 
            // AddLakeButton
            // 
            this.AddLakeButton.Location = new System.Drawing.Point(16, 235);
            this.AddLakeButton.Name = "AddLakeButton";
            this.AddLakeButton.Size = new System.Drawing.Size(120, 30);
            this.AddLakeButton.TabIndex = 8;
            this.AddLakeButton.Text = "Toevoegen";
            this.AddLakeButton.UseVisualStyleBackColor = true;
            this.AddLakeButton.Click += new System.EventHandler(this.AddLakeButton_Click);
            // 
            // ChosenLakesListBox
            // 
            this.ChosenLakesListBox.FormattingEnabled = true;
            this.ChosenLakesListBox.ItemHeight = 16;
            this.ChosenLakesListBox.Location = new System.Drawing.Point(318, 113);
            this.ChosenLakesListBox.Name = "ChosenLakesListBox";
            this.ChosenLakesListBox.Size = new System.Drawing.Size(120, 116);
            this.ChosenLakesListBox.TabIndex = 9;
            // 
            // ChosenBoatsListBox
            // 
            this.ChosenBoatsListBox.FormattingEnabled = true;
            this.ChosenBoatsListBox.ItemHeight = 16;
            this.ChosenBoatsListBox.Location = new System.Drawing.Point(318, 288);
            this.ChosenBoatsListBox.Name = "ChosenBoatsListBox";
            this.ChosenBoatsListBox.Size = new System.Drawing.Size(120, 116);
            this.ChosenBoatsListBox.TabIndex = 13;
            // 
            // AddBoatButton
            // 
            this.AddBoatButton.Location = new System.Drawing.Point(16, 410);
            this.AddBoatButton.Name = "AddBoatButton";
            this.AddBoatButton.Size = new System.Drawing.Size(120, 30);
            this.AddBoatButton.TabIndex = 12;
            this.AddBoatButton.Text = "Toevoegen";
            this.AddBoatButton.UseVisualStyleBackColor = true;
            this.AddBoatButton.Click += new System.EventHandler(this.AddBoatButton_Click);
            // 
            // BoatsListBox
            // 
            this.BoatsListBox.FormattingEnabled = true;
            this.BoatsListBox.ItemHeight = 16;
            this.BoatsListBox.Location = new System.Drawing.Point(16, 288);
            this.BoatsListBox.Name = "BoatsListBox";
            this.BoatsListBox.Size = new System.Drawing.Size(120, 116);
            this.BoatsListBox.TabIndex = 11;
            this.BoatsListBox.SelectedIndexChanged += new System.EventHandler(this.BoatsListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Boten om mee te varen:";
            // 
            // ChosenItemsListBox
            // 
            this.ChosenItemsListBox.FormattingEnabled = true;
            this.ChosenItemsListBox.ItemHeight = 16;
            this.ChosenItemsListBox.Location = new System.Drawing.Point(318, 463);
            this.ChosenItemsListBox.Name = "ChosenItemsListBox";
            this.ChosenItemsListBox.Size = new System.Drawing.Size(120, 116);
            this.ChosenItemsListBox.TabIndex = 17;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(15, 585);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(117, 30);
            this.AddItemButton.TabIndex = 16;
            this.AddItemButton.Text = "Toevoegen";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 16;
            this.ItemsListBox.Location = new System.Drawing.Point(13, 463);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(120, 116);
            this.ItemsListBox.TabIndex = 15;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Extra artikelen:";
            // 
            // CancelContractButton
            // 
            this.CancelContractButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelContractButton.Location = new System.Drawing.Point(15, 621);
            this.CancelContractButton.Name = "CancelContractButton";
            this.CancelContractButton.Size = new System.Drawing.Size(120, 49);
            this.CancelContractButton.TabIndex = 18;
            this.CancelContractButton.Text = "Annuleer";
            this.CancelContractButton.UseVisualStyleBackColor = true;
            // 
            // AcceptContractButton
            // 
            this.AcceptContractButton.Location = new System.Drawing.Point(318, 620);
            this.AcceptContractButton.Name = "AcceptContractButton";
            this.AcceptContractButton.Size = new System.Drawing.Size(120, 50);
            this.AcceptContractButton.TabIndex = 19;
            this.AcceptContractButton.Text = "Accepteer contract";
            this.AcceptContractButton.UseVisualStyleBackColor = true;
            this.AcceptContractButton.Click += new System.EventHandler(this.AcceptContractButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Prijs:";
            // 
            // LakePriceLabel
            // 
            this.LakePriceLabel.Location = new System.Drawing.Point(187, 113);
            this.LakePriceLabel.Name = "LakePriceLabel";
            this.LakePriceLabel.Size = new System.Drawing.Size(125, 23);
            this.LakePriceLabel.TabIndex = 21;
            // 
            // BoatPriceLabel
            // 
            this.BoatPriceLabel.Location = new System.Drawing.Point(188, 288);
            this.BoatPriceLabel.Name = "BoatPriceLabel";
            this.BoatPriceLabel.Size = new System.Drawing.Size(124, 23);
            this.BoatPriceLabel.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Prijs:";
            // 
            // PaysLockLabel
            // 
            this.PaysLockLabel.AutoSize = true;
            this.PaysLockLabel.Location = new System.Drawing.Point(143, 374);
            this.PaysLockLabel.Name = "PaysLockLabel";
            this.PaysLockLabel.Size = new System.Drawing.Size(148, 17);
            this.PaysLockLabel.TabIndex = 24;
            this.PaysLockLabel.Text = "Betaald geen sluitgeld";
            this.PaysLockLabel.Visible = false;
            // 
            // MotorNameLabel
            // 
            this.MotorNameLabel.Location = new System.Drawing.Point(230, 311);
            this.MotorNameLabel.Name = "MotorNameLabel";
            this.MotorNameLabel.Size = new System.Drawing.Size(82, 23);
            this.MotorNameLabel.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Aandrijving:";
            // 
            // MayTraverseLakes
            // 
            this.MayTraverseLakes.AutoSize = true;
            this.MayTraverseLakes.Location = new System.Drawing.Point(143, 357);
            this.MayTraverseLakes.Name = "MayTraverseLakes";
            this.MayTraverseLakes.Size = new System.Drawing.Size(155, 17);
            this.MayTraverseLakes.TabIndex = 27;
            this.MayTraverseLakes.Text = "Mag op speciale meren";
            this.MayTraverseLakes.Visible = false;
            // 
            // ActionRadiusLabel
            // 
            this.ActionRadiusLabel.Location = new System.Drawing.Point(241, 334);
            this.ActionRadiusLabel.Name = "ActionRadiusLabel";
            this.ActionRadiusLabel.Size = new System.Drawing.Size(71, 23);
            this.ActionRadiusLabel.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(142, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Actie-radius:";
            // 
            // ItemPriceLabel
            // 
            this.ItemPriceLabel.Location = new System.Drawing.Point(187, 463);
            this.ItemPriceLabel.Name = "ItemPriceLabel";
            this.ItemPriceLabel.Size = new System.Drawing.Size(125, 23);
            this.ItemPriceLabel.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(142, 463);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Prijs:";
            // 
            // DeleteLakeButton
            // 
            this.DeleteLakeButton.Location = new System.Drawing.Point(319, 235);
            this.DeleteLakeButton.Name = "DeleteLakeButton";
            this.DeleteLakeButton.Size = new System.Drawing.Size(120, 30);
            this.DeleteLakeButton.TabIndex = 32;
            this.DeleteLakeButton.Text = "Verwijderen";
            this.DeleteLakeButton.UseVisualStyleBackColor = true;
            this.DeleteLakeButton.Click += new System.EventHandler(this.DeleteLakeButton_Click);
            // 
            // DeleteBoatButton
            // 
            this.DeleteBoatButton.Location = new System.Drawing.Point(318, 410);
            this.DeleteBoatButton.Name = "DeleteBoatButton";
            this.DeleteBoatButton.Size = new System.Drawing.Size(120, 30);
            this.DeleteBoatButton.TabIndex = 33;
            this.DeleteBoatButton.Text = "Verwijderen";
            this.DeleteBoatButton.UseVisualStyleBackColor = true;
            this.DeleteBoatButton.Click += new System.EventHandler(this.DeleteBoatButton_Click);
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.Location = new System.Drawing.Point(318, 584);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(120, 30);
            this.DeleteItemButton.TabIndex = 34;
            this.DeleteItemButton.Text = "Verwijderen";
            this.DeleteItemButton.UseVisualStyleBackColor = true;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // MakeContract
            // 
            this.AcceptButton = this.AcceptContractButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.CancelContractButton;
            this.ClientSize = new System.Drawing.Size(451, 682);
            this.ControlBox = false;
            this.Controls.Add(this.DeleteItemButton);
            this.Controls.Add(this.DeleteBoatButton);
            this.Controls.Add(this.DeleteLakeButton);
            this.Controls.Add(this.ItemPriceLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ActionRadiusLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MayTraverseLakes);
            this.Controls.Add(this.MotorNameLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PaysLockLabel);
            this.Controls.Add(this.BoatPriceLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LakePriceLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AcceptContractButton);
            this.Controls.Add(this.CancelContractButton);
            this.Controls.Add(this.ChosenItemsListBox);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ChosenBoatsListBox);
            this.Controls.Add(this.AddBoatButton);
            this.Controls.Add(this.BoatsListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChosenLakesListBox);
            this.Controls.Add(this.AddLakeButton);
            this.Controls.Add(this.LakesListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FriescheLakesNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeContract";
            this.Text = "MakeContract";
            ((System.ComponentModel.ISupportInitialize)(this.FriescheLakesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown FriescheLakesNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LakesListBox;
        private System.Windows.Forms.Button AddLakeButton;
        private System.Windows.Forms.ListBox ChosenLakesListBox;
        private System.Windows.Forms.ListBox ChosenBoatsListBox;
        private System.Windows.Forms.Button AddBoatButton;
        private System.Windows.Forms.ListBox BoatsListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ChosenItemsListBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CancelContractButton;
        private System.Windows.Forms.Button AcceptContractButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LakePriceLabel;
        private System.Windows.Forms.Label BoatPriceLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label PaysLockLabel;
        private System.Windows.Forms.Label MotorNameLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label MayTraverseLakes;
        private System.Windows.Forms.Label ActionRadiusLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ItemPriceLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DeleteLakeButton;
        private System.Windows.Forms.Button DeleteBoatButton;
        private System.Windows.Forms.Button DeleteItemButton;
    }
}