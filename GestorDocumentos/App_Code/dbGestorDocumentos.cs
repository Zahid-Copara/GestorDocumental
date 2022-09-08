using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

public class BaseDatos : DataContext
{
    public BaseDatos() : base(@"Data Source=ZAHID;Initial Catalog=dBGestorDocumentos;Integrated Security=True") { }
    public Table<Titulo> tblTitulo;
    public Table<Cargo> tblCargo;
    public Table<Contacto> tblContacto;
    public Table<Provincia> tblProvincia;
    public Table<Organizacion> tblOrganizacion;
    public Table<GrupoCostos> tblGrupoCostos;
    public Table<CategoriaCorreo> tblCategoriaCorreo;
    public Table<Documento> tblDocumento;
    public Table<DocumentoDetalle> tblDocumentoDetalle;
}

[Table(Name = "tblTitulo")]
public class Titulo
{
    [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
    public int idTitulo;
    [Column]
    public string Nombre;
    public override string ToString()
    {
        return Nombre;
    }
}

[Table(Name = "tblCargo")]
public class Cargo
{
    [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
    public int idCargo;
    [Column]
    public string Nombre;
    public override string ToString()
    {
        return Nombre;
    }
}

[Table(Name = "tblContacto")]
public class Contacto
{

    [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
    public int idContacto;
    [Column]
    public int idCargo;
    [Column]
    public int idTitulo;
    [Column]
    public string Nombre;
    [Column]
    public string Apellido;
    [Column]
    public string numCedula;
    [Column]
    public string CorreoElectronico;
    [Column]
    public string Telefono;
    [Column]
    public string Celular;
    public override string ToString()
    {
        return idContacto + "-" + Nombre + " " + Apellido;
    }
}

[Table(Name = "tblProvincia")]
public class Provincia
{
    [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
    public int idProvincia;
    [Column]
    public string Nombre;
    public override string ToString()
    {
        return Nombre;
    }
}

[Table(Name = "tblOrganizacion")]
public class Organizacion
{

    [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
    public int idOrganizacion;
    [Column]
    public string Nombre;
    [Column]
    public string Direccion;
    [Column]
    public string CodigoPostal;
    [Column]
    public string Ciudad;
    [Column]
    public int idProvincia;
    [Column]
    public string Telefono;
    [Column]
    public string Correo;
    [Column]
    public string SitioWeb;

    public override string ToString()
    {
        return Nombre + " - " + Ciudad + " - " + Direccion;
    }
}

[Table(Name = "tblGrupoCostos")]
public class GrupoCostos
{
    [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
    public int idGrupoCostos;
    [Column]
    public string Nombre;
    public override string ToString()
    {
        return Nombre;
    }
}

[Table(Name = "tblCategoriaCorreo")]
public class CategoriaCorreo
{
    [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
    public int idCategoriaCorreo;
    [Column]
    public string Nombre;
    public override string ToString()
    {
        return Nombre;
    }
}

[Table(Name = "tblDocumento")]
public class Documento
{

    [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
    public int idDocumento;
    [Column]
    public DateTime FechaDocumento;
    [Column]
    public int idOrganizacion;
    [Column]
    public int idCategoriaCorreo;
    [Column]
    public int idGrupoCostos;
    [Column]
    public int idContacto;
    [Column]
    public decimal subtotal;
    [Column]
    public decimal valorIVA;
    [Column]
    public decimal total;
    public override string ToString()
    {
        return idDocumento + "- Subtotal:" + subtotal + " - Total:" + total;
    }
}

[Table(Name = "tblDocumentoDetalle")]
public class DocumentoDetalle
{

    [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
    public int idDocumentoDetalle;
    [Column]
    public int idDocumento;
    [Column]
    public string descripcion;
    [Column]
    public int cantidadProducto;
    [Column]
    public decimal precioUnitario;
    [Column]
    public int IVA;
    [Column]
    public decimal valorTotalDetalle;
    public override string ToString()
    {
        return idDocumentoDetalle + "-" + descripcion + " - $" + precioUnitario + "*" + cantidadProducto;
    }
}