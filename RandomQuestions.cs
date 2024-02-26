using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using System.Windows.Forms;

namespace RandomQuestions
{
    public partial class Shuffle : Form
    {
        public Shuffle()
        {
            InitializeComponent();
        }

        private void Shuffle_Load(object sender, EventArgs e)
        {

        }

        private void buttonImport_Click(object sender, EventArgs e) //este es el evento que se desencadena al hacer click en el botón
        {
            //se crea un objeto OpenFileDialog para seleccionar un archivo Excel y se crea un filtro para mostrar únicamente archivos Excel con esas extendiones (.xlsx y .xls)
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Archivos de Excel|*.xlsx|Archivos de Excel 97-2003|*.xls" })
            {
                //este if dice que si se selecciona un archivo y se hace click en aceptar...
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //entonces se abre el archivo seleccionado en modo lectura
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        //accá se crea un objeto IExcelDataReader para leer el archivo excel 
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            //acá se va a cargar el archvio de Excel como un conjunto de datos DataSet
                            var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                            //esta es una función que sirve para configurar un DataTipe en excel y se establece la propiedad UseHeaderRow en "true" para indicar que la 1ra fila contiene los encabezados de columna 
                            {
                                ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration

                                {
                                    UseHeaderRow = true
                                }

                            });
                            //acá se establece la fuente de datos de contro DataGridView en la primera fila del DataSet
                            dataGridView1.DataSource = dataSet.Tables[0];
                        }
                    }
                    //acá se establece el texto de encabezado
                    dataGridView1.Columns[0].HeaderText = "Calle";
                    dataGridView1.Columns[1].HeaderText = "Calle";
                    dataGridView1.Columns[2].HeaderText = "Calle";
                    dataGridView1.Columns[3].HeaderText = "Calle";

                    //estás líneas ajustan automáticamente el tamaño de las columnas y filas del control DataGridView, así como la fuente
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11);
                }


            }

        }
    }
}
