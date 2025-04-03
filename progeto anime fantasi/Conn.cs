using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progeto_anime_fantasi
{
    public static class Conn
    {
        private const string servidor = "127.0.0.1";//localhost
        private const string bancoDados = "kitsune_cardanimes";
        private const string usuario = "root";
        private const string senha = "";

        public static string strConn = $"server={servidor};user={usuario};password={senha};database={bancoDados}";
    }
}
