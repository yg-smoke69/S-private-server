using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C48")]
public class ItemTCP
{
	[Token(Token = "0x400B42E")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cid_003Ek__BackingField;

	[Token(Token = "0x400B42F")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Ccnt_003Ek__BackingField;

	[Token(Token = "0x170009E8")]
	public uint id
	{
		[Token(Token = "0x60082A0")]
		[Address(RVA = "0x33EBEF4", Offset = "0x33EBEF4", VA = "0x33EBEF4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60082A1")]
		[Address(RVA = "0x33EBEFC", Offset = "0x33EBEFC", VA = "0x33EBEFC")]
		set
		{
		}
	}

	[Token(Token = "0x170009E9")]
	public uint cnt
	{
		[Token(Token = "0x60082A2")]
		[Address(RVA = "0x33EBF04", Offset = "0x33EBF04", VA = "0x33EBF04")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60082A3")]
		[Address(RVA = "0x33EBF0C", Offset = "0x33EBF0C", VA = "0x33EBF0C")]
		set
		{
		}
	}

	[Token(Token = "0x600829F")]
	[Address(RVA = "0x33EBEEC", Offset = "0x33EBEEC", VA = "0x33EBEEC")]
	public ItemTCP()
	{
	}
}
