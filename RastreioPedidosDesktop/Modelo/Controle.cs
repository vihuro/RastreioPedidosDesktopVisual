﻿using RastreioPedidosDesktop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreioPedidosDesktop.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem;


        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificar(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }

            return tem;
        }

        public String cadastrar(String nome, String senha)
        {

            return mensagem;
        }
    }
}
