using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace APS3periodo
{
    public partial class Form1 : Form
    {

        static int size;//Tamanho da lista
        List<int> l1 = new List<int>(size);


        bool lista_ordenada = false;
        Ordenacao ord = new Ordenacao();

        string tipoOrd = "";



        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            statusStrip1.BackColor = Color.Red;
            tamanho_lista();
            pBarOrd.Maximum = size;
            PreencheLista(l1);


            Esable();
            toolStripStatusLabel1.Text = "Ordenando items";

            switch (cBoxMetOrd.Text)
            {

                case "Bubble Sort":

                    tipoOrd = "Bubble Sort";

                    break;

                case "Selection-Sort":
                    tipoOrd = "Selection-Sort";

                    break;

                case "Quick-Sort":
                    tipoOrd = "Quick-Sort";

                    break;

                default:
                    break;
            }

            bwOrdenacao.RunWorkerAsync();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            tamanho_lista();
            statusStrip1.BackColor = Color.LimeGreen;
            toolStripStatusLabel1.Text = "Preenchendo Lista";
            PreencheLista(l1);
            cBoxMetOrd.SelectedIndex = 0;
            ord.onProgressUpdate += new Progress(progresso); //Inscreve o metodo progresso() no evento  onProgressUpdate

            pBarOrd.Maximum = size;
        }


        /// <summary>
        /// Lista os itens na OrdList
        /// </summary>
        /// <param name="l"></param>
        void Listar(List<int> l)
        {

            OrdList.Items.Clear();

            foreach (var item in l)
            {
                OrdList.Items.Add(item);
            }

        }


        /// <summary>
        /// Bloqueia ou desbloqueia botões de acão
        /// </summary>
        void Esable()
        {
            bool bt1 = btnOrdenar.Enabled;
            bool bt2 = btnPreencheLista.Enabled;
            bool bt3 = btnListar.Enabled;

            if (bt1 && bt2 && bt3)
            {
                statusStrip1.BackColor = Color.DarkGray;
                btnOrdenar.Enabled = false;
                btnPreencheLista.Enabled = false;
                btnListar.Enabled = false;
            }
            else
            {
                statusStrip1.BackColor = Color.LimeGreen;
                btnOrdenar.Enabled = true;
                btnPreencheLista.Enabled = true;
                btnListar.Enabled = true;
            }
        }


        /// <summary>
        /// define o tamanho da lista
        /// </summary>
        void tamanho_lista()
        {

            if (rb1000.Checked)
            {
                size = 1000;
            }
            else if (rb10k.Checked)
            {
                size = 10000;
            }
            else if (rb100k.Checked)
            {
                size = 100000;
            }
            else             
            {
                size = 1000000;
            }
        }

        /// <summary>
        /// 
        /// Preenche o Vetor com numeros aleatórios de 0 a 100.000
        /// </summary>
        void PreencheLista(List<int> l)
        {

            lista_ordenada = false;
            Random r = new Random();
            int rand = 0;

            l1.Clear();

            for (int i = 0; i < size; i++)
            {
                l1.Add(i);
            }

            //Faz o 'embaralhamento' dos itens
            for (int i = 0; i < size; i++)
            {
                rand = r.Next(size);
                int aux = l1[i];
                l1[i] = l1[rand];
                l1[rand] = aux;
            }

           

            toolStripStatusLabel1.Text = "Pronto";

        }

        private void btnPreencheLista_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Preenchendo Lista";
            OrdList.Items.Clear();
            PreencheLista(l1);
            Listar(l1);
        }


        /// <summary>
        /// Passa valores para a BW.progres_change que atualiza componentes no form, é disparada com o evento Ordenacao.onProgressUpdate
        /// </summary>
        /// <param name="val"></param>
        void progresso(int val)
        {


            bwOrdenacao.ReportProgress(val);


        }


        #region Bworker Ordenação


        public void bwOrdenacao_DoWork(object sender, DoWorkEventArgs e)
        {
            ord.sw.Start();

            switch (tipoOrd)
            {
                case "Bubble Sort":
                    ord.bubbleSort(l1);

                    break;
                case "Selection-Sort":

                    ord.selectionSort(l1);

                    break;

                case "Quick-Sort":
                    ord.QuickSort(l1, 0, l1.Count - 1);

                    break;
                default:
                    break;
            }


        }


        private void bwOrdenacao_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblOrdProgress.Text = String.Format("{0}{1}{2}{3}{4}", "Progresso: ", e.ProgressPercentage + 1, " de ", size, " itens ordenados");

            if (pBarOrd.Value == size)
            {
                pBarOrd.Value = 0;
            }

           
            pBarOrd.Value = e.ProgressPercentage;
            
        }

        private void bwOrdenacao_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            ord.sw.Stop();
            toolStripStatusLabel1.Text = "Pronto";
            richTextBox1.Text += tipoOrd + " - Itens: " + size + " - tempo:" + ord.sw.ElapsedMilliseconds + "ms" + "\n";
            ord.sw.Reset();
            OrdList.Items.Clear();
            lista_ordenada = true;
            pBarOrd.Value = 0;
            Listar(l1);
            Esable();
            
        }

        #endregion




        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtBusca.Text) > size)
            {
                txtBusca.Text = Convert.ToString(size - 1);
            }

            if (txtBusca.Text == "")
            {
                lblResutBusca.Text = "Campo vazio, digite um item a buscar!";
                return;
            }

            if (!lista_ordenada)
            {
                lblResutBusca.Text = "Lista não está ordenada, não é possivel realizar busca binária!";
                return;
            }

            Busca b1 = new Busca();

            int key = Convert.ToInt32(txtBusca.Text);

            int pos = b1.BuscaBinaria_(l1, key);


            if (pos == -1)
                lblResutBusca.Text = "Item não encontrado, tente outro item";

            else
                lblResutBusca.Text = "Item encontrado, posição: " + pos + "\n" +
                    "Comparações: " + b1.Comparacoes;

            OrdList.SelectedIndex = pos;
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar(l1);
        }

    }
}
