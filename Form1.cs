using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using экзамен.Context;
using экзамен.Models;
using Microsoft.Extensions.Configuration;

namespace экзамен
{
    public partial class Form1 : Form
    {

        readonly string conn;
        SqlConnection conn_string;
        DataSet set;
        SqlDataAdapter da;
        DbContextOptions<StudentContext> options;
        

        public static object AddParam(string param, SqlCommand c)
        {
            c.Parameters.AddWithValue("@Name", param);
            object Rezult = c.ExecuteScalar();
            return Rezult;
        }
        public void AddColumn()
        {
            dataGridView1.Columns.Add("col1", "Фамилия");
            dataGridView1.Columns.Add("col2", "Группа");
            dataGridView1.Columns.Add("col3", "Оценка ADO.Net");
        }
        public void DeiColumn()
        {
            dataGridView1.Columns.Remove("col1");
            dataGridView1.Columns.Remove("col2");
            dataGridView1.Columns.Remove("col3");
        }
        public void NameColumn(DataSet s)
        {
            s.Tables[0].Columns[0].ColumnName = "Фамилия";
            s.Tables[0].Columns[1].ColumnName = "Группа";
        }

        public Form1()
        {
            InitializeComponent();
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            builder.AttachDBFilename = @"D:\ПВО11\дот нет\экзамен\экзамен\БД\student.mdf";
            builder.IntegratedSecurity = true;
            builder.ConnectTimeout = 30;
            conn = builder.ConnectionString;
            conn_string = new SqlConnection(conn);

             var optionsBuilder = new DbContextOptionsBuilder<StudentContext>();
            options = optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=D:\\ПВО11\\дот нет\\экзамен\\экзамен\\БД\\STUDENT.MDF;Trusted_Connection=True;")
                    .Options;

        }

        private void button1_Online_Click(object sender, EventArgs e)
        {

            panel1_FindGroup.Visible = true;
            panel1_del.Visible = false;
            Panel1_Min.Visible = false;
            Panel1_List.Visible = false;
            dataGridView1.DataSource = null;
            if (dataGridView1.Columns.Count != 0) DeiColumn();

            AddColumn();

            using (var connection = new SqlConnection(conn))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT s.SecondName, g.NameGroup, s.ADONet FROM Students s, GroupStud g WHERE s.GroupId=g.Id; ";

                using (SqlDataReader dtReader = cmd.ExecuteReader())
                {
                    while (dtReader.Read())
                    {
                        dataGridView1.Rows.Add(dtReader["SecondName"], dtReader["NameGroup"],
                                dtReader["ADONet"]);
                    }

                }
            }


        }
        private void button1_AVG_Click(object sender, EventArgs e)
        {
            string Name = textBox1_group.Text;

            using (var connection = new SqlConnection(conn))
            {
                connection.Open();

                var CmdGroup1 = new SqlCommand("Select AVG(ADONet) from Students s, GroupStud g where s.GroupId = g.Id and g.NameGroup=@Name", connection);
                var CmdGroup2 = new SqlCommand("Select count(*) from Students s, GroupStud g where s.GroupId = g.Id and g.NameGroup=@Name", connection);
                object rez1 = AddParam(Name, CmdGroup1);
                object rez2 = AddParam(Name, CmdGroup2);

                if (Convert.ToInt32(rez2) != 0)
                {
                    MessageBox.Show("Средний балл в указанной группе - " + Convert.ToDouble(rez1));
                }
                else MessageBox.Show("Группa не существует!!!!");
            }

        }
        private void button1_Offline_Click(object sender, EventArgs e)
        {
            panel1_FindGroup.Visible = false;
            panel1_del.Visible = true;
            Panel1_Min.Visible = false;
            Panel1_List.Visible = false;
            dataGridView1.DataSource = null;
            if (dataGridView1.Columns.Count != 0) DeiColumn();

            string sql = "select s.SecondName , g.NameGroup from Students s, GroupStud g where s.GroupId = g.Id;";
            da = new SqlDataAdapter(sql, conn);

            set = new DataSet();
            set.Tables["StudRez"]?.Clear();
            da.Fill(set, "StudRez");
            dataGridView1.DataSource = set.Tables["StudRez"];
            NameColumn(set);
        }

        private void button1_DelStud_Click(object sender, EventArgs e)
        {
            int index = int.Parse(textBox1_DelStud.Text) - 1;
            if (index <= set.Tables[0].Rows.Count)
            {
                string FamStudent = (string)set.Tables[0].Rows[index][0];

                conn_string.Open();

                SqlCommand comm = new SqlCommand("DELETE FROM Students WHERE (SecondName=@p1); ", conn_string);
                comm.Parameters.Add("@p1", SqlDbType.NVarChar).Value = FamStudent;

                da.DeleteCommand = comm;

                comm.ExecuteNonQuery();
                conn_string.Close();


                set.Tables["StudRez"]?.Clear();
                da.Fill(set, "StudRezAfterDel");
                dataGridView1.DataSource = set.Tables["StudRezAfterDel"];
                NameColumn(set);
            }
            else MessageBox.Show("Строка не существует!!!");

        }

        private async void button1_Async_Click(object sender, EventArgs e)
        {
            panel1_FindGroup.Visible = false;
            panel1_del.Visible = false;
            Panel1_Min.Visible = false;
            Panel1_List.Visible = false;
            dataGridView1.DataSource = null;
            if (dataGridView1.Columns.Count != 0) DeiColumn();
            AddColumn();

            var connection = new SqlConnection(conn);

            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT s.SecondName, g.NameGroup, s.ADONet FROM Students s, GroupStud g WHERE s.GroupId=g.Id and s.ADONet>7; WAITFOR DELAY '00:00:05'";

            using (var dtReader = await cmd.ExecuteReaderAsync())
            {
                while (dtReader.Read())
                {
                    dataGridView1.Rows.Add(dtReader["SecondName"], dtReader["NameGroup"],
                            dtReader["ADONet"]);
                }

            }
            connection.Close();
        }

        private void button1_Entity_Click(object sender, EventArgs e)
        {
            panel1_FindGroup.Visible = false;
            panel1_del.Visible = false;
            Panel1_Min.Visible = true;
            Panel1_List.Visible = true;
            dataGridView1.DataSource = null;
            if (dataGridView1.Columns.Count != 0) DeiColumn();

           using (var db = new StudentContext(options))
           //using (var db = new StudentContext())
            {
                dataGridView1.DataSource = db.Students.Include(s => s.Group).ToList()
                 .Select(s => new {  Фамилия = s.SecondName, Группа = s.Group.NameGroup, ОценкаADONet = s.Adonet }).ToList();
            }
        }

        private void Button3_All_Click(object sender, EventArgs e)
        {
            Form2 ListOfSrud = new Form2();
            using (var db = new StudentContext(options))
            //using (var db = new StudentContext())
            {
               
                Students[] stud = (from s in db.Students select s).ToArray();

                var b = from st in stud group st by st.Adonet;
                foreach (var gr in b)
                {
                    Form2.r1.Text += gr.Key.ToString() + Environment.NewLine;
                    foreach (var sn in gr)
                    {
                        Form2.r1.Text += sn.SecondName.ToString() + Environment.NewLine;
                    }
                }
               
                Form2.lab1.Text = "Cписoк студентов, сгруппированный их по оценкам";
                ListOfSrud.Show();

            }
        }

        private void Вutton2_7_Click(object sender, EventArgs e)  //(gr => gr.Group)
        {
            Form2 ListOfSrudWithMark = new Form2();
            using (var db = new StudentContext(options))
            //using (var db = new StudentContext())
            {
                //var stud = db.Students.Include(g => g.Group)
                //    .Select(x => new { Фамилия = x.SecondName, Группа = x.Group.NameGroup, Оценка = x.Adonet }).ToArray()
                //    .Where(bl => bl.Оценка > 7).ToArray().OrderBy(bl => bl.Оценка).ToArray();

                // или 2 вариант

                var stud = db.Students.Join(db.GroupStud,
                   s => s.GroupId,
                     g => g.Id,
                   (s, g) => new
                   {
                       Фамилия = s.SecondName,
                       Группа = g.NameGroup,
                       Оценка = s.Adonet
                   }).ToArray()
                             .Where(bl => bl.Оценка > 7).ToArray().OrderBy(bl => bl.Оценка).ToArray();


                var b = from st in stud group st by st.Группа;

                foreach (var gr in b)
                {
                    Form2.r1.Text += gr.Key.ToString() + Environment.NewLine;
                    foreach (var sn in gr)
                    {
                       Form2.r1.Text += sn.ToString() + Environment.NewLine;
                    }
                }
               
              
                Form2.lab1.Text = "Cписок студентов, получивших за экзамен оценку выше 7,"+ Environment.NewLine
                    +"сгруппированный их по группам";
                ListOfSrudWithMark.Show();

            }
        }

        private void Button1_Min_Click(object sender, EventArgs e)
        {
            string Name = textBox1_Min.Text;

            using (var db = new StudentContext(options))
            //using (var db = new StudentContext())
            {
              
                if (db.GroupStud.Any(u=>u.NameGroup==Name)==true)
                {
                    int min = db.Students.Where(u => u.Group.NameGroup == Name).Min(p => p.Adonet);
                    MessageBox.Show("Самый низкий балл за экзамен в указанной группе - " + min);
                }
                else MessageBox.Show("Группa не существует!!!!");

            }
        }
    }

}

