using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class Facture
    {
        //[Required(ErrorMessage ="Besoin d'un client")]
        public string Client { get; set; }
        
        [Required(ErrorMessage ="Besoin d'un numéro")]
        public string Numero { get; set; }
        
        //[Required(ErrorMessage ="Besoin d'une date d'émission")]
        public string DateEmission { get; set; }
        
        //[Required(ErrorMessage ="Besoin d'une date de réglement")]
        public string DateReglement { get; set; }
        
        //[Required(ErrorMessage ="Besoin d'un montant ")]
        public float MontantDu { get; set; }
        
        //[Required(ErrorMessage ="Besoin d'un montant ")]
        public float MontantRegle { get; set; }
        public float ResteARecevoir { get; set; }
        public Facture(string client, string numero, string dateEmission, string dateReglement, float montantDu, float montantRegle)
        {
           
                Client = client;
                Numero = numero;
                DateEmission = dateEmission;
                DateReglement = dateReglement;
                MontantDu  = montantDu;
                MontantRegle = montantRegle;
                ResteARecevoir = montantDu - montantRegle;
            
        }
    }
}
