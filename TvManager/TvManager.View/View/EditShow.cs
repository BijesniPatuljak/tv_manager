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
        private int index;
        private Show old_show;

        private List<RadioButton> radioButtons = new List<RadioButton>();


        public EditShow(IShowService showService, IAdService adService, int index = -1 )
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

            textBox_id.ReadOnly = true;



            if (index != -1)
            {
                old_show = showService.GetAllShows().ToList()[index];

                textBox_id.Text = old_show.Id.ToString();
                textBox_name.Text = old_show.Name.ToString();
                textBox_duration.Text = old_show.Duration.ToString();
                textBox_timeslot.Text = old_show.StartTime.ToString();

                radioButtons[9 - old_show.Priority].Checked = true;

            }
            else
            {
                textBox_id.Text = Guid.NewGuid().ToString();
            }
        }
        private void FillForm(Show show)
        {
            textBox_name.Text = show.Name.ToString();
            textBox_timeslot.Text = show.StartTime.ToString();
            textBox_id.Text = show.Id.ToString();

            Controls.OfType<RadioButton>().FirstOrDefault(b => b.Name == "radioButton" + (10 - show.Priority)).Checked = true;




        }
        private void EditShow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var new_show = new Show();
            new_show.Id = Guid.Parse(textBox_id.Text);
            new_show.StartTime = TimeSpan.Parse(textBox_timeslot.Text);
            new_show.Name = textBox_name.Text;
            new_show.Duration = TimeSpan.Parse(textBox_duration.Text);

            var checkedButton = priorities.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked).Text;

            new_show.Priority = Int32.Parse(checkedButton.ToString());


            if(index == -1)
            {
                showService.SaveShow(new_show);
            }
            else
            {
                showService.UpdateShow(old_show,new_show);
            }

            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_id.Text = Guid.NewGuid().ToString();
        }

        private void textBox_duration_TextChanged(object sender, EventArgs e)
        {

        }

        private void priorities_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
