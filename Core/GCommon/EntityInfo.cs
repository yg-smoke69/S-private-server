using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003EDA")]
public struct EntityInfo
{
	[Token(Token = "0x401A883")]
	[FieldOffset(Offset = "0x0")]
	public uint MainType;

	[Token(Token = "0x401A884")]
	[FieldOffset(Offset = "0x4")]
	public uint SubType;

	[Token(Token = "0x401A885")]
	[FieldOffset(Offset = "0x8")]
	public uint SubSubType;

	[Token(Token = "0x401A886")]
	[FieldOffset(Offset = "0xC")]
	public uint UniqueID;

	[Token(Token = "0x6019958")]
	[Address(RVA = "0x329FC18", Offset = "0x329FC18", VA = "0x329FC18")]
	public static bool operator ==(EntityInfo a, EntityInfo b)
	{
		return default(bool);
	}

	[Token(Token = "0x6019959")]
	[Address(RVA = "0x329FC54", Offset = "0x329FC54", VA = "0x329FC54")]
	public static bool operator !=(EntityInfo a, EntityInfo b)
	{
		return default(bool);
	}

	[Token(Token = "0x601995A")]
	[Address(RVA = "0x93F918", Offset = "0x93F918", VA = "0x93F918", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x601995B")]
	[Address(RVA = "0x93F920", Offset = "0x93F920", VA = "0x93F920")]
	public void ClearInfo()
	{
	}

	[Token(Token = "0x601995C")]
	[Address(RVA = "0x93F930", Offset = "0x93F930", VA = "0x93F930")]
	public bool IsNone()
	{
		return default(bool);
	}

	[Token(Token = "0x601995D")]
	[Address(RVA = "0x93F954", Offset = "0x93F954", VA = "0x93F954", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x601995E")]
	[Address(RVA = "0x93F95C", Offset = "0x93F95C", VA = "0x93F95C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
