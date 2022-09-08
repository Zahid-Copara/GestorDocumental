using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGestionDocumento" in both code and config file together.
[ServiceContract]
public interface IGestionDocumento
{
    #region LecturaElementos
    [OperationContract]
	List<Cargo> LeerCargo();
	[OperationContract]
	List<Titulo> LeerTitulo();
	[OperationContract]
	List<Provincia> LeerProvincia();
	[OperationContract]
	List<Contacto> LeerContacto();
	[OperationContract]
	List<Organizacion> LeerOrganizacion();
	[OperationContract]
	List<CategoriaCorreo> LeerCategoriaCorreo();
	[OperationContract]
	List<GrupoCostos> LeerGrupoCosto();
	#endregion
	#region AgregarElementos
	[OperationContract]
	void AgregarContacto(int idCargo, int idTitulo,string nombre, string apellido, string numCedula, string correo, string numTelefonico, string celular);
	[OperationContract]
	void AgregarOrganizacion(string nombreOrg, string direccionOrg, string codigoPostal, string ciudadOrg, int idProvincia, string telefonoOrg,string correoOrg, string sitioWebOrg);
	[OperationContract]
	void AgregarProvincia(string nombreProvincia);
	[OperationContract]
	void AgregarCargo(string nombreCargo);
	[OperationContract]
	void AgregarCategoriaCorreo(string nombreCategoriaCorreo);
	[OperationContract]
	void AgregarGrupoCosto(string nombreGrupoCostos);
	[OperationContract]
	void AgregarTitulo(string nombreTitulo);
    #endregion
    #region EliminarElementos
	[OperationContract]
	void EliminarContacto(int idContacto);
	[OperationContract]
	void EliminarOrganizacion(int idOrganizacion);
	[OperationContract]
	void EliminarProvincia(int idProvincia);
	[OperationContract]
	void EliminarCargo(int idCargo);
	[OperationContract]
	void EliminarCategoriaCorreo(int idCategoriaCorreo);
	[OperationContract]
	void EliminarGrupoCosto(int idGrupoCosto);
	[OperationContract]
	void EliminarTitulo(int idTitulo);
	#endregion
	#region BuscarElementos
	[OperationContract]
	Contacto BuscarContacto(string numCedula);
	[OperationContract]
	Organizacion BuscarOrganizacion(int idOrganizacion);
	[OperationContract]
	Organizacion BuscarOrg_Nombre(string nombreOrg);
	[OperationContract]
	Organizacion BuscarOrg_Direccion(string direccionOrg);
	[OperationContract]
	Provincia BuscarProvincia(string nombreProvincia);
	[OperationContract]
	Cargo BuscarCargo(string nombreCargo);
	[OperationContract]
	CategoriaCorreo BuscarCategoriaCorreo(string nombreCategoriaCorreo);
	[OperationContract]
	GrupoCostos BuscarGrupoCosto(string nombreGrupoCosto);
	[OperationContract]
	Titulo BuscarTitulo(string nombreTitulo);
	#endregion
	#region EditarElementos
	[OperationContract]
	void EditarContacto(int idContacto, int idCargo, int idTitulo, string nombre, string apellido, string numCedula, string correo, string numTelefonico, string celular);
	[OperationContract]
	void EditarOrganizacion(int idOrganizacion,string nombreOrg, string direccionOrg, string codigoPostal, string ciudadOrg, int idProvincia, string telefonoOrg, string correoOrg, string sitioWebOrg);
	[OperationContract]
	void EditarProvincia(int idProvincia, string nombreProvincia);
	[OperationContract]
	void EditarCargo(int idCargo, string nombreCargo);
	[OperationContract]
	void EditarCategoriaCorreo(int idCategoriaCorreo, string nombreCategoriaCorreo);
	[OperationContract]
	void EditarGrupoCosto(int idGrupoCosto, string nombreGrupoCosto);
	[OperationContract]
	void EditarTitulo(int idTitulo, string nombreTitulo);
	#endregion
}


