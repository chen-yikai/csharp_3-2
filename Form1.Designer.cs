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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.box = new System.Windows.Forms.PictureBox();
            this.up = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.speedTracke = new System.Windows.Forms.TrackBar();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.horizontalS = new System.Windows.Forms.HScrollBar();
            this.verticalS = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTracke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // box
            // 
            this.box.BackColor = System.Drawing.Color.Transparent;
            this.box.Image = global::csharp_3_2.Properties.Resources.arrow;
            this.box.Location = new System.Drawing.Point(61, 43);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(200, 100);
            this.box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "arrow-up.png");
            this.imgList.Images.SetKeyName(1, "arrow-down.png");
            this.imgList.Images.SetKeyName(2, "arrow-left.png");
            this.imgList.Images.SetKeyName(3, "arrow-right.png");
            // 
            // speedTracke
            // 
            this.speedTracke.Location = new System.Drawing.Point(530, 261);
            this.speedTracke.Maximum = 1000;
            this.speedTracke.Minimum = 1;
            this.speedTracke.Name = "speedTracke";
            this.speedTracke.Size = new System.Drawing.Size(258, 45);
            this.speedTracke.TabIndex = 6;
            this.speedTracke.TickFrequency = 50;
            this.speedTracke.Value = 500;
            this.speedTracke.Scroll += new System.EventHandler(this.speedTracke_Scroll);
            // 
            // horizontalS
            // 
            this.horizontalS.Location = new System.Drawing.Point(47, 418);
            this.horizontalS.Maximum = 300;
            this.horizontalS.Minimum = 100;
            this.horizontalS.Name = "horizontalS";
            this.horizontalS.Size = new System.Drawing.Size(143, 20);
            this.horizontalS.TabIndex = 7;
            this.horizontalS.Value = 200;
            this.horizontalS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.horizontalS_Scroll);
            // 
            // verticalS
            // 
            this.verticalS.Location = new System.Drawing.Point(26, 289);
            this.verticalS.Maximum = 300;
            this.verticalS.Minimum = 50;
            this.verticalS.Name = "verticalS";
            this.verticalS.Size = new System.Drawing.Size(21, 129);
            this.verticalS.TabIndex = 8;
            this.verticalS.Value = 100;
            this.verticalS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.verticalS_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(50, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "大小";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(526, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "速度(快~慢)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verticalS);
            this.Controls.Add(this.horizontalS);
            this.Controls.Add(this.speedTracke);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.right);
            this.Controls.Add(this.down);
            this.Controls.Add(this.left);
            this.Controls.Add(this.up);
            this.Controls.Add(this.box);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTracke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox box;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.TrackBar speedTracke;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.HScrollBar horizontalS;
        private System.Windows.Forms.VScrollBar verticalS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

