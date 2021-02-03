using System;

public class PuntoInteres
{
	private String descripcion;
	private double latitud;
	private double longitud;
	private int id;

	public PuntoInteres( String d, double lat, double lng, int id)
	{
		descripcion = d;
		latitud = lat;
		longitud = lng;
		this.id = id;
	}

    public string Descripcion { get => descripcion; set => descripcion = value; }
    public double Latitud { get => latitud; set => latitud = value; }
    public double Longitud { get => longitud; set => longitud = value; }
    public int Id { get => id; set => id = value; }
}
