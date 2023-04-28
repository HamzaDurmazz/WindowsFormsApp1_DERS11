using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1_EF02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TelRehberiEntities db = new TelRehberiEntities();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetirDeGetirelim();
        }

        private void GetirDeGetirelim()
        {
            dataGridView1.DataSource = db.Kisiler.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1.yol // parametre ile bir şey gönderileceği zaman ilk yolu kullanırız

            //Kisiler yeniKisi = new Kisiler();
            //yeniKisi.KisiAdi = textBox1.Text;
            //yeniKisi.KisiSoyadi = textBox2.Text;
            //yeniKisi.TelNo = textBox3.Text;
            //db.Kisiler.Add(yeniKisi);
            //db.SaveChanges();
            //GetirDeGetirelim();

            //2.Yol >>>>>>>>>>// parametresiz bir şey göndereceğimiz zaman 2.yolu
            //Kisiler yeniKisi = new Kisiler
            //{
            //    KisiAdi = textBox1.Text,
            //    KisiSoyadi = textBox2.Text,
            //    TelNo = textBox3.Text

            //};
            //db.Kisiler.Add(yeniKisi);
            //db.SaveChanges();
            //GetirDeGetirelim();

            //3.Yol // buda parametresiz

            db.Kisiler.Add
                (
                new Kisiler
                {
                    KisiAdi = textBox1.Text,
                    KisiSoyadi = textBox2.Text,
                    TelNo = textBox3.Text
                }
                );
            db.SaveChanges();
            GetirDeGetirelim();
            temizle();
        }
        Kisiler secili;
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                secili = db.Kisiler.Find(id);
                textBox1.Text = secili.KisiAdi;
                textBox2.Text = secili.KisiSoyadi;
                textBox3.Text = secili.TelNo;
            }

        }

        private void temizle()
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secili.KisiAdi = textBox1.Text;
            secili.KisiSoyadi = textBox1.Text;
            secili.TelNo = textBox1.Text;
            db.SaveChanges();
            GetirDeGetirelim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int id = (int)dataGridView1.Rows[0].Cells[0].Value;

          //  db.Kisiler.Remove(db.Kisiler.Find(id));
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Kisiler.Where(k=>k.KisiAdi.Contains(textBox4.Text)).ToList();
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            db.SaveChanges();//tab tuşuna basınca guncelleme yapıyor veritabanında
        }
    }
}
