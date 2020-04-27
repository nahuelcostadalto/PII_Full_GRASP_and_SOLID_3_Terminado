using System;
using System.IO;

//Usa poliformismo ya que la operacion imprimir ticket se implementa por dos objetos diferentes y 
// cumple con LSP porque al enviarle el mismo mensaje a 2 objetos uno de la clase PrintFile y otro de PrintConsole el mensaje funciona igualmente
namespace Full_GRASP_And_SOLID.Library 
{
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);

    }
}