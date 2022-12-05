using Desktop_TP_Final.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_TP_Final
{
    public partial class FormGerenciar : Form
    {
        String URI = "https://localhost:5001/api/v1/usuarios";
        int usuarioselectional = 0;
        public FormGerenciar()
        {            
            InitializeComponent();
            GetAllUsuarios();
        }

        private void deletar_btn_Click(object sender, EventArgs e)
        {
            DeleteUsuario(int.Parse(listBox1.GetItemText(listBox1.SelectedItem).Split(',')[0]));
        }

        private void editar_btn_Click(object sender, EventArgs e)
        {
  
            GetUsuarioById(int.Parse(listBox1.GetItemText(listBox1.SelectedItem).Split(',')[0]));
        }

        private async void GetAllUsuarios()
        {

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        listBox1.DataSource = JsonConvert.DeserializeObject<Usuario[]>(ProdutoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o usuário : " + response.StatusCode);
                    }
                }
            }
        }

        private async void GetUsuarioById(int codUsuario)
        {
            using (var client = new HttpClient())
            {
              
                BindingSource bsDados = new BindingSource();
                URI = URI + "/" + codUsuario.ToString();
                usuarioselectional = codUsuario;
                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var UsuarioJsonString = await response.Content.ReadAsStringAsync();
                    Usuario usuario = JsonConvert.DeserializeObject<Usuario>(UsuarioJsonString);
                    var editar = new FormEdit(usuario);
                    editar.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falha ao obter o usuário : " + response.StatusCode);
                }
            }
        }

        private async void DeleteUsuario(int codUsuário)
        {
            int UsuarioID = codUsuário;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await
                client.DeleteAsync(String.Format("{0}/{1}", URI, UsuarioID));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuário excluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o produto  : " + responseMessage.StatusCode);
                }
            }
            GetAllUsuarios();
        }


    }
}
