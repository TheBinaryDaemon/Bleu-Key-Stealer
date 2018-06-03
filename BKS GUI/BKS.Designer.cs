namespace BKS_GUI
{
    partial class BKS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BKS));
            this.Header = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.WipeCb = new System.Windows.Forms.CheckBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.BreakCb = new System.Windows.Forms.CheckBox();
            this.LoopCb = new System.Windows.Forms.CheckBox();
            this.ReplaceCb = new System.Windows.Forms.CheckBox();
            this.TagTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WebhkTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.MinimizeBtn);
            this.Header.Controls.Add(this.CloseBtn);
            this.Header.Location = new System.Drawing.Point(-1, -1);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(312, 20);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(4, 1);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(72, 19);
            this.Title.TabIndex = 17;
            this.Title.Text = "BKS v0.91";
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.Location = new System.Drawing.Point(254, -3);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(25, 23);
            this.MinimizeBtn.TabIndex = 14;
            this.MinimizeBtn.Text = "-";
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(285, -3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(25, 23);
            this.CloseBtn.TabIndex = 13;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // WipeCb
            // 
            this.WipeCb.AutoSize = true;
            this.WipeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WipeCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WipeCb.Location = new System.Drawing.Point(7, 55);
            this.WipeCb.Name = "WipeCb";
            this.WipeCb.Size = new System.Drawing.Size(94, 24);
            this.WipeCb.TabIndex = 1;
            this.WipeCb.Text = "Wipe Key";
            this.WipeCb.UseVisualStyleBackColor = true;
            this.WipeCb.CheckedChanged += new System.EventHandler(this.WipeCb_CheckedChanged);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.CreateBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CreateBtn.FlatAppearance.BorderSize = 0;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateBtn.Location = new System.Drawing.Point(-1, 205);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(312, 27);
            this.CreateBtn.TabIndex = 18;
            this.CreateBtn.Text = "Create Stub";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // BreakCb
            // 
            this.BreakCb.AutoSize = true;
            this.BreakCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreakCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BreakCb.Location = new System.Drawing.Point(7, 85);
            this.BreakCb.Name = "BreakCb";
            this.BreakCb.Size = new System.Drawing.Size(294, 24);
            this.BreakCb.TabIndex = 21;
            this.BreakCb.Text = "Break Key (changes 1 char in the key)";
            this.BreakCb.UseVisualStyleBackColor = true;
            this.BreakCb.CheckedChanged += new System.EventHandler(this.BreakCb_CheckedChanged);
            // 
            // LoopCb
            // 
            this.LoopCb.AutoSize = true;
            this.LoopCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoopCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoopCb.Location = new System.Drawing.Point(7, 115);
            this.LoopCb.Name = "LoopCb";
            this.LoopCb.Size = new System.Drawing.Size(64, 24);
            this.LoopCb.TabIndex = 22;
            this.LoopCb.Text = "Loop";
            this.LoopCb.UseVisualStyleBackColor = true;
            // 
            // ReplaceCb
            // 
            this.ReplaceCb.AutoSize = true;
            this.ReplaceCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplaceCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReplaceCb.Location = new System.Drawing.Point(7, 25);
            this.ReplaceCb.Name = "ReplaceCb";
            this.ReplaceCb.Size = new System.Drawing.Size(126, 24);
            this.ReplaceCb.TabIndex = 25;
            this.ReplaceCb.Text = "Fake Blacklist";
            this.ReplaceCb.UseVisualStyleBackColor = true;
            this.ReplaceCb.CheckedChanged += new System.EventHandler(this.ReplaceCb_CheckedChanged);
            // 
            // TagTxt
            // 
            this.TagTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TagTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TagTxt.Location = new System.Drawing.Point(151, 149);
            this.TagTxt.Name = "TagTxt";
            this.TagTxt.Size = new System.Drawing.Size(146, 20);
            this.TagTxt.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Webhook";
            // 
            // WebhkTxt
            // 
            this.WebhkTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WebhkTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WebhkTxt.Location = new System.Drawing.Point(86, 179);
            this.WebhkTxt.Name = "WebhkTxt";
            this.WebhkTxt.Size = new System.Drawing.Size(211, 20);
            this.WebhkTxt.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tag e.g. Vashta UI";
            // 
            // BKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 233);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WebhkTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TagTxt);
            this.Controls.Add(this.ReplaceCb);
            this.Controls.Add(this.LoopCb);
            this.Controls.Add(this.BreakCb);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.WipeCb);
            this.Controls.Add(this.Header);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BKS";
            this.Text = "BKS";
            this.Load += new System.EventHandler(this.BKS_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.CheckBox WipeCb;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.CheckBox BreakCb;
        private System.Windows.Forms.CheckBox LoopCb;
        private System.Windows.Forms.CheckBox ReplaceCb;
        private System.Windows.Forms.TextBox TagTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WebhkTxt;
        private System.Windows.Forms.Label label2;
    }
}

