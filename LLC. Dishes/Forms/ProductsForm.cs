using Microsoft.EntityFrameworkCore;
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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();

            sortComboBox.DisplayMember = nameof(Manufacturer.NameManufacturer);
            sortComboBox.ValueMember= nameof(Manufacturer.IdManufacturer);
        }


        private void DishView_ImageChanged(object sender, (Dish, byte[]) e) 
        {
            using (var db = new LLCDishesContext())
            {
                db.Entry(e.Item1).State = EntityState.Modified;
                e.Item1.Image = e.Item2;
                db.SaveChanges();
            }
        }

        private void Sort()
        {
            if (sortComboBox.SelectedItem == null) return;

            var selectedSort = ((Manufacturer)sortComboBox.SelectedItem).IdManufacturer;

            foreach (var item in flowLayoutPanel1.Controls) 
            {
                var visible = true;
                if (item is DishView dishView)
                {
                    if (selectedSort != 100000 && !(dishView.Dish.ManufacturerId == selectedSort))
                    {
                        visible = false;
                    }

                    if (isActualCheckBox.Checked && !(dishView.Dish.Amount > 0))
                    {
                        visible = false;
                    }

                    if (!(string.IsNullOrEmpty(searchTextBox.Text) || dishView.Dish.DishName.Contains(searchTextBox.Text)))
                    {
                        visible = false;
                    }

                    dishView.Visible = visible;
                } 
            }

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            using (var db = new LLCDishesContext())
            {
                var dishes = db.Dishes.Include(nameof(Manufacturer)).ToList();

                var hehe = db.Manufacturers.OrderBy(x => x.NameManufacturer);

                sortComboBox.Items.Clear();
                sortComboBox.Items.AddRange(hehe.ToArray());
                sortComboBox.Items.Insert(0, new Manufacturer()
                {
                    IdManufacturer = 100000,
                    NameManufacturer = "Все производители"
                });

                foreach (var dish in dishes)
                {
                    var dishView = new DishView(dish);

                    dishView.Parent = flowLayoutPanel1;

                    dishView.ImageChanged += DishView_ImageChanged;
                }
            }
        }

        private void isActualCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void sortComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Sort();
        }
    }
}
