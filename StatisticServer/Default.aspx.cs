using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StatisticServer
{
    public partial class Default : System.Web.UI.Page
    {

        SQLConnectTableAdapters.TbalsTableAdapter sqlTeacherBalls;
        SQLConnectTableAdapters.TeacherTableAdapter sqlTeacher;
        SQLConnectTableAdapters.SbalsTableAdapter sqlStudentBalls;
        SQLConnectTableAdapters.StudentTableAdapter sqlStudent;
        SQLConnectTableAdapters.GbalsTableAdapter sqlGroupBalls;
        SQLConnectTableAdapters.GroupTableAdapter sqlGroup;
        protected void Page_Load(object sender, EventArgs e)
        {

            sqlTeacher = new SQLConnectTableAdapters.TeacherTableAdapter();
            sqlTeacherBalls = new SQLConnectTableAdapters.TbalsTableAdapter();
            sqlStudent = new SQLConnectTableAdapters.StudentTableAdapter();
            sqlStudentBalls = new SQLConnectTableAdapters.SbalsTableAdapter();
            sqlGroup = new SQLConnectTableAdapters.GroupTableAdapter();
            sqlGroupBalls = new SQLConnectTableAdapters.GbalsTableAdapter();
            var q = sqlTeacher.GetData();
            for (int i = 0; i < q.Rows.Count; i++)
            {
                TableRow tr = new TableRow();
                TableCell tr1 = new TableCell();
                tr1.Text = (string)q.Rows[i].ItemArray[1];
                tr.Cells.Add(tr1);
                tr1 = new TableCell();
                try
                {
                    tr1.Text = ((int)sqlTeacherBalls.SelectBallsT((int)q.Rows[i].ItemArray[0])).ToString();
                }
                catch
                {
                    tr1.Text = "Отсутствует";
                }
                tr.Cells.Add(tr1);
                TeacherList.Rows.Add(tr);
                //
            }
            var q2 = sqlGroup.GetData();
            for (int i = 0; i < q2.Rows.Count; i++)
            {
                TableRow tr = new TableRow();
                TableCell tr1 = new TableCell();
                tr1.Text = (string)q2.Rows[i].ItemArray[1];
                tr.Cells.Add(tr1);
                tr1 = new TableCell();
                try
                {
                tr1.Text = ((int)sqlGroupBalls.SelectBallsG((int)q2.Rows[i].ItemArray[0])).ToString();
                }
                catch
                {
                    tr1.Text = "Отсутствует";
                }
                tr.Cells.Add(tr1);
                GroupList.Rows.Add(tr);
                //
            }
            var q3 = sqlStudent.GetData();
            for (int i = 0; i < q3.Rows.Count; i++)
            {
                TableRow tr = new TableRow();
                TableCell tr1 = new TableCell();
                tr1.Text = (string)q3.Rows[i].ItemArray[1];
                tr.Cells.Add(tr1);
                tr1 = new TableCell();
                 try
                {
                tr1.Text = ((int)sqlStudentBalls.SelectBallsS((int)q3.Rows[i].ItemArray[0])).ToString();
                }
                 catch
                 {
                     tr1.Text = "Отсутствует";
                 }
                tr.Cells.Add(tr1);

                tr1 = new TableCell();
                tr1.Text = ((int)sqlStudentBalls.ProgulSum((int)q3.Rows[i].ItemArray[0])).ToString();
               
                tr.Cells.Add(tr1);

                StudentList.Rows.Add(tr);
                //
            }
        }

        protected void TeacherList_Load(object sender, EventArgs e)
        
        {
         
        }
    }
}