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

            var tipoPaquete = new TiposPaquete();
            tipoPaquete.Paquetes = "Grande";
            contexto.TiposPaquetes.Add(tipoPaquete);

            var tipoPaquete2 = new TiposPaquete();
            tipoPaquete2.Paquetes = "Mediano";
            contexto.TiposPaquetes.Add(tipoPaquete2);

            var tipoPaquete3 = new TiposPaquete();
            tipoPaquete3.Paquetes = "Pequeño";
            contexto.TiposPaquetes.Add(tipoPaquete3);

            var tipoPaquete5 = new TiposPaquete();
            tipoPaquete5.Paquetes = "Extra Grande";
            contexto.TiposPaquetes.Add(tipoPaquete5);

            var tipoPaquete4 = new TiposPaquete();
            tipoPaquete4.Paquetes = "Sobre";
            contexto.TiposPaquetes.Add(tipoPaquete4);

            var tipopago = new FormasPago();
            tipopago.Pagos = "Efectivo";
            contexto.FormasdePago.Add(tipopago);

            var tipopago2 = new FormasPago();
            tipopago2.Pagos = "Tarjeta de Credito";
            contexto.FormasdePago.Add(tipopago2);

            var estado = new Estado();
            estado.EstadodePago = "Pagado";
            contexto.EstadoDePagos.Add(estado);

            var estado2 = new Estado();
            estado2.EstadodePago = "Cobro en Destino";
            contexto.EstadoDePagos.Add(estado2);

            var status = new Estatus();
            status.Status = "Por Entregar";
            contexto.EstatusPaquete.Add(status);
            
            var status2 = new Estatus();
            status2.Status = "En Tránsito";
            contexto.EstatusPaquete.Add(status2);

            var status3 = new Estatus();
            status3.Status = "Entregado";
            contexto.EstatusPaquete.Add(status3);

            base.Seed(contexto);//
        }
    }
}