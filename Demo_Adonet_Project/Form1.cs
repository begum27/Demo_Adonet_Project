using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo_Adonet_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Data Source = DESKTOP - GSJF6OR; Initial Catalog = SQL_Çalışmaları; Integrated Security = True

        private void btn_List_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GSJF6OR;Initial Catalog=SQL_Çalışmaları;Integrated Security=True");

            //data source= uzaktan veri tabanında bu kısma IP adresi yazılır. Biz SQL servername'i copy-paste yaptık
            //İnitialCatalog kısmı veri tabanı demek
            //İntegrated Security uzaktan bağlanma durumunda kullanıcı adı şifre yazılır burda.
                // bizde ise güvenlik kontrolü gibiuzaktan bağlanmadığımız için true-false yazdık.
            
            connection.Open();

            SqlCommand command = new SqlCommand("Select*from TblCategory",connection); 
            //Sorgu connectiondaki veritabanında çalışacak ondan dolayı connection diye 2. parametre oluşturduk
            // SqlCommand komut yazacağımı bir sınıf. ("") bu araya veriyi çekmemizi sağlayan komutu yazıyoruz.

            SqlDataAdapter adapter = new SqlDataAdapter(command);  //sqlDataAdapter sınıfı Datagriw'e veri çekmek için kullanılır


            DataTable datatable = new DataTable(); //Sanal tablo oluşturduk

            adapter.Fill(datatable);    // sanal tabloya adapter üzerindeki veriyi attık

            dtgCategory.DataSource= datatable;  // sanal tablodan da oluşturan datagrid nesnesine yolladık

            connection.Close();

            //1.command nesnesi ile ("") içine yazdığımız komut ile veriyi aldık ve üzerine atatık
            //2. command üzerindeki veriyi datagriw'e veri çekmemizi sağlayan SqlDataAdapter sınıfından türettiğimiz adapter nesnesine attık.
            //3. sanal tablo ürettik nesne olarak
            //4. sanal tabloya adapter üzerindeki veriyi atadık
            // 5. sanal tablodaki veriyi oluşturduğumuz datagrid'e yolladıkkkkk
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GSJF6OR;Initial Catalog=SQL_Çalışmaları;Integrated Security=True");
            
            connection.Open();

            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);

            command.Parameters.AddWithValue("@p1",( txt_CategoryName.Text)); 

            command.ExecuteNonQuery();   //Sorgunun çalıştırılıp SQl'de kaydedilmesini sağlıyor.
                                           // bunu yazmaksak işlem veri tababnına yansımaz. işlem silindi der örneğin ama silinmez.
                                           // SQl de de sonuç göremeyiz yazmazsak.

            connection.Close();

            MessageBox.Show("kategori başarılı şekilde eklendi");

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GSJF6OR;Initial Catalog=SQL_Çalışmaları;Integrated Security=True");

            connection.Open();

            SqlCommand command = new SqlCommand("Delete from TblCategory Where CategoryID=@p1", connection);

            command.Parameters.AddWithValue("@p1", txt_CategoryID.Text);
            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("kategori başarılı şekilde silindi");

            //birden fazla tabloda kullandığın şeyse sileceğin ID silemezsin.

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GSJF6OR;Initial Catalog=SQL_Çalışmaları;Integrated Security=True");

            connection.Open();

            SqlCommand command = new SqlCommand("Update TblCategory Set CategoryName=@p1 where CategoryID=@p2", connection);

            command.Parameters.AddWithValue("@p1", txt_CategoryName.Text);
            command.Parameters.AddWithValue("@p2", txt_CategoryID.Text);

            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Kategori Başarılı Şekilde güncellendi");

        }
    }
}
