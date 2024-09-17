namespace HelloWorld
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
            this.btnClickThis = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.BackColor = System.Drawing.Color.White;
            this.btnClickThis.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClickThis.Location = new System.Drawing.Point(12, 12);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(215, 70);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Hello World";
            this.btnClickThis.UseVisualStyleBackColor = false;
            this.btnClickThis.Click += new System.EventHandler(this.button1_Click);
            // 
            // Save
            // 
            this.Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Save.Location = new System.Drawing.Point(502, 396);
            this.Save.Name = "Save";
            this.Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Save.Size = new System.Drawing.Size(172, 57);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Exit.Location = new System.Drawing.Point(680, 396);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(172, 57);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // rtbEditor
            // 
            this.rtbEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEditor.BackColor = System.Drawing.Color.White;
            this.rtbEditor.Location = new System.Drawing.Point(12, 88);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(872, 282);
            this.rtbEditor.TabIndex = 4;
            this.rtbEditor.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(896, 470);
            this.Controls.Add(this.rtbEditor);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.btnClickThis);
            this.ForeColor = System.Drawing.Color.Red;
            this.MinimumSize = new System.Drawing.Size(918, 526);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RichTextBox rtbEditor;
    }
}

