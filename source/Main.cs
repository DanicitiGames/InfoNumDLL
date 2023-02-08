/// <summary>
/// Classe geradora de informações referente a um número inteiro
/// </summary>
public static class InfoNum
{
    /// <summary>
    /// Função para gerar as informações
    /// </summary>
    /// <param name="n">Número para ser analizado</param>
    /// <returns>string com as informações</returns>
    public static string Info(int n)
    {
        string line = "------------------------------\n";
        string data = $"{line}>>>Informações sobre o número: {n}\n{line}";
        if (n > 0) { data += $"Raíz quadrada: {Math.Sqrt(n)}\nNúmero positivo\n"; }
        else { data += "Número negativo\n"; }
        if (n % 2 == 0) { data += "Número par\n"; }
        else { data += "Número ímpar\n"; }
        if (n != 0)
        {
            data += $"{line}Porcentagem:";
            for (int i = 1; i < 10; i++)
            {
                data += $"\n{i}0% - {((decimal)n * (decimal)i) / 10m}";
            }
            data += $"\nDobro: {n * 2}\n{line}Adição:\n";
        } else { data += $"Número nulo\n{line}Adição:\n"; }
        if (n % 2 == 0) { data += $"{n/2} + {n/2} = {n}\n\n"; }
        else { data += $"{(n+1) / 2} + {(n-1)/ 2} = {n}\n\n"; }
        if(n != 0){ data += $"Divisão:\n{n*n} ÷ {n} = {n}\n{n*2} ÷ 2 = {n}\n\nSubtração:\n{n*2} - {n} = {n}\n{(n*3)/2} - {n/2} = {n}\n"; }
        data += line;
        return data;
    }
}
