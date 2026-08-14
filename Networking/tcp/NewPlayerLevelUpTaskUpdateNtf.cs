using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C63")]
public class NewPlayerLevelUpTaskUpdateNtf
{
	[Token(Token = "0x400B47D")]
	[FieldOffset(Offset = "0x8")]
	private List<NewPlayerLevelUpTaskUpdateInfo> _003Ctasks_003Ek__BackingField;

	[Token(Token = "0x17000A17")]
	public List<NewPlayerLevelUpTaskUpdateInfo> tasks
	{
		[Token(Token = "0x600830F")]
		[Address(RVA = "0x435CB3C", Offset = "0x435CB3C", VA = "0x435CB3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008310")]
		[Address(RVA = "0x435CB34", Offset = "0x435CB34", VA = "0x435CB34")]
		private set
		{
		}
	}

	[Token(Token = "0x600830E")]
	[Address(RVA = "0x435CAA8", Offset = "0x435CAA8", VA = "0x435CAA8")]
	public NewPlayerLevelUpTaskUpdateNtf()
	{
	}
}
