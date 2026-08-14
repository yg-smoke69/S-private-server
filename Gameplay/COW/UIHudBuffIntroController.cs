using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200203C")]
internal class UIHudBuffIntroController : UIPopupWindowController
{
	[Token(Token = "0x400CA27")]
	[FieldOffset(Offset = "0x48")]
	private UIHudBuffIntroView m_View;

	[Token(Token = "0x400CA28")]
	[FieldOffset(Offset = "0x4C")]
	private float m_EndTime;

	[Token(Token = "0x400CA29")]
	[FieldOffset(Offset = "0x50")]
	private float m_TotalTime;

	[Token(Token = "0x600A3AC")]
	[Address(RVA = "0x1E1776C", Offset = "0x1E1776C", VA = "0x1E1776C")]
	public UIHudBuffIntroController()
	{
	}

	[Token(Token = "0x600A3AD")]
	[Address(RVA = "0x1E17774", Offset = "0x1E17774", VA = "0x1E17774")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A3AE")]
	[Address(RVA = "0x1E1781C", Offset = "0x1E1781C", VA = "0x1E1781C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A3AF")]
	[Address(RVA = "0x1E178D8", Offset = "0x1E178D8", VA = "0x1E178D8")]
	public void SetData(float endTime, uint dataId)
	{
	}

	[Token(Token = "0x600A3B0")]
	[Address(RVA = "0x1E17C0C", Offset = "0x1E17C0C", VA = "0x1E17C0C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600A3B1")]
	[Address(RVA = "0x1E17EF8", Offset = "0x1E17EF8", VA = "0x1E17EF8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
