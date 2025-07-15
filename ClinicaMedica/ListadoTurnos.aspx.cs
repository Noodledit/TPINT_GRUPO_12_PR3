using Entidades;
using Servicios;
using System;
using System.Data;
using System.Globalization;
using System.Reflection.Emit;
using System.Web.UI.WebControls;
using WebLabel = System.Web.UI.WebControls.Label;


namespace ClinicaMedica
{
    public partial class ListadoTurnos : System.Web.UI.Page
    {
        private GestionTablas gestionTablas = new GestionTablas();
        private GestionDdl gestionDdl = new GestionDdl();
        private Turno ConfiguracionTurno = new Turno();
        private GestionRegistros GestorRegistros = new GestionRegistros();
        private CommandField ShowButton = new CommandField();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gestionDdl.CargarFechas(ddlFechas);
                gestionDdl.CargarEstados(ddlEstados);

                ComprobacionDeSesion();
                HabilitacionDeAcceso();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Session["UsuarioActivo"] == null)
            {
                string user = txtUsuario.Text;
                string pass = txtContrasenia.Text;

                GestionUsuario gestionUsuario = new GestionUsuario();


                Usuario usuario = gestionUsuario.Loguear(user, pass);
                

                if (usuario != null)
                {
                    Session["UsuarioActivo"] = usuario;
                    ComprobacionDeSesion();
                }
                else
                {
                    lblBienvenidoUsuario.ForeColor = System.Drawing.Color.Red;
                    lblBienvenidoUsuario.Text = "Usuario o contraseña incorrectos";
                }
            }
        }

        protected void ComprobacionDeSesion()
        {
            if (Session["UsuarioActivo"] != null)
            {
                btnLogin.Visible = false;
                btnUnlogin.Visible = true;
                txtContrasenia.Visible = false;
                txtUsuario.Visible = false;
                lblContrasenia.Visible = false;
                lblNombreUsuario.Visible = false;
                hlCambiarContrasenia.Visible = true;
                lblBienvenidoUsuario.ForeColor = System.Drawing.Color.White;
                lblBienvenidoUsuario.Text = ((Usuario)Session["UsuarioActivo"]).NombreUsuario + " " + ((Usuario)Session["UsuarioActivo"]).ApellidoUsuario;
                HabilitacionDeAcceso();
            }
            else
            {
                btnLogin.Visible = true;
                btnUnlogin.Visible = false;
                txtContrasenia.Visible = true;
                txtUsuario.Visible = true;
                lblContrasenia.Visible = true;
                lblNombreUsuario.Visible = true;
                lblBienvenidoUsuario.Text = string.Empty;
                gvTurnos.DataSource = null;
                gvTurnos.DataBind();
                HabilitacionDeAcceso();
            }
        }

        protected void btnUnlogin_Click(object sender, EventArgs e)
        {
            Session["UsuarioActivo"] = null;
            ComprobacionDeSesion();
        }

        protected void HabilitacionDeAcceso()
        {
            if (Session["UsuarioActivo"] != null)
            {
                CommandField ColumnaOpciones = (CommandField)gvTurnos.Columns[7];


                if (((Usuario)Session["UsuarioActivo"]).TipoUsuario > 1)
                {
                    hlAgregarMedico.Visible = true;

                    hlAsignarTurnos.Visible = true;
                    hlInformes.Visible = true;
                    hlListarMedicos.Visible = true;

                    if (ddlFechas.SelectedItem != null 
                        && ddlFechas.SelectedValue != "0" 
                        && !string.IsNullOrWhiteSpace(ddlFechas.SelectedItem.Text))
                    {
                        ConfiguracionTurno.Fecha = DateTime.ParseExact(ddlFechas.SelectedItem.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }

                    ColumnaOpciones.ShowSelectButton = false;
                    ColumnaOpciones.ShowEditButton = true;
                    ColumnaOpciones.ShowDeleteButton = true;
                }

                if (((Usuario)Session["UsuarioActivo"]).TipoUsuario >= 1)
                {          
                    hlListarTurnos.Visible = true;
                    hlSeguimientoPaciente.Visible = true;
                    lblFecha.Visible = true;
                    ddlFechas.Visible = true;
                    btnMostrarTodo.Visible = true;
                    btnConsultarEstado.Visible = true;
                    ddlEstados.Visible = true;
                    gvTurnos.Columns[7].Visible = true;

                    gestionDdl.CargarFechas(ddlFechas);

                    ConfiguracionTurno = new Turno();

                    if (((Usuario)Session["UsuarioActivo"]).TipoUsuario == 1)
                    {
                        gestionDdl.CargarFechas(ddlFechas, null, ((Usuario)Session["UsuarioActivo"]).LegajoDoctor);

                        ColumnaOpciones.ShowSelectButton = true;
                        ColumnaOpciones.ShowEditButton = false;
                        ColumnaOpciones.ShowDeleteButton = false;

                        ConfiguracionTurno.LegajoMed = Convert.ToInt32(((Usuario)Session["UsuarioActivo"]).LegajoDoctor);
                    }


                    if (ddlFechas.SelectedItem != null 
                        && ddlFechas.SelectedValue != "0" 
                        && !string.IsNullOrWhiteSpace(ddlFechas.SelectedItem.Text))
                    {
                        ConfiguracionTurno.Fecha = DateTime.Parse(ddlFechas.SelectedItem.Text);
                    }

                    gvTurnos.DataSource = gestionTablas.ObtenerTablaTurnos(ConfiguracionTurno);
                    gvTurnos.DataBind();
                }
            }
            else
            {
                gvTurnos.Columns[7].Visible = false;
                hlAgregarMedico.Visible = false;

                hlAsignarTurnos.Visible = false;
                hlInformes.Visible = false;
                hlListarMedicos.Visible = false;
                hlListarTurnos.Visible = false;
                hlSeguimientoPaciente.Visible = false;
                lblFecha.Visible = false;
                ddlFechas.Visible = false;
                btnMostrarTodo.Visible = false;
                btnConsultarEstado.Visible = false;
                ddlEstados.Visible = false;
            }
        }

        protected void ddlEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfiguracionTurno.LegajoMed = ((Usuario)Session["UsuarioActivo"]).LegajoDoctor;

            gvTurnos.DataSource = gestionTablas.ObtenerTablaTurnos(ConfiguracionTurno, Convert.ToInt32(ddlEstados.SelectedValue));
            gvTurnos.DataBind();
        }

        protected void ddlFechas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlFechas.SelectedItem != null && ddlFechas.SelectedValue != "0")
            {
                ConfiguracionTurno.Fecha = DateTime.ParseExact(ddlFechas.SelectedItem.Text,"dd/MM/yyyy",CultureInfo.InvariantCulture);
            }

            if (((Usuario)Session["UsuarioActivo"]).TipoUsuario >= 1)
            {
                ConfiguracionTurno.LegajoMed = ((Usuario)Session["UsuarioActivo"]).LegajoDoctor;
            }

            // Guarda el filtro en Session
            Session["FiltroTurno"] = ConfiguracionTurno;

            gvTurnos.DataSource = gestionTablas.ObtenerTablaTurnos(ConfiguracionTurno, Convert.ToInt32(ddlEstados.SelectedValue));
            gvTurnos.DataBind();
        }

        protected void gvTurnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTurnos.PageIndex = e.NewPageIndex;
            Turno configuracionTurnos = Session["FiltroTurno"] as Turno ?? new Turno();

            gvTurnos.DataSource = gestionTablas.ObtenerTablaTurnos(configuracionTurnos, Convert.ToInt32(ddlEstados.SelectedValue)); // se cambio el filtro
            gvTurnos.DataBind();
        }

        protected void gvTurnos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvTurnos.EditIndex = e.NewEditIndex;            
            gvTurnos.DataSource = gestionTablas.ObtenerTablaTurnos(ConfiguracionTurno, Convert.ToInt32(ddlEstados.SelectedValue));
            gvTurnos.DataBind();
        }

        protected void gvTurnos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Aqui se desglosa Numero de turno, y se pueden sacar varios datos desde ahi

            string NumeroTurno = gvTurnos.DataKeys[e.RowIndex].Value.ToString();
            string[] Division = NumeroTurno.Split('-');
            int semana = int.Parse(Division[0]);
            int idDia = int.Parse(Division[1]);
            int idEspecialidad = int.Parse(Division[2]);
            int legajo = int.Parse(Division[3]);


            GridViewRow fila = gvTurnos.Rows[e.RowIndex];
            //Logico de eliminar va aqui o el llamado a eliminar el turno, se hace a traves del mismo metodo de asignar turno,
            //pasando los datos del turno sin el dni(dni null)
            ConfiguracionTurno = new Turno(
             null,idEspecialidad, legajo, Convert.ToDateTime(((System.Web.UI.WebControls.Label)fila.FindControl("lbl_it_Fecha")).Text),
             TimeSpan.Parse(((System.Web.UI.WebControls.Label)fila.FindControl("lbl_it_Horario")).Text)
             );

            int Retorno = GestorRegistros.RegistrarTurno(ConfiguracionTurno);

            ConfiguracionTurno = new Turno();
            Session["FiltroTurno"] = ConfiguracionTurno;

            gvTurnos.DataSource = gestionTablas.ObtenerTablaTurnos(ConfiguracionTurno, Convert.ToInt32(ddlEstados.SelectedValue));
            gvTurnos.DataBind();
        }
        
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ConfiguracionTurno.DniPaciente = txtBuscador.Text.Trim();
            if (Session["UsuarioActivo"] != null)
            {
                ConfiguracionTurno.LegajoMed = ((Usuario)Session["UsuarioActivo"]).LegajoDoctor;
            }

            if (!string.IsNullOrEmpty(txtBuscador.Text))
            {
                lblMensaje.Text = string.Empty;

                DataTable tablaFiltrada = gestionTablas.ObtenerTablaTurnos(ConfiguracionTurno, 2);//El estado se coloca en '2' por que seria un Turno Tomado.
                gvTurnos.DataSource = tablaFiltrada;
                gvTurnos.DataBind();
            }
            else
            {
                lblMensaje.Text = "Ingrese DNI a buscar.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ConfiguracionTurno.LegajoMed = ((Usuario)Session["UsuarioActivo"]).LegajoDoctor;

            gvTurnos.DataSource = gestionTablas.ObtenerTablaTurnos(ConfiguracionTurno, Convert.ToInt32(ddlEstados.SelectedValue));
            gvTurnos.DataBind();
            txtBuscador.Text = string.Empty;
            ddlFechas.SelectedIndex = 0;
        }

        protected void gvTurnos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvTurnos.EditIndex = -1;//Salir del Edit
            gvTurnos.DataSource = gestionTablas.ObtenerTablaTurnos(ConfiguracionTurno, Convert.ToInt32(ddlEstados.SelectedValue));
            gvTurnos.DataBind();
        }

        protected void gvTurnos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //No estoy completamente seguro de que mas se deberia poder subir o actualizar desde aqui, asi que por el momento solo esta el DNI,
            //aunque hay un txt para el nombre del paciente es temporal ya que depende del dni asi que no tiene mucho sentido
            string NumeroTurno = gvTurnos.DataKeys[e.RowIndex].Value.ToString();
            string[] Division = NumeroTurno.Split('-');

            int idEspecialidad = int.Parse(Division[2]);
            int legajo = int.Parse(Division[3]);

            GridViewRow fila = gvTurnos.Rows[e.RowIndex];

            ConfiguracionTurno = new Turno();
            ConfiguracionTurno.IDEspecialidad = idEspecialidad;
            ConfiguracionTurno.LegajoMed = legajo;
            ConfiguracionTurno.Fecha = Convert.ToDateTime(((System.Web.UI.WebControls.Label)fila.FindControl("lbl_it_Fecha")).Text);
            ConfiguracionTurno.Hora = TimeSpan.Parse(((System.Web.UI.WebControls.Label)fila.FindControl("lbl_it_Horario")).Text);

            int Resulado = GestorRegistros.RegistrarTurno(ConfiguracionTurno);

            Session.Remove("FiltroTurno");
            gvTurnos.DataSource = gestionTablas.ObtenerTablaTurnos(ConfiguracionTurno, Convert.ToInt32(ddlEstados.SelectedValue));
            gvTurnos.DataBind();

            gvTurnos.EditIndex = -1;//Salir del Edit
        }
        //////////////////////////////////////////////////////////////////////////////////////
        protected void gvTurnos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int idTurno = Convert.ToInt32(gvTurnos.Rows[e.NewSelectedIndex].FindControl("lbl_it_NumeroTurno"));
            string paciente = ((WebLabel)gvTurnos.Rows[e.NewSelectedIndex].FindControl("lbl_it_NombrePaciente")).Text;
            string fecha = ((WebLabel)gvTurnos.Rows[e.NewSelectedIndex].FindControl("lbl_it_Fecha")).Text;

            // guardo en una session
            Session["TurnoSeleccionado"] = new
            {
                ID = idTurno,
                Paciente = paciente,
                Fecha = fecha
            };
            Response.Redirect("SeguimientosPacientes.aspx");
        }


    }
}
