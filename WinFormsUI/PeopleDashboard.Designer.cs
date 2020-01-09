namespace WinFormsUI
{
  partial class PeopleDashboard
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
      this.headerMainLabel = new System.Windows.Forms.Label();
      this.headerFirstNameLabel = new System.Windows.Forms.Label();
      this.headerLastNameLabel = new System.Windows.Forms.Label();
      this.headerAgeLabel = new System.Windows.Forms.Label();
      this.headerIsAliveLabel = new System.Windows.Forms.Label();
      this.firstNameTextBox = new System.Windows.Forms.TextBox();
      this.lastNameTextBox = new System.Windows.Forms.TextBox();
      this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.isAliveCheckBox = new System.Windows.Forms.CheckBox();
      this.saveListButton = new System.Windows.Forms.Button();
      this.addUserButton = new System.Windows.Forms.Button();
      this.peopleListBox = new System.Windows.Forms.ListBox();
      ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // headerMainLabel
      // 
      this.headerMainLabel.AutoSize = true;
      this.headerMainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerMainLabel.Location = new System.Drawing.Point(13, 13);
      this.headerMainLabel.Name = "headerMainLabel";
      this.headerMainLabel.Size = new System.Drawing.Size(314, 39);
      this.headerMainLabel.TabIndex = 0;
      this.headerMainLabel.Text = "Text File Challenge";
      // 
      // headerFirstNameLabel
      // 
      this.headerFirstNameLabel.AutoSize = true;
      this.headerFirstNameLabel.Location = new System.Drawing.Point(12, 68);
      this.headerFirstNameLabel.Name = "headerFirstNameLabel";
      this.headerFirstNameLabel.Size = new System.Drawing.Size(122, 25);
      this.headerFirstNameLabel.TabIndex = 1;
      this.headerFirstNameLabel.Text = "First Name:";
      // 
      // headerLastNameLabel
      // 
      this.headerLastNameLabel.AutoSize = true;
      this.headerLastNameLabel.Location = new System.Drawing.Point(13, 116);
      this.headerLastNameLabel.Name = "headerLastNameLabel";
      this.headerLastNameLabel.Size = new System.Drawing.Size(121, 25);
      this.headerLastNameLabel.TabIndex = 2;
      this.headerLastNameLabel.Text = "Last Name:";
      // 
      // headerAgeLabel
      // 
      this.headerAgeLabel.AutoSize = true;
      this.headerAgeLabel.Location = new System.Drawing.Point(78, 164);
      this.headerAgeLabel.Name = "headerAgeLabel";
      this.headerAgeLabel.Size = new System.Drawing.Size(56, 25);
      this.headerAgeLabel.TabIndex = 3;
      this.headerAgeLabel.Text = "Age:";
      // 
      // headerIsAliveLabel
      // 
      this.headerIsAliveLabel.AutoSize = true;
      this.headerIsAliveLabel.Location = new System.Drawing.Point(47, 212);
      this.headerIsAliveLabel.Name = "headerIsAliveLabel";
      this.headerIsAliveLabel.Size = new System.Drawing.Size(87, 25);
      this.headerIsAliveLabel.TabIndex = 4;
      this.headerIsAliveLabel.Text = "Is Alive:";
      // 
      // firstNameTextBox
      // 
      this.firstNameTextBox.Location = new System.Drawing.Point(140, 65);
      this.firstNameTextBox.Name = "firstNameTextBox";
      this.firstNameTextBox.Size = new System.Drawing.Size(174, 31);
      this.firstNameTextBox.TabIndex = 1;
      // 
      // lastNameTextBox
      // 
      this.lastNameTextBox.Location = new System.Drawing.Point(140, 113);
      this.lastNameTextBox.Name = "lastNameTextBox";
      this.lastNameTextBox.Size = new System.Drawing.Size(174, 31);
      this.lastNameTextBox.TabIndex = 2;
      // 
      // ageNumericUpDown
      // 
      this.ageNumericUpDown.Location = new System.Drawing.Point(140, 162);
      this.ageNumericUpDown.Name = "ageNumericUpDown";
      this.ageNumericUpDown.Size = new System.Drawing.Size(58, 31);
      this.ageNumericUpDown.TabIndex = 3;
      // 
      // isAliveCheckBox
      // 
      this.isAliveCheckBox.AutoSize = true;
      this.isAliveCheckBox.Location = new System.Drawing.Point(140, 218);
      this.isAliveCheckBox.Name = "isAliveCheckBox";
      this.isAliveCheckBox.Size = new System.Drawing.Size(15, 14);
      this.isAliveCheckBox.TabIndex = 4;
      this.isAliveCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.isAliveCheckBox.UseVisualStyleBackColor = true;
      // 
      // saveListButton
      // 
      this.saveListButton.Location = new System.Drawing.Point(17, 336);
      this.saveListButton.Name = "saveListButton";
      this.saveListButton.Size = new System.Drawing.Size(297, 52);
      this.saveListButton.TabIndex = 6;
      this.saveListButton.Text = "Save List";
      this.saveListButton.UseVisualStyleBackColor = true;
      this.saveListButton.Click += new System.EventHandler(this.saveListButton_Click);
      // 
      // addUserButton
      // 
      this.addUserButton.Location = new System.Drawing.Point(17, 262);
      this.addUserButton.Name = "addUserButton";
      this.addUserButton.Size = new System.Drawing.Size(297, 52);
      this.addUserButton.TabIndex = 5;
      this.addUserButton.Text = "Add User";
      this.addUserButton.UseVisualStyleBackColor = true;
      this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
      // 
      // peopleListBox
      // 
      this.peopleListBox.FormattingEnabled = true;
      this.peopleListBox.ItemHeight = 25;
      this.peopleListBox.Location = new System.Drawing.Point(349, 65);
      this.peopleListBox.Name = "peopleListBox";
      this.peopleListBox.Size = new System.Drawing.Size(383, 329);
      this.peopleListBox.TabIndex = 7;
      // 
      // PeopleDashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(744, 452);
      this.Controls.Add(this.peopleListBox);
      this.Controls.Add(this.addUserButton);
      this.Controls.Add(this.saveListButton);
      this.Controls.Add(this.isAliveCheckBox);
      this.Controls.Add(this.ageNumericUpDown);
      this.Controls.Add(this.lastNameTextBox);
      this.Controls.Add(this.firstNameTextBox);
      this.Controls.Add(this.headerIsAliveLabel);
      this.Controls.Add(this.headerAgeLabel);
      this.Controls.Add(this.headerLastNameLabel);
      this.Controls.Add(this.headerFirstNameLabel);
      this.Controls.Add(this.headerMainLabel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "PeopleDashboard";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Text File Challenge";
      ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label headerMainLabel;
        private System.Windows.Forms.Label headerFirstNameLabel;
        private System.Windows.Forms.Label headerLastNameLabel;
        private System.Windows.Forms.Label headerAgeLabel;
        private System.Windows.Forms.Label headerIsAliveLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
        private System.Windows.Forms.CheckBox isAliveCheckBox;
        private System.Windows.Forms.Button saveListButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.ListBox peopleListBox;
    }
}

