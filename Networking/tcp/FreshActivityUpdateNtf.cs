using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CB9")]
public class FreshActivityUpdateNtf
{
	[Token(Token = "0x400B5AE")]
	[FieldOffset(Offset = "0x8")]
	private List<FreshActivityUpdateInfo> _003Cactivitys_003Ek__BackingField;

	[Token(Token = "0x17000AC9")]
	public List<FreshActivityUpdateInfo> activitys
	{
		[Token(Token = "0x60084B4")]
		[Address(RVA = "0x33E93AC", Offset = "0x33E93AC", VA = "0x33E93AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084B5")]
		[Address(RVA = "0x33E93A4", Offset = "0x33E93A4", VA = "0x33E93A4")]
		private set
		{
		}
	}

	[Token(Token = "0x60084B3")]
	[Address(RVA = "0x33E9318", Offset = "0x33E9318", VA = "0x33E9318")]
	public FreshActivityUpdateNtf()
	{
	}
}
