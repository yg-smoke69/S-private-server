using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CEE")]
public class ChangeMapNtf
{
	[Token(Token = "0x400B739")]
	[FieldOffset(Offset = "0x8")]
	private uint[] _003Cmap_ids_003Ek__BackingField;

	[Token(Token = "0x400B73A")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x17000BA0")]
	public uint[] map_ids
	{
		[Token(Token = "0x6008689")]
		[Address(RVA = "0x33E8348", Offset = "0x33E8348", VA = "0x33E8348")]
		get
		{
			return null;
		}
		[Token(Token = "0x600868A")]
		[Address(RVA = "0x33E8350", Offset = "0x33E8350", VA = "0x33E8350")]
		set
		{
		}
	}

	[Token(Token = "0x17000BA1")]
	public uint game_mode
	{
		[Token(Token = "0x600868B")]
		[Address(RVA = "0x33E8358", Offset = "0x33E8358", VA = "0x33E8358")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600868C")]
		[Address(RVA = "0x33E8360", Offset = "0x33E8360", VA = "0x33E8360")]
		set
		{
		}
	}

	[Token(Token = "0x6008688")]
	[Address(RVA = "0x33E8340", Offset = "0x33E8340", VA = "0x33E8340")]
	public ChangeMapNtf()
	{
	}
}
