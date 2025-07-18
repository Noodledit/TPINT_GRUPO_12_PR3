﻿using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ClinicaMedica.ListadoTurnos;

namespace ClinicaMedica
{
    public partial class SeguimientosPacientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["TurnoSeleccionado"] != null)
            {
               
                if (Session["UsuarioActivo"] != null)
                {
                    var turno = (Turno)Session["TurnoSeleccionado"];
                    Usuario usuario = (Usuario)Session["UsuarioActivo"];
                    CargarHistorialPorPaciente(turno.DniPaciente);
                    lblBienvenidoUsuario.Text = usuario.NombreUsuario + " " + usuario.ApellidoUsuario;

                    DateTime Fecha = DateTime.Now;

                    lblDniPaciente.Text = turno.DniPaciente;
                    lblFechaTurno.Text = Fecha.ToString("dd/MM/yyyy");
                    lblNombrePaciente.Text = turno.NombrePaciente;
                }
                else
                {
                    Response.Redirect("ListadoTurnos.aspx");
                }
            }
        }

        protected void btnFinalizarConsulta_Click(object sender, EventArgs e)
        {
            btnFinalizarConsulta.Enabled = false;

            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;

            txtComentario.EnableViewState = false;
          

            lblMensaje.Text = "Esta seguro de terminar la consulta?";
        }

        protected void btnUnlogin_Click(object sender, EventArgs e)
        {
            Session["UsuarioActivo"] = null;
            Response.Redirect("ListadoTurnos.aspx");
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            Turno turnoIniciado = (Turno)Session["TurnoSeleccionado"];

            string comentario = txtComentario.Value;

            GestionRegistros gestion = new GestionRegistros();
            bool comentarioRegistrado = gestion.RegistrarSeguimiento(turnoIniciado, comentario);

            if (comentarioRegistrado)
            {
                lblMensaje.Text = "Comentario registrado correctamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                CargarHistorialPorPaciente(turnoIniciado.DniPaciente);
            }
            else
            {
                lblMensaje.Text = "Error al guardar el comentario.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }

            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;

            btnAceptar.Visible = true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            btnFinalizarConsulta.Enabled = true;

            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;

            txtComentario.EnableViewState = true;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Session["TurnoSeleccionado"] = null;
            Response.Redirect("ListadoTurnos.aspx");
        }

        protected void CargarHistorialPorPaciente(string dni)
        {
            GestionRegistros gestionRegistros = new GestionRegistros();
            DataTable HistorialPorPersona = gestionRegistros.ObtenerHistorialPorPaciente(dni);
           
            if (HistorialPorPersona != null && HistorialPorPersona.Rows.Count > 0)//veo que hay registros 
            {
                lvHistorial.DataSource = HistorialPorPersona;
                lvHistorial.DataBind();
            }
           
        }
    }
}