using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLC._Dishes.Forms
{
    public partial class DishView : UserControl
    {
        private readonly Dish dishView;
        private EventHandler<(Dish, byte[])> onImageChanged;

        public DishView(Dish dish)
        {
            InitializeComponent();
            this.dishView = dish;
            InitView(dish);
        }

        public Dish Dish => dishView;

        public void InitView(Dish dish)
        {
            using (var db = new LLCDishesContext())
            {
                nameLabel.Text = dish.DishName;
                descLabel.Text = dish.Description;
                supplierLabel.Text = dish.Description;
                costLabel.Text = dish.Cost.ToString();
                if (dish.Image != null)
                {
                    pictureBox1.Image = Image.FromStream(new MemoryStream(dish.Image));
                }

                if (dish.Amount > 0)
                {
                    isActualLabel.Text = "В наличии";
                    isActualLabel.ForeColor = Color.Green;
                }
                else
                {
                    isActualLabel.Text = "Нет в наличии";
                    isActualLabel.ForeColor = Color.Red;
                }
            }
        }

        public event EventHandler<(Dish, byte[])> ImageChanged
        {
            add
            {
                onImageChanged += value;
            }
            remove
            {
                onImageChanged -= value;
            }

        }

        private void imageAddButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            var image = File.ReadAllBytes(openFileDialog1.FileName);
            onImageChanged?.Invoke(this, (dishView, image));
            pictureBox1.Image = Image.FromStream(new MemoryStream(image));

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
