using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200329F")]
public class ModeDataModification
{
	[Token(Token = "0x20032A0")]
	public enum ModeDataModificationAction
	{
		[Token(Token = "0x4013466")]
		EnterClassicMode,
		[Token(Token = "0x4013467")]
		ClassicModeSave,
		[Token(Token = "0x4013468")]
		CustomModeSave,
		[Token(Token = "0x4013469")]
		Exit
	}

	[Token(Token = "0x20032A1")]
	public enum ModeDataModificationState
	{
		[Token(Token = "0x401346B")]
		None,
		[Token(Token = "0x401346C")]
		ClassicModeModified,
		[Token(Token = "0x401346D")]
		CustomModeModified
	}

	[Token(Token = "0x4013463")]
	[FieldOffset(Offset = "0x8")]
	public ModeDataModificationState ModificationState;

	[Token(Token = "0x4013464")]
	[FieldOffset(Offset = "0xC")]
	public bool IsDataChanged;

	[Token(Token = "0x6015565")]
	[Address(RVA = "0x22810B0", Offset = "0x22810B0", VA = "0x22810B0")]
	public ModeDataModification()
	{
	}

	[Token(Token = "0x6015566")]
	[Address(RVA = "0x22810B8", Offset = "0x22810B8", VA = "0x22810B8")]
	public void MarkModified(ModeDataModificationAction actionType)
	{
	}

	[Token(Token = "0x6015567")]
	[Address(RVA = "0x2281178", Offset = "0x2281178", VA = "0x2281178")]
	public void Reset()
	{
	}
}
