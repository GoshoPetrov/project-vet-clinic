namespace VetClinic
{
    public partial class IndexForm : Form
    {

        List<IAnimal> animals = new()
        {
            new Cat("Fluffy", new DateTime(2018, 5, 16), "Persian", "Regular chekups", 4.5, "Golden", "Feather wand"),
            new Dog("Buddy", new DateTime(2018, 5, 16), "Golden retriever", "Vaccinated", 4.5, "Golden"),
            new Cat("Katy", new DateTime(2018, 5, 16), "Persian", "Regular chekups", 4.5, "Golden", "Feather wand"),
        };

        public IndexForm()
        {
            InitializeComponent();
        }

        private void buttonAddNewPet_Click(object sender, EventArgs e)
        {
            var newPetForm = new NewPetForm();
            var result = newPetForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.animals.Add(newPetForm.Animal);
            }

            LoadAllPets();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            LoadAllPets();
        }

        private void LoadAllPets()
        {
            this.listViewPets.Clear();
            foreach (var pet in this.animals)
            {
                this.listViewPets.Items.Add(
                    pet.Name,
                    pet.GetType() == typeof(Cat) ? 1 : 0);
            }
        }

        private void listViewPets_MouseClick(object sender, MouseEventArgs e)
        {
            IAnimal selected = this.animals[this.listViewPets.SelectedItems[0].Index];

            if (selected == null) return;

            var detailsForm = new PetDetailsForm();
            detailsForm.InitPet(selected);
            detailsForm.ShowDialog();
        }

        private void listViewPets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
