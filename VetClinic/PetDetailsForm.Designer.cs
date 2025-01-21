namespace VetClinic
{
    partial class PetDetailsForm
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
            textBoxType = new TextBox();
            labelType = new Label();
            buttonAdopt = new Button();
            labelPetName = new Label();
            textBoxBreed = new TextBox();
            labelBreed = new Label();
            pictureBoxImage = new PictureBox();
            textBoxStatus = new TextBox();
            labelStatus = new Label();
            textBoxMedicalHistory = new TextBox();
            label1 = new Label();
            textBoxWeigth = new TextBox();
            label2 = new Label();
            textBoxColor = new TextBox();
            label3 = new Label();
            textBoxToy = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(151, 164);
            textBoxType.Name = "textBoxType";
            textBoxType.ReadOnly = true;
            textBoxType.Size = new Size(324, 31);
            textBoxType.TabIndex = 15;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(82, 164);
            labelType.Name = "labelType";
            labelType.Size = new Size(53, 25);
            labelType.TabIndex = 14;
            labelType.Text = "Type:";
            // 
            // buttonAdopt
            // 
            buttonAdopt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAdopt.Location = new Point(709, 482);
            buttonAdopt.Name = "buttonAdopt";
            buttonAdopt.Size = new Size(178, 63);
            buttonAdopt.TabIndex = 11;
            buttonAdopt.Text = "Adopt";
            buttonAdopt.UseVisualStyleBackColor = true;
            buttonAdopt.Click += buttonAdopt_Click;
            // 
            // labelPetName
            // 
            labelPetName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelPetName.FlatStyle = FlatStyle.System;
            labelPetName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPetName.Location = new Point(12, 9);
            labelPetName.Name = "labelPetName";
            labelPetName.Size = new Size(897, 107);
            labelPetName.TabIndex = 10;
            labelPetName.Text = "Pet's Name";
            labelPetName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxBreed
            // 
            textBoxBreed.Location = new Point(151, 232);
            textBoxBreed.Name = "textBoxBreed";
            textBoxBreed.ReadOnly = true;
            textBoxBreed.Size = new Size(324, 31);
            textBoxBreed.TabIndex = 17;
            // 
            // labelBreed
            // 
            labelBreed.AutoSize = true;
            labelBreed.Location = new Point(82, 232);
            labelBreed.Name = "labelBreed";
            labelBreed.Size = new Size(61, 25);
            labelBreed.TabIndex = 16;
            labelBreed.Text = "Breed:";
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxImage.Location = new Point(52, 6);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(134, 152);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 18;
            pictureBoxImage.TabStop = false;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(151, 293);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(324, 31);
            textBoxStatus.TabIndex = 20;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(82, 293);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(64, 25);
            labelStatus.TabIndex = 19;
            labelStatus.Text = "Status:";
            // 
            // textBoxMedicalHistory
            // 
            textBoxMedicalHistory.Location = new Point(151, 392);
            textBoxMedicalHistory.Multiline = true;
            textBoxMedicalHistory.Name = "textBoxMedicalHistory";
            textBoxMedicalHistory.ReadOnly = true;
            textBoxMedicalHistory.Size = new Size(324, 62);
            textBoxMedicalHistory.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 364);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 21;
            label1.Text = "Medical history:";
            // 
            // textBoxWeigth
            // 
            textBoxWeigth.Location = new Point(572, 164);
            textBoxWeigth.Name = "textBoxWeigth";
            textBoxWeigth.ReadOnly = true;
            textBoxWeigth.Size = new Size(315, 31);
            textBoxWeigth.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 164);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 23;
            label2.Text = "Weigth:";
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(572, 226);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.ReadOnly = true;
            textBoxColor.Size = new Size(315, 31);
            textBoxColor.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 226);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 25;
            label3.Text = "Color:";
            // 
            // textBoxToy
            // 
            textBoxToy.Location = new Point(572, 287);
            textBoxToy.Name = "textBoxToy";
            textBoxToy.ReadOnly = true;
            textBoxToy.Size = new Size(315, 31);
            textBoxToy.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 287);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 27;
            label4.Text = "Fav Toy:";
            // 
            // PetDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 572);
            Controls.Add(textBoxToy);
            Controls.Add(label4);
            Controls.Add(textBoxColor);
            Controls.Add(label3);
            Controls.Add(textBoxWeigth);
            Controls.Add(label2);
            Controls.Add(textBoxMedicalHistory);
            Controls.Add(label1);
            Controls.Add(textBoxStatus);
            Controls.Add(labelStatus);
            Controls.Add(pictureBoxImage);
            Controls.Add(textBoxBreed);
            Controls.Add(labelBreed);
            Controls.Add(textBoxType);
            Controls.Add(labelType);
            Controls.Add(buttonAdopt);
            Controls.Add(labelPetName);
            Name = "PetDetailsForm";
            Text = "Pet Details";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxType;
        private Label labelType;
        private Button buttonAdopt;
        private Label labelPetName;
        private TextBox textBoxBreed;
        private Label labelBreed;
        private PictureBox pictureBoxImage;
        private TextBox textBoxStatus;
        private Label labelStatus;
        private TextBox textBoxMedicalHistory;
        private Label label1;
        private TextBox textBoxWeigth;
        private Label label2;
        private TextBox textBoxColor;
        private Label label3;
        private TextBox textBoxToy;
        private Label label4;
    }
}