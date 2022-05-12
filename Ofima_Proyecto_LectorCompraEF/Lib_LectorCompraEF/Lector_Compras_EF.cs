using Lib_LectorCompraEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lib_LectorCompraEF
{
    public class Lector_Compras_EF
    {
        //Atributos

        private int SalidaXML { get; set; }
        private string Nodo { get; set; }

        public Lector_Compras_EF()
        {
            
            SalidaXML = 0;
            Nodo = string.Empty;
        }

        //Metodo encargado de retornar la informacion referente al emisor
        public dynamic LectorXMLEmisor(string RutaXML,int Origen)
        {
            Emisor NewEmisor = new Emisor();
      
            //Se inicializa la variable encargada de determinar el momento de salir de los foreach
            SalidaXML = 0;

            XmlDocument ReadXML = new XmlDocument();   
            ReadXML.Load(RutaXML);

            //Ciclos para recorrer el xml y capturar los datos referentes a la factura que se encuentran en el nodo principal.
            foreach (XmlNode N1 in ReadXML.DocumentElement.ChildNodes )
            {
                switch (N1.Name)
                {
                    case "cbc:ParentDocumentID":
                        NewEmisor.NumFactura = N1.InnerText;
                        SalidaXML++;
                        break;

                    case "cac:SenderParty":
                        foreach (XmlNode N2 in N1.ChildNodes)
                        {
                            foreach (XmlNode N3 in N2.ChildNodes)
                            {
                                switch (N3.Name)
                                {
                                    case "cbc:RegistrationName":
                                        NewEmisor.NomEmisor = N3.InnerText;
                                        SalidaXML++;
                                        break;
                                    case "cbc:CompanyID":
                                        NewEmisor.Nit = N3.InnerText + "-"+ N3.Attributes["schemeID"].Value;
                                        SalidaXML++;
                                        break;

                                    default:
                                        break;
                                }
                                if (SalidaXML == 3 )
                                {
                                    break;
                                }
                            }
                        }
                        break;
                       
                    default:
                        break;
                }

                if (SalidaXML == 3)
                {
                    break;
                }
            }

            if (Origen==1)
            {
                return NewEmisor;
            }
            else
            {
                return "";
            }
        }

        //Metodo que retorna la informacion del Adquiriente
        public dynamic LectorXMLAdquiriente(string RutaXML, int Origen)
        {
            SalidaXML = 0;
            Adquiriente NewAdquiriente = new Adquiriente();

            XmlDocument XmlRead = new XmlDocument();
            XmlRead.Load(RutaXML);

            foreach (XmlNode N1 in XmlRead.DocumentElement.ChildNodes)
            {
                if (N1.Name == "cac:ReceiverParty")
                {
                        foreach (XmlNode N2 in N1.ChildNodes)
                        {
                            foreach (XmlNode N3 in N2.ChildNodes)
                            {
                                switch (N3.Name)
                                {
                                    case "cbc:RegistrationName":
                                        NewAdquiriente.NomAdquiriente = N3.InnerText;
                                        SalidaXML++;
                                        break;

                                    case "cbc:CompanyID":
                                        NewAdquiriente.Nit = N3.InnerText + "-"+ N3.Attributes["schemeID"].Value;
                                        SalidaXML++;
                                        break;

                                    default:
                                        break;
                                }
                                if (SalidaXML == 2){ break;}
                            }
                        }
                }
                if (SalidaXML == 2) { break; }
            }

            LectorXMLAdquirienteAdi(RutaXML, NewAdquiriente);

            if (Origen == 1)
            {
                return NewAdquiriente;
            }
            else
            {
                return "";
            }
        }

        //Se capturan los demas datos del adquiriente
        public void LectorXMLAdquirienteAdi(string RutaXML, Adquiriente adqui)
        {
            SalidaXML = 0;
            XmlDocument XmlRead = new XmlDocument();
            XmlRead.Load(RutaXML);

            foreach (XmlNode N1 in XmlRead.DocumentElement.ChildNodes)
            {
                switch (N1.Name)
                {
                    case "cbc:IssueDate":
                        adqui.FechaFact = N1.InnerText;
                        SalidaXML++;
                        break;

                    case "cbc:IssueTime":
                        adqui.HoraFact = N1.InnerText;
                        SalidaXML++;
                        break;

                    case "cac:Attachment":
                        foreach (XmlNode N2 in N1.ChildNodes)
                        {
                            foreach (XmlNode N3 in N2.ChildNodes)
                            {
                                if (N3.Name == "cbc:Description")
                                {
                                    //Se captura el xml que hay dentro de este Nodo
                                     Nodo = N3.InnerText;

                                    //Se invoca metodo auxiliar que obtiene los valores desde el nuevo xml.
                                    AuxiliarXMLAdquirienteAdi(Replace(Nodo), adqui);
                                    SalidaXML++;
                                }
                            }
                        }
                        break;

                    default:
                        break;
                }
                if (SalidaXML == 3) { break; }

            }

        }

        //Metodo auxiliar que lee el nuevo xml extraido.
        public void AuxiliarXMLAdquirienteAdi(string NewXML, Adquiriente Adquirientes)
        {
            int AuxSalto = 0;
            XmlDocument XmlRead = new XmlDocument();
            XmlRead.LoadXml(NewXML);

            foreach (XmlNode N1 in XmlRead.DocumentElement.ChildNodes)
            {
                switch (N1.Name)
                {
                    case "cbc:UUID":
                        Adquirientes.CUFE = N1.InnerText;
                        AuxSalto++;
                        break;

                    case "cac:AccountingCustomerParty":
                        foreach (XmlNode N2 in N1.ChildNodes)
                        {
                            if (N2.Name == "cac:Party")
                            {
                                foreach (XmlNode N3 in N2.ChildNodes)
                                {
                                    switch (N3.Name)
                                    {
                                        case "cac:PhysicalLocation":
                                            foreach (XmlNode N4 in N3.ChildNodes)
                                            {
                                                foreach (XmlNode N5 in N4.ChildNodes)
                                                {
                                                    switch (N5.Name)
                                                    {
                                                        case "cbc:CityName":
                                                            Adquirientes.Ciudad=N5.InnerText;
                                                            AuxSalto++;
                                                            break;
                                                        case "cbc:PostalZone":
                                                            Adquirientes.CodPostal = Convert.ToInt32(N5.InnerText);
                                                            AuxSalto++;
                                                            break;
                                                        case "cbc:CountrySubentity":
                                                            Adquirientes.Departamento = N5.InnerText;
                                                            AuxSalto++;
                                                            break;
                                                        case "cac:AddressLine":
                                                            foreach (XmlNode N6 in N5.ChildNodes)
                                                            {
                                                                Adquirientes.Direccion = N6.InnerText;
                                                                AuxSalto++;
                                                            }
                                                            break;
                                                        default:
                                                            break;
                                                    }
                                                    if (SalidaXML == 5) { break; }
                                                }
                                                if (SalidaXML == 5) { break; }
                                            }
                                            break;
                                        case "cac:Contact":
                                            foreach (XmlNode N4 in N3.ChildNodes)
                                            {
                                                switch (N4.Name)
                                                {
                                                    case "cbc:Telephone":
                                                        Adquirientes.Celular = N4.InnerXml;
                                                        SalidaXML++;
                                                        break;
                                                    case "cbc:ElectronicMail":
                                                        Adquirientes.Email = N4.InnerText;
                                                        SalidaXML++;
                                                        break;
                                                    default:
                                                        break;
                                                }
                                                if (SalidaXML == 7) { break; }
                                            }
                                            break;


                                        default:
                                            break;
                                    }
                                    if (SalidaXML == 7) { break; }
                                }
                                if (SalidaXML == 7) { break; }
                            }
                        }
                        break;
                    case "cac:PaymentMeans":
                        foreach (XmlNode N2 in N1.ChildNodes)
                        {
                            switch (N2.Name)
                            {
                                case "cbc:ID":
                                    Adquirientes.FormaPago= Convert.ToInt32(N2.InnerXml);
                                    AuxSalto++;
                                    break;
                                case "cbc:PaymentMeansCode":
                                    Adquirientes.MedioDePago = Convert.ToInt32(N2.InnerXml);
                                    AuxSalto++; break;
                                default:
                                    break;
                            }
                            if (SalidaXML == 9) { break; }
                        }
                        break;
                    case "cac:PaymentTerms":
                        foreach (XmlNode N2 in N1.ChildNodes)
                        {
                            if (N2.Name == "cac:SettlementPeriod")
                            {
                                foreach (XmlNode N3 in N2.ChildNodes)
                                {
                                    Adquirientes.Plazo = Convert.ToInt32(N3.InnerText);
                                    SalidaXML++;
                                }
                            }
                            if (SalidaXML == 9) { break; }
                        }
                        break;
                    default:
                        break;
                }
                if (SalidaXML == 9) { break; }
            }
        }


        public dynamic LectorXMLDetalle(string RutaXML, int Origen)
        {
            SalidaXML = 0;
            Detalle detalle = new Detalle();
            List<Detalle> ListaDetalles = new List<Detalle>();    
            XmlDocument ReadXML = new XmlDocument();
            ReadXML.LoadXml(Nodo);

            foreach (XmlNode N1 in ReadXML.DocumentElement.ChildNodes)
            {
                if (N1.Name == "cac:InvoiceLine")
                {
                    foreach ( XmlNode N2 in N1.ChildNodes)
                    {
                        switch (N2.Name)
                        {
                            case "cbc:ID":
                                detalle.Item = Convert.ToInt32(N2.InnerText);
                                SalidaXML++;
                                break;
                            case "cbc:InvoicedQuantity":
                                detalle.Cantidad = Convert.ToDouble(N2.InnerText);
                                detalle.UND = N2.Attributes["unitCode"].Value;
                                SalidaXML++;
                                break;
                            case "cbc:LineExtensionAmount":
                                detalle.VlrTotal = Convert.ToDouble(N2.InnerText);
                                SalidaXML++;
                                break;
                            case "cac:TaxTotal":
                                foreach (XmlNode N3 in N2.ChildNodes)
                                {
                                    if (N3.Name == "cac:TaxCategory")
                                    {
                                        foreach (XmlNode N4 in N3.ChildNodes)
                                        {
                                            if (N4.Name == "cbc:Percent")
                                            {
                                                detalle.IVA = Convert.ToDouble(N4.InnerText);
                                                SalidaXML++;
                                            }
                                            if(SalidaXML == 4) { break; }
                                        }
                                        if (SalidaXML == 4) { break; }
                                    }
                                }
                                break;
                            case "cac:Item":
                                foreach (XmlNode N3 in N2.ChildNodes)
                                {
                                    switch (N3.Name)
                                    {
                                        case "cbc:Description":
                                            detalle.Descripcion = N3.InnerText;
                                            SalidaXML++;
                                            break;
                                        case "cac:SellersItemIdentification":
                                            foreach (XmlNode N4 in N3.ChildNodes)
                                            {
                                                detalle.Codigo = N4.InnerText;
                                                SalidaXML++;
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case "cac:Price":
                                foreach (XmlNode N3 in N2.ChildNodes)
                                {
                                    if (N3.Name == "cbc:PriceAmount")
                                    {
                                        detalle.VlrUnit = Convert.ToDouble(N3.InnerText);
                                        SalidaXML++;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    ListaDetalles.Add(new Detalle
                    {
                        Item        = detalle.Item,
                        Codigo      = detalle.Codigo,
                        Descripcion = detalle.Descripcion,
                        Cantidad    = detalle.Cantidad,
                        UND         = detalle.UND,
                        IVA         = detalle.IVA,
                        VlrUnit     = detalle.VlrUnit,
                        VlrTotal    = detalle.VlrTotal 
                    });
                }

            }

            if (Origen == 1)
            {
                return ListaDetalles;
            }
            else
            {
                return "";
            }
        }

        //Metodo encargado de quitar las etiquetas que no son requeridas en el nuevo xml.
        public string Replace(string Nodo)
        {
            string Replace1 = Nodo.Replace("<![CDATA[", "");
            string Retorno = Replace1.Replace("]]>", "");
            return Retorno;
        }

    }



}

