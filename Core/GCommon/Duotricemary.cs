using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003F3C")]
public struct Duotricemary
{
	[Token(Token = "0x401AA71")]
	private const string CHARS = "0123456789ABCDEFGHJKLMNPQRTUVWXY";

	[Token(Token = "0x401AA72")]
	[FieldOffset(Offset = "0x0")]
	private string m_StringValue;

	[Token(Token = "0x401AA73")]
	[FieldOffset(Offset = "0x8")]
	private ulong? m_IntValue;

	[Token(Token = "0x17001C28")]
	public string StringValue
	{
		[Token(Token = "0x6019C2D")]
		[Address(RVA = "0x93F8B4", Offset = "0x93F8B4", VA = "0x93F8B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019C2E")]
		[Address(RVA = "0x93F8BC", Offset = "0x93F8BC", VA = "0x93F8BC")]
		set
		{
		}
	}

	[Token(Token = "0x17001C29")]
	public ulong? IntValue
	{
		[Token(Token = "0x6019C2F")]
		[Address(RVA = "0x93F8C4", Offset = "0x93F8C4", VA = "0x93F8C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019C30")]
		[Address(RVA = "0x93F8D4", Offset = "0x93F8D4", VA = "0x93F8D4")]
		set
		{
		}
	}

	[Token(Token = "0x6019C2B")]
	[Address(RVA = "0x93F884", Offset = "0x93F884", VA = "0x93F884")]
	public Duotricemary(string stringValue)
	{
	}

	[Token(Token = "0x6019C2C")]
	[Address(RVA = "0x93F898", Offset = "0x93F898", VA = "0x93F898")]
	public Duotricemary(ulong intValue)
	{
	}

	[Token(Token = "0x6019C31")]
	[Address(RVA = "0x329D3F8", Offset = "0x329D3F8", VA = "0x329D3F8")]
	public static Duotricemary FromString(string stringValue)
	{
		return default(Duotricemary);
	}

	[Token(Token = "0x6019C32")]
	[Address(RVA = "0x329D410", Offset = "0x329D410", VA = "0x329D410")]
	public static Duotricemary FromInt(uint intValue)
	{
		return default(Duotricemary);
	}

	[Token(Token = "0x6019C33")]
	[Address(RVA = "0x93F8EC", Offset = "0x93F8EC", VA = "0x93F8EC")]
	public ulong ToInt()
	{
		return default(ulong);
	}

	[Token(Token = "0x6019C34")]
	[Address(RVA = "0x93F8F4", Offset = "0x93F8F4", VA = "0x93F8F4")]
	private ulong ToInt(string stringValue)
	{
		return default(ulong);
	}

	[Token(Token = "0x6019C35")]
	[Address(RVA = "0x93F8F8", Offset = "0x93F8F8", VA = "0x93F8F8")]
	private string ToDuotricemaryString(ulong intValue)
	{
		return null;
	}

	[Token(Token = "0x6019C36")]
	[Address(RVA = "0x329D9B4", Offset = "0x329D9B4", VA = "0x329D9B4")]
	public static implicit operator Duotricemary(ulong value)
	{
		return default(Duotricemary);
	}

	[Token(Token = "0x6019C37")]
	[Address(RVA = "0x329D9E4", Offset = "0x329D9E4", VA = "0x329D9E4")]
	public static implicit operator Duotricemary(string value)
	{
		return default(Duotricemary);
	}

	[Token(Token = "0x6019C38")]
	[Address(RVA = "0x329D9FC", Offset = "0x329D9FC", VA = "0x329D9FC")]
	public static Duotricemary operator +(Duotricemary d, ulong value)
	{
		return default(Duotricemary);
	}

	[Token(Token = "0x6019C39")]
	[Address(RVA = "0x329DA74", Offset = "0x329DA74", VA = "0x329DA74")]
	public static Duotricemary operator -(Duotricemary d, ulong value)
	{
		return default(Duotricemary);
	}

	[Token(Token = "0x6019C3A")]
	[Address(RVA = "0x93F910", Offset = "0x93F910", VA = "0x93F910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
