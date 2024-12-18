namespace csharp_3_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.box = new System.Windows.Forms.PictureBox();
            this.up = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // box
            // 
            this.box.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.box.Location = new System.Drawing.Point(61, 43);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(100, 100);
            this.box.TabIndex = 0;
            this.box.TabStop = false;
            // 
            // up
            // 
            this.up.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.up.Location = new System.Drawing.Point(662, 312);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(60, 60);
            this.up.TabIndex = 1;
            this.up.Text = "上";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.left.Location = new System.Drawing.Point(596, 378);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(60, 60);
            this.left.TabIndex = 2;
            this.left.Text = "左";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // down
            // 
            this.down.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.down.Location = new System.Drawing.Point(662, 378);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(60, 60);
            this.down.TabIndex = 3;
            this.down.Text = "下";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // right
            // 
            this.right.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.right.Location = new System.Drawing.Point(728, 378);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(60, 60);
            this.right.TabIndex = 4;
            this.right.Text = "右";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // pause
            // 
            this.pause.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pause.Location = new System.Drawing.Point(530, 378);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(60, 60);
            this.pause.TabIndex = 5;
            this.pause.Text = "停止";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.right);
            this.Controls.Add(this.down);
            this.Controls.Add(this.left);
            this.Controls.Add(this.up);
            this.Controls.Add(this.box);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox box;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button pause;
    }
}

