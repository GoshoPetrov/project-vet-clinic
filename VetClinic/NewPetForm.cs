using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinic
{
    public partial class NewPetForm : Form
    {
        private string petImage;

        internal IAnimal Animal { get; set; }

        public NewPetForm()
        {
            InitializeComponent();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckIfInputsAreValid())
            {
                return;
            }

            var animal = CreateNewAnimal();
            if (animal != null)
            {
                this.Animal = animal;
                this.DialogResult = DialogResult.OK;
            }

        }

        private IAnimal CreateNewAnimal()
        {
            IAnimal result = null;

            double weight = 0.0;
            double.TryParse(textBoxWeight.Text, out weight);
            if (this.radioButtonCat.Checked)
            {
                result = new Cat(this.textBoxName.Text, dateTimePickerBirthDay.Value, 
                    textBoxBreed.Text, textBoxMedicalHistory.Text, weight, textBoxColor.Text, textBoxFavToy.Text);
            }
            else
            {
                result = new Dog(this.textBoxName.Text, dateTimePickerBirthDay.Value, 
                    textBoxBreed.Text, textBoxMedicalHistory.Text, weight, textBoxColor.Text);
            }

            result.Image = this.petImage;

            return result;
        }

        private bool CheckIfInputsAreValid()
            => CheckIfNotEmpty(textBoxName, labelInfoName)
            && CheckIfValid(textBoxName, 3, labelInfoName)
            && CheckIfNotEmpty(textBoxBreed, labelInfoBreed)
            && CheckIfNotEmpty(textBoxColor, labelInfoColor)
            && CheckIfNotEmpty(textBoxMedicalHistory, labelInfoMedicalHistory)
            && CheckIfValidDouble(textBoxWeight, 1, labelInfoWeight)
            ;

        private static bool CheckIfValid(TextBox textBox, int minLength, Label errorLabel)
        {
            bool isValid = textBox.Text.Trim().Length >= minLength;
            errorLabel.Text = $"Should be at least {minLength} characters.";
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }
        private static bool CheckIfNotEmpty(TextBox textBox, Label errorLabel)
        {
            bool isValid = !string.IsNullOrWhiteSpace(textBox.Text);
            errorLabel.Text = $"Should not be empty";
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static bool CheckIfValidDouble(TextBox textBox, double min, Label errorLabel)
        {
            bool isValid = double.TryParse(textBox.Text.Trim(), out double parsedValue)
                && parsedValue > min;
            errorLabel.Text = $"Should be greater than {min:F02}";
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static void ShowValidationError(Label errorLabel, bool isValid)
        {
            errorLabel.Visible = !isValid;
        }

        private void radioButtonCat_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFavToy(true);
        }

        private void radioButtonDog_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFavToy(false);
        }

        private void UpdateFavToy(bool cat)
        {
            labelFavToy.Visible = cat;
            textBoxFavToy.Visible = cat;
            labelInfoFavToy.Visible = false;
        }

        private void textBoxImage_MouseDown(object sender, MouseEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.petImage = openFileDialog.FileName;
                this.textBoxImage.Text = Path.GetFileName(openFileDialog.FileName);
                try
                {
                    this.pictureBox1.Load(this.petImage);
                }
                catch
                {
                    // not an image...
                }
            }
        }

        private void textBoxImage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}