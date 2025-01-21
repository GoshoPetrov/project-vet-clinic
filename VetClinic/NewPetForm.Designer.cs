namespace VetClinic
{
    partial class NewPetForm
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
            buttonAdd = new Button();
            labelTitle = new Label();
            radioButtonCat = new RadioButton();
            radioButtonDog = new RadioButton();
            labelName = new Label();
            textBoxName = new TextBox();
            labelInfoName = new Label();
            labelInfoFavToy = new Label();
            textBoxFavToy = new TextBox();
            labelFavToy = new Label();
            labelInfoImage = new Label();
            textBoxImage = new TextBox();
            labelImage = new Label();
            pictureBox1 = new PictureBox();
            labelInfoBreed = new Label();
            textBoxBreed = new TextBox();
            labelBreed = new Label();
            labelInfoMedicalHistory = new Label();
            textBoxMedicalHistory = new TextBox();
            labelMedicalHistory = new Label();
            labelInfoWeight = new Label();
            textBoxWeight = new TextBox();
            labelWeight = new Label();
            labelInfoColor = new Label();
            textBoxColor = new TextBox();
            labelColor = new Label();
            label2 = new Label();
            dateTimePickerBirthDay = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAdd.Location = new Point(768, 522);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(178, 53);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add New Pet";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.FlatStyle = FlatStyle.System;
            labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(2, 14);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(963, 86);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "New Pet";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            labelTitle.Click += labelTitle_Click;
            // 
            // radioButtonCat
            // 
            radioButtonCat.AutoSize = true;
            radioButtonCat.Checked = true;
            radioButtonCat.Location = new Point(94, 94);
            radioButtonCat.Name = "radioButtonCat";
            radioButtonCat.Size = new Size(63, 29);
            radioButtonCat.TabIndex = 5;
            radioButtonCat.TabStop = true;
            radioButtonCat.Text = "Cat";
            radioButtonCat.UseVisualStyleBackColor = true;
            radioButtonCat.CheckedChanged += radioButtonCat_CheckedChanged;
            // 
            // radioButtonDog
            // 
            radioButtonDog.AutoSize = true;
            radioButtonDog.Location = new Point(94, 129);
            radioButtonDog.Name = "radioButtonDog";
            radioButtonDog.Size = new Size(72, 29);
            radioButtonDog.TabIndex = 6;
            radioButtonDog.TabStop = true;
            radioButtonDog.Text = "Dog";
            radioButtonDog.UseVisualStyleBackColor = true;
            radioButtonDog.CheckedChanged += radioButtonDog_CheckedChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(84, 198);
            labelName.Name = "labelName";
            labelName.Size = new Size(63, 25);
            labelName.TabIndex = 7;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(153, 198);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(324, 31);
            textBoxName.TabIndex = 8;
            // 
            // labelInfoName
            // 
            labelInfoName.AutoSize = true;
            labelInfoName.Location = new Point(153, 232);
            labelInfoName.Name = "labelInfoName";
            labelInfoName.Size = new Size(141, 25);
            labelInfoName.TabIndex = 9;
            labelInfoName.Text = "Name validation";
            labelInfoName.Visible = false;
            // 
            // labelInfoFavToy
            // 
            labelInfoFavToy.AutoSize = true;
            labelInfoFavToy.Location = new Point(601, 458);
            labelInfoFavToy.Name = "labelInfoFavToy";
            labelInfoFavToy.Size = new Size(105, 25);
            labelInfoFavToy.TabIndex = 12;
            labelInfoFavToy.Text = "Favorite toy";
            labelInfoFavToy.Visible = false;
            // 
            // textBoxFavToy
            // 
            textBoxFavToy.Location = new Point(601, 424);
            textBoxFavToy.Name = "textBoxFavToy";
            textBoxFavToy.Size = new Size(324, 31);
            textBoxFavToy.TabIndex = 11;
            // 
            // labelFavToy
            // 
            labelFavToy.AutoSize = true;
            labelFavToy.Location = new Point(532, 424);
            labelFavToy.Name = "labelFavToy";
            labelFavToy.Size = new Size(74, 25);
            labelFavToy.TabIndex = 10;
            labelFavToy.Text = "Fav Toy:";
            // 
            // labelInfoImage
            // 
            labelInfoImage.AutoSize = true;
            labelInfoImage.Location = new Point(601, 226);
            labelInfoImage.Name = "labelInfoImage";
            labelInfoImage.Size = new Size(141, 25);
            labelInfoImage.TabIndex = 15;
            labelInfoImage.Text = "Name validation";
            labelInfoImage.Visible = false;
            // 
            // textBoxImage
            // 
            textBoxImage.Location = new Point(601, 192);
            textBoxImage.Name = "textBoxImage";
            textBoxImage.Size = new Size(324, 31);
            textBoxImage.TabIndex = 14;
            textBoxImage.TextChanged += textBoxImage_TextChanged;
            textBoxImage.MouseDown += textBoxImage_MouseDown;
            // 
            // labelImage
            // 
            labelImage.AutoSize = true;
            labelImage.Location = new Point(532, 192);
            labelImage.Name = "labelImage";
            labelImage.Size = new Size(66, 25);
            labelImage.TabIndex = 13;
            labelImage.Text = "Image:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(744, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // labelInfoBreed
            // 
            labelInfoBreed.AutoSize = true;
            labelInfoBreed.Location = new Point(153, 311);
            labelInfoBreed.Name = "labelInfoBreed";
            labelInfoBreed.Size = new Size(141, 25);
            labelInfoBreed.TabIndex = 19;
            labelInfoBreed.Text = "Name validation";
            labelInfoBreed.Visible = false;
            // 
            // textBoxBreed
            // 
            textBoxBreed.Location = new Point(153, 277);
            textBoxBreed.Name = "textBoxBreed";
            textBoxBreed.Size = new Size(324, 31);
            textBoxBreed.TabIndex = 18;
            // 
            // labelBreed
            // 
            labelBreed.AutoSize = true;
            labelBreed.Location = new Point(84, 277);
            labelBreed.Name = "labelBreed";
            labelBreed.Size = new Size(61, 25);
            labelBreed.TabIndex = 17;
            labelBreed.Text = "Breed:";
            // 
            // labelInfoMedicalHistory
            // 
            labelInfoMedicalHistory.AutoSize = true;
            labelInfoMedicalHistory.Location = new Point(153, 391);
            labelInfoMedicalHistory.Name = "labelInfoMedicalHistory";
            labelInfoMedicalHistory.Size = new Size(141, 25);
            labelInfoMedicalHistory.TabIndex = 22;
            labelInfoMedicalHistory.Text = "Name validation";
            labelInfoMedicalHistory.Visible = false;
            // 
            // textBoxMedicalHistory
            // 
            textBoxMedicalHistory.Location = new Point(153, 357);
            textBoxMedicalHistory.Name = "textBoxMedicalHistory";
            textBoxMedicalHistory.Size = new Size(324, 31);
            textBoxMedicalHistory.TabIndex = 21;
            // 
            // labelMedicalHistory
            // 
            labelMedicalHistory.AutoSize = true;
            labelMedicalHistory.Location = new Point(84, 357);
            labelMedicalHistory.Name = "labelMedicalHistory";
            labelMedicalHistory.Size = new Size(61, 25);
            labelMedicalHistory.TabIndex = 20;
            labelMedicalHistory.Text = "Breed:";
            // 
            // labelInfoWeight
            // 
            labelInfoWeight.AutoSize = true;
            labelInfoWeight.Location = new Point(153, 458);
            labelInfoWeight.Name = "labelInfoWeight";
            labelInfoWeight.Size = new Size(141, 25);
            labelInfoWeight.TabIndex = 25;
            labelInfoWeight.Text = "Name validation";
            labelInfoWeight.Visible = false;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(153, 424);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(324, 31);
            textBoxWeight.TabIndex = 24;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(84, 424);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(68, 25);
            labelWeight.TabIndex = 23;
            labelWeight.Text = "Weight";
            // 
            // labelInfoColor
            // 
            labelInfoColor.AutoSize = true;
            labelInfoColor.Location = new Point(601, 305);
            labelInfoColor.Name = "labelInfoColor";
            labelInfoColor.Size = new Size(141, 25);
            labelInfoColor.TabIndex = 28;
            labelInfoColor.Text = "Name validation";
            labelInfoColor.Visible = false;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(601, 271);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(324, 31);
            textBoxColor.TabIndex = 27;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(532, 271);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(59, 25);
            labelColor.TabIndex = 26;
            labelColor.Text = "Color:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(517, 356);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 29;
            label2.Text = "Birthday:";
            // 
            // dateTimePickerBirthDay
            // 
            dateTimePickerBirthDay.Location = new Point(601, 351);
            dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            dateTimePickerBirthDay.Size = new Size(324, 31);
            dateTimePickerBirthDay.TabIndex = 32;
            // 
            // NewPetForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 589);
            Controls.Add(dateTimePickerBirthDay);
            Controls.Add(label2);
            Controls.Add(labelInfoColor);
            Controls.Add(textBoxColor);
            Controls.Add(labelColor);
            Controls.Add(labelInfoWeight);
            Controls.Add(textBoxWeight);
            Controls.Add(labelWeight);
            Controls.Add(labelInfoMedicalHistory);
            Controls.Add(textBoxMedicalHistory);
            Controls.Add(labelMedicalHistory);
            Controls.Add(labelInfoBreed);
            Controls.Add(textBoxBreed);
            Controls.Add(labelBreed);
            Controls.Add(pictureBox1);
            Controls.Add(labelInfoImage);
            Controls.Add(textBoxImage);
            Controls.Add(labelImage);
            Controls.Add(labelInfoFavToy);
            Controls.Add(textBoxFavToy);
            Controls.Add(labelFavToy);
            Controls.Add(labelInfoName);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(radioButtonDog);
            Controls.Add(radioButtonCat);
            Controls.Add(buttonAdd);
            Controls.Add(labelTitle);
            Name = "NewPetForm";
            Text = "New Pet";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Label labelTitle;
        private RadioButton radioButtonCat;
        private RadioButton radioButtonDog;
        private Label labelName;
        private Label labelInfoName;
        public TextBox textBoxName;
        private Label labelInfoFavToy;
        public TextBox textBoxFavToy;
        private Label labelFavToy;
        private Label labelInfoImage;
        public TextBox textBoxImage;
        private Label labelImage;
        private PictureBox pictureBox1;
        private Label labelInfoBreed;
        public TextBox textBoxBreed;
        private Label labelBreed;
        private Label labelInfoMedicalHistory;
        public TextBox textBoxMedicalHistory;
        private Label labelMedicalHistory;
        private Label labelInfoWeight;
        public TextBox textBoxWeight;
        private Label labelWeight;
        private Label labelInfoColor;
        public TextBox textBoxColor;
        private Label labelColor;
        private Label label2;
        private DateTimePicker dateTimePickerBirthDay;
    }
}