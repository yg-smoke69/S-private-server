using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C47")]
public class AwardDataTCP
{
	[Token(Token = "0x400B42D")]
	[FieldOffset(Offset = "0x8")]
	private List<ItemTCP> _003Citems_003Ek__BackingField;

	[Token(Token = "0x170009E7")]
	public List<ItemTCP> items
	{
		[Token(Token = "0x600829D")]
		[Address(RVA = "0x33E8000", Offset = "0x33E8000", VA = "0x33E8000")]
		get
		{
			return null;
		}
		[Token(Token = "0x600829E")]
		[Address(RVA = "0x33E7FF8", Offset = "0x33E7FF8", VA = "0x33E7FF8")]
		private set
		{
		}
	}

	[Token(Token = "0x600829C")]
	[Address(RVA = "0x33E7F6C", Offset = "0x33E7F6C", VA = "0x33E7F6C")]
	public AwardDataTCP()
	{
	}
}
