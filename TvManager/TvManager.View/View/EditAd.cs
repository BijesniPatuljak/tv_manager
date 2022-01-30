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
        private int index;

        private Ad old_ad;

        private List<RadioButton> radioButtons= new List<RadioButton>();

        public EditAd(IShowService showService, IAdService adService,int index = -1)
        {
            this.index = index;
            this.showService = showService;
            this.adService = adService;
            InitializeComponent();

            radioButtons.Add(radio9);
            radioButtons.Add(radio8);
            radioButtons.Add(radio7);
            radioButtons.Add(radio6);
            radioButtons.Add(radio5);
            radioButtons.Add(radio4);
            radioButtons.Add(radio3);

            textBox4.ReadOnly = true;



            


            if (index != -1)
            {
                old_ad = adService.GetAds().ToList()[index];

                textBox4.Text = old_ad.Id.ToString();
                textBox1.Text = old_ad.Name.ToString();
                textBox2.Text = old_ad.Duration.ToString();
                ad_start.Text = old_ad.StartTime.ToString();
                textBox3.Text = old_ad.Cost.ToString();

                radioButtons[9- old_ad.Priority].Checked = true;
               
            }
            else
            {
                textBox4.Text = Guid.NewGuid().ToString();
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked).Text;
            

            Ad ad = new Ad();
            ad.Id = Guid.Parse(textBox4.Text);
            ad.Name = textBox1.Text;
            ad.Priority = Int32.Parse(checkedButton);
            ad.Duration = TimeSpan.Parse(textBox2.Text);
            ad.StartTime = TimeSpan.Parse(ad_start.Text);
            ad.Cost = decimal.Parse(textBox3.Text);


            if (index == -1)
            {
                adService.SaveAd(ad);
            }
            else
            {
                adService.UpdateAd(old_ad, ad);
            }

            Close();
            

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
