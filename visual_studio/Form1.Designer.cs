namespace WindowsFormsApplication3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.training_data = new System.Windows.Forms.TextBox();
            this.fit = new System.Windows.Forms.RadioButton();
            this.predict = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.test_data = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.discrete = new System.Windows.Forms.RadioButton();
            this.continious = new System.Windows.Forms.RadioButton();
            this.binary = new System.Windows.Forms.RadioButton();
            this.multi_class = new System.Windows.Forms.RadioButton();
            this.visualization = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.target = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(387, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // training_data
            // 
            this.training_data.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.training_data.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.training_data.Location = new System.Drawing.Point(12, 50);
            this.training_data.Name = "training_data";
            this.training_data.Size = new System.Drawing.Size(344, 21);
            this.training_data.TabIndex = 1;
            this.training_data.Text = "Training Data";
            this.training_data.TextChanged += new System.EventHandler(this.training_data_TextChanged);
            // 
            // fit
            // 
            this.fit.AutoSize = true;
            this.fit.Checked = true;
            this.fit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fit.Location = new System.Drawing.Point(6, 16);
            this.fit.Name = "fit";
            this.fit.Size = new System.Drawing.Size(42, 17);
            this.fit.TabIndex = 2;
            this.fit.TabStop = true;
            this.fit.Text = "Fit";
            this.fit.UseVisualStyleBackColor = true;
            this.fit.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // predict
            // 
            this.predict.AutoSize = true;
            this.predict.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predict.Location = new System.Drawing.Point(102, 16);
            this.predict.Name = "predict";
            this.predict.Size = new System.Drawing.Size(71, 17);
            this.predict.TabIndex = 3;
            this.predict.Text = "Predict";
            this.predict.UseVisualStyleBackColor = true;
            this.predict.CheckedChanged += new System.EventHandler(this.predict_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "AltiSolve";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // test_data
            // 
            this.test_data.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_data.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.test_data.Location = new System.Drawing.Point(12, 125);
            this.test_data.Name = "test_data";
            this.test_data.Size = new System.Drawing.Size(344, 21);
            this.test_data.TabIndex = 5;
            this.test_data.Text = "Test Data";
            this.test_data.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(387, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Features Range ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // from
            // 
            this.from.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.from.Location = new System.Drawing.Point(15, 195);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(76, 21);
            this.from.TabIndex = 8;
            this.from.Text = "From";
            this.from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // to
            // 
            this.to.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.to.Location = new System.Drawing.Point(152, 196);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(86, 21);
            this.to.TabIndex = 9;
            this.to.Text = "To";
            this.to.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // discrete
            // 
            this.discrete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discrete.Location = new System.Drawing.Point(6, 19);
            this.discrete.Name = "discrete";
            this.discrete.Size = new System.Drawing.Size(92, 17);
            this.discrete.TabIndex = 10;
            this.discrete.Text = "Discrete";
            this.discrete.UseVisualStyleBackColor = true;
            this.discrete.CheckedChanged += new System.EventHandler(this.discrete_CheckedChanged);
            // 
            // continious
            // 
            this.continious.AutoSize = true;
            this.continious.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continious.Location = new System.Drawing.Point(112, 19);
            this.continious.Name = "continious";
            this.continious.Size = new System.Drawing.Size(93, 17);
            this.continious.TabIndex = 11;
            this.continious.Text = "Continious";
            this.continious.UseVisualStyleBackColor = true;
            // 
            // binary
            // 
            this.binary.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binary.Location = new System.Drawing.Point(36, 344);
            this.binary.Name = "binary";
            this.binary.Size = new System.Drawing.Size(72, 17);
            this.binary.TabIndex = 12;
            this.binary.Text = "Binary";
            this.binary.UseVisualStyleBackColor = true;
            this.binary.Visible = false;
            // 
            // multi_class
            // 
            this.multi_class.AutoSize = true;
            this.multi_class.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi_class.Location = new System.Drawing.Point(36, 367);
            this.multi_class.Name = "multi_class";
            this.multi_class.Size = new System.Drawing.Size(86, 17);
            this.multi_class.TabIndex = 13;
            this.multi_class.Text = "Multi Class";
            this.multi_class.UseVisualStyleBackColor = true;
            this.multi_class.Visible = false;
            // 
            // visualization
            // 
            this.visualization.AutoSize = true;
            this.visualization.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualization.Location = new System.Drawing.Point(6, 20);
            this.visualization.Name = "visualization";
            this.visualization.Size = new System.Drawing.Size(112, 17);
            this.visualization.TabIndex = 14;
            this.visualization.Text = "Visualization ";
            this.visualization.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(199, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Target ";
            // 
            // target
            // 
            this.target.Location = new System.Drawing.Point(15, 264);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(76, 21);
            this.target.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.predict);
            this.groupBox1.Controls.Add(this.fit);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 42);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.continious);
            this.groupBox2.Controls.Add(this.discrete);
            this.groupBox2.Location = new System.Drawing.Point(15, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 47);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.visualization);
            this.groupBox3.Location = new System.Drawing.Point(15, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 47);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(496, 477);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.target);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.multi_class);
            this.Controls.Add(this.binary);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.test_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.training_data);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AltiSolve (Ensemble Learning)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox training_data;
        private System.Windows.Forms.RadioButton fit;
        private System.Windows.Forms.RadioButton predict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox test_data;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.RadioButton discrete;
        private System.Windows.Forms.RadioButton continious;
        private System.Windows.Forms.RadioButton binary;
        private System.Windows.Forms.RadioButton multi_class;
        private System.Windows.Forms.RadioButton visualization;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox target;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

