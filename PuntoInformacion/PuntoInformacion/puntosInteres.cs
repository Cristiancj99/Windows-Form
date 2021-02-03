using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using System.Collections;

namespace PuntoInformacion
{
    public partial class puntosInteres : UserControl
    {
        private ArrayList puntosDeInteres;
        private GMapOverlay markerOverlay;
        private GMarkerGoogle marker;
        private DataTable dt;
        private int filaSeleccionada;
        bool admin;
         Database db;

        public puntosInteres( bool admin)
        {
            
            puntosDeInteres = new ArrayList();
            InitializeComponent();
            this.admin = admin;
            this.db = new Database();
            if (!admin)
            {
                button2.Visible = false;
                Eliminar.Visible = false;
                dataGridView1.Visible = false;
                txtDescripcion.Enabled = false;
                txtLat.Enabled = false;
                txtLng.Enabled = false;
            }

                
        }

        private void puntosInteres_Load(object sender, EventArgs e)
        {
            
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripcion", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(Double)));
            dt.Columns.Add(new DataColumn("Long", typeof(Double)));

            actualizarDatos();

            //dt.Rows.Add("ces cristo rey", 37.18460, -3.59297);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;


            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new GMap.NET.PointLatLng(37.18460,-3.59297);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 18;
            gMapControl1.AutoScroll = true;
            

            markerOverlay = new GMapOverlay("Ces Cristo Rey");
            marker = new GMarkerGoogle(new PointLatLng(37.18460, -3.59297), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud:{0} \nLongitud:{1}", 37.18460, -3.59297);
            gMapControl1.Overlays.Add(markerOverlay);

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void gMapControl2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            txtDescripcion.Text = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
            txtLat.Text = dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();
            txtLng.Text = dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();

            marker.Position = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text));
            gMapControl1.Position = marker.Position;


        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            txtLat.Text = lat.ToString();
            txtLng.Text = lng.ToString();

            marker.Position = new PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud:{0} \nLongitud:{1}", lat, lng);



        }



        private void aniadirPuntos(object sender, MouseEventArgs e)
        {
            dt.Rows.Add(txtDescripcion.Text, txtLat.Text, txtLng.Text);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud:{0} \nLongitud:{1}", txtLat.Text, txtLng.Text);
            gMapControl1.Overlays.Add(markerOverlay);

        }

        private void eliminarPuntos(object sender, MouseEventArgs e)
        {
            dt.Rows.RemoveAt(filaSeleccionada);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtDescripcion.Text, txtLat.Text, txtLng.Text);
            
            db.insertar(txtDescripcion.Text, Convert.ToDouble( txtLat.Text), Convert.ToDouble(txtLng.Text));
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            dt.Rows.RemoveAt(filaSeleccionada);

        }

        public void actualizarDatos()
        {
            puntosDeInteres = db.resultadosBd();
            foreach(PuntoInteres item in puntosDeInteres)
            {
                dt.Rows.Add(item.Descripcion,item.Latitud,item.Longitud);
            }

        }
    }
}
