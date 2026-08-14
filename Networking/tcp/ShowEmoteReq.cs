using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CE9")]
public class ShowEmoteReq
{
	[Token(Token = "0x400B72D")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B72E")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cemote_id_003Ek__BackingField;

	[Token(Token = "0x400B72F")]
	[FieldOffset(Offset = "0x14")]
	private List<AccountEmoteRandomID> _003Crandom_id_list_003Ek__BackingField;

	[Token(Token = "0x17000B94")]
	public ulong group_id
	{
		[Token(Token = "0x600866C")]
		[Address(RVA = "0x435F2A8", Offset = "0x435F2A8", VA = "0x435F2A8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600866D")]
		[Address(RVA = "0x435F2B0", Offset = "0x435F2B0", VA = "0x435F2B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B95")]
	public uint emote_id
	{
		[Token(Token = "0x600866E")]
		[Address(RVA = "0x435F2C0", Offset = "0x435F2C0", VA = "0x435F2C0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600866F")]
		[Address(RVA = "0x435F2C8", Offset = "0x435F2C8", VA = "0x435F2C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B96")]
	public List<AccountEmoteRandomID> random_id_list
	{
		[Token(Token = "0x6008670")]
		[Address(RVA = "0x435F2D0", Offset = "0x435F2D0", VA = "0x435F2D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008671")]
		[Address(RVA = "0x435F2A0", Offset = "0x435F2A0", VA = "0x435F2A0")]
		private set
		{
		}
	}

	[Token(Token = "0x600866B")]
	[Address(RVA = "0x435F214", Offset = "0x435F214", VA = "0x435F214")]
	public ShowEmoteReq()
	{
	}
}
