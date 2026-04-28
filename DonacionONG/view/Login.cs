using DonacionONG.model;
using DonacionONG.view;

namespace DonacionONG
{
    public partial class Login : Form
    {
        private List<Usuario> listaUsuarios;

        public Login()
        {
            InitializeComponent();
            precargarUsuarios();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsername.Text;
            string pass = txtPass.Text;

            foreach (Usuario u in listaUsuarios)
            {
                if (u.NombreUsuario.Equals(usuario) && u.Password.Equals(pass))
                {
                    Dashboard ds = new Dashboard();
                    ds.Show();
                    this.Hide();
                }
            }
        }


        private void precargarUsuarios()
        {
            listaUsuarios = new List<Usuario>();
            Usuario u1 = new Usuario(1, "Barbara", "123");
            Usuario u2 = new Usuario(2, "Vicente", "123");

            listaUsuarios.Add(u1);
            listaUsuarios.Add(u2);
        }
    }
}
