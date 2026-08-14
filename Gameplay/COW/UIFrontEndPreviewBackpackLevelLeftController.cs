using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C9F")]
public class UIFrontEndPreviewBackpackLevelLeftController : UIFrontEndPreviewBackpackLevelBaseController
{
	[Token(Token = "0x4011091")]
	[FieldOffset(Offset = "0x3C")]
	private UIFrontEndPreviewBackpackLevelLeftView m_UIView;

	[Token(Token = "0x6012A67")]
	[Address(RVA = "0x27DD1E4", Offset = "0x27DD1E4", VA = "0x27DD1E4")]
	public UIFrontEndPreviewBackpackLevelLeftController()
	{
	}

	[Token(Token = "0x6012A68")]
	[Address(RVA = "0x27DD1EC", Offset = "0x27DD1EC", VA = "0x27DD1EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012A69")]
	[Address(RVA = "0x27DD294", Offset = "0x27DD294", VA = "0x27DD294", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012A6A")]
	[Address(RVA = "0x27DD344", Offset = "0x27DD344", VA = "0x27DD344", Slot = "35")]
	protected override UIFrontEndPreviewBackpackLevelBaseView InitBaseView()
	{
		return null;
	}
}
