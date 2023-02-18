using ACTDAAZSEM4.Entidades;
using ACTDAAZSEM4.Negocio;

Actsem4 Texto = new Actsem4 ();
ClsNegocios clsNegocios = new ClsNegocios();



  Console.WriteLine("Ingrese un Texto:");
  string? TextoIngresado = Console.ReadLine();

  Actsem4 entidad = new Actsem4();
  entidad.Texto = TextoIngresado!;

  ClsNegocios negocio = new ClsNegocios();
  int cantidadLetras = negocio.Contadorletras(entidad);

  Console.WriteLine ("La cantidad de letras ingresadas es: " + cantidadLetras);

