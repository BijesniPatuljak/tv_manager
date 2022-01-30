using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvManager.View.View
{
    using System.Windows.Forms;
    using TvManager.View.Interfaces;
    using TvManager.Model.Models;
    public partial class EditAd : Form
    {
        private IShowService showService;
        private IAdService adService;
        public EditAd(IShowService showService, IAdService adService)
        {
            this.showService = showService;
            this.adService = adService;
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked).Text;
            

            Ad ad = new Ad();
            ad.Id = Guid.NewGuid();
            ad.Name = textBox1.Text;
            ad.Priority = Int32.Parse(checkedButton);
            ad.Duration = TimeSpan.Parse(textBox2.Text);
            ad.StartTime = TimeSpan.Parse(ad_start.Text);
            ad.Cost = decimal.Parse(textBox3.Text);

            adService.SaveAd(ad);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditAd_Load(object sender, EventArgs e)
        {

        }

        private void ad_start_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
