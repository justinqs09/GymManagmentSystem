namespace GymManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Configuración del formulario
            this.Text = "Login";
            this.ClientSize = new System.Drawing.Size(400, 300);

            // Controles del formulario
            Label lblUsername = new Label { Text = "Username:", Location = new System.Drawing.Point(50, 50) };
            TextBox txtUsername = new TextBox { Location = new System.Drawing.Point(150, 50), Width = 200 };

            Label lblPassword = new Label { Text = "Password:", Location = new System.Drawing.Point(50, 100) };
            TextBox txtPassword = new TextBox { Location = new System.Drawing.Point(150, 100), Width = 200, UseSystemPasswordChar = true };

            Label lblRole = new Label { Text = "Role:", Location = new System.Drawing.Point(50, 150) };
            ComboBox cbRole = new ComboBox
            {
                Location = new System.Drawing.Point(150, 150),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cbRole.Items.AddRange(new string[] { "Cliente", "Entrenador" });

            Button btnLogin = new Button { Text = "Login", Location = new System.Drawing.Point(150, 200), Width = 80 };
            Label lblMessage = new Label { Location = new System.Drawing.Point(50, 250), Width = 300, ForeColor = System.Drawing.Color.Red };

            // Agregar controles al formulario
            this.Controls.Add(lblUsername);
            this.Controls.Add(txtUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);
            this.Controls.Add(lblRole);
            this.Controls.Add(cbRole);
            this.Controls.Add(btnLogin);
            this.Controls.Add(lblMessage);

            // Evento del botón de login
            btnLogin.Click += (sender, e) =>
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string role = cbRole.SelectedItem?.ToString();

                // Validación de usuario y rol (puedes integrar una validación real)
                if (username == "admin" && password == "password123" && role == "Cliente")
                {
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "Login successful!";
                    ClasesForm clasesForm = new ClasesForm();
                    this.Hide();
                    clasesForm.ShowDialog();
                    this.Close();
                }
                else if (username == "trainer" && password == "trainer123" && role == "Entrenador")
                {
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "Login successful!";
                    InventarioForm inventarioForm = new InventarioForm();
                    this.Hide();
                    inventarioForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblMessage.Text = "Invalid username, password, or role!";
                }
            };
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}



