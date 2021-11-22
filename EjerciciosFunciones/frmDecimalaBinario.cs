using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosFunciones
{
    public partial class frmDecimalaBinario : Form
    {
        public frmDecimalaBinario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
             int numero = int.Parse(this.txtNumero.Text);

                int[] res = binario(numero);
                //Console.WriteLine("INICIO");
                for (int i = res.Length - 1; i > 0; i--)
                {
                
                    if (res[0] == 1)
                    {
                        this.check1.Checked = true;
                    }
                    else
                    {
                        this.check1.Checked = false;
                    }
                    if (res[1] == 1)
                    {
                        this.check2.Checked = true;
                    }
                    else
                    {
                        this.check2.Checked = false;
                    }
                    if (res[2] == 1)
                    {
                        this.check3.Checked = true;
                    }
                    else
                    {
                        this.check3.Checked = false;
                    }
                    if (res[3] == 1)
                    {
                        this.check4.Checked = true;
                    }
                    else
                    {
                        this.check4.Checked = false;
                    }
                    if (res[4] == 1)
                    {
                        this.check5.Checked = true;
                    }
                    else
                    {
                        this.check5.Checked = false;
                    }
                    if (res[5] == 1)
                    {
                        this.check6.Checked = true;
                    }
                    else
                    {
                        this.check6.Checked = false;
                    }
                    if (res[6] == 1)
                    {
                        this.check7.Checked = true;
                    }
                    else
                    {
                        this.check7.Checked = false;
                    }
                    if (res[7] == 1)
                    {
                        this.check8.Checked = true;
                    }
                    else
                    {
                        this.check8.Checked = false;
                    }
                    
                    Console.WriteLine("{0}", res[i]);
                }


            }
            // Console.WriteLine("FIN");
            // this.checkBox1.Checked = true;
            private int[] binario(int num)
            {
                int[] bin = { 0, 0, 0, 0, 0, 0, 0, 0 };
                //int[] bin =new int [8];
                int i = 0;
                int resto = 0;
                while (num > 0)
                {
                    resto = num % 2;
                    bin[i++] = resto;
                    num = num / 2;
                    //Console.WriteLine("{0}", resto);
                }

                return bin;
            }
    }
}
