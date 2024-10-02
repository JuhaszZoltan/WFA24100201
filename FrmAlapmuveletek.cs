namespace WFA24100201
{
    public partial class FrmAlapmuveletek : Form
    {
        public FrmAlapmuveletek()
        {
            InitializeComponent();
            btnKivonas.Click += BtnMuvelet_Click;
            btnOsszeadas.Click += BtnMuvelet_Click;
            btnOsztas.Click += BtnMuvelet_Click;
            btnSzorzas.Click += BtnMuvelet_Click;
            btnTorles.Click += BtnTorles_Click;
        }

        private void BtnTorles_Click(object? sender, EventArgs e)
        {
            lblMuvelet.Text = "Eredm�ny:";
            txbAdat01.Text = string.Empty;
            txbAdat02.Text = string.Empty;
            txbEredmeny.Text = string.Empty;
        }

        private void BtnMuvelet_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbAdat01.Text) || 
                string.IsNullOrEmpty(txbAdat02.Text))
            {
                MessageBox.Show(
                    caption: "HIBA!",
                    text: "T�ltse ki az adatmez�ket!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
                return;
            }

            bool adat01OK = float.TryParse(txbAdat01.Text, out float x);
            bool adat02OK = float.TryParse(txbAdat02.Text, out float y);

            if (!adat01OK || !adat02OK)
            {
                MessageBox.Show(
                    caption: "HIBA!",
                    text: "Nem megfelel� sz�mform�tum a beviteli mez�kben!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
                return;
            }

            switch ((sender as Button).Text)
            {
                case "+":
                    lblMuvelet.Text = "�sszead�s:";
                    txbEredmeny.Text = $"{x + y}";
                    break;
                case "-":
                    lblMuvelet.Text = "Kivon�s:";
                    txbEredmeny.Text = $"{x - y}";
                    break;
                case "*":
                    lblMuvelet.Text = "Szorz�s:";
                    txbEredmeny.Text = $"{x * y}";
                    break;
                case "/":
                    if (y == 0)
                    {
                        MessageBox.Show(
                            caption: "HIBA!",
                            text: "K�s�rlet 0-val val� oszt�sra!",
                            icon: MessageBoxIcon.Error,
                            buttons: MessageBoxButtons.OK);
                        return;
                    }
                    lblMuvelet.Text = "Oszt�s:";
                    txbEredmeny.Text = $"{x / y:0.00}";
                    break;
                default:
                    {
                        MessageBox.Show(
                            caption: "HIBA!",
                            text: "Nem defini�lt m�velet!",
                            icon: MessageBoxIcon.Error,
                            buttons: MessageBoxButtons.OK);
                        return;
                    }
            }
        }
    }
}
