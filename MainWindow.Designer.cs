namespace MouseJiggler2021
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IntervalNumUpDwn = new MouseJiggler2021.Extensions.Controls.ExNumUpDwn();
            this.MoveUpDwn = new MouseJiggler2021.Extensions.Controls.ExNumUpDwn();
            this.WaiterCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.JiggleTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumUpDwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveUpDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.93023F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.06977F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MoveUpDwn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.IntervalNumUpDwn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.WaiterCB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(265, 99);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // IntervalNumUpDwn
            // 
            this.IntervalNumUpDwn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntervalNumUpDwn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntervalNumUpDwn.Location = new System.Drawing.Point(134, 13);
            this.IntervalNumUpDwn.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.IntervalNumUpDwn.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.IntervalNumUpDwn.Name = "IntervalNumUpDwn";
            this.IntervalNumUpDwn.Size = new System.Drawing.Size(78, 20);
            this.IntervalNumUpDwn.TabIndex = 0;
            this.IntervalNumUpDwn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IntervalNumUpDwn.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.IntervalNumUpDwn.ValueDbl = 3D;
            this.IntervalNumUpDwn.ValueInt = 3;
            this.IntervalNumUpDwn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exNumUpDwn1_KeyPress);
            // 
            // MoveUpDwn
            // 
            this.MoveUpDwn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoveUpDwn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveUpDwn.Location = new System.Drawing.Point(134, 42);
            this.MoveUpDwn.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MoveUpDwn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MoveUpDwn.Name = "MoveUpDwn";
            this.MoveUpDwn.Size = new System.Drawing.Size(78, 20);
            this.MoveUpDwn.TabIndex = 1;
            this.MoveUpDwn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MoveUpDwn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MoveUpDwn.ValueDbl = 1D;
            this.MoveUpDwn.ValueInt = 1;
            this.MoveUpDwn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exNumUpDwn1_KeyPress);
            // 
            // WaiterCB
            // 
            this.WaiterCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WaiterCB.AutoSize = true;
            this.WaiterCB.Location = new System.Drawing.Point(134, 71);
            this.WaiterCB.Name = "WaiterCB";
            this.WaiterCB.Size = new System.Drawing.Size(15, 25);
            this.WaiterCB.TabIndex = 4;
            this.WaiterCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Timeout (seconds):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Movement Offset (1-10):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wait after idle:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "MJ2021";
            this.notifyIcon1.BalloonTipTitle = "Do a lil\' jig";
            this.notifyIcon1.Text = "Idle";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // JiggleTimer
            // 
            this.JiggleTimer.Interval = 500;
            this.JiggleTimer.Tick += new System.EventHandler(this.JiggleTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 99);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MouseJiggler 2021";
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumUpDwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveUpDwn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Extensions.Controls.ExNumUpDwn MoveUpDwn;
        private Extensions.Controls.ExNumUpDwn IntervalNumUpDwn;
        private System.Windows.Forms.CheckBox WaiterCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer JiggleTimer;
    }
}

