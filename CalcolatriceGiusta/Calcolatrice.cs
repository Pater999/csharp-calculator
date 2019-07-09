using System;
using System.Windows.Forms;
using System.Drawing;
class ClsForms : Form
{
    // Oggetti:
    TextBox txtDisplay;
    TextBox txtDisplay2;
    Button Btn0;
    Button Btn1;
    Button Btn2;
    Button Btn3;
    Button Btn4;
    Button Btn5;
    Button Btn6;
    Button Btn7;
    Button Btn8;
    Button Btn9;
    Button BtnSom;
    Button BtnMol;
    Button BtnDiv;
    Button BtnSot;
    Button BtnUgu;
    Button BtnRad;
    Button BtnCan;
    Button BtnCe;
    Button BtnC;
    Button BtnVir;
    Button BtnPerCen;
    Button BtnPot;
    Button BtnRec;
    Button BtnPeM;
    

    // Variabili di classe:
    string Operazione;
    double Operando1;
    double Operando2;
    bool Virgola = false;

    public ClsForms()
    {

        // Impostazioni Layout Finestra:
        this.Text = "Calcolatrice";
        this.Width = 332;
        this.Height = 450;
        this.BackColor = Color.WhiteSmoke;
        FormBorderStyle = FormBorderStyle.FixedToolWindow;

        // ------------------------------------------------ Display ---------------------------------------------------------------------------------- \\

        // Creazione DisplaySopra:
        this.txtDisplay2 = new TextBox();
        this.txtDisplay2.ReadOnly = true;
        this.txtDisplay2.Top = 20;
        this.txtDisplay2.Left = 0;
        this.txtDisplay2.Width = 319;
        this.txtDisplay2.Height = 20;
        this.txtDisplay2.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.txtDisplay2.BorderStyle = BorderStyle.None;
        this.txtDisplay2.TextAlign = HorizontalAlignment.Right;
        this.txtDisplay2.BackColor = Color.WhiteSmoke;
        this.Controls.Add(this.txtDisplay2);

        // Creazione Display:
        this.txtDisplay = new TextBox();
        this.txtDisplay.Top = txtDisplay2.Top + txtDisplay2.Height;
        this.txtDisplay.Left = 0;
        this.txtDisplay.Width = 319;
        this.txtDisplay.Height = 30;
        this.txtDisplay.Font = new Font(txtDisplay2.Font.FontFamily, 30);
        this.txtDisplay.TextAlign = HorizontalAlignment.Right;
        this.txtDisplay.BorderStyle = BorderStyle.None;
        this.txtDisplay.BackColor = Color.White;
        this.txtDisplay.Text = "0";
        this.Controls.Add(this.txtDisplay);
        this.txtDisplay.KeyPress += TxtDisplay_KeyPress;

        // ------------------------------------------------ Riga 1 ----------------------------------------------------------------------------------- \\

        // Bottone %
        this.BtnPerCen = new Button();
        this.BtnPerCen.Top = txtDisplay.Top + txtDisplay.Height;
        this.BtnPerCen.Text = "%";
        this.BtnPerCen.Left = -2;
        this.BtnPerCen.Width = this.Width / 4;
        this.BtnPerCen.AutoSize = true;
        this.BtnPerCen.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.BtnPerCen.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(BtnPerCen);
        this.BtnPerCen.Click += Funzioni_Click;

        // Bottone √
        this.BtnRad = new Button();
        this.BtnRad.Top = txtDisplay.Top + txtDisplay.Height;
        this.BtnRad.Text = "√";
        this.BtnRad.Width = this.Width / 4;
        this.BtnRad.AutoSize = true;
        this.BtnRad.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.BtnRad.Left = BtnPerCen.Width + BtnPerCen.Left;
        this.BtnRad.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(BtnRad);
        this.BtnRad.Click += Funzioni_Click;

        // Bottone x²
        this.BtnPot = new Button();
        this.BtnPot.Top = txtDisplay.Top + txtDisplay.Height;
        this.BtnPot.Text = "x²";
        this.BtnPot.Width = this.Width / 4;
        this.BtnPot.AutoSize = true;
        this.BtnPot.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.BtnPot.Left = BtnPerCen.Width + BtnRad.Left;
        this.BtnPot.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(BtnPot);
        this.BtnPot.Click += Funzioni_Click;

        // Bottone 1/x
        this.BtnRec = new Button();
        this.BtnRec.Top = txtDisplay.Top + txtDisplay.Height;
        this.BtnRec.Text = "1/x";
        this.BtnRec.Width = this.Width / 4;
        this.BtnRec.AutoSize = true;
        this.BtnRec.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.BtnRec.Left = BtnPerCen.Width + BtnPot.Left;
        this.BtnRec.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(BtnRec);
        this.BtnRec.Click += Funzioni_Click;

        // ------------------------------------------------ Riga 2 ----------------------------------------------------------------------------------- \\

        // Bottone CE
        this.BtnCe = new Button();
        this.BtnCe.Top = txtDisplay.Top + txtDisplay.Height + BtnRec.Height;
        this.BtnCe.Text = "CE";
        this.BtnCe.Left = -2;
        this.BtnCe.Width = this.Width / 4;
        this.BtnCe.AutoSize = true;
        this.BtnCe.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.BtnCe.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(BtnCe);
        this.BtnCe.Click += BottoniCancella_Click;

        // Bottone C
        this.BtnC = new Button();
        this.BtnC.Top = this.BtnCe.Top;
        this.BtnC.Text = "C";
        this.BtnC.Width = this.Width / 4;
        this.BtnC.AutoSize = true;
        this.BtnC.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.BtnC.Left = BtnPerCen.Width + BtnPerCen.Left;
        this.BtnC.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(BtnC);
        this.BtnC.Click += BottoniCancella_Click;

        // Bottone Canc
        this.BtnCan = new Button();
        this.BtnCan.Top = this.BtnCe.Top;
        this.BtnCan.Text = "<-";
        this.BtnCan.Width = this.Width / 4;
        this.BtnCan.AutoSize = true;
        this.BtnCan.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.BtnCan.Left = BtnPerCen.Width + BtnRad.Left;
        this.BtnCan.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(BtnCan);
        this.BtnCan.Click += BottoniCancella_Click;


        // Bottone Div
        this.BtnDiv = new Button();
        this.BtnDiv.Top = this.BtnCe.Top;
        this.BtnDiv.Text = "/";
        this.BtnDiv.Width = this.Width / 4;
        this.BtnDiv.AutoSize = true;
        this.BtnDiv.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.BtnDiv.Left = BtnPerCen.Width + BtnPot.Left;
        this.BtnDiv.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(BtnDiv);
        this.BtnDiv.Click += Operazioni_Click;

        // ------------------------------------------------ Riga 3 ----------------------------------------------------------------------------------- \\

        // Bottone 7
        this.Btn7 = new Button();
        this.Btn7.Top = txtDisplay.Top + txtDisplay.Height + BtnRec.Height + BtnCe.Height;
        this.Btn7.Text = "7";
        this.Btn7.Left = -2;
        this.Btn7.Width = this.Width / 4;
        this.Btn7.AutoSize = true;
        this.Btn7.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.Btn7.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(Btn7);
        this.Btn7.Click += Cifre_Click;

        // Bottone 8
        this.Btn8 = new Button();
        this.Btn8.Top = this.Btn7.Top;
        this.Btn8.Text = "8";
        this.Btn8.Width = this.Width / 4;
        this.Btn8.AutoSize = true;
        this.Btn8.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.Btn8.Left = BtnPerCen.Width + BtnPerCen.Left;
        this.Btn8.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(Btn8);
        this.Btn8.Click += Cifre_Click;

        // Bottone 9
        this.Btn9 = new Button();
        this.Btn9.Top = this.Btn7.Top;
        this.Btn9.Text = "9";
        this.Btn9.Width = this.Width / 4;
        this.Btn9.AutoSize = true;
        this.Btn9.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.Btn9.Left = BtnPerCen.Width + BtnRad.Left;
        this.Btn9.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(Btn9);
        this.Btn9.Click += Cifre_Click;

        // Bottone X
        this.BtnMol = new Button();
        this.BtnMol.Top = this.Btn7.Top;
        this.BtnMol.Text = "X";
        this.BtnMol.Width = this.Width / 4;
        this.BtnMol.AutoSize = true;
        this.BtnMol.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.BtnMol.Left = BtnPerCen.Width + BtnPot.Left;
        this.BtnMol.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(BtnMol);
        this.BtnMol.Click += Operazioni_Click;

        // ------------------------------------------------ Riga 4 ----------------------------------------------------------------------------------- \\

        // Bottone 4
        this.Btn4 = new Button();
        this.Btn4.Top = BtnMol.Top+BtnMol.Height;
        this.Btn4.Text = "4";
        this.Btn4.Left = -2;
        this.Btn4.Width = this.Width / 4;
        this.Btn4.AutoSize = true;
        this.Btn4.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.Btn4.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(Btn4);
        this.Btn4.Click += Cifre_Click;

        // Bottone 5
        this.Btn5 = new Button();
        this.Btn5.Top = this.Btn4.Top;
        this.Btn5.Text = "5";
        this.Btn5.Width = this.Width / 4;
        this.Btn5.AutoSize = true;
        this.Btn5.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.Btn5.Left = BtnPerCen.Width + BtnPerCen.Left;
        this.Btn5.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(Btn5);
        this.Btn5.Click += Cifre_Click;

        // Bottone 6
        this.Btn6 = new Button();
        this.Btn6.Top = this.Btn4.Top;
        this.Btn6.Text = "6";
        this.Btn6.Width = this.Width / 4;
        this.Btn6.AutoSize = true;
        this.Btn6.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.Btn6.Left = BtnPerCen.Width + BtnRad.Left;
        this.Btn6.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(Btn6);
        this.Btn6.Click += Cifre_Click;

        // Bottone -
        this.BtnSot = new Button();
        this.BtnSot.Top = this.Btn4.Top;
        this.BtnSot.Text = "-";
        this.BtnSot.Width = this.Width / 4;
        this.BtnSot.AutoSize = true;
        this.BtnSot.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.BtnSot.Left = BtnPerCen.Width + BtnPot.Left;
        this.BtnSot.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(BtnSot);
        this.BtnSot.Click += Operazioni_Click;

        // ------------------------------------------------ Riga 5 ----------------------------------------------------------------------------------- \\

        // Bottone 1
        this.Btn1 = new Button();
        this.Btn1.Top = Btn4.Top + BtnSot.Height;
        this.Btn1.Text = "1";
        this.Btn1.Left = -2;
        this.Btn1.Width = this.Width / 4;
        this.Btn1.AutoSize = true;
        this.Btn1.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.Btn1.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(Btn1);
        this.Btn1.Click += Cifre_Click;

        // Bottone 2
        this.Btn2 = new Button();
        this.Btn2.Top = this.Btn1.Top;
        this.Btn2.Text = "2";
        this.Btn2.Width = this.Width / 4;
        this.Btn2.AutoSize = true;
        this.Btn2.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.Btn2.Left = BtnPerCen.Width + BtnPerCen.Left;
        this.Btn2.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(Btn2);
        this.Btn2.Click += Cifre_Click;

        // Bottone 3
        this.Btn3 = new Button();
        this.Btn3.Top = this.Btn1.Top;
        this.Btn3.Text = "3";
        this.Btn3.Width = this.Width / 4;
        this.Btn3.AutoSize = true;
        this.Btn3.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.Btn3.Left = BtnPerCen.Width + BtnRad.Left;
        this.Btn3.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(Btn3);
        this.Btn3.Click += Cifre_Click;

        // Bottone +
        this.BtnSom = new Button();
        this.BtnSom.Top = this.Btn1.Top;
        this.BtnSom.Text = "+";
        this.BtnSom.Width = this.Width / 4;
        this.BtnSom.AutoSize = true;
        this.BtnSom.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.BtnSom.Left = BtnPerCen.Width + BtnPot.Left;
        this.BtnSom.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(BtnSom);
        this.BtnSom.Click += Operazioni_Click;

        // ------------------------------------------------ Riga 6 ----------------------------------------------------------------------------------- \\

        // Bottone +-
        this.BtnPeM= new Button();
        this.BtnPeM.Top = Btn1.Top + BtnSom.Height;
        this.BtnPeM.Text = "+-";
        this.BtnPeM.Left = -2;
        this.BtnPeM.Width = this.Width / 4;
        this.BtnPeM.AutoSize = true;
        this.BtnPeM.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.BtnPeM.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(BtnPeM);
        this.BtnPeM.Click += BtnPeM_Click;

        // Bottone 0
        this.Btn0 = new Button();
        this.Btn0.Top = this.BtnPeM.Top;
        this.Btn0.Text = "0";
        this.Btn0.Width = this.Width / 4;
        this.Btn0.AutoSize = true;
        this.Btn0.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.Btn0.Left = BtnPerCen.Width + BtnPerCen.Left;
        this.Btn0.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(Btn0);
        this.Btn0.Click += Cifre_Click;

        // Bottone Virgola
        this.BtnVir = new Button();
        this.BtnVir.Top = this.BtnPeM.Top;
        this.BtnVir.Text = ",";
        this.BtnVir.Width = this.Width / 4;
        this.BtnVir.AutoSize = true;
        this.BtnVir.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.BtnVir.Left = BtnPerCen.Width + BtnRad.Left;
        this.BtnVir.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(BtnVir);
        this.BtnVir.Click += BtnVir_Click; ;

        // Bottone Uguale
        this.BtnUgu = new Button();
        this.BtnUgu.Top = this.BtnPeM.Top;
        this.BtnUgu.Text = "=";
        this.BtnUgu.Width = this.Width / 4;
        this.BtnUgu.AutoSize = true;
        this.BtnUgu.Font = new Font(txtDisplay2.Font.FontFamily, 20);
        this.BtnUgu.Left = BtnPerCen.Width + BtnPot.Left;
        this.BtnUgu.FlatStyle = FlatStyle.Flat;
        this.Controls.Add(BtnUgu);
        this.BtnUgu.Click += Operazioni_Click;
    }


    // ------------------------------------------------ Eventi ----------------------------------------------------------------------------------- \\

    // Evento per Scrivere nella TextBox
    private void TxtDisplay_KeyPress(object sender, KeyPressEventArgs e)
    {
        soloNumeri(e);
    }


    // Evento Per Scrivere Le cifre
    private void Cifre_Click(object sender, EventArgs e)
    {
        Button x = sender as Button;
        string scelta = x.Text;
        if (txtDisplay.Text != "0")
        {
            this.txtDisplay.Text += scelta;
        }
        else
        {
            this.txtDisplay.Clear();
            this.txtDisplay.Text += scelta;
        }
    }


    // Evento Operazioni:
    private void Operazioni_Click(object sender, EventArgs e)
    {
        Button x = sender as Button;
        string scelta = x.Text;
        if (this.txtDisplay.Text != "0")               // Controllo che sia diversa da 0
        {
            switch (scelta)
            {
                case "=":
                    switch (Operazione)
                    {
                        case "+":
                            Operando2 = Convert.ToDouble(txtDisplay.Text);
                            txtDisplay2.Clear();
                            txtDisplay.Text = Convert.ToString(Operando1 + Operando2);
                            break;
                        case "-":
                            Operando2 = Convert.ToDouble(txtDisplay.Text);
                            txtDisplay2.Clear();
                            txtDisplay.Text = Convert.ToString(Operando1 - Operando2);
                            break;
                        case "X":
                            Operando2 = Convert.ToDouble(txtDisplay.Text);
                            txtDisplay2.Clear();
                            txtDisplay.Text = Convert.ToString(Operando1 * Operando2);
                            break;
                        case "/":
                            Operando2 = Convert.ToDouble(txtDisplay.Text);
                            txtDisplay2.Clear();
                            txtDisplay.Text = Convert.ToString(Operando1 / Operando2);
                            break;
                    }
                    break;

                default:
                    Operazione = scelta;
                    Operando1 = Convert.ToDouble(txtDisplay.Text);
                    txtDisplay.Clear();
                    txtDisplay2.Text = Convert.ToString(Operando1) + " " + Operazione;
                    Virgola = false;
                    break;
            }
        }
        else
        {
            this.txtDisplay2.Text = "Error";
        }
    }


    // Evento Bottone Virgola:
    private void BtnVir_Click(object sender, EventArgs e)
    {
        if (Virgola == false)
        {
            this.txtDisplay.Text += ",";
            Virgola = true;
        }
        else
        {
            return;
        }

    }

    // Evento Cambio Segno:
    private void BtnPeM_Click(object sender, EventArgs e)
    {
        if (txtDisplay.Text != "0")
        {
            string tempS = txtDisplay.Text;
            double tempD = Convert.ToDouble(txtDisplay.Text);
            if (tempD <= 0)
            {
                txtDisplay.Clear();
                for (int i=1;i<tempS.Length;i++)
                {
                    txtDisplay.Text += tempS[i];
                }
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }
        else
        {
            return;
        }
    }

    // Eventi Cancella:
    private void BottoniCancella_Click(object sender, EventArgs e)
    {
        Button x = sender as Button;
        string scelta = x.Text;
        switch(scelta)
        {
            // Cancella Tutto
            case "C":
                Operando1 = 0;
                Operando2 = 0;
                Operazione = "";
                txtDisplay.Text = "0";
                txtDisplay2.Text = "";
                Virgola = false;
                break;

            // Cancella Solo Operando 2
            case "CE":
                txtDisplay.Text = "0";
                Virgola = false;
                break;

            // Cancella Numero
            case "<-":
                string temp = txtDisplay.Text;
                if (temp.Length < 2)
                {
                    txtDisplay.Text = "0";
                }
                else
                {
                    txtDisplay.Clear();
                    for (int i = 0; i < temp.Length - 1; i++)
                    {
                        txtDisplay.Text += temp[i];
                    }
                }
                break;
        }
    }

    // Eventi Varie Funzioni:
    private void Funzioni_Click(object sender, EventArgs e)
    {
        Button x = sender as Button;
        string scelta = x.Text;
        switch (scelta)
        {
            case "%":
                break;
            case "x²":
                Operando1 = Convert.ToDouble(txtDisplay.Text);
                Operando2 = Math.Pow(Operando1,2);
                txtDisplay.Text = Convert.ToString(Operando2);
                break;
            case "1/x":
                Operando1 = Convert.ToDouble(txtDisplay.Text);
                Operando2 = 1 / Operando1;
                txtDisplay2.Text = "1/("+Convert.ToString(Operando1)+")";
                txtDisplay.Text = Convert.ToString(Operando2);
                break;
            case "√":
                Operando1 = Convert.ToDouble(txtDisplay.Text);
                Operando2 = Math.Sqrt(Operando1);
                txtDisplay.Text = Convert.ToString(Operando2);
                break;
        }
    }

    // -----------------------------------------------Altri Metodi: ----------------------------------------------------------------------------------- \\

    // Stabilisce se è un numero, una virgola o "e"
    public void soloNumeri(KeyPressEventArgs ev)
    {
        if (!IsNumeric(ev.KeyChar.ToString()) && (((int)ev.KeyChar) != 8) && (ev.KeyChar.ToString() != ","))
        {
            ev.Handled = true;
        }
    }
    // Controllo se è un numero
    public bool IsNumeric(string numero)
    {
        try
        {
            Int32.Parse(numero);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}





class Calcolatrice
{
    static void Main()
    {
        Application.Run(new ClsForms());
    }
}

