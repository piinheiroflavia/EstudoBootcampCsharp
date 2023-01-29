using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//TRABALHANDO CO TUPLAS
namespace exemploExplorando.models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            //retorno se deu certo
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                //verifica se o arquivo existe, lê as linhas, conta a quantidade de linhas
                return(true, linhas, linhas.Count());
            }
            //retorno não deu certo
            catch (Exception)
            {
                return(false, new string[0], 0);
            }
        }
    }
}