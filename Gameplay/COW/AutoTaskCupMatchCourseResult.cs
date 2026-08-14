using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E57")]
public class AutoTaskCupMatchCourseResult : AutoPopupTask
{
	[Token(Token = "0x400BF3E")]
	[FieldOffset(Offset = "0x8")]
	private UICupMatchCourseWndController m_Ctrl;

	[Token(Token = "0x400BF3F")]
	[FieldOffset(Offset = "0xC")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x60091CB")]
	[Address(RVA = "0x10F1170", Offset = "0x10F1170", VA = "0x10F1170")]
	public AutoTaskCupMatchCourseResult()
	{
	}

	[Token(Token = "0x60091CC")]
	[Address(RVA = "0x10F1178", Offset = "0x10F1178", VA = "0x10F1178", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091CD")]
	[Address(RVA = "0x10F1260", Offset = "0x10F1260", VA = "0x10F1260", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091CE")]
	[Address(RVA = "0x10F14EC", Offset = "0x10F14EC", VA = "0x10F14EC", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
