
namespace Constructor
{
    partial class CSMainForm
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
            this.components = new System.ComponentModel.Container();
            this.CSControlPanel = new System.Windows.Forms.Panel();
            this.CSLabel = new System.Windows.Forms.Label();
            this.CSButtonPanel = new System.Windows.Forms.Panel();
            this.resize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.CSFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.CSControlPanel.SuspendLayout();
            this.CSButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CSControlPanel
            // 
            this.CSControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CSControlPanel.Controls.Add(this.CSLabel);
            this.CSControlPanel.Controls.Add(this.CSButtonPanel);
            this.CSControlPanel.Location = new System.Drawing.Point(0, 0);
            this.CSControlPanel.Name = "CSControlPanel";
            this.CSControlPanel.Size = new System.Drawing.Size(907, 21);
            this.CSControlPanel.TabIndex = 0;
            this.CSControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CSCtrl_OnMouseDown);
            this.CSControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CSCtrl_OnMouseMove);
            // 
            // CSLabel
            // 
            this.CSLabel.AutoSize = true;
            this.CSLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CSLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSLabel.ForeColor = System.Drawing.Color.White;
            this.CSLabel.Location = new System.Drawing.Point(3, 1);
            this.CSLabel.Name = "CSLabel";
            this.CSLabel.Size = new System.Drawing.Size(160, 20);
            this.CSLabel.TabIndex = 1;
            this.CSLabel.Text = "ConstructDev - IN-DEV";
            this.CSLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CSCtrl_OnMouseDown);
            this.CSLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CSCtrl_OnMouseMove);
            // 
            // CSButtonPanel
            // 
            this.CSButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CSButtonPanel.Controls.Add(this.resize);
            this.CSButtonPanel.Controls.Add(this.close);
            this.CSButtonPanel.Controls.Add(this.show);
            this.CSButtonPanel.Location = new System.Drawing.Point(826, 0);
            this.CSButtonPanel.Name = "CSButtonPanel";
            this.CSButtonPanel.Size = new System.Drawing.Size(81, 21);
            this.CSButtonPanel.TabIndex = 2;
            // 
            // resize
            // 
            this.resize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resize.FlatAppearance.BorderSize = 0;
            this.resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resize.ForeColor = System.Drawing.Color.Transparent;
            this.resize.Image = global::Constructor.Properties.Resources.CTRL_RESIZE;
            this.resize.Location = new System.Drawing.Point(27, 0);
            this.resize.Margin = new System.Windows.Forms.Padding(0);
            this.resize.MaximumSize = new System.Drawing.Size(27, 21);
            this.resize.MinimumSize = new System.Drawing.Size(27, 21);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(27, 21);
            this.resize.TabIndex = 2;
            this.resize.TabStop = false;
            this.resize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.resize.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Transparent;
            this.close.Image = global::Constructor.Properties.Resources.CTRL_CLOSE;
            this.close.Location = new System.Drawing.Point(54, 0);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.MaximumSize = new System.Drawing.Size(27, 21);
            this.close.MinimumSize = new System.Drawing.Size(27, 21);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(27, 21);
            this.close.TabIndex = 3;
            this.close.TabStop = false;
            this.close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.close.UseVisualStyleBackColor = true;
            this.close.MouseEnter += new System.EventHandler(this.CSCtrl_OnCloseFocus);
            this.close.MouseLeave += new System.EventHandler(this.CSCtrl_OnCloseUnfocus);
            // 
            // show
            // 
            this.show.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.show.FlatAppearance.BorderSize = 0;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show.ForeColor = System.Drawing.Color.Transparent;
            this.show.Image = global::Constructor.Properties.Resources.CTRL_SHOW;
            this.show.Location = new System.Drawing.Point(0, 0);
            this.show.Margin = new System.Windows.Forms.Padding(0);
            this.show.MaximumSize = new System.Drawing.Size(27, 21);
            this.show.MinimumSize = new System.Drawing.Size(27, 21);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(27, 21);
            this.show.TabIndex = 1;
            this.show.TabStop = false;
            this.show.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.show.UseVisualStyleBackColor = true;
            // 
            // CSFadeTimer
            // 
            this.CSFadeTimer.Enabled = true;
            this.CSFadeTimer.Interval = 5;
            this.CSFadeTimer.Tick += new System.EventHandler(this.CSFadeTimer_Tick);
            // 
            // CSMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(907, 543);
            this.ControlBox = false;
            this.Controls.Add(this.CSControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CSMainForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.CSControlPanel.ResumeLayout(false);
            this.CSControlPanel.PerformLayout();
            this.CSButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CSControlPanel;
        public System.Windows.Forms.Button show;
        private System.Windows.Forms.Panel CSButtonPanel;
        public System.Windows.Forms.Button close;
        public System.Windows.Forms.Button resize;
        private System.Windows.Forms.Label CSLabel;
        private System.Windows.Forms.Timer CSFadeTimer;
    }
}

