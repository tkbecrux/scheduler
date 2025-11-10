namespace Scheduler
{
    partial class MainScheduler
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
            this.MainTabWindow = new System.Windows.Forms.TabControl();
            this.TabInput = new System.Windows.Forms.TabPage();
            this.TabScheduler = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Classes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelScheduleDoc = new System.Windows.Forms.Label();
            this.richTextBoxScheduleDoc = new System.Windows.Forms.RichTextBox();
            this.MainTabWindow.SuspendLayout();
            this.TabInput.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabWindow
            // 
            this.MainTabWindow.Controls.Add(this.TabInput);
            this.MainTabWindow.Controls.Add(this.TabScheduler);
            this.MainTabWindow.Location = new System.Drawing.Point(12, 12);
            this.MainTabWindow.Name = "MainTabWindow";
            this.MainTabWindow.SelectedIndex = 0;
            this.MainTabWindow.Size = new System.Drawing.Size(492, 256);
            this.MainTabWindow.TabIndex = 0;
            // 
            // TabInput
            // 
            this.TabInput.Controls.Add(this.tableLayoutPanel1);
            this.TabInput.Location = new System.Drawing.Point(4, 22);
            this.TabInput.Name = "TabInput";
            this.TabInput.Padding = new System.Windows.Forms.Padding(3);
            this.TabInput.Size = new System.Drawing.Size(484, 230);
            this.TabInput.TabIndex = 0;
            this.TabInput.Text = "Input";
            this.TabInput.UseVisualStyleBackColor = true;
            // 
            // TabScheduler
            // 
            this.TabScheduler.Controls.Add(this.labelScheduleDoc);
            this.TabScheduler.Controls.Add(this.richTextBoxScheduleDoc);
            this.TabScheduler.Location = new System.Drawing.Point(4, 22);
            this.TabScheduler.Name = "TabScheduler";
            this.TabScheduler.Padding = new System.Windows.Forms.Padding(3);
            this.TabScheduler.Size = new System.Drawing.Size(484, 230);
            this.TabScheduler.TabIndex = 1;
            this.TabScheduler.Text = "Schedule";
            this.TabScheduler.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Classes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 107);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Classes
            // 
            this.Classes.AutoSize = true;
            this.Classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classes.Location = new System.Drawing.Point(3, 0);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(83, 25);
            this.Classes.TabIndex = 0;
            this.Classes.Text = "Classes";
            this.Classes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelScheduleDoc
            // 
            this.labelScheduleDoc.AutoSize = true;
            this.labelScheduleDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScheduleDoc.Location = new System.Drawing.Point(12, 12);
            this.labelScheduleDoc.Name = "labelScheduleDoc";
            this.labelScheduleDoc.Size = new System.Drawing.Size(116, 20);
            this.labelScheduleDoc.TabIndex = 0;
            this.labelScheduleDoc.Text = "Schedule docs";
            // 
            // richTextBoxScheduleDoc
            // 
            this.richTextBoxScheduleDoc.Location = new System.Drawing.Point(16, 40);
            this.richTextBoxScheduleDoc.Name = "richTextBoxScheduleDoc";
            this.richTextBoxScheduleDoc.ReadOnly = true;
            this.richTextBoxScheduleDoc.Size = new System.Drawing.Size(452, 174);
            this.richTextBoxScheduleDoc.TabIndex = 1;
            this.richTextBoxScheduleDoc.Text = "Use this Schedule tab to build and review your space schedule.\r\n\r\n- Add classes in the Input tab.\r\n- Use schedule builder controls to generate timetables.\r\n- Save or export schedule.\r\n\r\nFor more information, see the project README or documentation.";
            // 
            // MainScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 705);
            this.Controls.Add(this.MainTabWindow);
            this.Name = "MainScheduler";
            this.Text = "Scheduler";
            this.MainTabWindow.ResumeLayout(false);
            this.TabInput.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabWindow;
        private System.Windows.Forms.TabPage TabInput;
        private System.Windows.Forms.TabPage TabScheduler;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Classes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelScheduleDoc;
        private System.Windows.Forms.RichTextBox richTextBoxScheduleDoc;
    }
}

