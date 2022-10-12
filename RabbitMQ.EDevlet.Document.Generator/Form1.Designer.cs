namespace RabbitMQ.EDevlet.Document.Generator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnect = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCreateDocument = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // txtConnect
            // 
            this.txtConnect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConnect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnect.Location = new System.Drawing.Point(17, 33);
            this.txtConnect.Margin = new System.Windows.Forms.Padding(4);
            this.txtConnect.Name = "txtConnect";
            this.txtConnect.Size = new System.Drawing.Size(483, 26);
            this.txtConnect.TabIndex = 1;
            this.txtConnect.Text = "amqp://guest:guest@localhost:5672";
           
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Green;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConnect.FlatAppearance.BorderSize = 10;
            this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnConnect.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnect.Location = new System.Drawing.Point(400, 73);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 35);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCreateDocument
            // 
            this.btnCreateDocument.BackColor = System.Drawing.Color.Orange;
            this.btnCreateDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateDocument.Enabled = false;
            this.btnCreateDocument.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCreateDocument.FlatAppearance.BorderSize = 10;
            this.btnCreateDocument.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCreateDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCreateDocument.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDocument.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateDocument.Location = new System.Drawing.Point(184, 127);
            this.btnCreateDocument.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateDocument.Name = "btnCreateDocument";
            this.btnCreateDocument.Size = new System.Drawing.Size(157, 81);
            this.btnCreateDocument.TabIndex = 4;
            this.btnCreateDocument.Text = "Create Document";
            this.btnCreateDocument.UseVisualStyleBackColor = false;
            this.btnCreateDocument.Click += new System.EventHandler(this.btnCreateDocument_Click);
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Location = new System.Drawing.Point(0, 271);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(513, 196);
            this.txtLog.TabIndex = 5;
            this.txtLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 467);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnCreateDocument);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtConnect);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "edevlet";
            this.Text = "E-Devlet Document Generator ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCreateDocument;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}

