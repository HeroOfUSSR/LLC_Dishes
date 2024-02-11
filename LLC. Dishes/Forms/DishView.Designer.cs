namespace LLC._Dishes.Forms
{
    partial class DishView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.costLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.isActualLabel = new System.Windows.Forms.Label();
            this.imageAddButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LLC._Dishes.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(19, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.costLabel);
            this.panel1.Controls.Add(this.supplierLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.descLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(313, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 174);
            this.panel1.TabIndex = 1;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costLabel.Location = new System.Drawing.Point(70, 135);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(47, 23);
            this.costLabel.TabIndex = 5;
            this.costLabel.Text = "Цена";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.supplierLabel.Location = new System.Drawing.Point(153, 112);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(130, 23);
            this.supplierLabel.TabIndex = 4;
            this.supplierLabel.Text = "Производитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Производитель:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена:";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descLabel.Location = new System.Drawing.Point(12, 41);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(86, 23);
            this.descLabel.TabIndex = 1;
            this.descLabel.Text = "Описание";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(12, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 23);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Название";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.isActualLabel);
            this.panel2.Location = new System.Drawing.Point(705, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 174);
            this.panel2.TabIndex = 2;
            // 
            // isActualLabel
            // 
            this.isActualLabel.AutoSize = true;
            this.isActualLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isActualLabel.Location = new System.Drawing.Point(14, 28);
            this.isActualLabel.Name = "isActualLabel";
            this.isActualLabel.Size = new System.Drawing.Size(100, 23);
            this.isActualLabel.TabIndex = 4;
            this.isActualLabel.Text = "В наличии?";
            // 
            // imageAddButton
            // 
            this.imageAddButton.BackColor = System.Drawing.Color.LightGray;
            this.imageAddButton.FlatAppearance.BorderSize = 0;
            this.imageAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageAddButton.Location = new System.Drawing.Point(19, 176);
            this.imageAddButton.Name = "imageAddButton";
            this.imageAddButton.Size = new System.Drawing.Size(123, 31);
            this.imageAddButton.TabIndex = 3;
            this.imageAddButton.Text = "Изменить картинку";
            this.imageAddButton.UseVisualStyleBackColor = false;
            this.imageAddButton.Click += new System.EventHandler(this.imageAddButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(162, 176);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(126, 31);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Изменить товар";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DishView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.imageAddButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DishView";
            this.Size = new System.Drawing.Size(860, 218);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
        private Label descLabel;
        private Label nameLabel;
        private Panel panel2;
        private Label isActualLabel;
        private Label costLabel;
        private Label supplierLabel;
        private Label label4;
        private Button imageAddButton;
        private Button editButton;
        private OpenFileDialog openFileDialog1;
    }
}
