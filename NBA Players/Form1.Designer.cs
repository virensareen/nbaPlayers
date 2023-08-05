namespace NBA_Players
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
            label1 = new Label();
            label2 = new Label();
            positionCbx = new ComboBox();
            playersBox = new ListBox();
            previousBtn = new Button();
            nextBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(303, 51);
            label1.Name = "label1";
            label1.Size = new Size(147, 50);
            label1.TabIndex = 0;
            label1.Text = "Players";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 129);
            label2.Name = "label2";
            label2.Size = new Size(259, 45);
            label2.TabIndex = 1;
            label2.Text = "Filter by position";
            // 
            // positionCbx
            // 
            positionCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            positionCbx.FormattingEnabled = true;
            positionCbx.Location = new Point(379, 134);
            positionCbx.Name = "positionCbx";
            positionCbx.Size = new Size(298, 40);
            positionCbx.TabIndex = 2;
            positionCbx.SelectedIndexChanged += positionCbx_SelectedIndexChanged;
            // 
            // playersBox
            // 
            playersBox.FormattingEnabled = true;
            playersBox.ItemHeight = 32;
            playersBox.Location = new Point(63, 214);
            playersBox.Name = "playersBox";
            playersBox.Size = new Size(636, 612);
            playersBox.TabIndex = 3;
            // 
            // previousBtn
            // 
            previousBtn.Location = new Point(63, 876);
            previousBtn.Name = "previousBtn";
            previousBtn.Size = new Size(150, 46);
            previousBtn.TabIndex = 4;
            previousBtn.Text = "&Previous";
            previousBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(549, 876);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(150, 46);
            nextBtn.TabIndex = 5;
            nextBtn.Text = "&Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 976);
            Controls.Add(nextBtn);
            Controls.Add(previousBtn);
            Controls.Add(playersBox);
            Controls.Add(positionCbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox positionCbx;
        private ListBox playersBox;
        private Button previousBtn;
        private Button nextBtn;
    }
}