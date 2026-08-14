using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002F40")]
public class ChatBlockUserInfo
{
	[Token(Token = "0x40120BB")]
	[FieldOffset(Offset = "0x8")]
	public ulong ID;

	[Token(Token = "0x40120BC")]
	[FieldOffset(Offset = "0x10")]
	public string Name;

	[Token(Token = "0x6013C3D")]
	[Address(RVA = "0x1722D60", Offset = "0x1722D60", VA = "0x1722D60")]
	public ChatBlockUserInfo()
	{
	}

	[Token(Token = "0x6013C3E")]
	[Address(RVA = "0x1722D68", Offset = "0x1722D68", VA = "0x1722D68", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6013C3F")]
	[Address(RVA = "0x1722EA8", Offset = "0x1722EA8", VA = "0x1722EA8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6013C40")]
	[Address(RVA = "0x1722FD4", Offset = "0x1722FD4", VA = "0x1722FD4")]
	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return default(bool);
	}

	[Token(Token = "0x6013C41")]
	[Address(RVA = "0x1722FDC", Offset = "0x1722FDC", VA = "0x1722FDC")]
	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return default(int);
	}
}
