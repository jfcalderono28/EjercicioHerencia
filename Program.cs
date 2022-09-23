/// <summary>
/// Clase hora
/// </summary>
/// 



public class Hora
{

    private int numeroHoras = 0;

    public void pedirHoras()
    {
        Console.WriteLine("Número de horas trabajadas: ");
        numeroHoras = Int32.Parse(Console.ReadLine());

    }

    public int getNumeroHoras()
    {
        return numeroHoras;
    }

    public void setNumeroHoras(int numeroHoras)
    {
        this.numeroHoras = numeroHoras;
    }
}


/// <summary>
/// Clase valor horas
/// /// ////////////////////////////////////////////////////////////////////////////////////
/// </summary>




public class ValorHoras : Hora
{

    private double total = 0;
    private double valorHora = 0;



    public void calcular(int nHoras)
    {
        if (nHoras < 41)
        {
            this.total = valorHora * nHoras;

        }
        else if (nHoras >= 40 && nHoras <= 48)
        {
            this.total = valorHora * 40;
            nHoras -= 40;
            double temp = valorHora * 1.20;
            this.total += temp * nHoras;
            // 3960

        }
        else if (nHoras > 48)
        {
            this.total = valorHora * 40;
            double temp = valorHora * 1.20;
            this.total += temp * 8;
            nHoras -= 48;

            temp = valorHora * 1.40;
            this.total += temp * nHoras;

        }

    }

    public void valorDeLaHora()
    {
        Console.WriteLine("Valor de la hora trabajada: ");
        this.valorHora = Int32.Parse(Console.ReadLine());
    }

    public double getTotal()
    {
        return total;
    }

    public void setTotal(double total)
    {
        this.total = total;
    }

    public double getValorHora()
    {
        return valorHora;
    }

    public void setValorHora(double valorHora)
    {
        this.valorHora = valorHora;
    }

}



/// <summary>
/// Clase empleado
/// /// ////////////////////////////////////////////////////////////////////////////////////
/// </summary>
/// 





public class Empleado : ValorHoras
{

    private String nombre;
    private int cedula;
    private int telefono;

    public Empleado(String nombre, int cedula, int telefono)
    {
        this.nombre = nombre;
        this.cedula = cedula;
        this.telefono = telefono;

        pedirHoras();
        valorDeLaHora();
        calcular(getNumeroHoras());

    }

    public void MostrarInformaciónEmpleado()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Cedula: " + cedula);
        Console.WriteLine("Telefono: " + telefono);
        Console.WriteLine("Número de horas trabajadas: " + getNumeroHoras());
        Console.WriteLine("Valor de la hora : " + getValorHora());
        Console.WriteLine("Total: " + getTotal());

    }

}



/// <summary>
/// EJECUTAR
/// ////////////////////////////////////////////////////////////////////////////////////
/// </summary>
/// 





public class Ejecutar
{

    public static void Main(String[] args)
    {
        // TODO Auto-generated method stub
        Empleado obj1 = new Empleado("Juan", 12345689, 987654321);
        obj1.MostrarInformaciónEmpleado();
    }

}



