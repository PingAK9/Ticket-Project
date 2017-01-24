using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamchovo.DTO
{
    class PriceDTO
    {
        public int price { get; set; }
        public string display { get; set; }

        public PriceDTO()
        {

        }
        public PriceDTO(int _value)
        {
            price = _value;
            display = Puntos(price);
        }
        string Puntos(int strValor)
        {
            string strAux = null;
            string strPuntos = null;

            strAux = strValor.ToString();

            if (strAux.Substring(0, 1) == Application.CurrentCulture.NumberFormat.NegativeSign)
            {
                strAux = strAux.Substring(1);
            }
            strPuntos = strAux;
            strAux = "";
            while (strPuntos.Length > 3)
            {
                strAux = Application.CurrentCulture.NumberFormat.NumberGroupSeparator + strPuntos.Substring(strPuntos.Length - 3, 3) + strAux;
                strPuntos = strPuntos.Substring(0, strPuntos.Length - 3);
            }
            strAux = strPuntos + strAux;
            return strAux;
        }
    }
}
