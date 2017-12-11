using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class Form1 : Form
    {
        Bitmap bitMap;
        int[,] anh;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int[] mau = new int[16000];
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                bitMap = new Bitmap(openFile.FileName);

                pictureBox1.Image = bitMap;
            }
            pictureBox2.Image = TaoAnhXam(bitMap);
            TaoAnhDT();
        }
        public double TinhPhanThieu()
        {
            double dolon = Math.Round(((double)kichthuoc/68793)*100,2);
            return dolon;
        }
        unsafe
        private Bitmap TaoAnhXam(Bitmap bM)
        {
            Bitmap tg = bM.Clone(new Rectangle(0,0,bM.Width,bM.Height),bM.PixelFormat);
            anh = new int[bM.Width, bM.Height];
            //Bước 1
            BitmapData bitmapData = tg.LockBits(new Rectangle(0, 0, tg.Width, tg.Height), ImageLockMode.ReadOnly, tg.PixelFormat);

            //Bước 2: Tính offSet
            int offSet = bitmapData.Stride - tg.Width * 3;

            byte* p = (byte*)bitmapData.Scan0;

            for (int i = 0; i < tg.Width; i++)
            {
                for (int j = 0; j < tg.Height; j++)
                {

                    int t = (p[0] + p[1] + p[2]) / 3;

                    p[0] = (byte)t;

                    p[1] = (byte)t;

                    p[2] = (byte)t;

                    anh[i, j] = t;

                    p += 3;
                }

                p += offSet;

            }
            tg.UnlockBits(bitmapData);
            return tg;
        }
        
        int kichthuoc = 0;
        unsafe
        private int[,] PhanNguongTuDong(int[,] anhtg)
        {
            int maxg = 0;
            int[,] anhmoi = new int[bitMap.Width, bitMap.Height];
            //anhtg = new int[5, 6]{ {0,1,2,3,4,5 },{ 0, 0, 1, 2, 3, 4 },{ 0, 0,0,1, 2, 3 },{ 0,0,0,0, 1, 2 },{ 0, 0,0,0,0, 1 } };
            float[] hg = new float[256];
            float[] tg = new float[256];
            float[] ghg = new float[256];
            float[] ihi = new float[256];
            float[] mg = new float[256];
            float[] fg = new float[256];

            for (int i = 0; i < bitMap.Width; i++)
            {
                for (int j = 0; j < bitMap.Height; j++)
                {
                    hg[anhtg[i, j]]++;
                    if (maxg < anhtg[i, j])
                        maxg = anhtg[i, j];
                }
            }
            float max = -1;
            int nguong = 0;
            tg[0] = hg[0];
            for (int i = 1; i <= maxg; i++)
            {
                tg[i] = tg[i - 1] + hg[i];
                ghg[i] = i * hg[i];
                ihi[i] = ihi[i - 1] + ghg[i];
                if (tg[i] == 0)
                    mg[i] = 0;
                else
                    mg[i] =(float) ((float)(1 / tg[i]) * ihi[i]);
            }
            for (int i = 0; i < maxg; i++)
            {
                fg[i] = (tg[i] / ((bitMap.Width * bitMap.Height)-tg[i])) * (float)Math.Pow(mg[i] - mg[maxg], 2);
                if (max < fg[i])
                {
                    max = fg[i];
                    nguong = i;
                }
            }
            for (int i = 0; i < bitMap.Width; i++)
            {
                for (int j = 0; j < bitMap.Height; j++)
                {
                    if (anhtg[i, j] < nguong)
                    {
                        anhmoi[i, j] = 0;
                        kichthuoc++;
                    }
                    else
                    {
                        anhmoi[i, j] = 255;
                        
                    }
                }
            }
            return anhmoi;

        }
        unsafe
        public void TaoAnhDT()
        {
            kichthuoc = 0;
            int[,] anh1 = PhanNguongTuDong(anh);

            Bitmap tg = TaoAnhXam((Bitmap)bitMap.Clone());

            //Bước 1
            BitmapData bitmapData = tg.LockBits(new Rectangle(0, 0, tg.Width, tg.Height), ImageLockMode.ReadOnly, tg.PixelFormat);

            //Bước 2: Tính offSet
            int offSet = bitmapData.Stride - tg.Width * 3;

            byte* p = (byte*)bitmapData.Scan0;

            for (int i = 0; i < tg.Width; i++)
            {
                for (int j = 0; j < tg.Height; j++)
                {
                    p[0] = (byte)anh1[i, j];

                    p[1] = (byte)anh1[i, j];

                    p[2] = (byte)anh1[i, j];

                    p += 3;
                }

                p += offSet;

            }
            tg.UnlockBits(bitmapData);
            pictureBox2.Image = tg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double tong = DemMau(bitMap) + other;
            double tilechay =Math.Round((DemMau(bitMap) / tong) * 100,1);
            double tilekchay = Math.Round((other / tong) * 100,1);
            MessageBox.Show("Tỉ lệ cháy: "+tilechay+"\nĐộ lớn: "+TinhPhanThieu(),"Kết Quả",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        unsafe
        public double DemMau(Bitmap bt)
        {
            double dem = 0;
            white = 0;
            other = 0;
            for (int i = 0; i < bt.Width; i++)
            {
                for (int j = 0; j < bt.Height; j++)
                {
                    Color c = bt.GetPixel(i,j);
                    if (BiChay(c))
                    {
                        dem++;
                    }
                }
            }
            
            return dem;
        }
        double white;
        double other;
        public bool BiChay(Color c)
        {
            int r = c.R;
            int g = c.G;
            int b = c.B;
            if ( r== 255 && g == 255 && b == 255)
            {
                white++;
                return false;
            }
            if(r>=0 && r < 120)
            {
                if(g>= 0 && g< 70)
                {
                    if(b>=0 && b< 45)
                    {
                        return true;
                    }
                }
            }
            other++;
            return false;
        }
        public void LoadData()
        {
            List<LuatMau> LiLuat = new List<LuatMau>();
            try
            {
                StreamReader rd = new StreamReader("Luat.txt");
                while(rd.ReadLine()!=null)
                {
                    String[] lineData = rd.ReadLine().Split(' ');
                    String Ten = lineData[0];
                    float DoLon = float.Parse(lineData[1]);
                    float DoChay = float.Parse(lineData[2]);
                    int Lop = int.Parse(lineData[3]);
                    LuatMau l = new LuatMau(Ten,DoLon,DoChay,Lop);
                    LiLuat.Add(l);
                }
                rd.Close();
                dataGridView1.DataSource = LiLuat;
            }
            catch
            {
                if(MessageBox.Show("File không tồn tại!", "Cảnh báo!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error).ToString() == "Retry")
                {
                    LoadData();
                }
            }
        }
    }
}
