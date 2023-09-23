
/// Validar Nome, os 3 primeiros caracteres devem ser obrigatoriamente letras em  seguida espaço e pelo menos um número

// ex ABC 1ab
// letra.letra.letra.[espaco].numeros
//-------------------------
 Condigo refatorado 23/09/20233

  Console.WriteLine("NickName: ");
  Console.
  WriteLine(Regex.IsMatch(Console.ReadLine(),
  @"^[a-zA-Z]{3}.?\s[0-9]+[a-zA-Z]+") ? "Aceito" : "Erro");

pra baixo é o codigo antigo feito.
//------------------------

string nome;
bool temEspacoAposLetras = false;
bool nomeValido = false;

Console.Clear();

Console.Write("Digite seu nome: ");
 nome = Console.ReadLine().Replace("-", ""); // evitar numeros negativos

for (int i = 0; i < nome.Length; i++)
{
  for (int j = 0; j <= 9; j++)
  {
      string num = j.ToString();

      if((i < 3 && nome[i].ToString() == num)){ // verifica se os 3 primeiros digitos sao apenas letras
        System.Console.WriteLine("Deve haver apenas letras nos 3 primeiros caracteres");
        return;
      }

      if( (nome[3].ToString() == " " && temEspacoAposLetras == false)){ //verifica se tem espaco apos os 3 primeiros digitos
        temEspacoAposLetras = true;
      }

      if((temEspacoAposLetras == true && nome[i].ToString() == num) && nomeValido == false){
          nomeValido = true; // caso haja espaco appos as 3 primeiras letras, entra aqui e verifica se tem numeros apos o espaco ou dps
      }
    }

    if(nomeValido == true){
      System.Console.WriteLine("Nome Válido");
      return;
    }

    if(i == nome.Length-1 && nomeValido == false){ 
      
      System.Console.WriteLine("Nome Inválido");
      return;
    }
    
  }
