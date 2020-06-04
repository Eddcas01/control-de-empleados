using empleadoscontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaFRM
{
    public partial class mdi_control : Form
    {
        //mantenimiento_concepto
        //private mantenimiento_empleados frm_mantenimiento_empleados;  
        private registrar_entradas frm_registrar_entradas;
        private registrar_salidas frm_registrar_salidas;

        //sentencia sn = new sentencia();
        String usuarioActivo = "rchocm";

        public mdi_control()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
        }

       
        //==========Funciones para evitar que se habrá 2 veces la misma ventana==========          
        private void frm_registrar_entradas_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_registrar_entradas = null; }
        private void frm_registrar_salidas_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_registrar_salidas = null; }        

        //====================Funciones de declaración de Eventos====================


        private void MDI_FRM_Load(object sender, EventArgs e)
        {
            /*/
            frm_login login = new frm_login();
            login.ShowDialog();
            Lbl_usuario.Text = login.obtenerNombreUsuario();
            usuarioActivo = Lbl_usuario.Text; 
            /*/
        }

        private void SeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*/
            MDI_Seguridad seguridad = new MDI_Seguridad(Lbl_usuario.Text);
            seguridad.lbl_nombreUsuario.Text = Lbl_usuario.Text;
            seguridad.ShowDialog(); 
            /*/
        }

        private void Btn_prueba_Click(object sender, EventArgs e)
        {
            //                      Usuario        Mensaje a guardar     Tabla
            //sn.insertarBitacora(Lbl_usuario.Text, "Probó la Bitacora", "General");
        }


        private void BonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CONCEPTO            
            /*/
            if (frm_mantenimiento_empleados == null)
            {
                frm_mantenimiento_empleados = new mantenimiento_empleados(usuarioActivo);
                frm_mantenimiento_empleados.MdiParent = this;
                frm_mantenimiento_empleados.FormClosed += new FormClosedEventHandler(frm_mantenimiento_empleados_FormClosed);
                frm_mantenimiento_empleados.Show();
            }
            else
            {
                frm_mantenimiento_empleados.Activate();
            }
            /*/
        }

        private void RegistrarEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REGISTRAR ENTRADAS
            //registrar_entradas
            if (frm_registrar_entradas == null)
            {
                frm_registrar_entradas = new registrar_entradas();
                frm_registrar_entradas.MdiParent = this;
                frm_registrar_entradas.FormClosed += new FormClosedEventHandler(frm_registrar_entradas_FormClosed);
                frm_registrar_entradas.Show();
            }
            else
            {
                frm_registrar_entradas.Activate();
            }
        }

        private void RegistrarSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REGISTRAR SALIDAS
            //registrar_salidas
            if (frm_registrar_salidas == null)
            {
                frm_registrar_salidas = new registrar_salidas();
                frm_registrar_salidas.MdiParent = this;
                frm_registrar_salidas.FormClosed += new FormClosedEventHandler(frm_registrar_salidas_FormClosed);
                frm_registrar_salidas.Show();
            }
            else
            {
                frm_registrar_salidas.Activate();
            }
        }
    }
}
