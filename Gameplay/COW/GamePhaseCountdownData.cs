using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200275D")]
public class GamePhaseCountdownData
{
	[Token(Token = "0x400F312")]
	[FieldOffset(Offset = "0x8")]
	public string descKey;

	[Token(Token = "0x400F313")]
	[FieldOffset(Offset = "0xC")]
	public bool isEnhanceShow;

	[Token(Token = "0x400F314")]
	[FieldOffset(Offset = "0x10")]
	public float phaseTime;

	[Token(Token = "0x400F315")]
	[FieldOffset(Offset = "0x14")]
	public float enhanceMoment;

	[Token(Token = "0x600F089")]
	[Address(RVA = "0x1DD7434", Offset = "0x1DD7434", VA = "0x1DD7434")]
	public GamePhaseCountdownData(float phaseTime, string descKey, bool isEnhanceShow = false, float enhanceMoment = 0f)
	{
	}
}
