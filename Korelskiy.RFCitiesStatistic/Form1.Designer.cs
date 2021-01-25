
namespace Korelskiy.RFCitiesStatistic
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addToDbCheckBox = new System.Windows.Forms.CheckBox();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.placeInRatingLabel = new System.Windows.Forms.Label();
            this.addCityButton = new System.Windows.Forms.Button();
            this.oneYearStatisticLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.allYearsStatisticLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.secondYearPopulationTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstYearPopulationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.secondYearTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstYearTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.citiesDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 483);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.addToDbCheckBox);
            this.tabPage1.Controls.Add(this.yearsLabel);
            this.tabPage1.Controls.Add(this.placeInRatingLabel);
            this.tabPage1.Controls.Add(this.addCityButton);
            this.tabPage1.Controls.Add(this.oneYearStatisticLabel);
            this.tabPage1.Controls.Add(this.resultLabel);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.allYearsStatisticLabel);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.secondYearPopulationTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.firstYearPopulationTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.secondYearTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.firstYearTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cityNameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add city";
            // 
            // addToDbCheckBox
            // 
            this.addToDbCheckBox.AutoSize = true;
            this.addToDbCheckBox.Location = new System.Drawing.Point(176, 6);
            this.addToDbCheckBox.Name = "addToDbCheckBox";
            this.addToDbCheckBox.Size = new System.Drawing.Size(205, 29);
            this.addToDbCheckBox.TabIndex = 35;
            this.addToDbCheckBox.Text = "Не добавлять в бд";
            this.addToDbCheckBox.UseVisualStyleBackColor = true;
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(444, 14);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(60, 25);
            this.yearsLabel.TabIndex = 34;
            this.yearsLabel.Text = "years";
            this.yearsLabel.Visible = false;
            // 
            // placeInRatingLabel
            // 
            this.placeInRatingLabel.AutoSize = true;
            this.placeInRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeInRatingLabel.Location = new System.Drawing.Point(435, 359);
            this.placeInRatingLabel.Name = "placeInRatingLabel";
            this.placeInRatingLabel.Size = new System.Drawing.Size(190, 69);
            this.placeInRatingLabel.TabIndex = 33;
            this.placeInRatingLabel.Text = "label9";
            this.placeInRatingLabel.Visible = false;
            // 
            // addCityButton
            // 
            this.addCityButton.ForeColor = System.Drawing.Color.Black;
            this.addCityButton.Location = new System.Drawing.Point(75, 359);
            this.addCityButton.Name = "addCityButton";
            this.addCityButton.Size = new System.Drawing.Size(214, 43);
            this.addCityButton.TabIndex = 32;
            this.addCityButton.Text = "Анализировать";
            this.addCityButton.UseVisualStyleBackColor = true;
            this.addCityButton.Click += new System.EventHandler(this.addCityButton_Click);
            // 
            // oneYearStatisticLabel
            // 
            this.oneYearStatisticLabel.AutoSize = true;
            this.oneYearStatisticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneYearStatisticLabel.Location = new System.Drawing.Point(441, 228);
            this.oneYearStatisticLabel.Name = "oneYearStatisticLabel";
            this.oneYearStatisticLabel.Size = new System.Drawing.Size(122, 44);
            this.oneYearStatisticLabel.TabIndex = 31;
            this.oneYearStatisticLabel.Text = "label8";
            this.oneYearStatisticLabel.Visible = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(441, 296);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(93, 32);
            this.resultLabel.TabIndex = 30;
            this.resultLabel.Text = "label7";
            this.resultLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(424, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 15);
            this.panel2.TabIndex = 29;
            // 
            // allYearsStatisticLabel
            // 
            this.allYearsStatisticLabel.AutoSize = true;
            this.allYearsStatisticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allYearsStatisticLabel.Location = new System.Drawing.Point(426, 48);
            this.allYearsStatisticLabel.Name = "allYearsStatisticLabel";
            this.allYearsStatisticLabel.Size = new System.Drawing.Size(379, 135);
            this.allYearsStatisticLabel.TabIndex = 28;
            this.allYearsStatisticLabel.Text = "label6";
            this.allYearsStatisticLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(387, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(31, 450);
            this.panel1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Население";
            // 
            // secondYearPopulationTextBox
            // 
            this.secondYearPopulationTextBox.Location = new System.Drawing.Point(206, 286);
            this.secondYearPopulationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondYearPopulationTextBox.Name = "secondYearPopulationTextBox";
            this.secondYearPopulationTextBox.Size = new System.Drawing.Size(142, 30);
            this.secondYearPopulationTextBox.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Население";
            // 
            // firstYearPopulationTextBox
            // 
            this.firstYearPopulationTextBox.Location = new System.Drawing.Point(30, 286);
            this.firstYearPopulationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstYearPopulationTextBox.Name = "firstYearPopulationTextBox";
            this.firstYearPopulationTextBox.Size = new System.Drawing.Size(143, 30);
            this.firstYearPopulationTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(208, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Год конца измерения";
            // 
            // secondYearTextBox
            // 
            this.secondYearTextBox.Location = new System.Drawing.Point(206, 198);
            this.secondYearTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondYearTextBox.Name = "secondYearTextBox";
            this.secondYearTextBox.Size = new System.Drawing.Size(137, 30);
            this.secondYearTextBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Год начала измерения";
            // 
            // firstYearTextBox
            // 
            this.firstYearTextBox.Location = new System.Drawing.Point(30, 198);
            this.firstYearTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstYearTextBox.Name = "firstYearTextBox";
            this.firstYearTextBox.Size = new System.Drawing.Size(138, 30);
            this.firstYearTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название города";
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Location = new System.Drawing.Point(30, 93);
            this.cityNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(313, 30);
            this.cityNameTextBox.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.citiesDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All cities";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 48);
            this.panel3.TabIndex = 1;
            // 
            // citiesDataGridView
            // 
            this.citiesDataGridView.AllowUserToAddRows = false;
            this.citiesDataGridView.AllowUserToDeleteRows = false;
            this.citiesDataGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.citiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesDataGridView.Location = new System.Drawing.Point(3, 61);
            this.citiesDataGridView.Name = "citiesDataGridView";
            this.citiesDataGridView.ReadOnly = true;
            this.citiesDataGridView.RowHeadersWidth = 51;
            this.citiesDataGridView.RowTemplate.Height = 24;
            this.citiesDataGridView.Size = new System.Drawing.Size(941, 375);
            this.citiesDataGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(970, 486);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Russian cities";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label placeInRatingLabel;
        private System.Windows.Forms.Button addCityButton;
        private System.Windows.Forms.Label oneYearStatisticLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label allYearsStatisticLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox secondYearPopulationTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstYearPopulationTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox secondYearTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstYearTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView citiesDataGridView;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.CheckBox addToDbCheckBox;
    }
}

