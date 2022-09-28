namespace NguyenVanAnBTH.Models.Process
{
    public class StringProcess
    {
        public string RemoveRemainingWhiteSpace (string strInput)
        {
            string result =" ";
            // viet code xu ly xoa cac ky tu trang con thua 
            // xoa bor ky tu trang o dau va cuoi
            strInput = strInput.Trim();
            // xoa bo cac ky tu tran con thua ow gia chuoi
            int index = strInput.IndexOf( "  ");
            while(strInput.IndexOf(" ")>0){

                strInput = strInput.Replace(" ", " ");
            }

            result = strInput;
            return result;
        }

        public string TenPhuongThuc()
    }
}