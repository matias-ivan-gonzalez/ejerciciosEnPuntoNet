/*¿Cuál es el problema del código siguiente y cómo se soluciona?
int i = 0;
for (int i = 1; i <= 10;)
{
Console.WriteLine(i++);
}
*/

/* El problema es la doble declaración de i, se soluciona quitando el segundo int
   en el for o sacando la primera asignacion(pero dejando el segundo)
   */
for (int i = 1; i <= 10;)
{
Console.WriteLine(i++);
}
Console.ReadLine();