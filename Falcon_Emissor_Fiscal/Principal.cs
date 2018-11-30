using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Falcon_Emissor_Fiscal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

        }

        #region Timers

        private void timer_get_action_Tick(object sender, EventArgs e)
        {
            timer_get_action.Stop();
        }

        private void verifica_acao_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void verifica_acao_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_action.Stop();

            try
            {

                // Emitindo a Nota fiscal =====================================
                EmissaoNFe();



            }
            catch (Exception ee)
            {
                notifyIcon1.ShowBalloonTip(2000, "Falcon Fiscal", ee.Message, ToolTipIcon.Error);
            }


        }


        #endregion

        #region Funções Principais

        

        public void EmissaoNFe()
        {



            // Coletando Certificado =========================================
            X509Certificate2 certificado = Certificado.get_certificado();



        }






        #endregion

     
    }
}
