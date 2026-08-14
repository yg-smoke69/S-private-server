using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200319F")]
public class NewPlayerTargetMatchGameInfo
{
	[Token(Token = "0x4012DC8")]
	[FieldOffset(Offset = "0x8")]
	public uint MinLevel;

	[Token(Token = "0x4012DC9")]
	[FieldOffset(Offset = "0xC")]
	public uint MaxLevel;

	[Token(Token = "0x4012DCA")]
	[FieldOffset(Offset = "0x10")]
	public string TargetHint;

	[Token(Token = "0x4012DCB")]
	[FieldOffset(Offset = "0x14")]
	public bool HaveGoto;

	[Token(Token = "0x4012DCC")]
	[FieldOffset(Offset = "0x18")]
	public uint GotoGuideID;

	[Token(Token = "0x4012DCD")]
	[FieldOffset(Offset = "0x1C")]
	public bool ShowLockLv;

	[Token(Token = "0x4012DCE")]
	[FieldOffset(Offset = "0x20")]
	public uint MatchState;

	[Token(Token = "0x4012DCF")]
	[FieldOffset(Offset = "0x24")]
	public string SpriteName;

	[Token(Token = "0x6014DA6")]
	[Address(RVA = "0x28B448C", Offset = "0x28B448C", VA = "0x28B448C")]
	public NewPlayerTargetMatchGameInfo()
	{
	}

	[Token(Token = "0x6014DA7")]
	[Address(RVA = "0x28B4494", Offset = "0x28B4494", VA = "0x28B4494")]
	public static implicit operator NewPlayerTargetMatchGameInfo(NewPlayerTargetData data)
	{
		return null;
	}
}
