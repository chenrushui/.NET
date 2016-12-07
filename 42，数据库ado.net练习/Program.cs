using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_数据库ado.net练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //对数据库的常见操作:SqlConnection SqlCommand   常用的类以及曾经错过的知识点，一定要记到脑子里面、
            //SqlConnection   //SqlCommand  SqlDataReader 类  这三个类的使用，一定要记住。现在就是最好的时候。
            //conn.Open() 打开连接
            //SqlDataReader  数据读取器,自己在脑海中想想一遍就好了,不是吗?
            //有些技能需要刻意去练习，不是吗? 
            //命名规范 首字母要大些，还有数据库的很多知识都忘记了


            QueryTeacherData();
            //QueryTeacherData0();
            //QueryTeacherData01();
            //QyeryTeacherData2();
            Console.ReadKey();

        }

        private static void QueryTeacherData01()
        {
            string strConn = @"Data source=172.16.20.1\dev;initial catalog=MyFirstData;user id=gungnirreader;password=itsme999";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string sql = "select * from Teacher";
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    //comm.ExecuteScalar();
                    //comm.ExecuteNonQuery();
                    conn.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    //每次读取一行
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string st = reader.GetString(1);
                            Console.WriteLine(st);
                        }

                    }
                }
            }
        }

        private static void QyeryTeacherData2()
        {
            string connStr = @"data source=172.16.20.1\dev;initial catalog=MyFirstData;user id =gungnirreader;password=itsme999";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "Select * from Teacher";
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(1);
                            Console.WriteLine(name);

                        }

                    }

                }
            }



        }

        private static void QueryTeacherData0()
        {
            //ado.net操作数据库
            string connStr = @"data source=172.16.20.1\dev;initial catalog=MyFirstData;user id= gungnirreader;password=itsme999";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                //要执行的sql语句
                string sql = "select * from Teacher";
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    //如果有下一行数据
                    if (reader.HasRows)
                    {
                        //如果能够读取到数据
                        while (reader.Read())
                        {
                            string name = reader.GetString(1);
                            Console.WriteLine(name);
                        }
                    }
                }
            }
        }

        private static void QueryTeacherData()
        {
            string connStr = @"Data source=172.16.20.1\dev;initial catalog=MyFirstData;user id=gungnirreader;password=itsme999";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "select * from Teacher";
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    //SqlDataReader类的使用
                    //打开连接。要执行的sql语句和连接对象。创建连接的时候需要连接字符串。记住连接字符串里面的内容(数据源，初始化策略，用户名和密码) 四个参数,使用分号进行分割
                    conn.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(1);
                            Console.WriteLine(name);
                        }
                    }
                }
            }
        }
    }
}
