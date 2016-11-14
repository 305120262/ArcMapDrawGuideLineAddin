﻿namespace ArcMapShowGridAddin
{
    partial class DetailForm
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
            this.gvPoints = new System.Windows.Forms.DataGridView();
            this.XSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XMap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YMap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblXSource = new System.Windows.Forms.Label();
            this.lblYSource = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPoints
            // 
            this.gvPoints.AllowUserToAddRows = false;
            this.gvPoints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XSource,
            this.YSource,
            this.XMap,
            this.YMap});
            this.gvPoints.Location = new System.Drawing.Point(346, 12);
            this.gvPoints.Name = "gvPoints";
            this.gvPoints.ReadOnly = true;
            this.gvPoints.RowTemplate.Height = 27;
            this.gvPoints.Size = new System.Drawing.Size(486, 172);
            this.gvPoints.TabIndex = 0;
            // 
            // XSource
            // 
            this.XSource.HeaderText = "X Source";
            this.XSource.Name = "XSource";
            this.XSource.ReadOnly = true;
            // 
            // YSource
            // 
            this.YSource.HeaderText = "Y Source";
            this.YSource.Name = "YSource";
            this.YSource.ReadOnly = true;
            // 
            // XMap
            // 
            this.XMap.HeaderText = "X Map";
            this.XMap.Name = "XMap";
            this.XMap.ReadOnly = true;
            this.XMap.Width = 76;
            // 
            // YMap
            // 
            this.YMap.HeaderText = "Y Map";
            this.YMap.Name = "YMap";
            this.YMap.ReadOnly = true;
            this.YMap.Width = 76;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "导出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 25);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(225, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 25);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(52, 25);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "0";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(160, 117);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(52, 25);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "0";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(225, 117);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(52, 25);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "X Map";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y Map";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "X Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y Source";
            // 
            // lblXSource
            // 
            this.lblXSource.AutoSize = true;
            this.lblXSource.Location = new System.Drawing.Point(105, 12);
            this.lblXSource.Name = "lblXSource";
            this.lblXSource.Size = new System.Drawing.Size(0, 15);
            this.lblXSource.TabIndex = 13;
            // 
            // lblYSource
            // 
            this.lblYSource.AutoSize = true;
            this.lblYSource.Location = new System.Drawing.Point(105, 44);
            this.lblYSource.Name = "lblYSource";
            this.lblYSource.Size = new System.Drawing.Size(0, 15);
            this.lblYSource.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "清除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 209);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblYSource);
            this.Controls.Add(this.lblXSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gvPoints);
            this.Name = "DetailForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "坐标点对";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.gvPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn XSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn YSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn XMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn YMap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblXSource;
        private System.Windows.Forms.Label lblYSource;
        private System.Windows.Forms.Button button3;
    }
}