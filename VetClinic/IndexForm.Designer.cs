namespace VetClinic
{
    partial class IndexForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            labelTitle = new Label();
            listViewPets = new ListView();
            imageListPets = new ImageList(components);
            buttonAddNewPet = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.FlatStyle = FlatStyle.System;
            labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(12, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(955, 86);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Vet Clinic";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listViewPets
            // 
            listViewPets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewPets.LargeImageList = imageListPets;
            listViewPets.Location = new Point(24, 92);
            listViewPets.Name = "listViewPets";
            listViewPets.Size = new Size(924, 379);
            listViewPets.SmallImageList = imageListPets;
            listViewPets.TabIndex = 1;
            listViewPets.UseCompatibleStateImageBehavior = false;
            listViewPets.SelectedIndexChanged += listViewPets_SelectedIndexChanged;
            listViewPets.MouseClick += listViewPets_MouseClick;
            // 
            // imageListPets
            // 
            imageListPets.ColorDepth = ColorDepth.Depth32Bit;
            imageListPets.ImageStream = (ImageListStreamer)resources.GetObject("imageListPets.ImageStream");
            imageListPets.TransparentColor = Color.Transparent;
            imageListPets.Images.SetKeyName(0, "icons8-dog-64.png");
            imageListPets.Images.SetKeyName(1, "icons8-cat-64.png");
            // 
            // buttonAddNewPet
            // 
            buttonAddNewPet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAddNewPet.Location = new Point(770, 506);
            buttonAddNewPet.Name = "buttonAddNewPet";
            buttonAddNewPet.Size = new Size(178, 53);
            buttonAddNewPet.TabIndex = 2;
            buttonAddNewPet.Text = "Add New Pet";
            buttonAddNewPet.UseVisualStyleBackColor = true;
            buttonAddNewPet.Click += buttonAddNewPet_Click;
            // 
            // IndexForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 584);
            Controls.Add(buttonAddNewPet);
            Controls.Add(listViewPets);
            Controls.Add(labelTitle);
            Name = "IndexForm";
            Text = "Vet Clinic";
            Load += IndexForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private ListView listViewPets;
        private Button buttonAddNewPet;
        private ImageList imageListPets;
    }
}
