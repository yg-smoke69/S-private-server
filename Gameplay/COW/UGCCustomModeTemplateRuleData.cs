using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002E7F")]
public class UGCCustomModeTemplateRuleData
{
	[Token(Token = "0x4011BDB")]
	[FieldOffset(Offset = "0x8")]
	public int ModeIndex;

	[Token(Token = "0x4011BDC")]
	[FieldOffset(Offset = "0xC")]
	public int FallbackIndex;

	[Token(Token = "0x4011BDD")]
	[FieldOffset(Offset = "0x10")]
	public bool Enabled;

	[Token(Token = "0x4011BDE")]
	[FieldOffset(Offset = "0x11")]
	public bool MultiTeamEnabled;

	[Token(Token = "0x4011BDF")]
	[FieldOffset(Offset = "0x12")]
	public bool EnabledGraph;

	[Token(Token = "0x4011BE0")]
	[FieldOffset(Offset = "0x13")]
	public bool EnabledHUD;

	[Token(Token = "0x60136B5")]
	[Address(RVA = "0x233F2F8", Offset = "0x233F2F8", VA = "0x233F2F8")]
	public UGCCustomModeTemplateRuleData()
	{
	}

	[Token(Token = "0x60136B6")]
	[Address(RVA = "0x233F300", Offset = "0x233F300", VA = "0x233F300")]
	public static implicit operator UGCCustomModeTemplateRuleData(WorkshopCustomModeTemplateRuleDesc desc)
	{
		return null;
	}
}
