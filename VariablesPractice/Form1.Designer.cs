
namespace VariablesPractice
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
            this.gretzkyButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.areaButton = new System.Windows.Forms.Button();
            this.carpetButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gretzkyButton
            // 
            this.gretzkyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gretzkyButton.Location = new System.Drawing.Point(22, 12);
            this.gretzkyButton.Name = "gretzkyButton";
            this.gretzkyButton.Size = new System.Drawing.Size(164, 81);
            this.gretzkyButton.TabIndex = 0;
            this.gretzkyButton.Text = "Hockey";
            this.gretzkyButton.UseVisualStyleBackColor = true;
            this.gretzkyButton.Click += new System.EventHandler(this.gretzkyButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(236, 12);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(540, 429);
            this.outputLabel.TabIndex = 1;
            // 
            // areaButton
            // 
            this.areaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaButton.Location = new System.Drawing.Point(22, 122);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(164, 81);
            this.areaButton.TabIndex = 2;
            this.areaButton.Text = "Area of a Circle";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // carpetButton
            // 
            this.carpetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetButton.Location = new System.Drawing.Point(22, 233);
            this.carpetButton.Name = "carpetButton";
            this.carpetButton.Size = new System.Drawing.Size(164, 81);
            this.carpetButton.TabIndex = 3;
            this.carpetButton.Text = "Cost of a Carpet";
            this.carpetButton.UseVisualStyleBackColor = true;
            this.carpetButton.Click += new System.EventHandler(this.carpetButton_Click);
            // 
            // billButton
            // 
            this.billButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billButton.Location = new System.Drawing.Point(22, 343);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(164, 81);
            this.billButton.TabIndex = 4;
            this.billButton.Text = "Bill of Sale";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.carpetButton);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.gretzkyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gretzkyButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button carpetButton;
        private System.Windows.Forms.Button billButton;
    }
}

