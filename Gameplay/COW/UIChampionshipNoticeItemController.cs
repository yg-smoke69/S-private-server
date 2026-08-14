using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002013")]
public class UIChampionshipNoticeItemController : UIBaseController
{
	[Token(Token = "0x400C97B")]
	[FieldOffset(Offset = "0x28")]
	private UIChampionshipNoticeItemView m_View;

	[Token(Token = "0x400C97C")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_GoPos;

	[Token(Token = "0x400C97D")]
	[FieldOffset(Offset = "0x30")]
	private uint m_SubGoPos;

	[Token(Token = "0x600A253")]
	[Address(RVA = "0x2834D30", Offset = "0x2834D30", VA = "0x2834D30")]
	public UIChampionshipNoticeItemController()
	{
	}

	[Token(Token = "0x600A254")]
	[Address(RVA = "0x2834DB4", Offset = "0x2834DB4", VA = "0x2834DB4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A255")]
	[Address(RVA = "0x2834E5C", Offset = "0x2834E5C", VA = "0x2834E5C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A256")]
	[Address(RVA = "0x2834FB8", Offset = "0x2834FB8", VA = "0x2834FB8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A257")]
	[Address(RVA = "0x2833F34", Offset = "0x2833F34", VA = "0x2833F34")]
	public void RefreshView(string url, uint goPos, uint subGoPos)
	{
	}

	[Token(Token = "0x600A258")]
	[Address(RVA = "0x283501C", Offset = "0x283501C", VA = "0x283501C")]
	private void OnBtnNoticeItemClick()
	{
	}

	[Token(Token = "0x600A259")]
	[Address(RVA = "0x2835168", Offset = "0x2835168", VA = "0x2835168")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A25A")]
	[Address(RVA = "0x2835170", Offset = "0x2835170", VA = "0x2835170")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
