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


    public partial class EditShow : Form
    {
        private IShowService showService;
        private IAdService adService;

        private Show currentShow;

        public EditShow(IShowService showService, IAdService adService, Show show = null )
        {
            this.showService = showService;
            this.adService = adService;
            InitializeComponent();

            currentShow = new Show();

            if ( show != null)
            {
                FillForm(show);
            }
        }
        private void FillForm(Show show)
        {
            textBox_name.Text = show.Name.ToString();
            textBox_timeslot.Text = show.PreferredTimeSlot.ToString();
            textBox_id.Text = show.Id.ToString();

            Controls.OfType<RadioButton>().FirstOrDefault(b => b.Name == "radioButton" + (10 - show.Priority)).Checked = true;




        }
        private void EditShow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            currentShow.Id = Guid.Parse(textBox_id.Text);
            currentShow.PreferredTimeSlot = TimeSpan.Parse(textBox_timeslot.Text);
            currentShow.Name = textBox_name.Text;

            var checkedButton = priorities.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked).Text;

            currentShow.Priority = Int32.Parse(checkedButton.ToString());




            showService.SaveShow(currentShow);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_id.Text = Guid.NewGuid().ToString();
        }
    }
}
