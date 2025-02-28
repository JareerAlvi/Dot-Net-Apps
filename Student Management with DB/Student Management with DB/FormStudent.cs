using System.Linq;
using System.Windows.Forms;

namespace Student_Management_with_DB
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();

            SchoolEntities schoolEntities = new SchoolEntities();
            //grdStudents.DataSource = schoolEntities.tbStudents.ToList();

            grdStudents.DataSource = schoolEntities.tbStudents
                .Where(x => x.Email.Contains("fa"))
                .OrderBy(x => x.Grade)
                .ToList();

            //var student = schoolEntities.tbStudents
            //    .Where(x => x.StudentID == 1)
            //    .First();

            var user = new tbUser() { UserName = "test1", Password = "test1" };

            schoolEntities.tbUsers.Add(user);
            schoolEntities.SaveChanges();

            int count = schoolEntities.tbStudents
                .Where(x => x.FirstName.Contains(""))
                .Count();
        }
    }
}
