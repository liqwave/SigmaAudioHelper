namespace SigmaAudioHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonFixMic = new System.Windows.Forms.Button();
            this.buttonMuteMic = new System.Windows.Forms.Button();
            this.pictureMicProperty = new System.Windows.Forms.PictureBox();
            this.pictureMicFix = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMicProperty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMicFix)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFixMic
            // 
            this.buttonFixMic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonFixMic.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFixMic.ForeColor = System.Drawing.Color.White;
            this.buttonFixMic.Location = new System.Drawing.Point(49, 267);
            this.buttonFixMic.Name = "buttonFixMic";
            this.buttonFixMic.Size = new System.Drawing.Size(325, 128);
            this.buttonFixMic.TabIndex = 0;
            this.buttonFixMic.Text = "Фиксировать уровень микрофона";
            this.buttonFixMic.UseVisualStyleBackColor = false;
            this.buttonFixMic.Click += new System.EventHandler(this.buttonFixMic_Click);
            // 
            // buttonMuteMic
            // 
            this.buttonMuteMic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonMuteMic.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMuteMic.ForeColor = System.Drawing.Color.White;
            this.buttonMuteMic.Location = new System.Drawing.Point(49, 59);
            this.buttonMuteMic.Name = "buttonMuteMic";
            this.buttonMuteMic.Size = new System.Drawing.Size(325, 128);
            this.buttonMuteMic.TabIndex = 1;
            this.buttonMuteMic.Text = "Замутиться";
            this.buttonMuteMic.UseVisualStyleBackColor = false;
            this.buttonMuteMic.Click += new System.EventHandler(this.buttonMuteMic_Click);
            // 
            // pictureMicProperty
            // 
            this.pictureMicProperty.Location = new System.Drawing.Point(420, 59);
            this.pictureMicProperty.Name = "pictureMicProperty";
            this.pictureMicProperty.Size = new System.Drawing.Size(128, 128);
            this.pictureMicProperty.TabIndex = 2;
            this.pictureMicProperty.TabStop = false;
            // 
            // pictureMicFix
            // 
            this.pictureMicFix.Location = new System.Drawing.Point(420, 267);
            this.pictureMicFix.Name = "pictureMicFix";
            this.pictureMicFix.Size = new System.Drawing.Size(128, 128);
            this.pictureMicFix.TabIndex = 3;
            this.pictureMicFix.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.pictureMicFix);
            this.Controls.Add(this.pictureMicProperty);
            this.Controls.Add(this.buttonMuteMic);
            this.Controls.Add(this.buttonFixMic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SigmaAudioHelper";
            ((System.ComponentModel.ISupportInitialize)(this.pictureMicProperty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMicFix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFixMic;
        private System.Windows.Forms.Button buttonMuteMic;
        private System.Windows.Forms.PictureBox pictureMicProperty;
        private System.Windows.Forms.PictureBox pictureMicFix;
    }
}

