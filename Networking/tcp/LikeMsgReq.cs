using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C81")]
public class LikeMsgReq
{
	[Token(Token = "0x400B4F9")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Csender_id_003Ek__BackingField;

	[Token(Token = "0x400B4FA")]
	[FieldOffset(Offset = "0x10")]
	private List<LikeMsg> _003Clike_list_003Ek__BackingField;

	[Token(Token = "0x17000A51")]
	public ulong sender_id
	{
		[Token(Token = "0x6008398")]
		[Address(RVA = "0x33EC3E0", Offset = "0x33EC3E0", VA = "0x33EC3E0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008399")]
		[Address(RVA = "0x33EC3E8", Offset = "0x33EC3E8", VA = "0x33EC3E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000A52")]
	public List<LikeMsg> like_list
	{
		[Token(Token = "0x600839A")]
		[Address(RVA = "0x33EC3F8", Offset = "0x33EC3F8", VA = "0x33EC3F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600839B")]
		[Address(RVA = "0x33EC3D8", Offset = "0x33EC3D8", VA = "0x33EC3D8")]
		private set
		{
		}
	}

	[Token(Token = "0x6008397")]
	[Address(RVA = "0x33EC34C", Offset = "0x33EC34C", VA = "0x33EC34C")]
	public LikeMsgReq()
	{
	}
}
