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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtNomeProduto.Text.Length == 0)
            {
                MessageBox.Show("O nome do produto não pode estar vazio!");


                TxtNomeProduto.BackColor = Color.Red;
                TxtNomeProduto.ForeColor = Color.White;
            }
            else if (TxtNomeProduto.Text.Length < 2)
            {
                MessageBox.Show("O nome do produto precisa ter no mínimo duas letras!");

                TxtNomeProduto.BackColor = Color.Red;
                TxtNomeProduto.ForeColor = Color.White;
            }
            else
            {
                if (LibCompras.Items.Contains(TxtNomeProduto.Text))
                {
                    MessageBox.Show($"Já existe {TxtNomeProduto.Text} na lista!");
                }
                else
                {
                    LibCompras.Items.Add(TxtNomeProduto.Text);

                    MessageBox.Show($"{TxtNomeProduto.Text} foi adicionado(a) na lista de compras com sucesso!");

                    TxtNomeProduto.BackColor = Color.White;
                    TxtNomeProduto.ForeColor = Color.Black;

                    TxtNomeProduto.Text = "";
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja apagar tudo?");

            if (resposta == DialogResult.OK)
            {
                LibCompras.Items.Clear();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if(LibCompras.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um item para remover!");

            }
            else
            {
                string itemRemovido = LibCompras.SelectedItem.ToString();

                LibCompras.Items.RemoveAt(LibCompras.SelectedIndex);

                MessageBox.Show($"{itemRemovido} foi removido da lista!");
            }
        }

        private void TxtNomeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd.PerformClick();
            }
        }
    }
    
}
