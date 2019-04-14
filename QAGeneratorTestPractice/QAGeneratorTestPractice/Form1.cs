using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QAGeneratorTestPractice
{
    public partial class Form1 : Form
    {
        //puta mierda de programa
        static string[] questionsArray =
        {
            //"abajo", "abandonar", "abismo", "absolver", "aceptar", "acrecentar", "afrontar", "basico", "beneficioso", "calumniar", "caracteristico", "carecer", "castigar", "civilizacion", "decadencia", "decidir", "denunciar", "destreza", "diligente", "efimero"
            //antonimos
            "arriba", "amparar", "cumbre", "condenar", "rechazar", "reducir", "eludir", "superficial", "lesivo", "encomiar", "generico", "poseer", "perdonar", "barbarie", "auge", "titubear", "encubrir", "torpeza", "indolente", "perenne"
            //"Eh", "Ph", "Kl", "Pl", "Go", "R", "M"
        };
    static string[] answerArray =
        {
            //"debajo","dejar", "precipicio", "perdonar", "recibir", "aumentar", "enfrentar", "primordial", "util", "difamar", "unico", "faltar", "sancionar", "progreso", "decaimiento", "resolver", "acusar", "habilidad", "activo", "momentaneo"
            //sinonimos de antonimos
            "encima", "proteger", "altura", "sancionar", "apartar", "aminorar", "evitar", "ligero", "perjudicial", "alabar", "comun", "tener", "absolver", "salvajismo", "esplendor", "dudar", "ocultar", "ineptitud", "perezoso", "eterno"
            //"200*10^9", "7900", "2200", "998", "1400", "8,315", "28,88*10^-3"
        };
        public Form1()
        {
            InitializeComponent();
        }
        bool questionTag = true;
        bool firstTimeTag = true;
        private void continueButton_Click(object sender, EventArgs e)
        {
            if (questionTag == true)
            {
                PutQuestion();
            }
            else
            {
                CheckAnswer();
            }
        }
        private void CheckAnswer()
        {
            if (answerTextBox.Text == answerArray[(numbers[questionNumber])])
            {
                questionLabel.ForeColor = System.Drawing.Color.Green;
                waitTime = 6;
                questionLabel.Text = "CORRECTO";

                questionNumber++;
                questionTag = true;
            }
            else
            {
                questionLabel.ForeColor = System.Drawing.Color.Red;

                questionLabel.Text = "La Respuesta Correcta es:      " + answerArray[(numbers[questionNumber])];
                waitTime = 10;
                questionNumber++;
                questionTag = true;
            }
        }
        private void QuickCheckAnswer()
        {
            if (answerTextBox.Text == answerArray[(numbers[questionNumber])])
            {
                questionLabel.ForeColor = System.Drawing.Color.Green;
                questionLabel.Text = "CORRECTO";

                questionTag = true;
                questionNumber++;
                //continueButton_Click(this, EventArgs.Empty);
            }
        }
        static int qMaxArrayIndex = questionsArray.Count() - 1;
        static int qArrayIndex;
        static int[] numbers;
        static Random r = new Random();
        static int questionNumber = 0;
        private void PutQuestion()
        {
            

            if (firstTimeTag)
            {
                //else if(questionNumber > 0)
                //{
                //    questionNumber++;
                //}
                //findRandom();
                questionLabel.ForeColor = System.Drawing.Color.Black;

                questionLabel.Text = questionsArray[(numbers[questionNumber])];
                questionTag = false;
                //System.Threading.Thread.Sleep(500);
                answerTextBox.Text = "";
                firstTimeTag = false;
            }
        }
        private void GenerateRandomArray()
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                r = new Random();
                qArrayIndex = r.Next(0, qMaxArrayIndex + 1);
                if (numbers.Contains(qArrayIndex))
                {
                    i--;
                }
                else
                {
                    numbers[i] = qArrayIndex;
                }
            }
            
        }
        /* private void findRandom()
        {
            r = new Random();
            qArrayIndex = r.Next(0, qMaxArrayIndex + 1);
            for (int i = 0; i < numbers.Length - 1; i++)
            {

                if (numbers[i] == -1)
                {
                    int numberIndex = Array.IndexOf(numbers, qArrayIndex);
                    int indexNumber = Array.IndexOf(numbers, numberIndex);

                    if (numberIndex == qArrayIndex)
                    {
                        r = new Random();
                        qArrayIndex = r.Next(0, qMaxArrayIndex + 1);
                    }
                    else if(numberIndex != qArrayIndex && numberIndex != indexNumber)
                    {
                        numbers[i] = qArrayIndex;
                    }
                }
                if (i == numbers.Length - 1)
                {
                    numbers = new int[questionsArray.Length];
                }
            }


        }
        */
        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (questionNumber >= numbers.Length)
            {
                numbers = new int[qArrayIndex];
                questionNumber = 0;
                GenerateRandomArray();
            }
            QuickCheckAnswer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numbers = new int[questionsArray.Length];
            GenerateRandomArray();

            PutQuestion();
            timerAnswerCheck.Start();
        }
        public static int time = 0;
        private void timerAnswerCheck_Tick(object sender, EventArgs e)
        {
            //time++;
            //if(time == 10)
            //{
            
            
            if (questionNumber >= numbers.Length)
            {
                numbers = new int[qArrayIndex];
                questionNumber = 0;
                GenerateRandomArray();
            }
            QuickCheckAnswer();

            if (questionTag)
            {
                answerTextBox.Text = "";
                cooldownTimer.Start();
                PutQuestion();
                
            }
            //time = 0;
            //}
        }
        public static int cooldownTime = 0;
        public static int waitTime = 6;
        private void cooldownTimer_Tick(object sender, EventArgs e)
        {
            cooldownTime++;
            
            if(cooldownTime == waitTime)
            {
                firstTimeTag = true;

                PutQuestion();
                cooldownTime = 0;
                cooldownTimer.Stop();
            }
        }

        private void invertirButton_Click(object sender, EventArgs e)
        {
            string[] temp = questionsArray;
            questionsArray = answerArray;
            answerArray = temp;

            questionLabel.Text = "";
            answerTextBox.Text = "";
            
            numbers = new int[questionsArray.Length];
            questionNumber = 0;
            GenerateRandomArray();
            questionTag = true;

            PutQuestion();
            timerAnswerCheck.Start();
        }
    }
}
