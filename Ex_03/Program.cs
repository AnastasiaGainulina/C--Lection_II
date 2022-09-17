// See https://aka.ms/new-console-template for more information
int []array = {11,92,33,46,45,16,27,84};

int n = array.Length;

int find = 46;

int index = 0;

while( index <n )
{
   if(array[index]==find)
   {
    System.Console.WriteLine(index);
    break;
   }
    // index= index+1;
    index++;
}