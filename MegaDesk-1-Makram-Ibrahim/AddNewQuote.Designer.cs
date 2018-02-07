namespace MegaDesk_4_Makram_Ibrahim
{
    partial class AddNewQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewQuote));
            this.cancelQuoteButton = new System.Windows.Forms.Button();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.numOfDrawersLabel = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.widthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.depth = new System.Windows.Forms.TextBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.materialsOutput = new System.Windows.Forms.ComboBox();
            this.widthError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rushOptions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numOfDrawers = new System.Windows.Forms.ComboBox();
            this.AddDeskQuoteButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelQuoteButton
            // 
            this.cancelQuoteButton.AutoSize = true;
            this.cancelQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelQuoteButton.Location = new System.Drawing.Point(12, 367);
            this.cancelQuoteButton.Name = "cancelQuoteButton";
            this.cancelQuoteButton.Size = new System.Drawing.Size(200, 50);
            this.cancelQuoteButton.TabIndex = 8;
            this.cancelQuoteButton.Text = "Cancel";
            this.cancelQuoteButton.UseVisualStyleBackColor = true;
            this.cancelQuoteButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CancelBtn_Click);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(12, 211);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(152, 24);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // customerName
            // 
            this.clientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientName.Location = new System.Drawing.Point(170, 211);
            this.clientName.Name = "customerName";
            this.clientName.Size = new System.Drawing.Size(187, 29);
            this.clientName.TabIndex = 1;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(13, 249);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(110, 24);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Desk Width:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(13, 287);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(112, 24);
            this.depthLabel.TabIndex = 5;
            this.depthLabel.Text = "Desk Depth:";
            // 
            // numOfDrawersLabel
            // 
            this.numOfDrawersLabel.AutoSize = true;
            this.numOfDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfDrawersLabel.Location = new System.Drawing.Point(401, 300);
            this.numOfDrawersLabel.Name = "numOfDrawersLabel";
            this.numOfDrawersLabel.Size = new System.Drawing.Size(84, 24);
            this.numOfDrawersLabel.TabIndex = 7;
            this.numOfDrawersLabel.Text = "Drawers:";
            // 
            // width
            // 
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.Location = new System.Drawing.Point(170, 249);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(73, 29);
            this.width.TabIndex = 2;
            this.width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharValidation);
            this.width.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            this.width.Validated += new System.EventHandler(this.Width_Validated);
            // 
            // widthErrorProvider
            // 
            this.widthErrorProvider.ContainerControl = this;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // depth
            // 
            this.depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth.Location = new System.Drawing.Point(170, 289);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(73, 29);
            this.depth.TabIndex = 3;
            this.depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharValidation);
            this.depth.Validating += new System.ComponentModel.CancelEventHandler(this.Depth_Validating);
            this.depth.Validated += new System.EventHandler(this.Depth_Validated);
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(400, 218);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(127, 24);
            this.materialLabel.TabIndex = 11;
            this.materialLabel.Text = "Desk Material:";
            // 
            // materialTypeBox
            // 
            this.materialsOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialsOutput.FormattingEnabled = true;
            this.materialsOutput.Location = new System.Drawing.Point(529, 214);
            this.materialsOutput.MaxDropDownItems = 5;
            this.materialsOutput.Name = "materialTypeBox";
            this.materialsOutput.Size = new System.Drawing.Size(140, 32);
            this.materialsOutput.TabIndex = 4;
            // 
            // widthError
            // 
            this.widthError.AutoSize = true;
            this.widthError.Location = new System.Drawing.Point(220, 251);
            this.widthError.Name = "widthError";
            this.widthError.Size = new System.Drawing.Size(0, 13);
            this.widthError.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rush Days:";
            // 
            // rushOptions
            // 
            this.rushOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rushOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOptions.FormattingEnabled = true;
            this.rushOptions.Items.AddRange(new object[] {
            "None",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.rushOptions.Location = new System.Drawing.Point(529, 254);
            this.rushOptions.MaxDropDownItems = 5;
            this.rushOptions.Name = "rushOptions";
            this.rushOptions.Size = new System.Drawing.Size(140, 32);
            this.rushOptions.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "24in - 96in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "12in - 48in";
            // 
            // numOfDrawers
            // 
            this.numOfDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfDrawers.FormattingEnabled = true;
            this.numOfDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.numOfDrawers.Location = new System.Drawing.Point(529, 292);
            this.numOfDrawers.Name = "numOfDrawers";
            this.numOfDrawers.Size = new System.Drawing.Size(73, 32);
            this.numOfDrawers.TabIndex = 6;
            // 
            // AddDeskQuoteButton
            // 
            this.AddDeskQuoteButton.AutoSize = true;
            this.AddDeskQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDeskQuoteButton.Location = new System.Drawing.Point(218, 367);
            this.AddDeskQuoteButton.Name = "AddDeskQuoteButton";
            this.AddDeskQuoteButton.Size = new System.Drawing.Size(200, 50);
            this.AddDeskQuoteButton.TabIndex = 7;
            this.AddDeskQuoteButton.Text = "Submit Quote";
            this.AddDeskQuoteButton.UseVisualStyleBackColor = true;
            this.AddDeskQuoteButton.Click += new System.EventHandler(this.DeskQuoteBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(660, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(660, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // AddNewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 433);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AddDeskQuoteButton);
            this.Controls.Add(this.numOfDrawers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rushOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthError);
            this.Controls.Add(this.materialsOutput);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.numOfDrawersLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.cancelQuoteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewQuote";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelQuoteButton;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label numOfDrawersLabel;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.ErrorProvider widthErrorProvider;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.ComboBox materialsOutput;
        private System.Windows.Forms.Label widthError;
        private System.Windows.Forms.ComboBox rushOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox numOfDrawers;
        private System.Windows.Forms.Button AddDeskQuoteButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}