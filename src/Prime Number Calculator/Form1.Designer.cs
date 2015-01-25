namespace Prime_Number_Calculator
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
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.numberIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.Button();
            this.addText = new System.Windows.Forms.CheckBox();
            this.pNumberOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mNumberIn = new System.Windows.Forms.TextBox();
            this.autoSave = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 13);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(142, 54);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(12, 73);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(142, 54);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // numberIn
            // 
            this.numberIn.Location = new System.Drawing.Point(12, 146);
            this.numberIn.Name = "numberIn";
            this.numberIn.Size = new System.Drawing.Size(139, 20);
            this.numberIn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start at:";
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(12, 234);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(142, 35);
            this.saveFile.TabIndex = 5;
            this.saveFile.Text = "Save to file";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // addText
            // 
            this.addText.AutoSize = true;
            this.addText.Location = new System.Drawing.Point(12, 211);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(69, 17);
            this.addText.TabIndex = 6;
            this.addText.Text = "Add Text";
            this.addText.UseVisualStyleBackColor = true;
            this.addText.CheckedChanged += new System.EventHandler(this.addText_CheckedChanged);
            // 
            // pNumberOut
            // 
            this.pNumberOut.Location = new System.Drawing.Point(181, 13);
            this.pNumberOut.Multiline = true;
            this.pNumberOut.Name = "pNumberOut";
            this.pNumberOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pNumberOut.Size = new System.Drawing.Size(351, 279);
            this.pNumberOut.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stop at:";
            // 
            // mNumberIn
            // 
            this.mNumberIn.Location = new System.Drawing.Point(12, 185);
            this.mNumberIn.Name = "mNumberIn";
            this.mNumberIn.Size = new System.Drawing.Size(139, 20);
            this.mNumberIn.TabIndex = 10;
            // 
            // autoSave
            // 
            this.autoSave.AutoSize = true;
            this.autoSave.BackColor = System.Drawing.SystemColors.Control;
            this.autoSave.Location = new System.Drawing.Point(12, 275);
            this.autoSave.Name = "autoSave";
            this.autoSave.Size = new System.Drawing.Size(85, 17);
            this.autoSave.TabIndex = 11;
            this.autoSave.Text = "Auto Save ?";
            this.autoSave.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 302);
            this.Controls.Add(this.autoSave);
            this.Controls.Add(this.mNumberIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pNumberOut);
            this.Controls.Add(this.addText);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberIn);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Prime Number Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox numberIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.CheckBox addText;
        private System.Windows.Forms.TextBox pNumberOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mNumberIn;
        private System.Windows.Forms.CheckBox autoSave;
    }
}

