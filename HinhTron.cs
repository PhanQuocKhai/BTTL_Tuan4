using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTL_Tuan4
{
    class HinhTron
    {
        private ToaDo _tam;
        public ToaDo Tam
        {
            get { return _tam; }
            set { _tam = value; }
        }
        private double banKinh;
        public double BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }
        public HinhTron()
        {
            this.Tam = new ToaDo();
            BanKinh = 0;
        }
        public HinhTron(ToaDo t, double bk)
        {
            this.Tam = t;
            this.Tam.X = t.X;
            this.Tam.Y = t.Y;
            this.Tam.Ten = t.Ten;
            this.BanKinh = bk;
        }
        public double ChuVi()
        {
            return BanKinh * 2 * 3.14;
        }
        public double DienTich()
        {
            return BanKinh * BanKinh * 3.14;
        }

    }
}