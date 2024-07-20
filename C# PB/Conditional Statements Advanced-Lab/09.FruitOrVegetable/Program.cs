
//banana, apple, kiwi, cherry, lemon и grapes
//	tomato, cucumber, pepper и carrot


string any = Console.ReadLine();

switch (any)
{
	case "banana":
	case "apple":
	case "kiwi":
	case "cherry":
	case "lemon":
	case "grapes":
		Console.WriteLine("fruit");
		break;
	case "tomato":
	case "cucumber":
	case "pepper":
	case "carrot":
		Console.WriteLine("vegetable");
		break;
    default:
		Console.WriteLine("unknown");
		break;
}