private int codigo;
private string? nome;
private decimal salario;
private int codigo;
public int Codigo
{
    get { return codigo; }
    set { 
        codigo = value; }
}
private string? nome;
public string? Nome
{
    get { return nome; }
    set { 
        if (value != "")
            nome = value;
        else Console.WriteLine("") }
}