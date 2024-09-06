// 1. Single reponsability
//using PrincipiosSolid.SRP;

//ReportManagerSRP reportManagerSRP = new ReportManagerSRP();
//reportManagerSRP.GenerarReporteVentas();
//TicketManagerSRP ticketManagerSRP = new TicketManagerSRP();
//ticketManagerSRP.EmitirBoleto("Felipe", "Profesor");

// 2. Open Close
//using PrincipiosSolid.OCP;

//TicketManagerOCP ticketManagerOCP = new TicketManagerOCP();
////BoletoAdulto boletoAdulto = new BoletoAdulto();
//BoletoNiño boletoNiño = new BoletoNiño();
////BoletoSenior boletoSenior = new BoletoSenior();
////BoletoEstudiante boletoEstudiante = new BoletoEstudiante();

//double valBoleto = ticketManagerOCP.CalcularPrecio(boletoNiño);
//Console.WriteLine($"El valor del boleto es {valBoleto.ToString()}");

// 3. Liskov 
//using PrincipiosSolid.LSP;

//ParqueTematico parque = new ParqueTematico();

//Atraccion montañaRusa = new MontañaRusa();
//Atraccion carrosChocones = new CarrosChocones();

//parque.IniciarAtraccion(montañaRusa);
//parque.IniciarAtraccion(carrosChocones);

// 4. Segregacion de interfaces
//using PrincipiosSolid.ISP;

//MontañaRusa montañaRusa = new MontañaRusa();
//montañaRusa.InspeccionarSeguridad();
//montañaRusa.Operar();

// 5. Inversion de dependencias, podemos cambiar la atraccion sin cambiar parque tematico
using PrincipiosSolid.DIP;

MontañaRusaDIP montañaRusaDIP = new MontañaRusaDIP();
ParqueTematicoDIP parqueTematicoDIP = new ParqueTematicoDIP(montañaRusaDIP);
parqueTematicoDIP.IniciarAtraccion();