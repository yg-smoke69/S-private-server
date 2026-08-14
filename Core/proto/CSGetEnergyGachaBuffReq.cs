using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001872")]
public class CSGetEnergyGachaBuffReq
{
	[Token(Token = "0x4009CFD")]
	[FieldOffset(Offset = "0x8")]
	public uint lottery_id;

	[Token(Token = "0x4009CFE")]
	[FieldOffset(Offset = "0xC")]
	public uint lottery_sub_id;

	[Token(Token = "0x6007ECB")]
	[Address(RVA = "0x31844F4", Offset = "0x31844F4", VA = "0x31844F4")]
	public CSGetEnergyGachaBuffReq()
	{
	}
}
