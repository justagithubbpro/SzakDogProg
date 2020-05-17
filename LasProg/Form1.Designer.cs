namespace LasProg
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.LoadProgressText = new System.Windows.Forms.Label();
			this.mongodb_1000migrate = new System.Windows.Forms.Button();
			this.mongodb_100migrate = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.secondPath = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.mssql_1000migrate = new System.Windows.Forms.Button();
			this.mssql_100migrate = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.firstPath = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.mongo_load_text = new System.Windows.Forms.Label();
			this.mssq_load_text = new System.Windows.Forms.Label();
			this.mongodb_load = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.mssqlq_load = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tabControl1.Location = new System.Drawing.Point(13, 16);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(579, 414);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.LoadProgressText);
			this.tabPage1.Controls.Add(this.mongodb_1000migrate);
			this.tabPage1.Controls.Add(this.mongodb_100migrate);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.secondPath);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.mssql_1000migrate);
			this.tabPage1.Controls.Add(this.mssql_100migrate);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.firstPath);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 23);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(571, 387);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "DataMigration";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// LoadProgressText
			// 
			this.LoadProgressText.AutoSize = true;
			this.LoadProgressText.Location = new System.Drawing.Point(240, 178);
			this.LoadProgressText.Name = "LoadProgressText";
			this.LoadProgressText.Size = new System.Drawing.Size(101, 14);
			this.LoadProgressText.TabIndex = 15;
			this.LoadProgressText.Text = "Nothing in Progress";
			// 
			// mongodb_1000migrate
			// 
			this.mongodb_1000migrate.Location = new System.Drawing.Point(479, 203);
			this.mongodb_1000migrate.Name = "mongodb_1000migrate";
			this.mongodb_1000migrate.Size = new System.Drawing.Size(75, 23);
			this.mongodb_1000migrate.TabIndex = 14;
			this.mongodb_1000migrate.Text = "Load(1000)";
			this.mongodb_1000migrate.UseVisualStyleBackColor = true;
			this.mongodb_1000migrate.Click += new System.EventHandler(this.mongodb_1000migrate_Click);
			// 
			// mongodb_100migrate
			// 
			this.mongodb_100migrate.Location = new System.Drawing.Point(479, 174);
			this.mongodb_100migrate.Name = "mongodb_100migrate";
			this.mongodb_100migrate.Size = new System.Drawing.Size(75, 23);
			this.mongodb_100migrate.TabIndex = 13;
			this.mongodb_100migrate.Text = "Load(100)";
			this.mongodb_100migrate.UseVisualStyleBackColor = true;
			this.mongodb_100migrate.Click += new System.EventHandler(this.mongodb_100migrate_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(367, 208);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 14);
			this.label9.TabIndex = 12;
			this.label9.Text = "Load by 1000";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(367, 178);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 14);
			this.label8.TabIndex = 11;
			this.label8.Text = "Load by 100";
			// 
			// secondPath
			// 
			this.secondPath.Location = new System.Drawing.Point(454, 143);
			this.secondPath.Name = "secondPath";
			this.secondPath.Size = new System.Drawing.Size(100, 22);
			this.secondPath.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(367, 146);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 14);
			this.label7.TabIndex = 9;
			this.label7.Text = "Path of the File:";
			// 
			// mssql_1000migrate
			// 
			this.mssql_1000migrate.Location = new System.Drawing.Point(117, 204);
			this.mssql_1000migrate.Name = "mssql_1000migrate";
			this.mssql_1000migrate.Size = new System.Drawing.Size(75, 23);
			this.mssql_1000migrate.TabIndex = 8;
			this.mssql_1000migrate.Text = "Load(1000)";
			this.mssql_1000migrate.UseVisualStyleBackColor = true;
			this.mssql_1000migrate.Click += new System.EventHandler(this.mssql_1000migrate_Click);
			// 
			// mssql_100migrate
			// 
			this.mssql_100migrate.Location = new System.Drawing.Point(117, 174);
			this.mssql_100migrate.Name = "mssql_100migrate";
			this.mssql_100migrate.Size = new System.Drawing.Size(75, 23);
			this.mssql_100migrate.TabIndex = 7;
			this.mssql_100migrate.Text = "Load(100)";
			this.mssql_100migrate.UseVisualStyleBackColor = true;
			this.mssql_100migrate.Click += new System.EventHandler(this.mssql_100migrate_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 208);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 14);
			this.label6.TabIndex = 6;
			this.label6.Text = "Load by 1000";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 178);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 14);
			this.label5.TabIndex = 5;
			this.label5.Text = "Load by 100";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 14);
			this.label4.TabIndex = 4;
			this.label4.Text = "Path of the File:";
			// 
			// firstPath
			// 
			this.firstPath.Location = new System.Drawing.Point(92, 143);
			this.firstPath.Name = "firstPath";
			this.firstPath.Size = new System.Drawing.Size(100, 22);
			this.firstPath.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(451, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 14);
			this.label3.TabIndex = 2;
			this.label3.Text = "MongoDB";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(89, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 14);
			this.label2.TabIndex = 1;
			this.label2.Text = "MsSQL";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(253, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "Data Migration";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.mongo_load_text);
			this.tabPage2.Controls.Add(this.mssq_load_text);
			this.tabPage2.Controls.Add(this.mongodb_load);
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Controls.Add(this.mssqlq_load);
			this.tabPage2.Controls.Add(this.dataGridView1);
			this.tabPage2.Location = new System.Drawing.Point(4, 23);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(571, 387);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Query";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// mongo_load_text
			// 
			this.mongo_load_text.AutoSize = true;
			this.mongo_load_text.Location = new System.Drawing.Point(9, 360);
			this.mongo_load_text.Name = "mongo_load_text";
			this.mongo_load_text.Size = new System.Drawing.Size(80, 14);
			this.mongo_load_text.TabIndex = 5;
			this.mongo_load_text.Text = "Haven\'t started";
			// 
			// mssq_load_text
			// 
			this.mssq_load_text.AutoSize = true;
			this.mssq_load_text.Location = new System.Drawing.Point(6, 167);
			this.mssq_load_text.Name = "mssq_load_text";
			this.mssq_load_text.Size = new System.Drawing.Size(80, 14);
			this.mssq_load_text.TabIndex = 4;
			this.mssq_load_text.Text = "Haven\'t started";
			// 
			// mongodb_load
			// 
			this.mongodb_load.Location = new System.Drawing.Point(489, 351);
			this.mongodb_load.Name = "mongodb_load";
			this.mongodb_load.Size = new System.Drawing.Size(75, 23);
			this.mongodb_load.TabIndex = 3;
			this.mongodb_load.Text = "Load";
			this.mongodb_load.UseVisualStyleBackColor = true;
			this.mongodb_load.Click += new System.EventHandler(this.mongodb_load_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(7, 194);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(558, 150);
			this.dataGridView2.TabIndex = 2;
			// 
			// mssqlq_load
			// 
			this.mssqlq_load.Location = new System.Drawing.Point(490, 163);
			this.mssqlq_load.Name = "mssqlq_load";
			this.mssqlq_load.Size = new System.Drawing.Size(75, 23);
			this.mssqlq_load.TabIndex = 1;
			this.mssqlq_load.Text = "Load";
			this.mssqlq_load.UseVisualStyleBackColor = true;
			this.mssqlq_load.Click += new System.EventHandler(this.mssqlq_load_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(7, 7);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(558, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 442);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button mongodb_1000migrate;
		private System.Windows.Forms.Button mongodb_100migrate;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox secondPath;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button mssql_1000migrate;
		private System.Windows.Forms.Button mssql_100migrate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox firstPath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button mssqlq_load;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button mongodb_load;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label mongo_load_text;
		private System.Windows.Forms.Label mssq_load_text;
		private System.Windows.Forms.Label LoadProgressText;
	}
}

