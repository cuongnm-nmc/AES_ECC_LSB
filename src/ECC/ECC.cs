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
using System.IO;

using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Crypto.EC;

namespace ECC
{
    public partial class ECC : Form
    {
        public ECC()
        {
            InitializeComponent();
        }
        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        X9ECParameters prms = NistNamedCurves.GetByOid(SecObjectIdentifiers.SecP256k1);
        BigInteger privateKey;
        Org.BouncyCastle.Math.EC.ECPoint publicKey;

        private void encrypt_Click(object sender, EventArgs e)
        {
            if(pb.Text == String.Empty)
            {
                MessageBox.Show("Please enter the public key elements!");
                return;
            }
            // Convert message to point
            Org.BouncyCastle.Math.EC.ECPoint M = ConvertString2Point();
            if (M == null)
            {
                MessageBox.Show("Cannot convert string to point on curve :(");
                return;
            }
            string[] publicKeys = pb.Text.Trim().Split('\n');
            BigInteger x = new BigInteger(publicKeys[0].Trim(), 16);
            BigInteger y = new BigInteger(publicKeys[1].Trim(), 16);
            publicKey = prms.Curve.CreatePoint(x, y);

            Org.BouncyCastle.Math.EC.ECPoint G = prms.G;
            byte[] k = new byte[32];
            BigInteger K; // k for step 1, 2 , 3
            BigInteger max = prms.N.Subtract(BigInteger.One);
            do // Step 1 //
            {
                rng.GetBytes(k);
                K = new BigInteger(k);
            } while (K.CompareTo(BigInteger.One) <= 0 || K.CompareTo(max) > 0);

            // Step 2 // CT1 = k * G
            Org.BouncyCastle.Math.EC.ECPoint CT1 = G.Multiply(K).Normalize();

            // Step 3// CT2 = M + k * Pu
            Org.BouncyCastle.Math.EC.ECPoint CT2 = publicKey.Multiply(K).Normalize();
            CT2 = CT2.Add(M).Normalize();

            output.Text = CT1.XCoord + "\n" + CT1.YCoord + "\n" + CT2.XCoord+ "\n" + CT2.YCoord;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(fs);

            sw.Write(output.Text);
            sw.Close();
        }

        private void generateK_Click(object sender, EventArgs e)
        {
            byte[] privateK = new byte[32];
            
            do
            {
                rng.GetBytes(privateK);
                privateKey = new BigInteger(privateK);
            } while (privateKey.CompareTo(BigInteger.Zero) <= 0);
            
            pr.Text = privateKey.ToString();

            Org.BouncyCastle.Math.EC.ECPoint G = prms.G;
            //baseP.Text = G.XCoord + "\n" + G.YCoord;

            publicKey = G.Multiply(privateKey).Normalize();
            //pb.Text = publicKey.XCoord + "\n" + publicKey.YCoord;
            pb.Text = publicKey.AffineXCoord + "\n" + publicKey.AffineYCoord;
        }


        Org.BouncyCastle.Math.EC.ECPoint ConvertString2Point()
        {
            ECFieldElement a = prms.Curve.A;
            ECFieldElement b = prms.Curve.B;
            if(input.Text == String.Empty)
            {
                MessageBox.Show("Please enter the 256-bit AES key! Thank you.");
                return null;
            }    
            BigInteger x = new BigInteger(input.Text.Trim(), 16);
            ECFieldElement xp = prms.Curve.FromBigInteger(x);

            // Compute y = sqrt(x^3 + ax + b) 
            ECFieldElement yp = xp.Multiply(xp).Multiply(xp); // x^3
            yp = yp.Add(a.Multiply(xp)); // + ax
            yp = yp.Add(b); // + b
            yp = yp.Sqrt(); // sqrt(y^2)
            if (yp == null)
            {
                return null;
            }
            else
            {
                // Create point M
                Org.BouncyCastle.Math.EC.ECPoint M = prms.Curve.CreatePoint(xp.ToBigInteger(), yp.ToBigInteger());
                return M;
            }
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            if(pr.Text == String.Empty)
            {
                MessageBox.Show("Please enter the private key exponent.");
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            output.Text = sr.ReadToEnd();
            fs.Close();

            privateKey = new BigInteger(pr.Text.Trim());
            string[] input = output.Text.Trim().Split('\n');

            BigInteger x = new BigInteger(input[0].Trim(), 16);
            BigInteger y = new BigInteger(input[1].Trim(), 16);
            Org.BouncyCastle.Math.EC.ECPoint CT1 = prms.Curve.CreatePoint(x, y);

            x = new BigInteger(input[2].Trim(), 16);
            y = new BigInteger(input[3].Trim(), 16);
            Org.BouncyCastle.Math.EC.ECPoint CT2 = prms.Curve.CreatePoint(x, y);

            Org.BouncyCastle.Math.EC.ECPoint temp = CT1.Multiply(privateKey).Normalize();
            Org.BouncyCastle.Math.EC.ECPoint M = CT2.Subtract(temp).Normalize();
            plain.Text = M.XCoord.ToString().ToUpper();

        }
    }
}
