using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class TempoController : Conexao
    {
        public List<Tempo> ListarTempos()
        {
            List<Tempo> lstTempos = new List<Tempo>();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "select";
            cmd.CommandText += " codTempo,";
            cmd.CommandText += " nomeJogador1,";
            cmd.CommandText += " nomeJogador2,";
            cmd.CommandText += " jogadorGanhador,";
            cmd.CommandText += " tempoJogo";
            cmd.CommandText += " from";
            cmd.CommandText += " Tempos";
            cmd.CommandText += " order by tempoJogo asc";
            
            Abrir();

            MySqlDataReader reader = Pesquisar(cmd);

            while (reader.Read())
            {
                Tempo t = new Tempo();

                t.codTempo = reader.GetInt32(0);
                t.nomeJogador1 = reader.GetString(1);
                t.nomeJogador2 = reader.GetString(2);
                t.jogadorGanhador = reader.GetInt32(3);
                t.tempoJogo = reader.GetTimeSpan(4);

                lstTempos.Add(t);
            }

            Fechar();

            return lstTempos;
        }

        public void Incluir(Tempo obj)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "insert into Tempos values ";
            cmd.CommandText += " (default,";
            cmd.CommandText += " @nomeJogador1,";
            cmd.CommandText += " @nomeJogador2,";
            cmd.CommandText += " @jogadorGanhador,";
            cmd.CommandText += " @tempoJogo)";

            cmd.Parameters.AddWithValue("@nomeJogador1", obj.nomeJogador1);
            cmd.Parameters.AddWithValue("@nomeJogador2", obj.nomeJogador2);
            cmd.Parameters.AddWithValue("@jogadorGanhador", obj.jogadorGanhador);
            cmd.Parameters.AddWithValue("@tempoJogo", obj.tempoJogo);

            Abrir();
            Executar(cmd);
            Fechar();
        }

    }
}
