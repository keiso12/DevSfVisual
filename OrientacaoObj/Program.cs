using OrientacaoObj.Models;

Console.Clear();

Produto cafe=new Produto();

cafe.Nome = "Café";
cafe.Preco = 7.5;

Produto arroz = new Produto{
    Nome = "Arroz",
    Preco= 10,
    Validade=DateTime.Today
};
Console.Write(cafe);
Console.Write(arroz);