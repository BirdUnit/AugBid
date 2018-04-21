using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AugBid_
{
    class Item
    {
        private float price;
        private string name;
        private string description;
        private int id;
        private string user;
        private PictureBox image;

        public Item(float price, string name, string description, int id, string user, PictureBox image)
        {
            this.price = price;
            this.name = name;
            this.description = description;
            this.id = id;
            this.user = user;
            this.image = image;
        }

        public void setPrice(float price, string user)
        {
            this.price = price;
            this.user = user;
        }

    }
}
