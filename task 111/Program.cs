Console.Write("Введите скобочную последовательность:");
string braket = Console.ReadLine();

var myStack = new Stack<char>();

string answer = "yes";

for (int i = 0; i < braket.Length; i++)
{
  bool isNotBracket = braket[i] != '(' && braket[i] != '[' && braket[i] != ')' && braket[i] != ']' 
  && braket[i] != '{' && braket[i] != '}';
  if (isNotBracket)
  {
    continue;
  }

  bool isOpeningBracket = braket[i] == '(' || braket[i] == '[' || braket[i] == '{';
  if (isOpeningBracket)
  {
    myStack.Push (braket[i]);
  }

  if  (braket[i] == ')')
  {
    if (myStack.Count == 0)
    {
      answer = "no";
      break;
    }

    if (myStack.Pop() != '(')
    {
      answer = "no";
      break;
    }
  }

  if  (braket[i] == ']')
  {
    if (myStack.Count == 0)
    {
      answer = "no";
      break;
    }

    if (myStack.Pop() != '[')
    {
      answer = "no";
      break;
    }
  }

  if  (braket[i] == '}')
  {
    if (myStack.Count == 0)
    {
      answer = "no";
      break;
    }

    if (myStack.Pop() != '{')
    {
      answer = "no";
      break;
    }
  }

}

if (myStack.Count != 0)
{
  answer = "no";
}

Console.WriteLine(answer);
