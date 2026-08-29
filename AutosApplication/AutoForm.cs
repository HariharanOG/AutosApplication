using AutosApplication.Data;
using Microsoft.EntityFrameworkCore;

namespace AutosApplication
{
    public partial class AutoForm : Form
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

        public AutoForm(IDbContextFactory<AppDbContext> dbContextFactory)
        {
            InitializeComponent();
            _dbContextFactory = dbContextFactory;
        }
    }
}