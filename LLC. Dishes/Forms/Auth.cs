using LLC._Dishes.Forms;
using Microsoft.VisualBasic.Logging;
using System.Runtime;

namespace LLC._Dishes
{
    public partial class Auth : Form
    {
        public static User profile { get; set; }

        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new LLCDishesContext())
            {
                var login = loginTextBox.Text;
                var password = passwordTextBox.Text;

                var currentUser = db.Users.FirstOrDefault(x => x.Login == login && x.Password == password);

                if (currentUser.Login == login && currentUser.Password == password)
                {
                    var productsForm = new ProductsForm();
                    productsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Неверный пароль или логин");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new LLCDishesContext())
            {
                var currentUser = db.Users.FirstOrDefault(x => x.RoleId == 4);
            }
            var productsForm = new ProductsForm();
            productsForm.ShowDialog();
        }
    }
}