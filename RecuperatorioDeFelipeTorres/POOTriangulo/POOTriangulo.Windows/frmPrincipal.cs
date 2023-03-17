using POOTriangulo.Datos;
using POOTriangulo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOTriangulo.Windows
{
    public partial class frmPrincipal : Form
    {
        bool hayCambios = false;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private List<Triangulo> lista;
        private RepositorioDeTriangulos repositorio;
        public int cantidad;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioDeTriangulos();
            lista = repositorio.GetLista();
            cantidad = repositorio.GetCantidad();
            MostarTolal();
            if (cantidad > 0)
            {
                MostarLista();
            }
            else
            {
                MessageBox.Show("No hay elementos en la lista", "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void MostarLista()
        {
            TrianguloDataGridView.Rows.Clear();
            foreach (var Tri in lista)
            {
                var r = ConstruirFila();
                SetearFila(Tri, r);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            TrianguloDataGridView.Rows.Add(r);
        }

        private void SetearFila(Triangulo tri, DataGridViewRow r)
        {
            r.Cells[ColLadoA.Index].Value = tri.LadoA;
            r.Cells[ColLadoB.Index].Value = tri.LadoB;
            r.Cells[ColLadoC.Index].Value = tri.LadoC;
            r.Cells[ColPerimetro.Index].Value = tri.GetPerimetro().ToString("N2");
            r.Cells[ColArea.Index].Value = tri.GetArea().ToString("N2");
            r.Cells[ColRelleno.Index].Value = tri.Relleno;
            r.Cells[ColTrazo.Index].Value = tri.Trazo;
            r.Tag = tri;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(TrianguloDataGridView);
            return r;
        }

        private void MostarTolal()
        {
            CantidadLabel.Text = cantidad.ToString();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            frmTrianguloAE frm = new frmTrianguloAE();
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
            var triNuevo = frm.GetTriangulo();
            repositorio.Agregar(triNuevo);
            var r = ConstruirFila();
            SetearFila(triNuevo, r);
            AgregarFila(r);
            MessageBox.Show("Triangulo Agregado Correctamente");
            cantidad = repositorio.GetCantidad();
            MostarTolal();
            hayCambios = true;

        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (TrianguloDataGridView.SelectedRows.Count==0)
            {
                return;
            }
            var r = TrianguloDataGridView.SelectedRows[0];
            Triangulo tri = r.Tag as Triangulo;
            DialogResult dr = MessageBox.Show($"Elininar Triangulo de lados {tri.LadoA}, {tri.LadoB} {tri.LadoC}",
                "Confirmar Eliminacion",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }
            if (repositorio.Borrar(tri))
            {
                lista.Remove(tri);
                TrianguloDataGridView.Rows.Remove(r);
                cantidad = repositorio.GetCantidad();
                MostarTolal();
                hayCambios = true;
                MessageBox.Show("Se a borrodo de la grilla", "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (TrianguloDataGridView.SelectedRows.Count==0)
            {
                return;
            }
            var r = TrianguloDataGridView.SelectedRows[0];
            Triangulo tri = r.Tag as Triangulo;
            frmTrianguloAE frm = new frmTrianguloAE() { Text = "Editar Triangulo" };
            frm.SetTriangulo(tri);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
            tri = frm.GetTriangulo();
            SetearFila(tri, r);
            hayCambios = true;
            MessageBox.Show("Triangulo Modificado", "Informacion", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void GuardarToolStripButton_Click(object sender, EventArgs e)
        {
            ManejadorDeArchivoSecuencial
                .GuardarEnArchivoSecuencial(repositorio.GetLista());
            MessageBox.Show("Se a Guardado", "Confirmacion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        private void CerrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (hayCambios)
            {
                ManejadorDeArchivoSecuencial.GuardarEnArchivoSecuencial(repositorio.GetLista());
            }
            Application.Exit();
        }
    }
}
