using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C4E")]
public class ActivityUpdateNtf
{
	[Token(Token = "0x400B43C")]
	[FieldOffset(Offset = "0x8")]
	private List<ActivityUpdateInfo> _003Cactivitys_003Ek__BackingField;

	[Token(Token = "0x170009F1")]
	public List<ActivityUpdateInfo> activitys
	{
		[Token(Token = "0x60082B6")]
		[Address(RVA = "0x33E79D8", Offset = "0x33E79D8", VA = "0x33E79D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60082B7")]
		[Address(RVA = "0x33E79D0", Offset = "0x33E79D0", VA = "0x33E79D0")]
		private set
		{
		}
	}

	[Token(Token = "0x60082B5")]
	[Address(RVA = "0x33E7944", Offset = "0x33E7944", VA = "0x33E7944")]
	public ActivityUpdateNtf()
	{
	}
}
