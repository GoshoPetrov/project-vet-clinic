using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinic
{
    public partial class PetDetailsForm : Form
    {
        private IAnimal pet;

        public PetDetailsForm()
        {
            InitializeComponent();
        }

        internal void InitPet(IAnimal selected)
        {
            this.pet = selected;

            try
            {
                if (!string.IsNullOrEmpty(this.pet.Image))
                {
                    pictureBoxImage.Load(this.pet.Image);
                }
            }
            catch { }

            this.labelPetName.Text = selected.Name;
            this.textBoxType.Text = this.pet.GetType() == typeof(Cat) ? "Cat" : "Dog";

            this.textBoxBreed.Text = this.pet.Breed;
            this.textBoxStatus.Text = this.pet.Status.ToString();
            this.textBoxMedicalHistory.Text = this.pet.MedicalHistory;
            this.textBoxWeigth.Text = $"{this.pet.Weight:F02}";
            this.textBoxColor.Text = this.pet.Color;

            Cat cat = this.pet as Cat;
            if (cat != null)
            {
                this.textBoxToy.Text = cat.FavoriteToy;
            }

            this.buttonAdopt.Enabled = this.pet.Status == Status.NotAdopted;
        }

        private void buttonAdopt_Click(object sender, EventArgs e)
        {
            this.pet.Status = Status.Adopted;
            this.DialogResult = DialogResult.OK;
        }
    }
}
