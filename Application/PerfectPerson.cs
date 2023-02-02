namespace Learn13;

/// <summary>
/// کلاس شخص
/// </summary>
public class Person
{
	#region Constructor
	/// <summary>
	/// سازنده
	/// </summary>
	/// <param name="salary">حقوق شخص</param>
	public Person(int salary)
	{
		Salary = salary;
	}
	#endregion /Constructor

	#region Properties

	#region public int Age { get; set; }
	private int _age;

	/// <summary>
	/// سن
	/// </summary>
	public int Age
	{
		get
		{
			return _age;
		}
		set
		{
			if (value >= 0 && value <= 100)
			{
				_age = value;
			}
		}
	}
	#endregion /public int Age { get; set; }

	#region public int Salary { get; private set; }
	private int _salary;

	/// <summary>
	/// حقوق
	/// </summary>
	public int Salary
	{
		get
		{
			return _salary;
		}
		private set
		{
			if (value >= 0)
			{
				_salary = value;
			}
		}
	}
	#endregion /public int Salary { get; private set; }

	#region public string FirstName { get; set; }
	/// <summary>
	/// نام
	/// </summary>
	public string FirstName { get; set; }
	#endregion /public string FirstName { get; set; }

	#region public string LastName { get; set; }
	/// <summary>
	/// نام خانوادگی
	/// </summary>
	public string LastName { get; set; }
	#endregion /public string LastName { get; set; }

	#region public string FullName { get; }
	/// <summary>
	/// نام و نام خانوادگی
	/// </summary>
	public string FullName
	{
		get
		{
			var result =
				$"{FirstName} {LastName}".Trim();

			return result;
		}
	}
	#endregion /public string FullName { get; }

	#endregion /Properties

	#region Methods

	#region ShowInformation()
	/// <summary>
	/// با استفاده از این تابع اطلاعات شخص به طور کامل نمایش داده می‌شود
	/// </summary>
	public void ShowInformation()
	{
		var message =
			$"I'm {FullName} and {Age} years old and I make {Salary}$";

		System.Console.WriteLine(value: message);
	}
	#endregion /ShowInformation()

	#endregion /Methods
}
