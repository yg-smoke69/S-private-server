using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DB3")]
public class MaxLobbyDisplayInfo
{
	[Token(Token = "0x400BC3B")]
	[FieldOffset(Offset = "0x8")]
	private uint[] _003Cweapon_ids_003Ek__BackingField;

	[Token(Token = "0x400BC3C")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cvehicle_display_003Ek__BackingField;

	[Token(Token = "0x400BC3D")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cgloo_display_003Ek__BackingField;

	[Token(Token = "0x400BC3E")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Cskyboard_display_003Ek__BackingField;

	[Token(Token = "0x17000EE1")]
	public uint[] weapon_ids
	{
		[Token(Token = "0x6008DA0")]
		[Address(RVA = "0x435C8CC", Offset = "0x435C8CC", VA = "0x435C8CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008DA1")]
		[Address(RVA = "0x435C8D4", Offset = "0x435C8D4", VA = "0x435C8D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000EE2")]
	public uint vehicle_display
	{
		[Token(Token = "0x6008DA2")]
		[Address(RVA = "0x435C8DC", Offset = "0x435C8DC", VA = "0x435C8DC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008DA3")]
		[Address(RVA = "0x435C8E4", Offset = "0x435C8E4", VA = "0x435C8E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000EE3")]
	public uint gloo_display
	{
		[Token(Token = "0x6008DA4")]
		[Address(RVA = "0x435C8EC", Offset = "0x435C8EC", VA = "0x435C8EC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008DA5")]
		[Address(RVA = "0x435C8F4", Offset = "0x435C8F4", VA = "0x435C8F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000EE4")]
	public uint skyboard_display
	{
		[Token(Token = "0x6008DA6")]
		[Address(RVA = "0x435C8FC", Offset = "0x435C8FC", VA = "0x435C8FC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008DA7")]
		[Address(RVA = "0x435C904", Offset = "0x435C904", VA = "0x435C904")]
		set
		{
		}
	}

	[Token(Token = "0x6008D9F")]
	[Address(RVA = "0x435C8C4", Offset = "0x435C8C4", VA = "0x435C8C4")]
	public MaxLobbyDisplayInfo()
	{
	}
}
