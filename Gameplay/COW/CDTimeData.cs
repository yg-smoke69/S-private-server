using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D81")]
public class CDTimeData
{
	[Token(Token = "0x401175B")]
	[FieldOffset(Offset = "0x8")]
	public ulong RequestTime;

	[Token(Token = "0x401175C")]
	[FieldOffset(Offset = "0x10")]
	public int CdSecond;

	[Token(Token = "0x60130BC")]
	[Address(RVA = "0x1815064", Offset = "0x1815064", VA = "0x1815064")]
	public CDTimeData(ulong _RequestTime, int _CdSecond)
	{
	}

	[Token(Token = "0x60130BD")]
	[Address(RVA = "0x1815094", Offset = "0x1815094", VA = "0x1815094")]
	public bool CheckOutofCd()
	{
		return default(bool);
	}
}
