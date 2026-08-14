using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C94")]
public class NewLuckyBagList
{
	[Token(Token = "0x400B53C")]
	[FieldOffset(Offset = "0x8")]
	private List<NewLuckyBagReq> _003Cnew_lucky_bags_003Ek__BackingField;

	[Token(Token = "0x17000A76")]
	public List<NewLuckyBagReq> new_lucky_bags
	{
		[Token(Token = "0x60083F1")]
		[Address(RVA = "0x435C9D0", Offset = "0x435C9D0", VA = "0x435C9D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60083F2")]
		[Address(RVA = "0x435C9C8", Offset = "0x435C9C8", VA = "0x435C9C8")]
		private set
		{
		}
	}

	[Token(Token = "0x60083F0")]
	[Address(RVA = "0x435C93C", Offset = "0x435C93C", VA = "0x435C93C")]
	public NewLuckyBagList()
	{
	}
}
