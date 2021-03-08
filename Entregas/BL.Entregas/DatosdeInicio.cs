using System.Data.Entity;

namespace BL.Entregas
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>//

    {
        protected override void Seed(Contexto contexto)//
        {
            
            var tipo1 = new Tipo();//
            tipo1.Descripcion = "Cliente Contado";//
            contexto.Tipos.Add(tipo1);//

            var tipo2 = new Tipo();//
            tipo2.Descripcion = "Cliente Credito";//
            contexto.Tipos.Add(tipo2);//

            base.Seed(contexto);//
        }
    }
}