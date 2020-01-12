namespace HMatuszewski.PhotoAlbum
{
    using System;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Text;
    using System.Windows.Forms;

    public partial class LoginPage : Form
    {
        public static int LoggedUser = -1;

        public LoginPage()
        {
            InitializeComponent();
        }


        private void Login(object sender, EventArgs e)
        {


            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HMatuszewski.PhotoAlbum.Properties.Settings.BDFotoConnectionString"].ConnectionString))
            {
                var sb = new StringBuilder();
                sb.Append("SELECT ID ");
                sb.Append("FROM [dbo].[Users]");
                sb.Append("WHERE Login = '" + LoginTextBox.Text + "' AND Password = '" + PassTextBox.Text + "'");


                var sql = sb.ToString();

                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            LoggedUser = (int) reader.GetValue(0);
                            Console.WriteLine("Logged as User:" + LoggedUser);
                            var mainMenu = new MainMenu();
                            mainMenu.Show();
                                Hide();
                        }
                    }
                }
            }
        }
    }
}