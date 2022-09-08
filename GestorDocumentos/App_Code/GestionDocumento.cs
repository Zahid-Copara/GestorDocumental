using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GestionDocumento" in code, svc and config file together.
public class GestionDocumento : IGestionDocumento
{
    BaseDatos miDB = new BaseDatos();
    #region LecturaElementos
    public List<Cargo> LeerCargo()
    {
        List<Cargo> cargos = new List<Cargo>();
        var listaCargo = from aux in miDB.tblCargo
                         select aux;

        foreach (var iter in listaCargo)
        {
            cargos.Add(iter);
        }

        return cargos;
    }
    public List<Titulo> LeerTitulo()
    {
        List<Titulo> titulos = new List<Titulo>();
        var listaTitulos = from aux in miDB.tblTitulo
                           select aux;

        foreach (var iter in listaTitulos)
        {
            titulos.Add(iter);
        }

        return titulos;
    }
    public List<Provincia> LeerProvincia()
    {
        List<Provincia> provincias = new List<Provincia>();
        var listaProvincias = from aux in miDB.tblProvincia
                              select aux;

        foreach (var iter in listaProvincias)
        {
            provincias.Add(iter);
        }

        return provincias;
    }
    public List<CategoriaCorreo> LeerCategoriaCorreo()
    {
        List<CategoriaCorreo> categoriaCorreos = new List<CategoriaCorreo>();
        var listaCategoriaCorreos = from aux in miDB.tblCategoriaCorreo
                              select aux;

        foreach (var iter in listaCategoriaCorreos)
        {
            categoriaCorreos.Add(iter);
        }

        return categoriaCorreos;
    }
    public List<Contacto> LeerContacto()
    {
        List<Contacto> contactos = new List<Contacto>();
        var listConta = from aux in miDB.tblContacto
                        select aux;

        foreach (var iter in listConta)
        {
            contactos.Add(iter);
        }

        return contactos;
    }
    public List<Organizacion> LeerOrganizacion()
    {
        List<Organizacion> organizaciones = new List<Organizacion>();
        var listOrg = from aux in miDB.tblOrganizacion
                        select aux;

        foreach (var iter in listOrg)
        {
            organizaciones.Add(iter);
        }

        return organizaciones;
    }
    public List<GrupoCostos> LeerGrupoCosto()
    {
        List<GrupoCostos> grupoCostos = new List<GrupoCostos>();
        var listaGrupoCostos = from aux in miDB.tblGrupoCostos
                              select aux;

        foreach (var iter in listaGrupoCostos)
        {
            grupoCostos.Add(iter);
        }

        return grupoCostos;
    }
    #endregion
    #region AgregarElementos
    public void AgregarContacto(int idCargo, int idTitulo, string nombre, string apellido, string numCedula, string correo, string numTelefonico, string celular)
    {
        Contacto contacto = new Contacto();
        contacto.idCargo = idCargo;
        contacto.idTitulo = idTitulo;
        contacto.Nombre = nombre;
        contacto.Apellido = apellido;
        contacto.numCedula = numCedula;
        contacto.CorreoElectronico = correo;
        contacto.Telefono = numTelefonico;
        contacto.Celular = celular;
        miDB.tblContacto.InsertOnSubmit(contacto);
        miDB.SubmitChanges();
    }
    public void AgregarOrganizacion(string nombreOrg, string direccionOrg, string codigoPostal, string ciudadOrg, int idProvincia, string telefonoOrg, string correoOrg, string sitioWebOrg)
    {
        Organizacion organizacion = new Organizacion();
        organizacion.Nombre = nombreOrg;
        organizacion.Direccion = direccionOrg;
        organizacion.CodigoPostal = codigoPostal;
        organizacion.Ciudad = ciudadOrg;
        organizacion.idProvincia = idProvincia;
        organizacion.Telefono = telefonoOrg;
        organizacion.Correo = correoOrg;
        organizacion.SitioWeb = sitioWebOrg;
        miDB.tblOrganizacion.InsertOnSubmit(organizacion);
        miDB.SubmitChanges();
    }
    public void AgregarProvincia(string nombreProvincia)
    {
        Provincia provincia = new Provincia();
        provincia.Nombre = nombreProvincia;
        miDB.tblProvincia.InsertOnSubmit(provincia);
        miDB.SubmitChanges();
    }
    public void AgregarCargo(string nombreCargo)
    {
        Cargo cargo = new Cargo();
        cargo.Nombre = nombreCargo;
        miDB.tblCargo.InsertOnSubmit(cargo);
        miDB.SubmitChanges();
    }
    public void AgregarCategoriaCorreo(string nombreCategoriaCorreo)
    {
        CategoriaCorreo categoriaCorreo = new CategoriaCorreo();
        categoriaCorreo.Nombre = nombreCategoriaCorreo;
        miDB.tblCategoriaCorreo.InsertOnSubmit(categoriaCorreo);
        miDB.SubmitChanges();
    }
    public void AgregarGrupoCosto(string nombreGrupoCosto)
    {
        GrupoCostos grupoCosto = new GrupoCostos();
        grupoCosto.Nombre = nombreGrupoCosto;
        miDB.tblGrupoCostos.InsertOnSubmit(grupoCosto);
        miDB.SubmitChanges();
    }
    public void AgregarTitulo(string nombreTitulo)
    {
        Titulo titulo = new Titulo();
        titulo.Nombre = nombreTitulo;
        miDB.tblTitulo.InsertOnSubmit(titulo);
        miDB.SubmitChanges();
    }
    #endregion
    #region EliminarElementos
    public void EliminarContacto(int idContacto)
    {
        var iper = (from iter in miDB.tblContacto
                    where iter.idContacto == idContacto
                    select iter).SingleOrDefault();
        miDB.tblContacto.DeleteOnSubmit(iper);
        miDB.SubmitChanges();
    }
    public void EliminarOrganizacion(int idOrganizacion)
    {
        var iper = (from iter in miDB.tblOrganizacion
                    where iter.idOrganizacion == idOrganizacion
                    select iter).SingleOrDefault();
        miDB.tblOrganizacion.DeleteOnSubmit(iper);
        miDB.SubmitChanges();
    }
    public void EliminarProvincia(int idProvincia)
    {
        var iper = (from iter in miDB.tblProvincia
                    where iter.idProvincia == idProvincia
                    select iter).SingleOrDefault();
        miDB.tblProvincia.DeleteOnSubmit(iper);
        miDB.SubmitChanges();
    }
    public void EliminarCargo(int idCargo)
    {
        var iper = (from iter in miDB.tblCargo
                    where iter.idCargo == idCargo
                    select iter).SingleOrDefault();
        miDB.tblCargo.DeleteOnSubmit(iper);
        miDB.SubmitChanges();
    }
    public void EliminarCategoriaCorreo(int idCategoriaCorreo)
    {
        var iper = (from iter in miDB.tblCategoriaCorreo
                    where iter.idCategoriaCorreo == idCategoriaCorreo
                    select iter).SingleOrDefault();
        miDB.tblCategoriaCorreo.DeleteOnSubmit(iper);
        miDB.SubmitChanges();
    }
    public void EliminarGrupoCosto(int idGrupoCosto)
    {
        var iper = (from iter in miDB.tblGrupoCostos
                    where iter.idGrupoCostos == idGrupoCosto
                    select iter).SingleOrDefault();
        miDB.tblGrupoCostos.DeleteOnSubmit(iper);
        miDB.SubmitChanges();
    }
    public void EliminarTitulo(int idTitulo)
    {
        var iper = (from iter in miDB.tblTitulo
                    where iter.idTitulo == idTitulo
                    select iter).SingleOrDefault();
        miDB.tblTitulo.DeleteOnSubmit(iper);
        miDB.SubmitChanges();
    }
    #endregion
    #region BuscarElementos
    public Contacto BuscarContacto(string numCedula)
    {
        var iper = (from iter in miDB.tblContacto
                    where iter.numCedula == numCedula
                    select iter).SingleOrDefault();
        return iper;
    }
    public Organizacion BuscarOrganizacion(int idOrganizacion)
    {
        var iper = (from iter in miDB.tblOrganizacion
                    where iter.idOrganizacion == idOrganizacion
                    select iter).SingleOrDefault();
        return iper;
    }
    public Organizacion BuscarOrg_Nombre(string nombreOrg)
    {
        var iper = (from iter in miDB.tblOrganizacion
                    where iter.Nombre == nombreOrg
                    select iter).SingleOrDefault();
        return iper;
    }
    public Organizacion BuscarOrg_Direccion(string direccionOrg)
    {
        var iper = (from iter in miDB.tblOrganizacion
                    where iter.Direccion == direccionOrg
                    select iter).SingleOrDefault();
        return iper;
    }
    public Provincia BuscarProvincia(string nombreProvincia)
    {
        var iper = (from iter in miDB.tblProvincia
                    where iter.Nombre == nombreProvincia
                    select iter).SingleOrDefault();
        return iper;
    }
    public Cargo BuscarCargo(string nombreCargo)
    {
        var iper = (from iter in miDB.tblCargo
                    where iter.Nombre == nombreCargo
                    select iter).SingleOrDefault();
        return iper;
    }
    public CategoriaCorreo BuscarCategoriaCorreo(string nombreCategoriaCorreo)
    {
        var iper = (from iter in miDB.tblCategoriaCorreo
                    where iter.Nombre == nombreCategoriaCorreo
                    select iter).SingleOrDefault();
        return iper;
    }
    public GrupoCostos BuscarGrupoCosto(string nombreGrupoCosto)
    {
        var iper = (from iter in miDB.tblGrupoCostos
                    where iter.Nombre == nombreGrupoCosto
                    select iter).SingleOrDefault();
        return iper;
    }
    public Titulo BuscarTitulo(string nombreTitulo)
    {
        var iper = (from iter in miDB.tblTitulo
                    where iter.Nombre == nombreTitulo
                    select iter).SingleOrDefault();
        return iper;
    }
    #endregion
    #region EditarElementos
    public void EditarContacto(int idContacto, int idCargo, int idTitulo, string nombre, string apellido, string numCedula, string correo, string numTelefonico, string celular)
    {
        var iper = (from iter in miDB.tblContacto
                    where iter.idContacto == idContacto
                    select iter).SingleOrDefault();

        iper.idCargo = idCargo;
        iper.idTitulo = idTitulo;
        iper.Nombre = nombre;
        iper.Apellido = apellido;
        iper.numCedula = numCedula;
        iper.CorreoElectronico = correo;
        iper.Telefono = numTelefonico;
        iper.Celular = celular;
        miDB.SubmitChanges();
    }
    public void EditarOrganizacion(int idOrganizacion, string nombreOrg, string direccionOrg, string codigoPostal, string ciudadOrg, int idProvincia, string telefonoOrg, string correoOrg, string sitioWebOrg)
    {
        var iper = (from iter in miDB.tblOrganizacion
                    where iter.idOrganizacion == idOrganizacion
                    select iter).SingleOrDefault();

        iper.Nombre = nombreOrg;
        iper.Direccion = direccionOrg;
        iper.CodigoPostal = codigoPostal;
        iper.Ciudad = ciudadOrg;
        iper.idProvincia = idProvincia;
        iper.Telefono = telefonoOrg;
        iper.Correo = correoOrg;
        iper.SitioWeb = sitioWebOrg;
        miDB.SubmitChanges();
    }
    public void EditarProvincia(int idProvincia, string nombreProvincia)
    {
        var iper = (from iter in miDB.tblProvincia
                    where iter.idProvincia == idProvincia
                    select iter).SingleOrDefault();

        iper.Nombre = nombreProvincia;
        miDB.SubmitChanges();
    }
    public void EditarCargo(int idCargo, string nombreCargo)
    {
        var iper = (from iter in miDB.tblCargo
                    where iter.idCargo == idCargo
                    select iter).SingleOrDefault();

        iper.Nombre = nombreCargo;
        miDB.SubmitChanges();
    }
    public void EditarCategoriaCorreo(int idCategoriaCorreo, string nombreCategoriaCorreo)
    {
        var iper = (from iter in miDB.tblCategoriaCorreo
                    where iter.idCategoriaCorreo == idCategoriaCorreo
                    select iter).SingleOrDefault();

        iper.Nombre = nombreCategoriaCorreo;
        miDB.SubmitChanges();
    }
    public void EditarGrupoCosto(int idGrupoCosto, string nombreGrupoCosto)
    {
        var iper = (from iter in miDB.tblGrupoCostos
                    where iter.idGrupoCostos == idGrupoCosto
                    select iter).SingleOrDefault();

        iper.Nombre = nombreGrupoCosto;
        miDB.SubmitChanges();
    }
    public void EditarTitulo(int idTitulo, string nombreTitulo)
    {
        var iper = (from iter in miDB.tblTitulo
                    where iter.idTitulo == idTitulo
                    select iter).SingleOrDefault();

        iper.Nombre = nombreTitulo;
        miDB.SubmitChanges();
    }
    #endregion







}
