using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission1
{
    class NotRegular
    {

        public static bool Not(string login)
        {

            byte[] bytes = new byte[192];
            int kol = 0;
            for (int i = 0; i < 47; i++)
            {
                bytes[kol] = (byte)i;
                kol++;
            }
            for (int i = 58; i < 64; i++)
            {
                bytes[kol] = (byte)i;
                kol++;
            }
            for (int i = 91; i < 96; i++)
            {
                bytes[kol] = (byte)i;
                kol++;
            }
            for (int i = 123; i < 255; i++)
            {
                bytes[kol] = (byte)i;
                kol++;
            }

            char[] chars = Encoding.ASCII.GetChars(bytes);

            bool flag = false;

            foreach (var item in chars)
            {
                for (int i = 0; i < login.Length; i++)
                {
                    if (login[i] == item)
                    {
                        flag = true;
                    }
                }
            }

            bool access
                ;
            if (login.Length >= 2 && login.Length <= 10 && Char.IsDigit((char)login[0]) == false && flag == false)
                access = true;
            else access = false;

            return access;
        }

    }
}
