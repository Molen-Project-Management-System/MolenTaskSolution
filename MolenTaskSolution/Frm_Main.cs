
using System.Data.SqlClient;

namespace MolenTaskSolution
{
    public partial class Frm_Main : Form
    {
        
        

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            page_UsersFrmMain.BringToFront();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            page_TaskFrmMain.BringToFront();

        }

        private void page_UsersFrmMain_Load(object sender, EventArgs e)
        {
            
            


        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }
    }
}