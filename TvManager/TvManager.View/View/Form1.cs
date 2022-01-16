namespace TvManager.View
{
    using System.Windows.Forms;
    using TvManager.View.Interfaces;

    public partial class Form1 : Form
    {
        private IShowService showService;
        private IAdService adService;
        public Form1(IShowService showService, IAdService adService)
        {
            this.showService = showService;
            this.adService = adService;
            InitializeComponent();
        }
    }
}