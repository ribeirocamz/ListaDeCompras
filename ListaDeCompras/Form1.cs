using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ADCIONAR ITENS NA LISTA
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Verificar se txbProduto (campo de inserção dos produtos) está vazio:
            if (txbProduto.Text.Length == 0)
            {
                MessageBox.Show("O nome do produto não pode estar em branco!", "Erro!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Mudar a cor do fundo e a cor da letra,
                //indicando o campo a ser preenchido:
                txbProduto.BackColor = Color.Red;
                txbProduto.ForeColor = Color.White;

            }
            else if (txbProduto.Text.Length < 2)
            {
                //txbProdutos precisa ter no mínimo dois caracteres
                MessageBox.Show("O nome do produto precisa ter no mínimo duas letras!",
                "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Mudar a cor do fundo e a cor da letra,
                //indicando o campo a ser preenchido:
                txbProduto.BackColor = Color.Red;
                txbProduto.ForeColor = Color.White;
            }
            else
            {
                //Verificar se o item já existe na lista:
                if (libItens.Text.Contains(txbProduto.Text))
                {
                    MessageBox.Show($"O item {txbProduto.Text} já existe em sua lista de compras!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Adicionar o item na lista:
                libItens.Items.Add(txbProduto.Text);
                MessageBox.Show($"{txbProduto.Text} foi adicionado na sua lista de compras!",
                "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Retornar o campo txbProdutos à cor normal quando
                //o campo for preenchido corretamente:
                txbProduto.BackColor = Color.White;
                txbProduto.ForeColor = Color.Black;

                //Limpar o campo de adicionar produtos:
                txbProduto.Clear();
            }
        }



        //VERIFICAÇÃO DO BOTÃO "LIMPAR LISTA"
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Perguntar ao usuário se ele realmente deseja apagar todos os itens:
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja apagar todos os itens?",
            "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Se a resposta for afirmativa:
            if (resposta == DialogResult.Yes)
            {
                libItens.Items.Clear();
                MessageBox.Show("A lista está vazia!", "Sucesso!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        //VERIFICAÇÃO DO BOTÃO "EXCLUIR"
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verificar se o usuário não selecionou nada:
            if (libItens.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um item para remover!", "Erro!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Salvar temporariamente o nome do item que será removido:
                string itemRemovido = libItens.SelectedItem.ToString();

                //Perguntar ao usuário se ele deseja excluir o item selecionado:
                DialogResult resposta = MessageBox.Show($"Tem certeza que deseja excluir {libItens.SelectedItem} da sua lista?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //Se a resposta for afirmativa:
                if (resposta == DialogResult.Yes)
                {
                    //Remover o item selecionado:
                    libItens.Items.RemoveAt(libItens.SelectedIndex);
                }


                //Mostrar qual item foi removido da lista
                MessageBox.Show($"{itemRemovido} foi removido da lista", "Sucesso!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        //UTILIZAR TECLA ENTER PARA ADICIONAR ITENS NA LISTA
        private void txbProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //"Pressionar" o btnAdicionar:
                btnAdicionar.PerformClick();
            }
        }
    }
}
