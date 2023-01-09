using Nullable__Delegate__Exceptions_Practices;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;

#region Nullable

//string name = null;

//int? num = null;

//if (name == null)
//{
//    Console.WriteLine("ConsoleWriteLine");
//}


//int? m = 5;

//GetPersonById(m);

//static void GetPersonById(string Id)
//{
//	if (Id == null)
//	{
//		Console.WriteLine("NotFound");
//	}
//}

#endregion


#region Func,Action
//PracticeDelegate calculate = new PracticeDelegate();
//calculate.CheckDelegate();
//calculate.CheckWord();
//calculate.ShowString();
#endregion


#region Exception


//try
//{
//	int[] arr = {1,2,3,4};
//	arr[5] = 1000;

//}
//catch (Exception ex)
//{

//	Console.WriteLine(ex.Message);
//}



//Divide(5, 0);

//static void Divide (int n, int m)
//{bool isSuccess = false;
//	try
//	{
//		var result = n / m;
//		isSuccess = true;
//		Console.WriteLine(result);

//	}
//	catch (Exception ex)
//	{

//		Console.WriteLine(ex.Message);
//		isSuccess = true;
//	}
//	finally
//	{
//		string message = string.Empty;
//		if (isSuccess)
//		{
//			SendEmail("Register is ok");
//		}
//		else
//		{
//			SendEmail("something is wrong");
//		}

//		SendEmail(message);
//	}

//}
//static void SendEmail(string message)
//{
//	Console.WriteLine(message);
//}

//Login("test", "pervin12345");



//static void Login(string username, string password)
//{
//	try
//	{
//		if (username=="pervin123" && password =="pervin12345")
//		{
//			Console.WriteLine("Login is success");
//		}
//		else
//		{
//			throw new InvalidLoginException ("username or password is wrong");
//		}

//	}
//	catch (Exception ex)
//	{

//		Console.WriteLine(ex.Message);
//	}

//}


#endregion


IEmployeeService service = new EmployeeService();

service.GetCountByAge(27);



