using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002367")]
public class UIUGCQuitFeedbackItemController : UIBaseController
{
	[Token(Token = "0x2002368")]
	public delegate void Del(uint index, bool selected);

	[Token(Token = "0x400DC70")]
	[FieldOffset(Offset = "0x28")]
	public Del ClickItemDel;

	[Token(Token = "0x400DC71")]
	[FieldOffset(Offset = "0x2C")]
	private UIUGCQuitFeedbackItemView m_View;

	[Token(Token = "0x400DC72")]
	[FieldOffset(Offset = "0x30")]
	private uint m_Id;

	[Token(Token = "0x400DC73")]
	[FieldOffset(Offset = "0x34")]
	private bool m_Selected;

	[Token(Token = "0x600C58B")]
	[Address(RVA = "0x279043C", Offset = "0x279043C", VA = "0x279043C")]
	public UIUGCQuitFeedbackItemController()
	{
	}

	[Token(Token = "0x600C58C")]
	[Address(RVA = "0x27904C0", Offset = "0x27904C0", VA = "0x27904C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C58D")]
	[Address(RVA = "0x2790564", Offset = "0x2790564", VA = "0x2790564", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C58E")]
	[Address(RVA = "0x27906C0", Offset = "0x27906C0", VA = "0x27906C0")]
	private void OnClickItem()
	{
	}

	[Token(Token = "0x600C58F")]
	[Address(RVA = "0x278FBE0", Offset = "0x278FBE0", VA = "0x278FBE0")]
	public void SetViewData(int index)
	{
	}

	[Token(Token = "0x600C590")]
	[Address(RVA = "0x27909CC", Offset = "0x27909CC", VA = "0x27909CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
