
namespace AstronomicalProcessing
{
    partial class AstronomicalProcessing
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
            this.ListBoxHours = new System.Windows.Forms.ListBox();
            this.TextBoxHours = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonModify = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAutofill = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ButtonMid = new System.Windows.Forms.Button();
            this.ButtonMode = new System.Windows.Forms.Button();
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.ButtonRange = new System.Windows.Forms.Button();
            this.ButtonLinearSearch = new System.Windows.Forms.Button();
            this.TextBoxMid = new System.Windows.Forms.TextBox();
            this.TextBoxMode = new System.Windows.Forms.TextBox();
            this.TextBoxAverage = new System.Windows.Forms.TextBox();
            this.TextBoxRange = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxHours
            // 
            this.ListBoxHours.FormattingEnabled = true;
            this.ListBoxHours.Location = new System.Drawing.Point(125, 69);
            this.ListBoxHours.Name = "ListBoxHours";
            this.ListBoxHours.Size = new System.Drawing.Size(142, 316);
            this.ListBoxHours.TabIndex = 0;
            this.ListBoxHours.Click += new System.EventHandler(this.ListBoxHours_Click);
            // 
            // TextBoxHours
            // 
            this.TextBoxHours.Location = new System.Drawing.Point(123, 423);
            this.TextBoxHours.Multiline = true;
            this.TextBoxHours.Name = "TextBoxHours";
            this.TextBoxHours.Size = new System.Drawing.Size(65, 21);
            this.TextBoxHours.TabIndex = 1;
            this.TextBoxHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxHours_KeyPress);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(22, 87);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 42);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonModify
            // 
            this.ButtonModify.BackColor = System.Drawing.Color.White;
            this.ButtonModify.Location = new System.Drawing.Point(22, 157);
            this.ButtonModify.Name = "ButtonModify";
            this.ButtonModify.Size = new System.Drawing.Size(75, 42);
            this.ButtonModify.TabIndex = 3;
            this.ButtonModify.Text = "Modify";
            this.ButtonModify.UseVisualStyleBackColor = false;
            this.ButtonModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(22, 231);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 42);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.BackColor = System.Drawing.Color.White;
            this.ButtonSort.Location = new System.Drawing.Point(22, 310);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(75, 42);
            this.ButtonSort.TabIndex = 5;
            this.ButtonSort.Text = "Sort";
            this.ButtonSort.UseVisualStyleBackColor = false;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type Number";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.White;
            this.ButtonSearch.Location = new System.Drawing.Point(209, 423);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(84, 21);
            this.ButtonSearch.TabIndex = 7;
            this.ButtonSearch.Text = "Binary Search";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(99, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ASTRONOMICAL PROCESSING";
            // 
            // ButtonAutofill
            // 
            this.ButtonAutofill.ForeColor = System.Drawing.Color.Green;
            this.ButtonAutofill.Location = new System.Drawing.Point(348, 30);
            this.ButtonAutofill.Name = "ButtonAutofill";
            this.ButtonAutofill.Size = new System.Drawing.Size(75, 23);
            this.ButtonAutofill.TabIndex = 9;
            this.ButtonAutofill.Text = "AutoFill";
            this.ButtonAutofill.UseVisualStyleBackColor = true;
            this.ButtonAutofill.Click += new System.EventHandler(this.ButtonAutofill_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 463);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(477, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Message";
            // 
            // ButtonMid
            // 
            this.ButtonMid.BackColor = System.Drawing.Color.White;
            this.ButtonMid.Location = new System.Drawing.Point(302, 87);
            this.ButtonMid.Name = "ButtonMid";
            this.ButtonMid.Size = new System.Drawing.Size(75, 42);
            this.ButtonMid.TabIndex = 11;
            this.ButtonMid.Text = "Mid";
            this.ButtonMid.UseVisualStyleBackColor = false;
            // 
            // ButtonMode
            // 
            this.ButtonMode.BackColor = System.Drawing.Color.White;
            this.ButtonMode.Location = new System.Drawing.Point(302, 157);
            this.ButtonMode.Name = "ButtonMode";
            this.ButtonMode.Size = new System.Drawing.Size(75, 42);
            this.ButtonMode.TabIndex = 12;
            this.ButtonMode.Text = "Mode";
            this.ButtonMode.UseVisualStyleBackColor = false;
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.BackColor = System.Drawing.Color.White;
            this.ButtonAverage.Location = new System.Drawing.Point(302, 231);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(75, 42);
            this.ButtonAverage.TabIndex = 13;
            this.ButtonAverage.Text = "Average";
            this.ButtonAverage.UseVisualStyleBackColor = false;
            // 
            // ButtonRange
            // 
            this.ButtonRange.BackColor = System.Drawing.Color.White;
            this.ButtonRange.Location = new System.Drawing.Point(302, 310);
            this.ButtonRange.Name = "ButtonRange";
            this.ButtonRange.Size = new System.Drawing.Size(75, 42);
            this.ButtonRange.TabIndex = 14;
            this.ButtonRange.Text = "Range";
            this.ButtonRange.UseVisualStyleBackColor = false;
            // 
            // ButtonLinearSearch
            // 
            this.ButtonLinearSearch.BackColor = System.Drawing.Color.White;
            this.ButtonLinearSearch.Location = new System.Drawing.Point(310, 424);
            this.ButtonLinearSearch.Name = "ButtonLinearSearch";
            this.ButtonLinearSearch.Size = new System.Drawing.Size(84, 21);
            this.ButtonLinearSearch.TabIndex = 15;
            this.ButtonLinearSearch.Text = "Linear Search";
            this.ButtonLinearSearch.UseVisualStyleBackColor = false;
            // 
            // TextBoxMid
            // 
            this.TextBoxMid.Location = new System.Drawing.Point(400, 87);
            this.TextBoxMid.Multiline = true;
            this.TextBoxMid.Name = "TextBoxMid";
            this.TextBoxMid.Size = new System.Drawing.Size(54, 42);
            this.TextBoxMid.TabIndex = 16;
            // 
            // TextBoxMode
            // 
            this.TextBoxMode.Location = new System.Drawing.Point(400, 157);
            this.TextBoxMode.Multiline = true;
            this.TextBoxMode.Name = "TextBoxMode";
            this.TextBoxMode.Size = new System.Drawing.Size(54, 42);
            this.TextBoxMode.TabIndex = 17;
            // 
            // TextBoxAverage
            // 
            this.TextBoxAverage.Location = new System.Drawing.Point(400, 231);
            this.TextBoxAverage.Multiline = true;
            this.TextBoxAverage.Name = "TextBoxAverage";
            this.TextBoxAverage.Size = new System.Drawing.Size(54, 42);
            this.TextBoxAverage.TabIndex = 18;
            // 
            // TextBoxRange
            // 
            this.TextBoxRange.Location = new System.Drawing.Point(400, 310);
            this.TextBoxRange.Multiline = true;
            this.TextBoxRange.Name = "TextBoxRange";
            this.TextBoxRange.Size = new System.Drawing.Size(54, 42);
            this.TextBoxRange.TabIndex = 19;
            // 
            // AstronomicalProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(477, 485);
            this.Controls.Add(this.TextBoxRange);
            this.Controls.Add(this.TextBoxAverage);
            this.Controls.Add(this.TextBoxMode);
            this.Controls.Add(this.TextBoxMid);
            this.Controls.Add(this.ButtonLinearSearch);
            this.Controls.Add(this.ButtonRange);
            this.Controls.Add(this.ButtonAverage);
            this.Controls.Add(this.ButtonMode);
            this.Controls.Add(this.ButtonMid);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ButtonAutofill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonModify);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxHours);
            this.Controls.Add(this.ListBoxHours);
            this.Name = "AstronomicalProcessing";
            this.Text = "AstronomicalProcessing";
            this.Load += new System.EventHandler(this.AstronomicalProcessing_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AstronomicalProcessing_MouseMove);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxHours;
        private System.Windows.Forms.TextBox TextBoxHours;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonModify;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAutofill;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button ButtonMid;
        private System.Windows.Forms.Button ButtonMode;
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.Button ButtonRange;
        private System.Windows.Forms.Button ButtonLinearSearch;
        private System.Windows.Forms.TextBox TextBoxMid;
        private System.Windows.Forms.TextBox TextBoxMode;
        private System.Windows.Forms.TextBox TextBoxAverage;
        private System.Windows.Forms.TextBox TextBoxRange;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

