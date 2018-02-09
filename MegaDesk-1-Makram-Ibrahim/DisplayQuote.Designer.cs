namespace MegaDesk_4_Makram_Ibrahim
{
    partial class DisplayQuote
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
            this.quotePrices = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.closeQuoteButton = new System.Windows.Forms.Button();
            this.DisplQuote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quotePrices
            // 
            this.quotePrices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.quotePrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotePrices.Location = new System.Drawing.Point(418, 338);
            this.quotePrices.Name = "quotePrices";
            this.quotePrices.Size = new System.Drawing.Size(125, 31);
            this.quotePrices.TabIndex = 15;
            this.quotePrices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Cost:";
            // 
            // closeQuoteButton
            // 
            this.closeQuoteButton.AutoSize = true;
            this.closeQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeQuoteButton.Location = new System.Drawing.Point(12, 399);
            this.closeQuoteButton.Name = "closeQuoteButton";
            this.closeQuoteButton.Size = new System.Drawing.Size(200, 50);
            this.closeQuoteButton.TabIndex = 16;
            this.closeQuoteButton.Text = "Close";
            this.closeQuoteButton.UseVisualStyleBackColor = true;
            this.closeQuoteButton.Click += new System.EventHandler(this.QuoteBtn_Click);
            // 
            // DisplQuote
            // 
            this.DisplQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplQuote.Location = new System.Drawing.Point(126, 9);
            this.DisplQuote.Name = "DisplQuote";
            this.DisplQuote.Size = new System.Drawing.Size(518, 312);
            this.DisplQuote.TabIndex = 17;
            this.DisplQuote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.ControlBox = false;
            this.Controls.Add(this.DisplQuote);
            this.Controls.Add(this.closeQuoteButton);
            this.Controls.Add(this.quotePrices);
            this.Controls.Add(this.label3);
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label quotePrices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closeQuoteButton;
        private System.Windows.Forms.Label DisplQuote;
    }
}