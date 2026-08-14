using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BE5")]
internal class UIVeteranOptionalGiftItemController : UIBaseController
{
	[Token(Token = "0x4010C31")]
	[FieldOffset(Offset = "0x28")]
	private UIVeteranOptionalGiftItemView m_View;

	[Token(Token = "0x4010C32")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelVeteranSignin m_ModelSignin;

	[Token(Token = "0x4010C33")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsHighLight;

	[Token(Token = "0x4010C34")]
	[FieldOffset(Offset = "0x34")]
	private int m_Slot;

	[Token(Token = "0x17001311")]
	public bool IsHighLight
	{
		[Token(Token = "0x6012303")]
		[Address(RVA = "0x2CACA90", Offset = "0x2CACA90", VA = "0x2CACA90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6012302")]
	[Address(RVA = "0x2CACA0C", Offset = "0x2CACA0C", VA = "0x2CACA0C")]
	public UIVeteranOptionalGiftItemController()
	{
	}

	[Token(Token = "0x6012304")]
	[Address(RVA = "0x2CACAE8", Offset = "0x2CACAE8", VA = "0x2CACAE8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012305")]
	[Address(RVA = "0x2CACB8C", Offset = "0x2CACB8C", VA = "0x2CACB8C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012306")]
	[Address(RVA = "0x2CACE5C", Offset = "0x2CACE5C", VA = "0x2CACE5C")]
	public void SetViewData(int slot)
	{
	}

	[Token(Token = "0x6012307")]
	[Address(RVA = "0x2CACF60", Offset = "0x2CACF60", VA = "0x2CACF60")]
	public void SetHighLightTab(bool flag)
	{
	}

	[Token(Token = "0x6012308")]
	[Address(RVA = "0x2CACFFC", Offset = "0x2CACFFC", VA = "0x2CACFFC")]
	public void SetSlotIcon(int slot, int order)
	{
	}

	[Token(Token = "0x6012309")]
	[Address(RVA = "0x2CAD384", Offset = "0x2CAD384", VA = "0x2CAD384")]
	public void SetSlotIcon(uint itemid)
	{
	}

	[Token(Token = "0x601230A")]
	[Address(RVA = "0x2CAD594", Offset = "0x2CAD594", VA = "0x2CAD594")]
	public void ResetSlotIcon()
	{
	}

	[Token(Token = "0x601230B")]
	[Address(RVA = "0x2CAD69C", Offset = "0x2CAD69C", VA = "0x2CAD69C")]
	public void SetDefaultSlotIcon(string resName)
	{
	}

	[Token(Token = "0x601230C")]
	[Address(RVA = "0x2CAD758", Offset = "0x2CAD758", VA = "0x2CAD758")]
	private void SetSpriteViewByResName(UISprite sprite, string resName)
	{
	}

	[Token(Token = "0x601230D")]
	[Address(RVA = "0x2CAD870", Offset = "0x2CAD870", VA = "0x2CAD870")]
	public void CloseVfxOnClose()
	{
	}

	[Token(Token = "0x601230E")]
	[Address(RVA = "0x2CAD900", Offset = "0x2CAD900", VA = "0x2CAD900", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x601230F")]
	[Address(RVA = "0x2CAD964", Offset = "0x2CAD964", VA = "0x2CAD964", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6012310")]
	[Address(RVA = "0x2CAD9C8", Offset = "0x2CAD9C8", VA = "0x2CAD9C8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6012311")]
	[Address(RVA = "0x2CADA2C", Offset = "0x2CADA2C", VA = "0x2CADA2C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012312")]
	[Address(RVA = "0x2CADA34", Offset = "0x2CADA34", VA = "0x2CADA34")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6012313")]
	[Address(RVA = "0x2CADA3C", Offset = "0x2CADA3C", VA = "0x2CADA3C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6012314")]
	[Address(RVA = "0x2CADA44", Offset = "0x2CADA44", VA = "0x2CADA44")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
