using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
  public class MostrarMarcaVehiculo
  {
    public int PK_MarcaVehiculo { get; set; }
    public CatalogoPais Pais { get; set; }
    public string MarcaVehiculo1 { get; set; }
    public int AnioFundacion { get; set; }

    private BDAutoloteEntities conexion;
    public MostrarMarcaVehiculo()
    {
      Init();
    }

    private void Init()
    {
      this.MarcaVehiculo1 = String.Empty;
      this.AnioFundacion = 1999;
      conexion = new BDAutoloteEntities();
    }

    
    }
    }
  

