namespace SimpleViewModel.TestForm
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
            if (disposing && ( components != null ))
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
            this._textBoxFirstName = new System.Windows.Forms.TextBox();
            this._checkBoxMale = new System.Windows.Forms.CheckBox();
            this._textBoxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._comboBoxState = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _textBoxFirstName
            // 
            this._textBoxFirstName.Location = new System.Drawing.Point(98, 31);
            this._textBoxFirstName.Name = "_textBoxFirstName";
            this._textBoxFirstName.Size = new System.Drawing.Size(206, 20);
            this._textBoxFirstName.TabIndex = 0;
            // 
            // _checkBoxMale
            // 
            this._checkBoxMale.AutoSize = true;
            this._checkBoxMale.Location = new System.Drawing.Point(41, 119);
            this._checkBoxMale.Name = "_checkBoxMale";
            this._checkBoxMale.Size = new System.Drawing.Size(55, 17);
            this._checkBoxMale.TabIndex = 1;
            this._checkBoxMale.Text = "Male?";
            this._checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // _textBoxLastName
            // 
            this._textBoxLastName.Location = new System.Drawing.Point(98, 75);
            this._textBoxLastName.Name = "_textBoxLastName";
            this._textBoxLastName.Size = new System.Drawing.Size(206, 20);
            this._textBoxLastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "LastName";
            // 
            // _comboBoxState
            // 
            this._comboBoxState.FormattingEnabled = true;
            this._comboBoxState.Location = new System.Drawing.Point(98, 162);
            this._comboBoxState.Name = "_comboBoxState";
            this._comboBoxState.Size = new System.Drawing.Size(206, 21);
            this._comboBoxState.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "State";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 452);
            this.Controls.Add(this._comboBoxState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textBoxLastName);
            this.Controls.Add(this._checkBoxMale);
            this.Controls.Add(this._textBoxFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxFirstName;
        private System.Windows.Forms.CheckBox _checkBoxMale;
        private System.Windows.Forms.TextBox _textBoxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _comboBoxState;
        private System.Windows.Forms.Label label3;
    }
}

