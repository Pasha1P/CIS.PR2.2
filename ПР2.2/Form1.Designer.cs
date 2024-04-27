namespace ПР3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFilm3 = new System.Windows.Forms.Button();
            this.buttonFilm4 = new System.Windows.Forms.Button();
            this.buttonFilm5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Inf = new System.Windows.Forms.ToolStripMenuItem();
            this.InfProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonFilm2 = new System.Windows.Forms.Button();
            this.buttonFilm1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите на какой филм пойдете:";
            // 
            // buttonFilm3
            // 
            this.buttonFilm3.Image = global::ПР3.Properties.Resources.Батя2;
            this.buttonFilm3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFilm3.Location = new System.Drawing.Point(230, 175);
            this.buttonFilm3.Name = "buttonFilm3";
            this.buttonFilm3.Size = new System.Drawing.Size(67, 109);
            this.buttonFilm3.TabIndex = 4;
            this.buttonFilm3.Text = "Батя";
            this.buttonFilm3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFilm3.UseVisualStyleBackColor = true;
            this.buttonFilm3.Click += new System.EventHandler(this.buttonFilm3_Click);
            // 
            // buttonFilm4
            // 
            this.buttonFilm4.Image = global::ПР3.Properties.Resources.неприличные_гости1;
            this.buttonFilm4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFilm4.Location = new System.Drawing.Point(108, 197);
            this.buttonFilm4.Name = "buttonFilm4";
            this.buttonFilm4.Size = new System.Drawing.Size(116, 87);
            this.buttonFilm4.TabIndex = 3;
            this.buttonFilm4.Text = "Неприличные гости";
            this.buttonFilm4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFilm4.UseVisualStyleBackColor = true;
            this.buttonFilm4.Click += new System.EventHandler(this.buttonFilm4_Click);
            // 
            // buttonFilm5
            // 
            this.buttonFilm5.Image = global::ПР3.Properties.Resources.сто_лет_тому_вперед;
            this.buttonFilm5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFilm5.Location = new System.Drawing.Point(12, 175);
            this.buttonFilm5.Name = "buttonFilm5";
            this.buttonFilm5.Size = new System.Drawing.Size(90, 109);
            this.buttonFilm5.TabIndex = 1;
            this.buttonFilm5.Text = "Сто лет тому вперед";
            this.buttonFilm5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFilm5.UseVisualStyleBackColor = true;
            this.buttonFilm5.Click += new System.EventHandler(this.buttonFilm5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Inf});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(313, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Inf
            // 
            this.Inf.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfProgramm});
            this.Inf.Name = "Inf";
            this.Inf.Size = new System.Drawing.Size(65, 20);
            this.Inf.Text = "Справка";
            // 
            // InfProgramm
            // 
            this.InfProgramm.Name = "InfProgramm";
            this.InfProgramm.Size = new System.Drawing.Size(149, 22);
            this.InfProgramm.Text = "О программе";
            this.InfProgramm.Click += new System.EventHandler(this.InfProgramm_Click);
            // 
            // buttonFilm2
            // 
            this.buttonFilm2.Image = global::ПР3.Properties.Resources.шепот_мертвых;
            this.buttonFilm2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFilm2.Location = new System.Drawing.Point(207, 60);
            this.buttonFilm2.Name = "buttonFilm2";
            this.buttonFilm2.Size = new System.Drawing.Size(90, 109);
            this.buttonFilm2.TabIndex = 5;
            this.buttonFilm2.Text = "Астрал. Шёпот мертвых";
            this.buttonFilm2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFilm2.UseVisualStyleBackColor = true;
            this.buttonFilm2.Click += new System.EventHandler(this.buttonFilm2_Click);
            // 
            // buttonFilm1
            // 
            this.buttonFilm1.Image = global::ПР3.Properties.Resources.Блиндаж;
            this.buttonFilm1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFilm1.Location = new System.Drawing.Point(12, 60);
            this.buttonFilm1.Name = "buttonFilm1";
            this.buttonFilm1.Size = new System.Drawing.Size(184, 109);
            this.buttonFilm1.TabIndex = 2;
            this.buttonFilm1.Text = "Блиндаж";
            this.buttonFilm1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFilm1.UseVisualStyleBackColor = true;
            this.buttonFilm1.Click += new System.EventHandler(this.buttonFilm1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 310);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonFilm2);
            this.Controls.Add(this.buttonFilm3);
            this.Controls.Add(this.buttonFilm4);
            this.Controls.Add(this.buttonFilm1);
            this.Controls.Add(this.buttonFilm5);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПР2.2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFilm5;
        private System.Windows.Forms.Button buttonFilm1;
        private System.Windows.Forms.Button buttonFilm4;
        private System.Windows.Forms.Button buttonFilm3;
        private System.Windows.Forms.Button buttonFilm2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Inf;
        private System.Windows.Forms.ToolStripMenuItem InfProgramm;
    }
}

