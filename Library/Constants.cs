namespace VietNamQRPay;

#region BANK INFORMATION
public static class BankNameMapping
{
    public static readonly Dictionary<string, string> Mapping = new()
    {
        { BankCode.ABBANK, "Ngân hàng TMCP An Bình" },
        { BankCode.ACB, "Ngân hàng TMCP Á Châu" },
        { BankCode.AGRIBANK, "Ngân hàng Nông nghiệp và Phát triển Nông thôn Việt Nam" },
        { BankCode.BAC_A_BANK, "Ngân hàng TMCP Bắc Á" },
        { BankCode.BAOVIET_BANK, "Ngân hàng TMCP Bảo Việt" },
        { BankCode.BANVIET, "Ngân hàng TMCP Bản Việt" },
        { BankCode.BIDC, "Ngân hàng Đầu tư và Phát triển Campuchia" },
        { BankCode.BIDV, "Ngân hàng TMCP Đầu tư và Phát triển Việt Nam" },
        { BankCode.CAKE, "Ngân hàng số Cake by VPBank" },
        { BankCode.CBBANK, "Ngân hàng Xây dựng Việt Nam" },
        { BankCode.CIMB, "Ngân hàng CIMB Việt Nam" },
        { BankCode.COOP_BANK, "Ngân hàng Hợp tác xã Việt Nam" },
        { BankCode.DBS_BANK, "Ngân hàng DBS" },
        { BankCode.DONG_A_BANK, "Ngân hàng TMCP Đông Á" },
        { BankCode.EXIMBANK, "Ngân hàng TMCP Xuất Nhập Khẩu Việt Nam" },
        { BankCode.GPBANK, "Ngân hàng TMCP Dầu Khí Toàn Cầu" },
        { BankCode.HDBANK, "Ngân hàng TMCP Phát triển TP.HCM" },
        { BankCode.HONGLEONG_BANK, "Ngân hàng Hong Leong Việt Nam" },
        { BankCode.HSBC, "Ngân hàng TNHH Một Thành Viên HSBC Việt Nam" },
        { BankCode.IBK_HCM, "Ngân hàng Công nghiệp Hàn Quốc - Chi nhánh TP.HCM" },
        { BankCode.IBK_HN, "Ngân hàng Công nghiệp Hàn Quốc - Chi nhánh Hà Nội" },
        { BankCode.INDOVINA_BANK, "Ngân hàng TNHH Indovina" },
        { BankCode.KASIKORN_BANK, "Ngân hàng Kasikorn Thái Lan" },
        { BankCode.KIENLONG_BANK, "Ngân hàng TMCP Kiên Long" },
        { BankCode.KOOKMIN_BANK_HCM, "Ngân hàng Kookmin - Chi nhánh TP.HCM" },
        { BankCode.KOOKMIN_BANK_HN, "Ngân hàng Kookmin - Chi nhánh Hà Nội" },
        { BankCode.LIENVIETPOST_BANK, "Ngân hàng TMCP Bưu Điện Liên Việt" },
        { BankCode.MBBANK, "Ngân hàng TMCP Quân Đội" },
        { BankCode.MSB, "Ngân hàng TMCP Hàng Hải Việt Nam" },
        { BankCode.NAM_A_BANK, "Ngân hàng TMCP Nam Á" },
        { BankCode.NCB, "Ngân hàng TMCP Quốc Dân" },
        { BankCode.NONGHYUP_BANK_HN, "Ngân hàng NongHyup - Chi nhánh Hà Nội" },
        { BankCode.OCB, "Ngân hàng TMCP Phương Đông" },
        { BankCode.OCEANBANK, "Ngân hàng TM TNHH Một Thành Viên Đại Dương" },
        { BankCode.PGBANK, "Ngân hàng TMCP Xăng Dầu Petrolimex" },
        { BankCode.PUBLIC_BANK, "Ngân hàng Public Bank Việt Nam" },
        { BankCode.PVCOM_BANK, "Ngân hàng TMCP Đại Chúng Việt Nam" },
        { BankCode.SACOMBANK, "Ngân hàng TMCP Sài Gòn Thương Tín" },
        { BankCode.SAIGONBANK, "Ngân hàng TMCP Sài Gòn Công Thương" },
        { BankCode.SCB, "Ngân hàng TMCP Sài Gòn" },
        { BankCode.SEA_BANK, "Ngân hàng TMCP Đông Nam Á" },
        { BankCode.SHB, "Ngân hàng TMCP Sài Gòn - Hà Nội" },
        { BankCode.SHINHAN_BANK, "Ngân hàng Shinhan Việt Nam" },
        { BankCode.STANDARD_CHARTERED_BANK, "Ngân hàng Standard Chartered Việt Nam" },
        { BankCode.TECHCOMBANK, "Ngân hàng TMCP Kỹ Thương Việt Nam" },
        { BankCode.TIMO, "Ngân hàng số Timo" },
        { BankCode.TPBANK, "Ngân hàng TMCP Tiên Phong" },
        { BankCode.UBANK, "Ngân hàng số Ubank by VPBank" },
        { BankCode.UNITED_OVERSEAS_BANK, "Ngân hàng United Overseas Bank Việt Nam" },
        { BankCode.VIB, "Ngân hàng TMCP Quốc tế Việt Nam" },
        { BankCode.VIET_A_BANK, "Ngân hàng TMCP Việt Á" },
        { BankCode.VIET_BANK, "Ngân hàng TMCP Việt Nam Thương Tín" },
        { BankCode.VIETCOMBANK, "Ngân hàng TMCP Ngoại Thương Việt Nam" },
        { BankCode.VIETINBANK, "Ngân hàng TMCP Công Thương Việt Nam" },
        { BankCode.VPBANK, "Ngân hàng TMCP Việt Nam Thịnh Vượng" },
        { BankCode.VRB, "Ngân hàng Liên doanh Việt - Nga" },
        { BankCode.WOORI_BANK, "Ngân hàng Woori Việt Nam" }
    };
}

/// <summary>
/// Thông tin ngân hàng
/// </summary>
/// <param name="id"></param>
/// <param name="name"></param>
/// <param name="key"></param>
/// <param name="type"></param>
/// <param name="bin"></param>
/// <param name="shortName"></param>
/// <param name="code"></param>
/// <param name="bankLogo"></param>
public class BankInformation(int id, string name, string key, int type, string bin, string shortName, string code, string bankLogo)
{
    /// <summary>
    /// Id ngân hàng
    /// </summary>
    public int Id { get; set; } = id;

    /// <summary>
    /// Tên ngân hàng
    /// </summary>
    public string Name { get; set; } = name;

    /// <summary>
    /// Key ngân hàng
    /// </summary>
    public string Key { get; set; } = key;

    /// <summary>
    /// Mã BIN của ngân hàng
    /// </summary>
    public string Bin { get; set; } = bin;

    /// <summary>
    /// Loại ngân hàng
    /// </summary>
    public int Type { get; set; } = type;

    /// <summary>
    /// Mã ngân hàng
    /// </summary>
    public string Code { get; set; } = code;

    /// <summary>
    /// Tên viết tắt của ngân hàng
    /// </summary>
    public string ShortName { get; set; } = shortName;

    /// <summary>
    /// Logo ngân hàng
    /// </summary>
    public string BankLogo { get; set; } = bankLogo;

    /// <summary>
    /// Chuyển đổi thông tin ngân hàng sang chuỗi
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Key: {Key}, Type: {Type}, Bin: {Bin}, ShortName: {ShortName}, Code: {Code}";
    }
}

public static class BankMapping
{
    public static readonly List<BankInformation> Banks =
    [
        new BankInformation(33,"Ngân hàng TMCP Sài Gòn Thương Tín","Sacombank",2,"970403","SACOMBANK","STB","https://cdn.topi.vn/bank/ae570768b9d096b09482627251098017.png"),
        new BankInformation(7,"Ngân hàng TNHH MTV CIMB Việt Nam","CIMB",1,"422589","CIMBBANK","CIMB","https://cdn.topi.vn/bank/787e675f1747d4d6acc873b7d6d7ce8b.png"),
        new BankInformation(65,"Ngân hàng TNHH MTV Public Việt Nam","PublicBank",2,"970439","PBVN","PBVN","https://cdn.topi.vn/bank/88c8dc8d65cc9839e8cbaf10d5b7e20c.png"),
        new BankInformation(75,"Ngân hàng TNHH MTV Standard Chartered Bank Việt Nam","StandardChartered",1,"970410","STANDARDCHARTERED","SCVN","https://cdn.topi.vn/bank/a029e8bd3a5d8613c7de2a0505e07128.png"),
        new BankInformation(35,"Ngân hàng TMCP Sài Gòn","SCB",1,"970429","SCB","SGB","https://cdn.topi.vn/bank/117fcc8d0b5ce254f6d7cd9d7cec4d8f.png"),
        new BankInformation(37,"Ngân hàng TMCP Đông Nam Á","SeABank",2,"970440","SEABANK","SEAV","https://cdn.topi.vn/bank/57266a3dcb4e1146c75e0799a3a7be85.png"),
        new BankInformation(11,"Ngân hàng TMCP Phát triển Thành phố Hồ Chí Minh","HDBank",2,"970437","HDBANK","HDB","https://cdn.topi.vn/bank/2c3baf04779a2f19706ab5721c82627f.png"),
        new BankInformation(28,"Ngân hàng Thương mại TNHH MTV Đại Dương","Oceanbank",2,"970414","OCEANBANK","OJB","https://cdn.topi.vn/bank/1c67d0604684ff247387d5086dd4cfe9.png"),
        new BankInformation(8,"Ngân hàng TMCP Đông Á","DongABank",1,"970406","DONGABANK","EAB","https://cdn.topi.vn/bank/02e0e5ce268b73c72672c396c53543e7.png"),
        new BankInformation(85,"Ngân hàng TNHH MTV Hong Leong Việt Nam","HongLeong",2,"970442","HONGLEONGBANK","HLOB","https://cdn.topi.vn/bank/c379c3c8afe27b4acc2392790b17ad55.png"),
        new BankInformation(52,"Ngân hàng Liên doanh Việt - Nga","VRB",2,"970421","VRB","VRB","https://cdn.topi.vn/bank/feba8c1e8ff401f988928554109b3f23.png"),
        new BankInformation(104,"DBS Bank Ltd","DBSBank",2,"796500","DBS","DBS","https://cdn.topi.vn/bank/0de2c51f77c99f0188c4698448949521.png"),
        new BankInformation(117,"Ngân hàng TMCP Sài Gòn Công Thương","SaigonBank",1,"970400","SAIGONBANK","SGCTB","https://cdn.topi.vn/bank/c312b71bf480943b6d874c9dd51f5895.png"),
        new BankInformation(24,"Ngân hàng TMCP Nam Á","NamABank",2,"970428","NAMABANK","NAB","https://cdn.topi.vn/bank/89c6b06d591bbb4da7d4cd69d88f3da4.png"),
        new BankInformation(18,"Ngân hàng TMCP Kiên Long","KienLongBank",2,"970452","KIENLONGBANK","KLB","https://cdn.topi.vn/bank/6f37efdc4162d09ac160dc0d2a894cbb.png"),
        new BankInformation(41,"Ngân hàng TMCP Kỹ thương Việt Nam","Techcombank",2,"970407","TECHCOMBANK","TCB","https://cdn.topi.vn/bank/b5ff0ad5eae704be1e17e27339742368.png"),
        new BankInformation(56,"Ngân hàng hợp tác CoopBank","CoopBank",2,"970446","COOPBANK","COOPBANK",""),
        new BankInformation(135,"Ngân hàng United Overseas - Chi nhánh TP. Hồ Chí Minh","UnitedOverseas",1,"970458","UOB","UOB","https://cdn.topi.vn/bank/ce7288f5be0a098961035829df74bc21.png"),
        new BankInformation(43,"Ngân hàng TMCP Quốc tế Việt Nam","VIB",2,"970441","VIB","VIB","https://cdn.topi.vn/bank/cbd66a299080023009fcae5961304953.png"),
        new BankInformation(10,"Ngân hàng Thương mại TNHH MTV Dầu Khí Toàn Cầu","GPBank",2,"970408","GPBANK","GPB","https://cdn.topi.vn/bank/62401d02e31aed3271955d7cfdee93f6.png"),
        new BankInformation(42,"Ngân hàng TMCP Tiên Phong","TPBank",2,"970423","TPBANK","TPB","https://cdn.topi.vn/bank/05a875d0b09336cc1e5aea37d4270fe5.png"),
        new BankInformation(20,"Ngân hàng TMCP Quân đội","MBBank",1,"970422","MB","MBB","https://cdn.topi.vn/bank/6878c6a4e96621f552a61645b12267da.png"),
        new BankInformation(51,"Ngân hàng TMCP Việt Nam Thịnh Vượng","VPBank",2,"970432","VPBANK","VPB","https://cdn.topi.vn/bank/501e22de70d42cea27b42290081b26b8.png"),
        new BankInformation(9,"Ngân hàng TMCP Xuất Nhập khẩu Việt Nam","Eximbank",2,"970431","EXIMBANK","EIB","https://cdn.topi.vn/bank/b3b25953da833e1b0c35b8f2288e4086.png"),
        new BankInformation(1,"Ngân hàng TMCP An Bình","ABBANK",2,"970425","ABBANK","ABB","https://cdn.topi.vn/bank/253b3a00a6fd9590250ac6a4e66fc596.png"),
        new BankInformation(4,"Ngân hàng TMCP Bắc Á","BacABank",2,"970409","BACABANK","BAB","https://cdn.topi.vn/bank/8b6f1fb8f9d2f4c8a9f1eee4f95fa00f.png"),
        new BankInformation(60,"Ngân hàng Công nghiệp Hàn Quốc - Chi nhánh Hà Nội","IBK-HN Bank",2,"970455","IBKHN","IBKHN","https://cdn.topi.vn/bank/0d041df4f8c35d46a2449f5b1a2bfb6d.png"),
        new BankInformation(45,"Ngân hàng TMCP Việt Á","VietABank",2,"970427","VIETABANK","VAB","https://cdn.topi.vn/bank/cbb7ccd6410fe9d6ab5de652b2e272ab.png"),
        new BankInformation(27,"OCB-Ngân Hàng Phương Đông","OCB",2,"970448","OCB","OCB","https://cdn.topi.vn/bank/212295c68b046e99a2dde40f36e36275.png"),
        new BankInformation(30,"Ngân hàng TMCP Xăng dầu Petrolimex","PGBank",2,"970430","PGBANK","PGB","https://cdn.topi.vn/bank/092ed22e91d46e2e6fc645427ef7320a.png"),
        new BankInformation(38,"Ngân hàng TMCP Sài Gòn - Hà Nội","SHB",2,"970443","SHB","SHB","https://cdn.topi.vn/bank/cc6fca524967d2599e1aee3971c3c24c.png"),
        new BankInformation(2,"Ngân hàng TMCP Á Châu","ACB",2,"970416","ACB","ACB","https://cdn.topi.vn/bank/7d9ebde0da26bb354668d1fd5c3510f3.png"),
        new BankInformation(3,"Ngân hàng Nông nghiệp và Phát triển Nông thôn Việt Nam","Agribank",1,"970405","AGRIBANK","AGR","https://cdn.topi.vn/bank/a6e64f6e2feaa1a438f676f76a1ff29c.png"),
        new BankInformation(23,"Ngân hàng TMCP Hàng Hải","MSB",2,"970426","MSB","MSB","https://cdn.topi.vn/bank/3f5825cc5cb42955bcbb7cad4c5a38df.png"),
        new BankInformation(72,"Ngân hàng TMCP Bản Việt","VietCapitalBank",2,"970454","BVBANK","BVB","https://cdn.topi.vn/bank/e2fdfbfb36bfecf5d706ba6076f72266.png"),
        new BankInformation(91,"Ngân hàng TNHH Indovina","IndovinaBank",2,"970434","IVB","IVB",""),
        new BankInformation(6,"Ngân hàng TMCP Đầu tư và Phát triển Việt Nam","BIDV",2,"970418","BIDV","BIDV","https://cdn.topi.vn/bank/e1c97fe428fdef389de4760b85841b6f.png"),
        new BankInformation(66,"Ngân hàng TNHH MTV Shinhan Việt Nam","ShinhanBank",1,"970424","SHINHANBANK","SHBVN","https://cdn.topi.vn/bank/86225e36ade8faa0cba7003113ab61ab.png"),
        new BankInformation(46,"Ngân hàng TMCP Việt Nam Thương Tín","VietBank",2,"970433","VIETBANK","VNB","https://cdn.topi.vn/bank/de6aae84478affb51483f3c578151e24.png"),
        new BankInformation(13,"Ngân hàng TNHH MTV HSBC (Việt Nam)","HSBC",2,"458761","HSBC","HSBC","https://cdn.topi.vn/bank/e21541c99909f50140e0bfb03a6a42e6.png"),
        new BankInformation(107,"Ngân hàng TMCP Quốc Dân","NCB",1,"970419","NCB","NCB","https://cdn.topi.vn/bank/f17e78dad29fe6cee462c4a5560466f5.png"),
        new BankInformation(53,"Ngân hàng TNHH MTV Woori Việt Nam","Woori",1,"970457","WOORIBANK","WOORIBANK","https://cdn.topi.vn/bank/bb6577a3670e0b19f2c98de016ca6537.png"),
        new BankInformation(130,"Ngân hàng Nonghyup - Chi nhánh Hà Nội","Nonghyup",1,"801011","NONGHYUP","NONGHYUP",""),
        new BankInformation(84,"Ngân hàng TMCP Bưu Điện Liên Việt","LienVietPostBank",2,"970449","LPBANK","LPB","https://cdn.topi.vn/bank/65dc820a119008f07ae1ba6d6d99c78b.png"),
        new BankInformation(49,"Ngân hàng TMCP Công thương Việt Nam","VietinBank",1,"970415","VIETINBANK","CTG","https://cdn.topi.vn/bank/8c94cf356e1599be1cce05a22d98f9a1.png"),
        new BankInformation(82,"Ngân hàng TMCP Bảo Việt","BaoVietBank",2,"970438","BAOVIETBANK","BAOVB","https://cdn.topi.vn/bank/9ee660af6024dfdcaf0c2c293013b4d2.png"),
        new BankInformation(32,"Ngân hàng TMCP Đại Chúng Việt Nam","PVcomBank",1,"970412","PVCOMBANK","PVcombank","https://cdn.topi.vn/bank/ed0b068cc8611a6fa1049492b2e766d3.png"),
        new BankInformation(48,"Ngân hàng TMCP Ngoại Thương Việt Nam","Vietcombank",2,"970436","VIETCOMBANK","VCB","https://cdn.topi.vn/bank/61b52abfeccb2fde1b835c56c10fd811.png"),
    ];
}
#endregion

#region BANK CODE
public static class BankCode
{
    public const string ABBANK = "ABB";
    public const string ACB = "ACB";
    public const string AGRIBANK = "AGRIBANK";
    public const string BAC_A_BANK = "BAB";
    public const string BAOVIET_BANK = "BAOVIETBANK";
    public const string BANVIET = "BVB";
    public const string BIDC = "BIDC";
    public const string BIDV = "BID";
    public const string CAKE = "CAKE";
    public const string CBBANK = "VNCB";
    public const string CIMB = "CIMB";
    public const string COOP_BANK = "COOPBANK";
    public const string DBS_BANK = "DBS";
    public const string DONG_A_BANK = "DONGABANK";
    public const string EXIMBANK = "EIB";
    public const string GPBANK = "GPBANK";
    public const string HDBANK = "HDB";
    public const string HONGLEONG_BANK = "HLB";
    public const string HSBC = "HSBC";
    public const string IBK_HCM = "IBKHCM";
    public const string IBK_HN = "IBKHN";
    public const string INDOVINA_BANK = "IVB";
    public const string KASIKORN_BANK = "KBANK";
    public const string KIENLONG_BANK = "KLB";
    public const string KOOKMIN_BANK_HCM = "KBHCM";
    public const string KOOKMIN_BANK_HN = "KBHN";
    public const string LIENVIETPOST_BANK = "LPB";
    public const string MBBANK = "MBB";
    public const string MSB = "MSB";
    public const string NAM_A_BANK = "NAB";
    public const string NCB = "NVB";
    public const string NONGHYUP_BANK_HN = "NONGHYUP";
    public const string OCB = "OCB";
    public const string OCEANBANK = "OCEANBANK";
    public const string PGBANK = "PGB";
    public const string PUBLIC_BANK = "PBVN";
    public const string PVCOM_BANK = "PVCOMBANK";
    public const string SACOMBANK = "STB";
    public const string SAIGONBANK = "SGB";
    public const string SCB = "SCB";
    public const string SEA_BANK = "SSB";
    public const string SHB = "SHB";
    public const string SHINHAN_BANK = "SVB";
    public const string STANDARD_CHARTERED_BANK = "SC";
    public const string TECHCOMBANK = "TCB";
    public const string TIMO = "TIMO";
    public const string TPBANK = "TPB";
    public const string UBANK = "UBANK";
    public const string UNITED_OVERSEAS_BANK = "UOB";
    public const string VIB = "VIB";
    public const string VIET_A_BANK = "VAB";
    public const string VIET_BANK = "VBB";
    public const string VIETCOMBANK = "VCB";
    public const string VIETINBANK = "CTG";
    public const string VPBANK = "VPB";
    public const string VRB = "VRB";
    public const string WOORI_BANK = "WRB";
}
#endregion

#region BANK KEY
public class BankKey
{
    public const string ABBANK = "abbank";
    public const string ACB = "acb";
    public const string AGRIBANK = "agribank";
    public const string BAC_A_BANK = "bacabank";
    public const string BAOVIET_BANK = "baoviet";
    public const string BANVIET = "banviet";
    public const string BIDC = "bidc";
    public const string BIDV = "bidv";
    public const string CAKE = "cake";
    public const string CBBANK = "cbbank";
    public const string CIMB = "cimb";
    public const string COOP_BANK = "coopbank";
    public const string DBS_BANK = "dbsbank";
    public const string DONG_A_BANK = "dongabank";
    public const string EXIMBANK = "eximbank";
    public const string GPBANK = "gpbank";
    public const string HDBANK = "hdbank";
    public const string HONGLEONG_BANK = "hongleongbank";
    public const string HSBC = "hsbc";
    public const string IBK_HCM = "ibkhcm";
    public const string IBK_HN = "ibkhn";
    public const string INDOVINA_BANK = "indovinabank";
    public const string KASIKORN_BANK = "kasikorn";
    public const string KIENLONG_BANK = "kienlongbank";
    public const string KOOKMIN_BANK_HCM = "kookminhcm";
    public const string KOOKMIN_BANK_HN = "kookminhn";
    public const string LIENVIETPOST_BANK = "lienvietpostbank";
    public const string MBBANK = "mbbank";
    public const string MSB = "msb";
    public const string NAM_A_BANK = "namabank";
    public const string NCB = "ncb";
    public const string NONGHYUP_BANK_HN = "nonghyup";
    public const string OCB = "ocb";
    public const string OCEANBANK = "oceanbank";
    public const string PGBANK = "pgbank";
    public const string PUBLIC_BANK = "publicbank";
    public const string PVCOM_BANK = "pvcombank";
    public const string SACOMBANK = "sacombank";
    public const string SAIGONBANK = "saigonbank";
    public const string SCB = "scb";
    public const string SEA_BANK = "seabank";
    public const string SHB = "shb";
    public const string SHINHAN_BANK = "shinhanbank";
    public const string STANDARD_CHARTERED_BANK = "standardcharteredbank";
    public const string TECHCOMBANK = "techcombank";
    public const string TIMO = "timo";
    public const string TPBANK = "tpbank";
    public const string UBANK = "ubank";
    public const string UNITED_OVERSEAS_BANK = "uob";
    public const string VIB = "vib";
    public const string VIET_A_BANK = "vietabank";
    public const string VIET_BANK = "vietbank";
    public const string VIETCOMBANK = "vietcombank";
    public const string VIETINBANK = "vietinbank";
    public const string VPBANK = "vpbank";
    public const string VRB = "vrb";
    public const string WOORI_BANK = "wooribank";
}
#endregion

#region BANK APPS
public class BankApp
{
    public string bank { get; set; }
    public string? scheme { get; set; }
    public string? packageId { get; set; }
    public string? appStoreId { get; set; }
    public bool supportVietQR { get; set; }
    public bool supportVNPayQR { get; set; }

    /// <summary>
    /// List app support VNPayQR deeplink https://sandbox.vnpayment.vn/apis/danh-sach-ngan-hang/
    /// </summary>
    public static IEnumerable<BankApp> BankApps = new List<BankApp> {
        new BankApp {
            bank= BankKey.ABBANK,
            scheme= "abbankmobile",
            packageId= "com.vnpay.abbank",
            appStoreId= "id1137160023",
            supportVietQR= true,
            supportVNPayQR= true
          },
        new BankApp {
        bank= BankKey.ACB,
        scheme= "acbapp",
        packageId= "mobile.acb.com.vn",
        appStoreId= "id950141024",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.AGRIBANK,
        scheme= "agribankmobile",
        packageId= "com.vnpay.Agribank3g",
        appStoreId= "id935944952",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.BAC_A_BANK,
        packageId= "com.bab.retailUAT",
        appStoreId= "id1441408786",
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.BAOVIET_BANK,
        scheme= "baovietmobile",
        packageId= "com.vnpay.bvbank",
        appStoreId= "id1504422967",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.BIDC,
        scheme= "bidcvnmobile",
        packageId= "com.vnpay.bidc",
        appStoreId= "id1043501726",
        supportVietQR= false,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.BIDV,
        scheme= "bidvsmartbanking",
        packageId= "com.vnpay.bidv",
        appStoreId= "id1061867449",
        supportVietQR= true,
        supportVNPayQR= true
        },

        new BankApp {
        bank= BankKey.CAKE,
        scheme= "cake.vn",
        packageId= "xyz.be.cake",
        appStoreId= "id1551907051",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.CBBANK,
        packageId= "cbbank.vn.mobile",
        appStoreId= "id1531443181",
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.CIMB,
        scheme= "cimb",
        packageId= "vn.cimbbank.octo",
        appStoreId= "id1318127958",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.COOP_BANK,
        scheme= "coopbankmobile",
        packageId= "com.vnpay.coopbank",
        appStoreId= "id1578445811",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.DBS_BANK,
        packageId= "com.dbs.sg.dbsmbanking",
        appStoreId= "id1068403826",
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.DONG_A_BANK,
        packageId= "com.dongabank.mobilenternet",
        appStoreId= "id993124125",
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.EXIMBANK,
        scheme= "eximbankmobile",
        packageId= "com.vnpay.eximbank",
        appStoreId= "id1242260338",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.GPBANK,
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.HDBANK,
        scheme= "hdbankmobile",
        packageId= "com.vnpay.hdbank",
        appStoreId= "id1461658565",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.HONGLEONG_BANK,
        packageId= "my.com.hongleongconnect.mobileconnect",
        appStoreId= "id1446719260",
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.HSBC,
        packageId= "vn.hsbc.hsbcvietnam",
        appStoreId= "id1472163155",
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.IBK_HCM,
        scheme= "ionebankglobal",
        packageId= "com.ibk.neobanking.mini",
        appStoreId= "id787064809",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.INDOVINA_BANK,
        scheme= "ivbmobilebanking",
        packageId= "com.vnpay.ivb",
        appStoreId= "id1096963960",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.KASIKORN_BANK,
        packageId= "com.kasikornbank.kplus.vn",
        appStoreId= "id1586576195",
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.KIENLONG_BANK,
        scheme= "kienlongbankmobilebanking",
        packageId= "com.sunshine.ksbank",
        appStoreId= "id1562823941",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.KOOKMIN_BANK_HCM,
        packageId= "com.kbstar.global",
        appStoreId= "id1542727700",
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.LIENVIETPOST_BANK,
        scheme= "lv24h",
        packageId= "vn.com.lpb.lienviet24h",
        appStoreId= "id1488794748",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.MBBANK,
        scheme= "mbmobile",
        packageId= "com.mbmobile",
        appStoreId= "id1205807363",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.MSB,
        scheme= "msbmobile",
        packageId= "vn.com.msb.smartBanking",
        appStoreId= "id436134873",
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.NAM_A_BANK,
        scheme= "deeplinkapp",
        packageId= "ops.namabank.com.vn",
        appStoreId= "id1456997296",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.NCB,
        scheme= "ncbizimobile",
        packageId= "com.ncb.bank",
        appStoreId= "id1465217154",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.NONGHYUP_BANK_HN,
        scheme= "newnhsmartbanking",
        packageId= "nh.smart.banking",
        appStoreId= "id1444712671",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.OCB,
        scheme= "omniapp",
        packageId= "com.ocb.omniextra",
        appStoreId= "id1358682577",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.OCEANBANK,
        scheme= "oceanbankmobilebanking",
        packageId= "com.vnpay.ocean",
        appStoreId= "id1469028843",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.PGBANK,
        packageId= "pgbankApp.pgbank.com.vn",
        appStoreId= "id1537765475",
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.PUBLIC_BANK,
        scheme= "publicbankmobile",
        packageId= "com.vnpay.publicbank",
        appStoreId= "id1573736472",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.PVCOM_BANK,
        scheme= "pvcombankapp",
        packageId= "com.vsii.pvcombank",
        appStoreId= "id957284067",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.SACOMBANK,
        scheme= "sacombankmobile",
        packageId= "src.com.sacombank",
        appStoreId= "id885814869",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.SAIGONBANK,
        scheme= "Sgbmobile",
        packageId= "com.vnpay.sgbank",
        appStoreId= "id1481832587",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.SCB,
        scheme= "scbmobilebanking",
        packageId= "com.vnpay.SCB",
        appStoreId= "id954973621",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.SEA_BANK,
        scheme= "seabankmobile",
        packageId= "vn.com.seabank.mb1",
        appStoreId= "id846407152",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.SHB,
        scheme= "shbmobile",
        packageId= "vn.shb.mbanking",
        appStoreId= "id538278798",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.SHINHAN_BANK,
        scheme= "shinhanglbvnbank",
        packageId= "com.shinhan.global.vn.bank",
        appStoreId= "id1071033810",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.STANDARD_CHARTERED_BANK,
        packageId= "com.sc.mobilebanking.vn",
        appStoreId= "id1146741999",
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.TECHCOMBANK,
        scheme= "tcb",
        packageId= "vn.com.techcombank.bb.app",
        appStoreId= "id1548623362",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.TIMO,
        scheme= "plus",
        packageId= "io.lifestyle.plus",
        appStoreId= "id1521230347",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.TPBANK,
        scheme= "tpbankmobile",
        packageId= "com.tpbankquickpay",
        appStoreId= "id1292194225",
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.TPBANK,
        scheme= "hydro",
        packageId= "com.tpb.mb.gprsandroid",
        appStoreId= "id450464147",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.UBANK,
        packageId= "vn.vpbank.ubank",
        appStoreId= "id1529056628",
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.UNITED_OVERSEAS_BANK,
        scheme= "mightyapp",
        packageId= "com.uob.mightyvn",
        appStoreId= "id1174327324",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.VIB,
        scheme= "myvib2",
        packageId= "com.vib.myvib2",
        appStoreId= "id1626624790",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.VIET_A_BANK,
        scheme= "vabmobilebanking",
        packageId= "phn.com.vn.mb",
        appStoreId= "id910897337",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.VIET_BANK,
        scheme= "vietbankmobilebanking",
        packageId= "com.vnpay.vietbank",
        appStoreId= "id1461658565",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.BANVIET,
        scheme= "bvbankdigimi",
        packageId= "vn.banvietbank.mobilebanking",
        appStoreId= "id1526444697",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.VIETCOMBANK,
        scheme= "vietcombankmobile",
        packageId= "com.VCB",
        appStoreId= "id561433133",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.VIETINBANK,
        scheme= "vietinbankmobile",
        packageId= "com.vietinbank.ipay",
        appStoreId= "id689963454",
        supportVietQR= true,
        supportVNPayQR= true
        },
        new BankApp {
        bank= BankKey.VPBANK,
        scheme= "vpbankneo",
        packageId= "com.vnpay.vpbankonline",
        appStoreId= "id1209349510",
        supportVietQR= true,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.VRB,
        supportVietQR= false,
        supportVNPayQR= false
        },
        new BankApp {
        bank= BankKey.WOORI_BANK,
        scheme= "wvbs",
        packageId= "vn.com.woori.smart",
        appStoreId= "id1501785125",
        supportVietQR= true,
        supportVNPayQR= false
        }
    };

    #region banks.ts

    public static Dictionary<string, Bank> BanksObject = new Dictionary<string, Bank>
    {
        {BankKey.ABBANK, new Bank{
            key = BankKey.ABBANK,
            code = BankCode.ABBANK,
            name = "Ngân hàng TMCP An Bình",
            bin = "970425",
            shortName = "AB Bank",
            vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
            lookupSupported = 1,
            swiftCode = "ABBKVNVX",
            keywords = "anbinh"
          }},
        {BankKey.ACB, new Bank{
        key = BankKey.ACB,
        code = BankCode.ACB,
        name = "Ngân hàng TMCP Á Châu",
        bin = "970416",
        shortName = "ACB",
        vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
        lookupSupported = 1,
        swiftCode = "ASCBVNVX",
        keywords = "achau"
        }},
    {BankKey.AGRIBANK, new Bank{
    key = BankKey.AGRIBANK,
    code = BankCode.AGRIBANK,
    name = "Ngân hàng Nông nghiệp và Phát triển Nông thôn Việt Nam",
    bin = "970405",
    shortName = "Agribank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "VBAAVNVX",
    keywords = "nongnghiep, nongthon, agribank, agri"
    }},
    {BankKey.BAC_A_BANK, new Bank{
    key = BankKey.BAC_A_BANK,
    code = BankCode.BAC_A_BANK,
    name = "Ngân hàng TMCP Bắc Á",
    bin = "970409",
    shortName = "BacA Bank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "NASCVNVX",
    keywords = "baca, NASB"
    }},
    {BankKey.BAOVIET_BANK, new Bank{
    key = BankKey.BAOVIET_BANK,
    code = BankCode.BAOVIET_BANK,
    name = "Ngân hàng TMCP Bảo Việt",
    bin = "970438",
    shortName = "BaoViet Bank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "BVBVVNVX",
    keywords = "baoviet, BVB"
    }},
    {BankKey.BANVIET, new Bank{
    key = BankKey.BANVIET,
    code = BankCode.BANVIET,
    name = "Ngân hàng TMCP Bản Việt",
    bin = "970454",
    shortName = "BVBank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "VCBCVNVX",
    keywords = "banviet, vietcapitalbank"
    }},
    {BankKey.BIDC, new Bank{
    key = BankKey.BIDC,
    code = BankCode.BIDC,
    name = "Ngân hàng TMCP Đầu tư và Phát triển Campuchia",
    bin = "",
    shortName = "BIDC",
    vietQRStatus = (int)VietQRStatus.NOT_SUPPORTED
    }},
    {BankKey.BIDV, new Bank{
    key = BankKey.BIDV,
    code = BankCode.BIDV,
    name = "Ngân hàng TMCP Đầu tư và Phát triển Việt Nam",
    bin = "970418",
    shortName = "BIDV",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "BIDVVNVX"
    }},
    {BankKey.CAKE, new Bank{
    key = BankKey.CAKE,
    code = BankCode.CAKE,
    name = "Ngân hàng số CAKE by VPBank - Ngân hàng TMCP Việt Nam Thịnh Vượng",
    bin = "546034",
    shortName = "CAKE by VPBank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = null
    }},
    {BankKey.CBBANK, new Bank{
    key = BankKey.CBBANK,
    code = BankCode.CBBANK,
    name = "Ngân hàng Thương mại TNHH MTV Xây dựng Việt Nam",
    bin = "970444",
    shortName = "CB Bank",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 1,
    swiftCode = "GTBAVNVX",
    keywords = "xaydungvn, xaydung"
    }},
    {BankKey.CIMB, new Bank{
    key = BankKey.CIMB,
    code = BankCode.CIMB,
    name = "Ngân hàng TNHH MTV CIMB Việt Nam",
    bin = "422589",
    shortName = "CIMB Bank",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 1,
    swiftCode = "CIBBVNVN",
    keywords = "cimbvn"
    }},
    {BankKey.COOP_BANK, new Bank{
    key = BankKey.COOP_BANK,
    code = BankCode.COOP_BANK,
    name = "Ngân hàng Hợp tác xã Việt Nam",
    bin = "970446",
    shortName = "Co-op Bank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = null,
    keywords = "hoptacxa, coop"
    }},
    {BankKey.DBS_BANK, new Bank{
    key = BankKey.DBS_BANK,
    code = BankCode.DBS_BANK,
    name = "NH TNHH MTV Phát triển Singapore - Chi nhánh TP. Hồ Chí Minh",
    bin = "796500",
    shortName = "DBS Bank",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 0,
    swiftCode = "DBSSVNVX",
    keywords = "dbshcm"
    }},
    {BankKey.DONG_A_BANK, new Bank{
    key = BankKey.DONG_A_BANK,
    code = BankCode.DONG_A_BANK,
    name = "Ngân hàng TMCP Đông Á",
    bin = "970406",
    shortName = "DongA Bank",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 1,
    swiftCode = "EACBVNVX",
    keywords = "donga, DAB"
    }},
    {BankKey.EXIMBANK, new Bank{
    key = BankKey.EXIMBANK,
    code = BankCode.EXIMBANK,
    name = "Ngân hàng TMCP Xuất Nhập khẩu Việt Nam",
    bin = "970431",
    shortName = "Eximbank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "EBVIVNVX"
    }},
    {BankKey.GPBANK, new Bank{
    key = BankKey.GPBANK,
    code = BankCode.GPBANK,
    name = "Ngân hàng Thương mại TNHH MTV Dầu Khí Toàn Cầu",
    bin = "970408",
    shortName = "GPBank",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 1,
    swiftCode = "GBNKVNVX",
    keywords = "daukhi"
    }},
    {BankKey.HDBANK, new Bank{
    key = BankKey.HDBANK,
    code = BankCode.HDBANK,
    name = "Ngân hàng TMCP Phát triển TP. Hồ Chí Minh",
    bin = "970437",
    shortName = "HDBank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "HDBCVNVX"
    }},
    {BankKey.HONGLEONG_BANK, new Bank{
    key = BankKey.HONGLEONG_BANK,
    code = BankCode.HONGLEONG_BANK,
    name = "Ngân hàng TNHH MTV Hong Leong Việt Nam",
    bin = "970442",
    shortName = "HongLeong Bank",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 1,
    swiftCode = "HLBBVNVX",
    keywords = "HLBVN"
    }},
    {BankKey.HSBC, new Bank{
    key = BankKey.HSBC,
    code = BankCode.HSBC,
    name = "Ngân hàng TNHH MTV HSBC (Việt Nam)",
    bin = "458761",
    shortName = "HSBC Vietnam",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 1,
    swiftCode = "HSBCVNVX"
    }},
    {BankKey.IBK_HCM, new Bank{
    key = BankKey.IBK_HCM,
    code = BankCode.IBK_HCM,
    name = "Ngân hàng Công nghiệp Hàn Quốc - Chi nhánh TP. Hồ Chí Minh",
    bin = "970456",
    shortName = "IBK HCM",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 0,
    swiftCode = null,
    keywords = "congnghiep"
    }},
    {BankKey.IBK_HN, new Bank{
    key = BankKey.IBK_HN,
    code = BankCode.IBK_HN,
    name = "Ngân hàng Công nghiệp Hàn Quốc - Chi nhánh Hà Nội",
    bin = "970455",
    shortName = "IBK HN",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 0,
    swiftCode = null,
    keywords = "congnghiep"
    }},
    {BankKey.INDOVINA_BANK, new Bank{
    key = BankKey.INDOVINA_BANK,
    code = BankCode.INDOVINA_BANK,
    name = "Ngân hàng TNHH Indovina",
    bin = "970434",
    shortName = "Indovina Bank",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 1,
    swiftCode = null
    }},
    {BankKey.KASIKORN_BANK, new Bank{
    key = BankKey.KASIKORN_BANK,
    code = BankCode.KASIKORN_BANK,
    name = "Ngân hàng Đại chúng TNHH KASIKORNBANK - CN TP. Hồ Chí Minh",
    bin = "668888",
    shortName = "Kasikornbank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "KASIVNVX"
    }},
    {BankKey.KIENLONG_BANK, new Bank{
    key = BankKey.KIENLONG_BANK,
    code = BankCode.KIENLONG_BANK,
    name = "Ngân hàng TMCP Kiên Long",
    bin = "970452",
    shortName = "KienlongBank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "KLBKVNVX"
    }},
    {BankKey.KOOKMIN_BANK_HCM, new Bank{
    key = BankKey.KOOKMIN_BANK_HCM,
    code = BankCode.KOOKMIN_BANK_HCM,
    name = "Ngân hàng Kookmin - Chi nhánh TP. Hồ Chí Minh",
    bin = "970463",
    shortName = "Kookmin Bank HCM",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 0,
    swiftCode = null
    }},
    {BankKey.KOOKMIN_BANK_HN, new Bank{
    key = BankKey.KOOKMIN_BANK_HN,
    code = BankCode.KOOKMIN_BANK_HN,
    name = "Ngân hàng Kookmin - Chi nhánh Hà Nội",
    bin = "970462",
    shortName = "Kookmin Bank HN",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 0,
    swiftCode = null
    }},
    {BankKey.LIENVIETPOST_BANK, new Bank{
    key = BankKey.LIENVIETPOST_BANK,
    code = BankCode.LIENVIETPOST_BANK,
    name = "Ngân hàng TMCP Bưu Điện Liên Việt",
    bin = "970449",
    shortName = "LienVietPostBank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "LVBKVNVX",
    keywords = "lienvietbank"
    }},
    {BankKey.MBBANK, new Bank{
    key = BankKey.MBBANK,
    code = BankCode.MBBANK,
    name = "Ngân hàng TMCP Quân đội",
    bin = "970422",
    shortName = "MB Bank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "MSCBVNVX"
    }},
    {BankKey.MSB, new Bank{
    key = BankKey.MSB,
    code = BankCode.MSB,
    name = "Ngân hàng TMCP Hàng Hải",
    bin = "970426",
    shortName = "MSB",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "MCOBVNVX",
    keywords = "hanghai"
    }},
    {BankKey.NAM_A_BANK, new Bank{
    key = BankKey.NAM_A_BANK,
    code = BankCode.NAM_A_BANK,
    name = "Ngân hàng TMCP Nam Á",
    bin = "970428",
    shortName = "Nam A Bank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "NAMAVNVX",
    keywords = "namabank"
    }},
    {BankKey.NCB, new Bank{
    key = BankKey.NCB,
    code = BankCode.NCB,
    name = "Ngân hàng TMCP Quốc Dân",
    bin = "970419",
    shortName = "NCB Bank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "NVBAVNVX",
    keywords = "quocdan"
    }},
    {BankKey.NONGHYUP_BANK_HN, new Bank{
    key = BankKey.NONGHYUP_BANK_HN,
    code = BankCode.NONGHYUP_BANK_HN,
    name = "Ngân hàng Nonghyup - Chi nhánh Hà Nội",
    bin = "801011",
    shortName = "Nonghyup Bank",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 0,
    swiftCode = null
    }},
    {BankKey.OCB, new Bank{
    key = BankKey.OCB,
    code = BankCode.OCB,
    name = "Ngân hàng TMCP Phương Đông",
    bin = "970448",
    shortName = "OCB Bank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "ORCOVNVX",
    keywords = "phuongdong"
    }},
    {BankKey.OCEANBANK, new Bank{
    key = BankKey.OCEANBANK,
    code = BankCode.OCEANBANK,
    name = "Ngân hàng Thương mại TNHH MTV Đại Dương",
    bin = "970414",
    shortName = "Ocean Bank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "OCBKUS3M",
    keywords = "daiduong"
    }},
    {BankKey.PGBANK, new Bank{
    key = BankKey.PGBANK,
    code = BankCode.PGBANK,
    name = "Ngân hàng TMCP Xăng dầu Petrolimex",
    bin = "970430",
    shortName = "PG Bank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "PGBLVNVX"
    }},
    {BankKey.PUBLIC_BANK, new Bank{
    key = BankKey.PUBLIC_BANK,
    code = BankCode.PUBLIC_BANK,
    name = "Ngân hàng TNHH MTV Public Việt Nam",
    bin = "970439",
    shortName = "Public Bank Vietnam",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 1,
    swiftCode = "VIDPVNVX",
    keywords = "publicvn"
    }},
    {BankKey.PVCOM_BANK, new Bank{
    key = BankKey.PVCOM_BANK,
    code = BankCode.PVCOM_BANK,
    name = "Ngân hàng TMCP Đại Chúng Việt Nam",
    bin = "970412",
    shortName = "PVcomBank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "WBVNVNVX",
    keywords = "daichung"
    }},
    {BankKey.SACOMBANK, new Bank{
    key = BankKey.SACOMBANK,
    code = BankCode.SACOMBANK,
    name = "Ngân hàng TMCP Sài Gòn Thương Tín",
    bin = "970403",
    shortName = "Sacombank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "SGTTVNVX"
    }},
    {BankKey.SAIGONBANK, new Bank{
    key = BankKey.SAIGONBANK,
    code = BankCode.SAIGONBANK,
    name = "Ngân hàng TMCP Sài Gòn Công Thương",
    bin = "970400",
    shortName = "SaigonBank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "SBITVNVX",
    keywords = "saigoncongthuong, saigonbank"
    }},
    {BankKey.SCB, new Bank{
    key = BankKey.SCB,
    code = BankCode.SCB,
    name = "Ngân hàng TMCP Sài Gòn",
    bin = "970429",
    shortName = "SCB",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "SACLVNVX",
    keywords = "saigon"
    }},
    {BankKey.SEA_BANK, new Bank{
    key = BankKey.SEA_BANK,
    code = BankCode.SEA_BANK,
    name = "Ngân hàng TMCP Đông Nam Á",
    bin = "970440",
    shortName = "SeABank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "SEAVVNVX"
    }},
    {BankKey.SHB, new Bank{
    key = BankKey.SHB,
    code = BankCode.SHB,
    name = "Ngân hàng TMCP Sài Gòn - Hà Nội",
    bin = "970443",
    shortName = "SHB",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "SHBAVNVX",
    keywords = "saigonhanoi, sghn"
    }},
    {BankKey.SHINHAN_BANK, new Bank{
    key = BankKey.SHINHAN_BANK,
    code = BankCode.SHINHAN_BANK,
    name = "Ngân hàng TNHH MTV Shinhan Việt Nam",
    bin = "970424",
    shortName = "Shinhan Bank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "SHBKVNVX"
    }},
    {BankKey.STANDARD_CHARTERED_BANK, new Bank{
    key = BankKey.STANDARD_CHARTERED_BANK,
    code = BankCode.STANDARD_CHARTERED_BANK,
    name = "Ngân hàng TNHH MTV Standard Chartered Bank Việt Nam",
    bin = "970410",
    shortName = "Standard Chartered Vietnam",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 1,
    swiftCode = "SCBLVNVX"
    }},
    {BankKey.TECHCOMBANK, new Bank{
    key = BankKey.TECHCOMBANK,
    code = BankCode.TECHCOMBANK,
    name = "Ngân hàng TMCP Kỹ thương Việt Nam",
    bin = "970407",
    shortName = "Techcombank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "VTCBVNVX"
    }},
    {BankKey.TIMO, new Bank{
    key = BankKey.TIMO,
    code = BankCode.TIMO,
    name = "Ngân hàng số Timo by Bản Việt Bank",
    bin = "963388",
    shortName = "Timo",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 0,
    swiftCode = null,
    keywords = "banviet"
    }},
    {BankKey.TPBANK, new Bank{
    key = BankKey.TPBANK,
    code = BankCode.TPBANK,
    name = "Ngân hàng TMCP Tiên Phong",
    bin = "970423",
    shortName = "TPBank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "TPBVVNVX",
    keywords = "tienphong"
    }},
    {BankKey.UBANK, new Bank{
    key = BankKey.UBANK,
    code = BankCode.UBANK,
    name = "Ngân hàng số Ubank by VPBank - Ngân hàng TMCP Việt Nam Thịnh Vượng",
    bin = "546035",
    shortName = "Ubank by VPBank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = null
    }},
    {BankKey.UNITED_OVERSEAS_BANK, new Bank{
    key = BankKey.UNITED_OVERSEAS_BANK,
    code = BankCode.UNITED_OVERSEAS_BANK,
    name = "Ngân hàng United Overseas Bank Việt Nam",
    bin = "970458",
    shortName = "United Overseas Bank Vietnam",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 1,
    swiftCode = null
    }},
    {BankKey.VIB, new Bank{
    key = BankKey.VIB,
    code = BankCode.VIB,
    name = "Ngân hàng TMCP Quốc tế Việt Nam",
    bin = "970441",
    shortName = "VIB",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "VNIBVNVX",
    keywords = "quocte"
    }},
    {BankKey.VIET_A_BANK, new Bank{
    key = BankKey.VIET_A_BANK,
    code = BankCode.VIET_A_BANK,
    name = "Ngân hàng TMCP Việt Á",
    bin = "970427",
    shortName = "VietABank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "VNACVNVX"
    }},
    {BankKey.VIET_BANK, new Bank{
    key = BankKey.VIET_BANK,
    code = BankCode.VIET_BANK,
    name = "Ngân hàng TMCP Việt Nam Thương Tín",
    bin = "970433",
    shortName = "VietBank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "VNTTVNVX",
    keywords = "vietnamthuongtin, vnthuongtin"
    }},
    {BankKey.VIETCOMBANK, new Bank{
    key = BankKey.VIETCOMBANK,
    code = BankCode.VIETCOMBANK,
    name = "Ngân hàng TMCP Ngoại Thương Việt Nam",
    bin = "970436",
    shortName = "Vietcombank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "BFTVVNVX"
    }},
    {BankKey.VIETINBANK, new Bank{
    key = BankKey.VIETINBANK,
    code = BankCode.VIETINBANK,
    name = "Ngân hàng TMCP Công thương Việt Nam",
    bin = "970415",
    shortName = "VietinBank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "ICBVVNVX",
    keywords = "viettin" // Some users may use this keyword
    }},
    {BankKey.VPBANK, new Bank{
    key = BankKey.VPBANK,
    code = BankCode.VPBANK,
    name = "Ngân hàng TMCP Việt Nam Thịnh Vượng",
    bin = "970432",
    shortName = "VPBank",
    vietQRStatus = (int)VietQRStatus.TRANSFER_SUPPORTED,
    lookupSupported = 1,
    swiftCode = "VPBKVNVX",
    keywords = "vnthinhvuong"
    }},
    {BankKey.VRB, new Bank{
    key = BankKey.VRB,
    code = BankCode.VRB,
    name = "Ngân hàng Liên doanh Việt - Nga",
    bin = "970421",
    shortName = "VietNgaBank",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 1,
    swiftCode = null,
    keywords = "vietnam-russia, vrbank"
    }},
    {BankKey.WOORI_BANK, new Bank{
    key = BankKey.WOORI_BANK,
    code = BankCode.WOORI_BANK,
    name = "Ngân hàng TNHH MTV Woori Việt Nam",
    bin = "970457",
    shortName = "Woori Bank",
    vietQRStatus = (int)VietQRStatus.RECEIVE_ONLY,
    lookupSupported = 1,
    swiftCode = null
    } }
    };

    #endregion
}
#endregion

#region BANKS
public class Bank
{
    public string key { get; set; }
    public string code { get; set; }
    public string name { get; set; }
    public string shortName { get; set; }
    public string bin { get; set; }
    public int vietQRStatus { get; set; }
    public int? lookupSupported { get; set; }
    public string? swiftCode { get; set; }
    public string? keywords { get; set; }
}

public enum VietQRStatus
{
    NOT_SUPPORTED = -1,
    RECEIVE_ONLY = 0,
    TRANSFER_SUPPORTED = 1
}
#endregion

#region QR-PAY
public class QRProvider
{
    public const string VIETQR = "VIETQR";
    public const string VNPAY = "VNPAY";
}

public class QRProviderGUID
{
    public const string VNPAY = "A000000775";
    public const string VIETQR = "A000000727";
}

public class FieldID
{
    public const string VERSION = "00";
    public const string INIT_METHOD = "01";
    public const string VNPAYQR = "26";
    public const string VIETQR = "38";
    public const string CATEGORY = "52";
    public const string CURRENCY = "53";
    public const string AMOUNT = "54";
    public const string TIP_AND_FEE_TYPE = "55";
    public const string TIP_AND_FEE_AMOUNT = "56";
    public const string TIP_AND_FEE_PERCENT = "57";
    public const string NATION = "58";
    public const string MERCHANT_NAME = "59";
    public const string CITY = "60";
    public const string ZIP_CODE = "61";
    public const string ADDITIONAL_DATA = "62";
    public const string CRC = "63";
}

public class EVMCoFieldID
{
    public const string Field65 = "65";
    public const string Field66 = "66";
    public const string Field67 = "67";
    public const string Field68 = "68";
    public const string Field69 = "69";
    public const string Field70 = "70";
    public const string Field71 = "71";
    public const string Field72 = "72";
    public const string Field73 = "73";
    public const string Field74 = "74";
    public const string Field75 = "75";
    public const string Field76 = "76";
    public const string Field77 = "77";
    public const string Field78 = "78";
    public const string Field79 = "79";
}

public class UnreservedFieldID
{
    public const string Field80 = "80";
    public const string Field81 = "81";
    public const string Field82 = "82";
    public const string Field83 = "83";
    public const string Field84 = "84";
    public const string Field85 = "85";
    public const string Field86 = "86";
    public const string Field87 = "87";
    public const string Field88 = "88";
    public const string Field89 = "89";
    public const string Field90 = "90";
    public const string Field91 = "91";
    public const string Field92 = "92";
    public const string Field93 = "93";
    public const string Field94 = "94";
    public const string Field95 = "95";
    public const string Field96 = "96";
    public const string Field97 = "97";
    public const string Field98 = "98";
    public const string Field99 = "99";
}

public class ProviderFieldID
{
    public const string GUID = "00";
    public const string DATA = "01";
    public const string SERVICE = "02";
}

public class VietQRService
{
    public const string BY_ACCOUNT_NUMBER = "QRIBFTTA";
    public const string BY_CARD_NUMBER = "QRIBFTTC";
}

public class VietQRConsumerFieldID
{
    public const string BANK_BIN = "00";
    public const string BANK_NUMBER = "01";
}

public class AdditionalDataID
{
    public const string BILL_NUMBER = "01"; // Số hóa đơn
    public const string MOBILE_NUMBER = "02"; // Số ĐT
    public const string STORE_LABEL = "03"; // Mã cửa hàng
    public const string LOYALTY_NUMBER = "04"; // Mã khách hàng thân thiết
    public const string REFERENCE_LABEL = "05"; // Mã tham chiếu
    public const string CUSTOMER_LABEL = "06"; // Mã khách hàng
    public const string TERMINAL_LABEL = "07"; // Mã số điểm bán
    public const string PURPOSE_OF_TRANSACTION = "08"; // Mục đích giao dịch
    public const string ADDITIONAL_CONSUMER_DATA_REQUEST = "09"; // Yêu cầu dữ liệu KH bổ sung
}

public class Provider
{
    public string? fieldId { get; set; }
    /// <summary>
    /// QRProvider
    /// </summary>
    public string? name { get; set; }
    public string? guid { get; set; }
    public string? service { get; set; }
}

public class AdditionalData
{
    public string? billNumber { get; set; }
    public string? mobileNumber { get; set; }
    public string? store { get; set; }
    public string? loyaltyNumber { get; set; }
    public string? reference { get; set; }
    public string? customerLabel { get; set; }
    public string? terminal { get; set; }
    public string? purpose { get; set; }
    public string? dataRequest { get; set; }
}

public class Consumer
{
    public string? bankBin { get; set; }
    public string? bankNumber { get; set; }
}

public class Merchant
{
    public string? id { get; set; }
    public string? name { get; set; }
}
#endregion
