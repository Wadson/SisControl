﻿using SisControl.DALL;
using SisControl.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisControl.BLL
{
    internal class ContaReceberBLL
    {
        ContaReceberDALL contasreceberDALL = null;


        public DataTable Listar()
        {
            DataTable dtable = new DataTable();

            contasreceberDALL = new ContaReceberDALL();
            dtable = contasreceberDALL.lista_contas_receber();
            try
            {

            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }
        //*********************************************************************************************
        public DataTable ListarContasReceber_Opcional(ContaRedeberMODEL contas)
        {
            DataTable dtable = new DataTable();
            try
            {
                contasreceberDALL = new ContaReceberDALL();
                dtable = contasreceberDALL.lista_contas_receber();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }
        //*********************************************************************************************
        public void Salvar(ContaRedeberMODEL controle)
        {
            contasreceberDALL = new ContaReceberDALL();
            contasreceberDALL.salvarcontasreceber(controle);
            try
            {

            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        //***********************************************************************************************
        public void Excluir(ContaRedeberMODEL contas)
        {
            try
            {
                contasreceberDALL = new ContaReceberDALL();
                contasreceberDALL.excluicontasreceber(contas);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //*************************************************************************************************
        public void Atualizar(ContaRedeberMODEL contas)
        {
            try
            {
                contasreceberDALL = new ContaReceberDALL();
                contasreceberDALL.atualiza_contasreceber(contas);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        //************************************************************************************************
        public void Atualizar2(ContaRedeberMODEL contas)
        {
            try
            {
                //contasreceberDALL = new ContaReceberDALL();
                //contasreceberDALL.atualiza_contas(contas);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //************************************************************************************************
        public void BaixarContaDal(ContaRedeberMODEL baixaconta)
        {
            try
            {
                //contasreceberDALL = new ContaReceberDALL();
                //contasreceberDALL(baixaconta);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        //************************************************************************************************
        public void PagarContasDal(ContaRedeberMODEL controle)
        {
            try
            {
                //contasreceberDALL = new ContasReceberDAL();
                //contasreceberDALL.darBaixaConta(controle);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
