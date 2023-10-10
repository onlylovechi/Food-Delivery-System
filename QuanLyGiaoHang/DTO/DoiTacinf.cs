using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 internal class DoiTacInf{
    private string iD;
    private string type;
    private string diachi;
    private string tencuahang;
    private string chinhanh;
    public string ID { get => iD; set => iD = value; }
    public string Type { get => type; set => type = value; }
    public string Diachi { get => diachi; set => diachi = value; }
    public string Tencuahang { get => tencuahang; set => tencuahang = value; }
    public string Chinhanh { get => chinhanh; set => chinhanh = value; }
    public DoiTacInf() { }
    public DoiTacInf(DataRow row)
    {
        this.ID = row["MaDT"].ToString();
        this.Type=row["LoaiAmThuc"].ToString();
        this.Diachi = row["DiaChi"].ToString();
        this.Tencuahang = row["TenCuaHang"].ToString();
        this.Chinhanh = row["MaCN"].ToString();
    }
}