using System;
class Program {
 public static void Main (string [] args)
 {
 Console.WriteLine("Quantos elementos deseja informar?");
 int[] valores = new int [int.Parse(Console.ReadLine())];
 for (int cont = 0; cont < valores.Length; cont++ ){
 Console.WriteLine("Informe o {0}° valor", cont + 1);
 valores[cont] = int.Parse(Console.ReadLine());
 }
 Console.WriteLine("");
 Console.WriteLine("A maior diferença é: {0}", maiorDiferenca(valores));
 Console.WriteLine("Os valores estão em ordem crescentes? {0}", crescente(valores));
 }
 public static int maiorDiferenca (int[] valores)
 {
 int maior = valores[0];
 int menor = valores[0];
 for (int cont = 0; cont < valores.Length; cont++ ){
 if (valores[cont] > maior){
 maior = valores[cont];
 }
 if (valores[cont] < menor){
 menor = valores[cont];
 }
 }
 return maior - menor;
 }
 public static bool crescente(int[] valores){
 for (int i = 1; i < valores.Length; i++){
 if (valores[i] < valores[i - 1]){
 return false;
 }
 }
 return true;
 }
} 