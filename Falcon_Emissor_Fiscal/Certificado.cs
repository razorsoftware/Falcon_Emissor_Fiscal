using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Falcon_Emissor_Fiscal
{
    public class Certificado
    {

        public static X509Certificate2 get_certificado(){

            X509Certificate2 certificado = new X509Certificate2();

            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
            X509Certificate2Collection collection = (X509Certificate2Collection)store.Certificates;
            X509Certificate2Collection collection1 = (X509Certificate2Collection)collection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
            X509Certificate2Collection collection2 = (X509Certificate2Collection)collection.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, false);
            X509Certificate2Collection scollection = X509Certificate2UI.SelectFromCollection(collection2, "Certificados disponíveis", "Selecione o certificado digital", X509SelectionFlag.SingleSelection);

            if (scollection.Count == 0 || scollection == null)
                throw new Exception("Nenhum certificado encontrado !");
            
            certificado = scollection[0];
            return certificado;

            
            
            
        }

    }
}
