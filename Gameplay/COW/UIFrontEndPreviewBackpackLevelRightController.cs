using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CA0")]
public class UIFrontEndPreviewBackpackLevelRightController : UIFrontEndPreviewBackpackLevelBaseController
{
	[Token(Token = "0x4011092")]
	[FieldOffset(Offset = "0x3C")]
	private UIFrontEndPreviewBackpackLevelRightView m_UIView;

	[Token(Token = "0x6012A6B")]
	[Address(RVA = "0x27DD56C", Offset = "0x27DD56C", VA = "0x27DD56C")]
	public UIFrontEndPreviewBackpackLevelRightController()
	{
	}

	[Token(Token = "0x6012A6C")]
	[Address(RVA = "0x27DD574", Offset = "0x27DD574", VA = "0x27DD574")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012A6D")]
	[Address(RVA = "0x27DD61C", Offset = "0x27DD61C", VA = "0x27DD61C", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012A6E")]
	[Address(RVA = "0x27DD6CC", Offset = "0x27DD6CC", VA = "0x27DD6CC", Slot = "35")]
	protected override UIFrontEndPreviewBackpackLevelBaseView InitBaseView()
	{
		return null;
	}
}
