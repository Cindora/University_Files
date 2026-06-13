using System.Windows.Forms;

namespace SportRentalApp
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        // Свойства для доступа к данным из главной формы
        public string LastName => txtLastName.Text.Trim();
        public string FirstName => txtFirstName.Text.Trim();
        public string MiddleName => string.IsNullOrWhiteSpace(txtMiddleName.Text) ? null : txtMiddleName.Text.Trim();
        public string Phone => txtPhone.Text.Trim();
        public string Passport => txtPassport.Text.Trim();

        // Валидация перед закрытием с результатом OK
        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LastName) ||
                string.IsNullOrWhiteSpace(FirstName) ||
                string.IsNullOrWhiteSpace(Phone) ||
                string.IsNullOrWhiteSpace(Passport))
            {
                MessageBox.Show("Заполните все обязательные поля (Фамилия, Имя, Телефон, Паспорт).",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None; // не закрывать форму
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}