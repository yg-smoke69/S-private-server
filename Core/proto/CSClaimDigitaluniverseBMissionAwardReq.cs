using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001960")]
public class CSClaimDigitaluniverseBMissionAwardReq
{
	[Token(Token = "0x4009F9F")]
	[FieldOffset(Offset = "0x8")]
	public uint progress;

	[Token(Token = "0x4009FA0")]
	[FieldOffset(Offset = "0xC")]
	public ELimitedEvent.DigitaluniverseBGateType gate_type;

	[Token(Token = "0x6007FB9")]
	[Address(RVA = "0x317E5B8", Offset = "0x317E5B8", VA = "0x317E5B8")]
	public CSClaimDigitaluniverseBMissionAwardReq()
	{
	}
}
