using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D91")]
public class IngameItem
{
	[Token(Token = "0x400BAA6")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Citem_id_003Ek__BackingField;

	[Token(Token = "0x400BAA7")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Ccnt_003Ek__BackingField;

	[Token(Token = "0x17000D52")]
	public uint item_id
	{
		[Token(Token = "0x6008A61")]
		[Address(RVA = "0x33EB814", Offset = "0x33EB814", VA = "0x33EB814")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A62")]
		[Address(RVA = "0x33EB81C", Offset = "0x33EB81C", VA = "0x33EB81C")]
		set
		{
		}
	}

	[Token(Token = "0x17000D53")]
	public uint cnt
	{
		[Token(Token = "0x6008A63")]
		[Address(RVA = "0x33EB824", Offset = "0x33EB824", VA = "0x33EB824")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A64")]
		[Address(RVA = "0x33EB82C", Offset = "0x33EB82C", VA = "0x33EB82C")]
		set
		{
		}
	}

	[Token(Token = "0x6008A60")]
	[Address(RVA = "0x33EB80C", Offset = "0x33EB80C", VA = "0x33EB80C")]
	public IngameItem()
	{
	}
}
