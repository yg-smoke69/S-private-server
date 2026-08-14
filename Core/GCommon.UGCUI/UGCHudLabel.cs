using Il2CppDummyDll;

namespace GCommon.UGCUI;

[Token(Token = "0x200410A")]
public class UGCHudLabel : UGCHudWidget
{
	[Token(Token = "0x401B51B")]
	[FieldOffset(Offset = "0x58")]
	protected UILabel m_Label;

	[Token(Token = "0x17001D3A")]
	public UILabel Label
	{
		[Token(Token = "0x601A8FB")]
		[Address(RVA = "0x324D3B0", Offset = "0x324D3B0", VA = "0x324D3B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A8F9")]
	[Address(RVA = "0x324D3A4", Offset = "0x324D3A4", VA = "0x324D3A4")]
	public UGCHudLabel()
	{
	}

	[Token(Token = "0x601A8FA")]
	[Address(RVA = "0x324D3A8", Offset = "0x324D3A8", VA = "0x324D3A8", Slot = "9")]
	public override UGCHudWidgetType GetHudWidgetType()
	{
		return default(UGCHudWidgetType);
	}
}
