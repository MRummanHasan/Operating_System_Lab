namespace Calculator_Marsh
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
            this.label1 = new System.Windows.Forms.Label();
            this.prev_listbox = new System.Windows.Forms.ListBox();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.cmb_operator = new System.Windows.Forms.ComboBox();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.lbl_operation = new System.Windows.Forms.Label();
            this.lbl_value2 = new System.Windows.Forms.Label();
            this.lbl_value1 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_value2 = new System.Windows.Forms.TextBox();
            this.txt_value1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Recent Operations...";
            // 
            // prev_listbox
            // 
            this.prev_listbox.BackColor = System.Drawing.Color.Black;
            this.prev_listbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_listbox.ForeColor = System.Drawing.Color.Lime;
            this.prev_listbox.FormattingEnabled = true;
            this.prev_listbox.ItemHeight = 19;
            this.prev_listbox.Location = new System.Drawing.Point(63, 234);
            this.prev_listbox.Name = "prev_listbox";
            this.prev_listbox.Size = new System.Drawing.Size(310, 213);
            this.prev_listbox.TabIndex = 17;
            // 
            // txt_answer
            // 
            this.txt_answer.BackColor = System.Drawing.Color.White;
            this.txt_answer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_answer.Location = new System.Drawing.Point(173, 164);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.ReadOnly = true;
            this.txt_answer.Size = new System.Drawing.Size(200, 26);
            this.txt_answer.TabIndex = 16;
            // 
            // cmb_operator
            // 
            this.cmb_operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_operator.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_operator.FormattingEnabled = true;
            this.cmb_operator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "^2 (square)",
            "^3 (cube)"});
            this.cmb_operator.Location = new System.Drawing.Point(173, 34);
            this.cmb_operator.Name = "cmb_operator";
            this.cmb_operator.Size = new System.Drawing.Size(200, 27);
            this.cmb_operator.TabIndex = 8;
            // 
            // lbl_answer
            // 
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_answer.Location = new System.Drawing.Point(111, 164);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(56, 19);
            this.lbl_answer.TabIndex = 10;
            this.lbl_answer.Text = "Answer";
            // 
            // lbl_operation
            // 
            this.lbl_operation.AutoSize = true;
            this.lbl_operation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operation.Location = new System.Drawing.Point(97, 37);
            this.lbl_operation.Name = "lbl_operation";
            this.lbl_operation.Size = new System.Drawing.Size(70, 19);
            this.lbl_operation.TabIndex = 11;
            this.lbl_operation.Text = "Operation";
            // 
            // lbl_value2
            // 
            this.lbl_value2.AutoSize = true;
            this.lbl_value2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value2.Location = new System.Drawing.Point(59, 104);
            this.lbl_value2.Name = "lbl_value2";
            this.lbl_value2.Size = new System.Drawing.Size(109, 19);
            this.lbl_value2.TabIndex = 12;
            this.lbl_value2.Text = "Second Number";
            // 
            // lbl_value1
            // 
            this.lbl_value1.AutoSize = true;
            this.lbl_value1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value1.Location = new System.Drawing.Point(77, 69);
            this.lbl_value1.Name = "lbl_value1";
            this.lbl_value1.Size = new System.Drawing.Size(90, 19);
            this.lbl_value1.TabIndex = 13;
            this.lbl_value1.Text = "First Number";
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(173, 133);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(200, 25);
            this.btn_submit.TabIndex = 15;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click_1);
            // 
            // txt_value2
            // 
            this.txt_value2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_value2.Location = new System.Drawing.Point(173, 101);
            this.txt_value2.Name = "txt_value2";
            this.txt_value2.Size = new System.Drawing.Size(200, 26);
            this.txt_value2.TabIndex = 14;
            this.txt_value2.Text = "0";
            // 
            // txt_value1
            // 
            this.txt_value1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_value1.Location = new System.Drawing.Point(173, 69);
            this.txt_value1.Name = "txt_value1";
            this.txt_value1.Size = new System.Drawing.Size(200, 26);
            this.txt_value1.TabIndex = 9;
            this.txt_value1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prev_listbox);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.cmb_operator);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.lbl_operation);
            this.Controls.Add(this.lbl_value2);
            this.Controls.Add(this.lbl_value1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_value2);
            this.Controls.Add(this.txt_value1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox prev_listbox;
        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.ComboBox cmb_operator;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.Label lbl_operation;
        private System.Windows.Forms.Label lbl_value2;
        private System.Windows.Forms.Label lbl_value1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_value2;
        private System.Windows.Forms.TextBox txt_value1;
    }
}

