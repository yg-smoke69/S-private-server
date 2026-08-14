using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D40")]
public class AwakenTaskChangeNtf
{
	[Token(Token = "0x400B879")]
	[FieldOffset(Offset = "0x8")]
	private List<AwakenTaskChangeInfo> _003Cawaken_tasks_003Ek__BackingField;

	[Token(Token = "0x17000C4A")]
	public List<AwakenTaskChangeInfo> awaken_tasks
	{
		[Token(Token = "0x6008816")]
		[Address(RVA = "0x33E7F64", Offset = "0x33E7F64", VA = "0x33E7F64")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008817")]
		[Address(RVA = "0x33E7F5C", Offset = "0x33E7F5C", VA = "0x33E7F5C")]
		private set
		{
		}
	}

	[Token(Token = "0x6008815")]
	[Address(RVA = "0x33E7ED0", Offset = "0x33E7ED0", VA = "0x33E7ED0")]
	public AwakenTaskChangeNtf()
	{
	}
}
