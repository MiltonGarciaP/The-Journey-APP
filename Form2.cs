using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Journey
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Variables utilizadas para el proceso

        int Peso = 0;
        int Estatura = 0;
        

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numero buen mamañema", "Alerta de un animal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void EstaturaT_TextChanged(object sender, EventArgs e)
        {
            
            Estatura = int.Parse(EstaturaT.Text);

        }
        

        private void PesoT_TextChanged(object sender, EventArgs e)
        {
            
            Peso = int.Parse(PesoT.Text);
        }

        private void GOT_TextChanged(object sender, EventArgs e)
        {
            int GO;
            GO = int.Parse(GOT.Text);
        }

        private void VPPS_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void PLCA_TextChanged(object sender, EventArgs e)
        {
            int PDLCA;
            PDLCA = int.Parse(PLCA.Text);

        }

        private void PPCM_TextChanged(object sender, EventArgs e)
        {
            int PDPCM;
            PDPCM = int.Parse(PPCM.Text);
        }

        private void label21_Click(object sender, EventArgs e)
        {
            



        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(EdadT.Text))
            {
                MessageBox.Show("No puede dejar el campo edad vacio" );
            }

            if (String.IsNullOrEmpty(EstaturaT.Text))
            {
                MessageBox.Show("No puede dejar el campo de estatura vacio");

            }

            if (String.IsNullOrEmpty(PesoT.Text))
            {
                MessageBox.Show("No puede dejar el campo peso vacio");
            }

            if (String.IsNullOrEmpty(GOT.Text))
            {
                MessageBox.Show("No puede dejar el porcentaje de grasa objectivo vacio");
            }

            if (String.IsNullOrEmpty(PLCA.Text))
            {
                MessageBox.Show("No puede dejar el campo porcentaje de lipidos de la celula adiposa vacio");
            }

            if (String.IsNullOrEmpty(PPCM.Text))
            {
                MessageBox.Show("No puede dejar el campo proteinas de la celula muscular vacio");
            }


            // Para el Porcenteaje de grasa corporal 

            int IM = (int.Parse(PesoT.Text)) / (int.Parse(EstaturaT.Text) * 2);
            double IMC = Convert.ToDouble(IM);
            int edad = int.Parse(EdadT.Text);
            double Años = Convert.ToDouble(edad);


            if (radioButton1.Checked == true)
            {
                // Indice de masa corporal
                double PGC = 1.39 * IMC + 0.16 * Años - 9 * 1 - 7;

                double FinalPGC = (double)(Math.Floor((decimal)(PGC * 10)) / 10);

                FinalPGC = Math.Abs(FinalPGC);
                label66.Text = FinalPGC.ToString();

                

                //Formula de peso masa grasa
                int es = int.Parse(EstaturaT.Text);
                double PMG = FinalPGC * es / 100;
                label26.Text = PMG.ToString();

                // Formula de peso masa magra 

                int peso = int.Parse(PesoT.Text);
                double PMM = PMG - peso;
                label31.Text = PMM.ToString();
                PMM = Math.Abs(PMM);

                // Formula para calidad muscular

                // Perdida pocentual de grasa

                double PPDG = int.Parse(GOT.Text);
                double PDDGS = PPDG - FinalPGC;
                label10.Text = PDDGS.ToString();

                // perdida de grasa esperada 
                double esta = int.Parse(EstaturaT.Text);
                double PGE = esta * PDDGS / 100;
                label12.Text = PGE.ToString();

                // Perdida de peso magro

                double PPMO = PGE * PDDGS;
                label14.Text = PPMO.ToString();

                // Perdida de peso Total esperado
                double PT = PPMO + PGE;
                label16.Text = PT.ToString();


                // valor porcentual de perdida de peso semanal 

                double VPDPDPS = 0.70;
                label40.Text = VPDPDPS.ToString();

                // Perdia de peso corporal esperada por semana
                double PDPCEPS = PT / VPDPDPS;
                label71.Text = VPDPDPS.ToString();

                // Perdia de peso corporal esperada por semana
                double pst = int.Parse(PesoT.Text);
                double PDPCEP = pst * VPDPDPS / 100;

                label71.Text = PDPCEP.ToString();

                // Duracion restante del deficit calorico

                double DRDC = PT / pst;
                double dias = DRDC * 7;
                dias = (double)(Math.Floor((decimal)(dias * 10)) / 10);
                label74.Text = dias.ToString();
                label44.Text = DRDC.ToString();

                // Total de lipidos en la grasa subcutanea
                double PLC = int.Parse(PLCA.Text);

                double TDLGS = FinalPGC * PLC * 100;
                label35.Text = TDLGS.ToString();
                // Total de proteinas en la masa muscular
                double PPCMS = int.Parse(PPCM.Text);
                double TPMM = PPCMS * PMG * 1000;
                label36.Text = TPMM.ToString();

                // Energia porveniente de la masa muscular
                double EPMM = TPMM * 4;
                label38.Text = EPMM.ToString();

                // Energia proveniente de la grasa subcutanea
                double EPGS = PLC * 9;
                label37.Text = EPGS.ToString();

                //Perdida total requerida de energia de la grasa subcutanea para lograr objetivo
                double PTREGS = (PGE * 453.59) * 9;
                label57.Text = PTREGS.ToString();

                //Deficit calorico diario para cumplir objectivo 
                double CDPCO = PTREGS / dias;
                label59.Text = CDPCO.ToString();

                // Formula BMR

                double BMR = (10 * peso / 2.205) + 6.25 * Estatura - 5 * edad + 5;
                label21.Text = BMR.ToString();

                // TDEE
                if (radioButton3.Checked == true)
                {
                    double TDEE = BMR * 1.2;
                    TDEE = (double)(Math.Floor((decimal)(TDEE * 10)) / 10);
                    label42.Text = TDEE.ToString();
                }
                if (radioButton4.Checked == true)
                {
                    double TDEE = BMR * 1.375;
                    TDEE = (double)(Math.Floor((decimal)(TDEE * 10)) / 10);
                    label42.Text = TDEE.ToString();

                }
                if (radioButton5.Checked == true)
                {
                    double TDEE = BMR * 1.55;
                    TDEE = (double)(Math.Floor((decimal)(TDEE * 10)) / 10);
                    label42.Text = TDEE.ToString();

                }
                if (radioButton6.Checked == true)
                {
                    double TDEE = BMR * 1.725;
                    TDEE = (double)(Math.Floor((decimal)(TDEE * 10)) / 10);
                    label42.Text = TDEE.ToString();
                }
                if (radioButton6.Checked == true)
                {
                    double TDEE = BMR * 1.9;
                    TDEE = (double)(Math.Floor((decimal)(TDEE * 10)) / 10);
                    label42.Text = TDEE.ToString();
                }
                




            }

            // if para mujeres 
            if (radioButton2.Checked == true)
            {
                // Indice de masa corporal
                double PGC = 1.39 * IMC + 0.16 * Años - 9 * 0 - 7;

                double FinalPGC = (double)(Math.Floor((decimal)(PGC * 10)) / 10);

                FinalPGC = Math.Abs(FinalPGC);


                label66.Text = FinalPGC.ToString();

                //Formula de peso masa grasa
                int es = int.Parse(EstaturaT.Text);
                double PMG = FinalPGC * es / 100;
                label26.Text = PMG.ToString();

                // Formula de peso masa magra 

                int peso = int.Parse(PesoT.Text);
                double PMM = peso - PMG;
                PMM = Math.Abs(PMM);
                label31.Text = PMM.ToString();

                // Formula para calidad muscular


                // Perdida pocentual de grasa

                double PPDG = int.Parse(GOT.Text);
                double PDDGS = PPDG - FinalPGC;
                label10.Text = PDDGS.ToString();

                // perdida de grasa esperada 
                double esta = int.Parse(EstaturaT.Text);
                double PGE = esta * PDDGS / 100;
                label12.Text = PGE.ToString();

                // Perdida de peso magro

                double PPMO = PGE * PDDGS;
                label14.Text = PPMO.ToString();

                // Perdida de peso Total esperado

                double PT = PPMO + PGE;
                label16.Text = PT.ToString();

                // valor porcentual de perdida de peso semanal 

                double VPDPDPS = 0.70;
                label40.Text = VPDPDPS.ToString();

                // Perdia de peso corporal esperada por semana
                double pst = int.Parse(PesoT.Text);
                double PDPCEP = pst  * VPDPDPS / 100;

                label71.Text = PDPCEP.ToString();

                // Duracion restante del deficit calorico

                double DRDC = PT / pst;
                double dias = DRDC * 7;
                dias = (double)(Math.Floor((decimal)(dias * 10)) / 10);
                label74.Text = dias.ToString();
                label44.Text = DRDC.ToString();

                // Total de lipidos en la grasa subcutanea
                double PLC = int.Parse(PLCA.Text);

                double TDLGS = FinalPGC * PLC * 100;
                label35.Text = TDLGS.ToString();
                // Total de proteinas en la masa muscular
                double PPCMS = int.Parse(PPCM.Text);
                double TPMM = PPCMS * PMG * 1000;
                label36.Text = TPMM.ToString();

                // Energia proveniente de la masa muscular

                double EPMM = TPMM * 4;
                label38.Text = EPMM.ToString();

                // Energia proveniente de la grasa subcutanea
                double EPGS = PLC * 9;
                 label37.Text = EPGS.ToString();

                //Perdida total requerida de energia de la grasa subcutanea para lograr objetivo
                double PTREGS = (PGE * 453.59) * 9;
               label57.Text = PTREGS.ToString();

                //Deficit calorico diario para cumplir objectivo 
                double CDPCO = PTREGS / dias;
                label59.Text = CDPCO.ToString();

               // Formula BMR
              
                double BMR = (10 * peso / 2.205) + 6.25 * Estatura - 5 * edad - 161;
                label21.Text = BMR.ToString();



                // Formula TDEE
                if (radioButton3.Checked == true) 
                {
                    double TDEE = BMR * 1.2;
                    TDEE = (double)(Math.Floor((decimal)(TDEE * 10)) / 10);
                    label42.Text = TDEE.ToString();
                }
                if (radioButton4.Checked == true) 
                {
                    double TDEE = BMR * 1.375;
                    TDEE = (double)(Math.Floor((decimal)(TDEE * 10)) / 10);
                    label42.Text = TDEE.ToString();

                }
                if (radioButton5.Checked == true) 
                {
                    double TDEE = BMR * 1.55;
                    TDEE = (double)(Math.Floor((decimal)(TDEE * 10)) / 10);
                    label42.Text = TDEE.ToString();

                }
                if (radioButton6.Checked == true) 
                {
                    double TDEE = BMR * 1.725;
                    TDEE = (double)(Math.Floor((decimal)(TDEE * 10)) / 10);
                    label42.Text = TDEE.ToString();
                }
                if (radioButton6.Checked == true)
                {
                    double TDEE = BMR * 1.9;
                   TDEE = (double)(Math.Floor((decimal)(TDEE * 10)) / 10);
                    label42.Text = TDEE.ToString();
                }
               







            }




        }

        private void Ir_Click(object sender, EventArgs e)
        {
             

            

            

        }
    }
}
