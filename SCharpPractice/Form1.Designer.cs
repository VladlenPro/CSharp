namespace SCharpPractice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnEventPractice = new System.Windows.Forms.Button();
            this.btnREfVal = new System.Windows.Forms.Button();
            this.btnStruct = new System.Windows.Forms.Button();
            this.btnLinq = new System.Windows.Forms.Button();
            this.btnExtention = new System.Windows.Forms.Button();
            this.btnGarbageCollector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delegate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEventPractice
            // 
            this.btnEventPractice.Location = new System.Drawing.Point(27, 44);
            this.btnEventPractice.Name = "btnEventPractice";
            this.btnEventPractice.Size = new System.Drawing.Size(94, 23);
            this.btnEventPractice.TabIndex = 1;
            this.btnEventPractice.Text = "Event Practice";
            this.btnEventPractice.UseVisualStyleBackColor = true;
            this.btnEventPractice.Click += new System.EventHandler(this.btnEventPractice_Click);
            // 
            // btnREfVal
            // 
            this.btnREfVal.Location = new System.Drawing.Point(26, 73);
            this.btnREfVal.Name = "btnREfVal";
            this.btnREfVal.Size = new System.Drawing.Size(75, 23);
            this.btnREfVal.TabIndex = 2;
            this.btnREfVal.Text = "Ref Val";
            this.btnREfVal.UseVisualStyleBackColor = true;
            this.btnREfVal.Click += new System.EventHandler(this.btnREfVal_Click);
            // 
            // btnStruct
            // 
            this.btnStruct.Location = new System.Drawing.Point(26, 102);
            this.btnStruct.Name = "btnStruct";
            this.btnStruct.Size = new System.Drawing.Size(75, 23);
            this.btnStruct.TabIndex = 3;
            this.btnStruct.Text = "Struct";
            this.btnStruct.UseVisualStyleBackColor = true;
            this.btnStruct.Click += new System.EventHandler(this.btnStruct_Click);
            // 
            // btnLinq
            // 
            this.btnLinq.Location = new System.Drawing.Point(28, 132);
            this.btnLinq.Name = "btnLinq";
            this.btnLinq.Size = new System.Drawing.Size(75, 23);
            this.btnLinq.TabIndex = 4;
            this.btnLinq.Text = "Linq";
            this.btnLinq.UseVisualStyleBackColor = true;
            this.btnLinq.Click += new System.EventHandler(this.btnLinq_Click);
            // 
            // btnExtention
            // 
            this.btnExtention.Location = new System.Drawing.Point(28, 159);
            this.btnExtention.Name = "btnExtention";
            this.btnExtention.Size = new System.Drawing.Size(115, 23);
            this.btnExtention.TabIndex = 5;
            this.btnExtention.Text = "Extention method";
            this.btnExtention.UseVisualStyleBackColor = true;
            this.btnExtention.Click += new System.EventHandler(this.btnExtention_Click);
            // 
            // btnGarbageCollector
            // 
            this.btnGarbageCollector.Location = new System.Drawing.Point(26, 187);
            this.btnGarbageCollector.Name = "btnGarbageCollector";
            this.btnGarbageCollector.Size = new System.Drawing.Size(117, 23);
            this.btnGarbageCollector.TabIndex = 6;
            this.btnGarbageCollector.Text = "GarbageCollector";
            this.btnGarbageCollector.UseVisualStyleBackColor = true;
            this.btnGarbageCollector.Click += new System.EventHandler(this.btnGarbageCollector_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGarbageCollector);
            this.Controls.Add(this.btnExtention);
            this.Controls.Add(this.btnLinq);
            this.Controls.Add(this.btnStruct);
            this.Controls.Add(this.btnREfVal);
            this.Controls.Add(this.btnEventPractice);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button btnEventPractice;
        private Button btnREfVal;
        private Button btnStruct;
        private Button btnLinq;
        private Button btnExtention;
        private Button btnGarbageCollector;
    }
}