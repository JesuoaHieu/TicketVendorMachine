namespace TicketVendorMachine
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
            this.pnHome = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSelect = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbGa = new System.Windows.Forms.ComboBox();
            this.pnPayment = new System.Windows.Forms.Panel();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnMomo = new System.Windows.Forms.Button();
            this.pnHome.SuspendLayout();
            this.pnSelect.SuspendLayout();
            this.pnPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHome
            // 
            this.pnHome.Controls.Add(this.btnStart);
            this.pnHome.Controls.Add(this.label1);
            this.pnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHome.Location = new System.Drawing.Point(0, 0);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(800, 450);
            this.pnHome.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(339, 266);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "BẮT ĐẦU";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÁY BÁN VÉ ";
            // 
            // pnSelect
            // 
            this.pnSelect.Controls.Add(this.btnNext);
            this.pnSelect.Controls.Add(this.cbGa);
            this.pnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSelect.Location = new System.Drawing.Point(0, 0);
            this.pnSelect.Name = "pnSelect";
            this.pnSelect.Size = new System.Drawing.Size(800, 450);
            this.pnSelect.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(325, 266);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 35);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "TIẾP TỤC";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // cbGa
            // 
            this.cbGa.FormattingEnabled = true;
            this.cbGa.Items.AddRange(new object[] {
            "Ga Suối Tiên ",
            "Ga Văn Thánh",
            "Ga Tân Cảng",
            "Ga Thủ Đức"});
            this.cbGa.Location = new System.Drawing.Point(325, 88);
            this.cbGa.Name = "cbGa";
            this.cbGa.Size = new System.Drawing.Size(121, 28);
            this.cbGa.TabIndex = 0;
            // 
            // pnPayment
            // 
            this.pnPayment.Controls.Add(this.btnCard);
            this.pnPayment.Controls.Add(this.btnMomo);
            this.pnPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPayment.Location = new System.Drawing.Point(0, 0);
            this.pnPayment.Name = "pnPayment";
            this.pnPayment.Size = new System.Drawing.Size(800, 450);
            this.pnPayment.TabIndex = 2;
            this.pnPayment.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPayment_Paint);
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(440, 231);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(136, 47);
            this.btnCard.TabIndex = 1;
            this.btnCard.Text = "CARD";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnMomo
            // 
            this.btnMomo.Location = new System.Drawing.Point(197, 231);
            this.btnMomo.Name = "btnMomo";
            this.btnMomo.Size = new System.Drawing.Size(136, 47);
            this.btnMomo.TabIndex = 0;
            this.btnMomo.Text = "MOMO";
            this.btnMomo.UseVisualStyleBackColor = true;
            this.btnMomo.Click += new System.EventHandler(this.btnMomo_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnHome);
            this.Controls.Add(this.pnSelect);
            this.Controls.Add(this.pnPayment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnHome.ResumeLayout(false);
            this.pnHome.PerformLayout();
            this.pnSelect.ResumeLayout(false);
            this.pnPayment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnSelect;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cbGa;
        private System.Windows.Forms.Panel pnPayment;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnMomo;
    }
}

