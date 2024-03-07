using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.IO;

namespace CloudDataSecurity2
{
    public partial class btnOpen : Form
    {
        public btnOpen()
        {
            InitializeComponent();           
            txbKey_encrypt.Text = "456976CE4C01ADF1A7C24362606D272EE0AE1500C5F851312BB4730920B02EE6";
            CheckForIllegalCrossThreadCalls = false;
        }
        //Hàm này tạo ra một salt ngẫu nhiên.
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    // Thêm các giá trị random vào mảng byte 
                    rng.GetBytes(data);
                }
            }

            return data;
        }

        /// Mã hóa File với mật khẩu  
        private void FileEncrypt(string inputFile, string password)
        {
          
            //Tạo  salt ngẫu nhiên
            byte[] salt = GenerateRandomSalt();

          
            //Tạo file để lưu dữ liệu sau khi đã mã hóa
            FileStream fsCrypt = new FileStream(inputFile + ".aes", FileMode.Create);


            //Chuyển đổi key từ string sang mảng byte
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            //Tạo đối tượng sử dụng thuật toán mã hóa đối xứng là Rijndael (AES)
            RijndaelManaged AES = new RijndaelManaged();

            //độ dài khóa
            AES.KeySize = 256;

            //độ dài của block
            AES.BlockSize = 128;

            //kiểu đệm
            AES.Padding = PaddingMode.PKCS7;

                      
            // Tạo key mới bằng cách sử dụng : salt , key người dùng nhập vào và số lần lặp
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);


            // set key và iv của thuật toán dưới dạng byte
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            //Chế độ mã hóa
            AES.Mode = CipherMode.CFB;



            //Thêm salt vào đầu của file output để nó có thể tạo sự ngẫu nhiên 
            fsCrypt.Write(salt, 0, salt.Length);


            // Khởi tạo một đối tượng (CryptoStream) để xử lý (mả hóa) dữ liệu và ghi dữ liệu đó vào "fsCrypt"
            // fsCrypt: chứa các byte đã được mã hóa
            // AES.CreateEncryptor() : đối tượng dùng để mã hóa 
            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            // File dùng cần được mã hóa
            FileStream fsIn = new FileStream(inputFile, FileMode.Open);


            // Tạo buffer 1mb để lưu trữ dữ liệu được mã hóa và phân bổ trong bộ nhớ thay vì toàn bộ file
            byte[] buffer = new byte[1048576];

            int read;

            try
            {
                // đọc dữ liệu "đầu vào" và ghi vào buffer
                // trả về 0 nếu đã đọc hết
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    // làm mới "fsIn" mỗi khi đọc
                    Application.DoEvents();

                    // ghi buffer vào luồng "cs" (CryptoStream) và cs sẽ mã hóa dữ liệu từ buffer
                    cs.Write(buffer, 0, read);
                }

                // đóng luồng "input"
                fsIn.Close();
            }
            // Hiển thị lỗi nếu có
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                
            }
            finally
            {
                // đóng luồng (CryptoStream) , (FileStream) và giải phóng tài nguyên
                cs.Close();
                fsCrypt.Close();
            }
        }

      
        /// Giải mã File với mật khẩu
        private void FileDecrypt(string inputFile, string outputFile, string password)
        {
            // Chuyển key từ string sang chuội byte để xử lý 
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            // tạo mảng salt 32 bytes
            byte[] salt = new byte[32];

            // File cần đc giải mã
            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

            // đọc dữ liệu từ "fsCrypt" và ghi vào "salt"
            fsCrypt.Read(salt, 0, salt.Length);

            //Tạo đối tượng sử dụng thuật toán mã hóa đối xứng là Rijndael (AES)
            RijndaelManaged AES = new RijndaelManaged();

            // độ dài key
            AES.KeySize = 256;

            //độ dài block
            AES.BlockSize = 128;

            // Tạo key mới bằng cách sử dụng : salt , key người dùng nhập vào và số lần lặp
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);

            // set key và iv của thuật toán dưới dạng byte
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            // chế độ đệm
            //AES.Padding = PaddingMode.PKCS7;

            //chế độ giải mã
            AES.Mode = CipherMode.CFB;

            // Khởi tạo một đối tượng (CryptoStream) để xử lý (giải mã) dữ liệu
            // fsCrypt : chứa dữ liệu cần giải mã
            // AES.CreateEncryptor() : đối tượng dùng để giải mã
            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.OpenOrCreate,FileAccess.ReadWrite);

            int read;
            byte[] buffer = new byte[1048576];

            try
            {
                // đọc dữ liệu "đầu vào" , cs sẽ giải mã và ghi vào buffer
                // = 0 nếu đọc hết
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    // làm mới "cs"
                    Application.DoEvents();
                    //ghi dữ liệu từ buffer vào "fsOut"
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                MessageBox.Show("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                // đóng luồng giải mã dữ liệu
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                // đóng luồng ghi dữ liệu đc giải mã và luồng chứa dữ liệu cần đc giải mã
                fsOut.Close();
                fsCrypt.Close();
            }
        }

        
        // NHẤN ĐỂ GIẢI MÃ
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //Mở File để giải mã
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Đã chọn được file ! ");
            }

            string key = txbKey_decrypt.Text;
          
            // Giải mã
            FileDecrypt(openFileDialog.FileName, txbPathToSaveDecryptedFile.Text, key);

            MessageBox.Show("Giải mà thành công ! ");

            // Example
            // FileDecrypt(@"C:\Users\sdkca\Desktop\example.doc.aes",
            // @"C:\Users\sdkca\Desktop\example_decrypted.doc", password);
        }

        //NHẤN ĐỂ MÃ HÓA
        private void btnSelectFileToEncrypt_Click(object sender, EventArgs e)
        {
            // Mở File để mã hóa
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Chọn file thành công !");
            }

            txbPathToEncrypt.Text = openFileDialog.FileName;
            string key = txbKey_encrypt.Text;
           
            //Mã hóa
            FileEncrypt(openFileDialog.FileName, key);
            MessageBox.Show("Mã hóa thành công ! ");
        }

        private void btnOpen_Load(object sender, EventArgs e)
        {

        }

        private void btnSHA256_Click(object sender, EventArgs e)
        {
            // dùng hash 256 để chuyển key nhập vào thành key mới 256 bit
            SHA256 mySHA256 = SHA256Managed.Create();

            //băm key mà người dùng nhập vào
            byte[] key2 = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(txbKey_encrypt.Text));

            // hiển thị lên textbox
            txb256bit.Text = StringToBinary(txbKey_encrypt.Text);
        }

        // hàm chuyển dạng từ string sang binary
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create sha256 hash
            // Tạo hàm băm password thành 256 bit : 32 bytes
            SHA256 mySHA256 = SHA256Managed.Create();
            //băm key mà người dùng nhập vào
            byte[] key2 = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(txbKey_decrypt.Text));

            // chuyễn nó sang string
            string str = System.Text.Encoding.UTF8.GetString(key2);

            // hiển thị lên textbox
            txb256.Text = str;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
