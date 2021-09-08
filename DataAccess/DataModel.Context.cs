﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDAutoloteEntities : DbContext
    {
        public BDAutoloteEntities()
            : base("name=BDAutoloteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Autolote> Autolote { get; set; }
        public DbSet<CatalogoCiudad> CatalogoCiudad { get; set; }
        public DbSet<CatalogoDepartamento> CatalogoDepartamento { get; set; }
        public DbSet<CatalogoPais> CatalogoPais { get; set; }
        public DbSet<CatalogoTipoMoneda> CatalogoTipoMoneda { get; set; }
        public DbSet<CatalogoUnidadLongitud> CatalogoUnidadLongitud { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ColorVehiculo> ColorVehiculo { get; set; }
        public DbSet<CompraVehiculo> CompraVehiculo { get; set; }
        public DbSet<ContactoAutolote> ContactoAutolote { get; set; }
        public DbSet<ContactoCliente> ContactoCliente { get; set; }
        public DbSet<ContactoEmpleado> ContactoEmpleado { get; set; }
        public DbSet<ContactoProveedor> ContactoProveedor { get; set; }
        public DbSet<CuerpoVehiculo> CuerpoVehiculo { get; set; }
        public DbSet<DetalleCompraVehiculo> DetalleCompraVehiculo { get; set; }
        public DbSet<DetalleVentaVehiculo> DetalleVentaVehiculo { get; set; }
        public DbSet<DireccionAutolote> DireccionAutolote { get; set; }
        public DbSet<DireccionCliente> DireccionCliente { get; set; }
        public DbSet<DireccionEmpleado> DireccionEmpleado { get; set; }
        public DbSet<DireccionProveedor> DireccionProveedor { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<EstadoVehiculo> EstadoVehiculo { get; set; }
        public DbSet<IdentificacionCliente> IdentificacionCliente { get; set; }
        public DbSet<IdentificacionEmpleado> IdentificacionEmpleado { get; set; }
        public DbSet<IdentificacionProveedor> IdentificacionProveedor { get; set; }
        public DbSet<MarcaVehiculo> MarcaVehiculo { get; set; }
        public DbSet<ModeloVehiculo> ModeloVehiculo { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<TipoCliente> TipoCliente { get; set; }
        public DbSet<TipoContacto> TipoContacto { get; set; }
        public DbSet<TipoEmpleado> TipoEmpleado { get; set; }
        public DbSet<TipoIdentificacion> TipoIdentificacion { get; set; }
        public DbSet<TipoMotor> TipoMotor { get; set; }
        public DbSet<TipoProveedor> TipoProveedor { get; set; }
        public DbSet<TipoTransmision> TipoTransmision { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<VentaVehiculo> VentaVehiculo { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
