﻿using SisControl.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisControl.DALL
{
    internal class ProdutosDALL
    {
        public DataTable ListaProduto()
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT ProdutoID, NomeProduto, Descricao, PrecoCusto, Lucro, PrecoDeVenda, QuantidadeEmEstoque, DataDeEntrada, CategoriaID, FabricanteID, UnidadeDeMedida, Status, DataDeVencimento, Imagem, FornecedorID, Referencia FROM Produtos", conn);

                SqlDataAdapter daCliente = new SqlDataAdapter();
                daCliente.SelectCommand = sql;
                DataTable dtcliente = new DataTable();
                daCliente.Fill(dtcliente);
                return dtcliente;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }

        public void SalvarProduto(ProdutosModel produto)
        {
            var conn = Conexao.Conex();
            try
            {
<<<<<<< HEAD
                SqlCommand sql = new SqlCommand("INSERT INTO Produtos (NomeProduto, Descricao, PrecoCusto, Lucro, PrecoDeVenda, QuantidadeEmEstoque, DataDeEntrada, CategoriaID, FabricanteID, UnidadeDeMedida, Status, DataDeVencimento, Imagem, FornecedorID, Referencia) VALUES (@NomeProduto, @Descricao, @PrecoCusto, @Lucro, @PrecoDeVenda, @QuantidadeEmEstoque, @DataDeEntrada, @CategoriaID, @FabricanteID, @UnidadeDeMedida, @Status, @DataDeVencimento, @Imagem, @FornecedorID, @Referencia)", conn);
=======
                SqlCommand sql = new SqlCommand("INSERT INTO Produtos (NomeProduto, Descricao, PrecoCusto, Lucro, PrecoDeVenda, QuantidadeEmEstoque, DataDeEntrada, CategoriaID, FabricanteID, UnidadeDeMedida, Status, DataDeVencimento, Imagem, FornecedorID) VALUES (@NomeProduto, @Descricao, @PrecoCusto, @Lucro, @PrecoDeVenda, @QuantidadeEmEstoque, @DataDeEntrada, @CategoriaID, @FabricanteID, @UnidadeDeMedida, @Status, @DataDeVencimento, @Imagem, @FornecedorID)", conn);
>>>>>>> 52ded11ebc2146f3d05bb3a76b0841fddc107b63

                sql.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
                sql.Parameters.AddWithValue("@Descricao", produto.Descricao);
                sql.Parameters.AddWithValue("@PrecoCusto", produto.PrecoCusto);
                sql.Parameters.AddWithValue("@Lucro", produto.Lucro);
                sql.Parameters.AddWithValue("@PrecoDeVenda", produto.PrecoDeVenda);
                sql.Parameters.AddWithValue("@QuantidadeEmEstoque", produto.QuantidadeEmEstoque);
                sql.Parameters.AddWithValue("@DataDeEntrada", produto.DataDeEntrada);
                sql.Parameters.AddWithValue("@CategoriaID", produto.CategoriaID);
                sql.Parameters.AddWithValue("@FabricanteID", produto.FabricanteID);
                sql.Parameters.AddWithValue("@UnidadeDeMedida", produto.UnidadeDeMedida);
                sql.Parameters.AddWithValue("@Status", produto.Status);
                sql.Parameters.AddWithValue("@DataDeVencimento", produto.DataDeVencimento);
                sql.Parameters.AddWithValue("@Imagem", produto.Imagem);
                sql.Parameters.AddWithValue("@FornecedorID", produto.FornecedorID);
                sql.Parameters.AddWithValue("@Referencia", produto.Referencia);
                

                conn.Open();
                sql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void ExcluirProduto(ProdutoMODEL produto)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("DELETE FROM Produtos WHERE ProdutoID = @ProdutoID", conn);
                sql.Parameters.AddWithValue("@ProdutoID", produto.ProdutoID); // Corrigir para passar o ProdutoID

                conn.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }


        public void AtualizaProduto(ProdutosModel produto)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("UPDATE Produto SET NomeProduto = @NomeProduto, Descricao = @Descricao, PrecoCusto = @PrecoCusto, Lucro = @Lucro, PrecoDeVenda = @PrecoDeVenda, QuantidadeEmEstoque = @QuantidadeEmEstoque, DataDeEntrada = @DataDeEntrada, CategoriaID = @CategoriaID, FabricanteID = @FabricanteID, UnidadeDeMedida = @UnidadeDeMedida, Status = @Status, DataDeVencimento = @DataDeVencimento, Imagem = @Imagem, FornecedorID = @FornecedorID, Referencia = @Referencia WHERE ProdutoID = @ProdutoID", conn);

                sql.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
                sql.Parameters.AddWithValue("@Descricao", produto.Descricao);
                sql.Parameters.AddWithValue("@PrecoCusto", produto.PrecoCusto);
                sql.Parameters.AddWithValue("@Lucro", produto.Lucro);
                sql.Parameters.AddWithValue("@PrecoDeVenda", produto.PrecoDeVenda);
                sql.Parameters.AddWithValue("@QuantidadeEmEstoque", produto.QuantidadeEmEstoque);
                sql.Parameters.AddWithValue("@DataDeEntrada", produto.DataDeEntrada);
                sql.Parameters.AddWithValue("@CategoriaID", produto.CategoriaID);
                sql.Parameters.AddWithValue("@FabricanteID", produto.FabricanteID);
                sql.Parameters.AddWithValue("@UnidadeDeMedida", produto.UnidadeDeMedida);
                sql.Parameters.AddWithValue("@Status", produto.Status);
                sql.Parameters.AddWithValue("@DataDeVencimento", produto.DataDeVencimento);
                sql.Parameters.AddWithValue("@Imagem", produto.Imagem);
                sql.Parameters.AddWithValue("@FornecedorID", produto.FornecedorID);
                sql.Parameters.AddWithValue("@Referencia", produto.Referencia);
                sql.Parameters.AddWithValue("@ProdutoID", produto.ProdutoID);

                conn.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }


        public DataTable PesquisarPorNome(string nome)
        {
            var conn = Conexao.Conex();
            try
            {
                DataTable dt = new DataTable();

                string sqlconn = "SELECT ProdutoID, NomeProduto, Descricao, PrecoCusto, Lucro, PrecoDeVenda, QuantidadeEmEstoque, DataDeEntrada, CategoriaID, FabricanteID, UnidadeDeMedida, Status, DataDeVencimento, Imagem, FornecedorID, Referencia FROM Produtos WHERE NomeProduto LIKE @NomeProduto";

                SqlCommand cmd = new SqlCommand(sqlconn, conn);
                cmd.Parameters.AddWithValue("@NomeProduto", "%" + nome + "%");
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                conn.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar a pesquisa: " + ex.Message);
                return null;
            }
        }

        public DataTable PesquisarPorCodigo(string nome)
        {
            var conn = Conexao.Conex();
            try
            {
                DataTable dt = new DataTable();

                string sqlconn = "SELECT ProdutoID, NomeProduto, Descricao, PrecoCusto, Lucro, PrecoDeVenda, QuantidadeEmEstoque, DataDeEntrada, CategoriaID, FabricanteID, UnidadeDeMedida, Status, DataDeVencimento, Imagem, FornecedorID, Referencia FROM Produto WHERE ProdutoID LIKE @ProdutoID";

                SqlCommand cmd = new SqlCommand(sqlconn, conn);
                cmd.Parameters.AddWithValue("@ProdutoID", "%" + nome + "%");
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                conn.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar a pesquisa: " + ex.Message);
                return null;
            }
        }

    }
}
