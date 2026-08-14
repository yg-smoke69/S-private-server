using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002771")]
internal class UIHudGrenadeSubBtnController : UIBaseController
{
	[Token(Token = "0x400F38B")]
	[FieldOffset(Offset = "0x28")]
	private UIHudGrenadeSubBtnView m_View;

	[Token(Token = "0x400F38C")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudGrenadeBtnController.ButtonType m_BtnType;

	[Token(Token = "0x600F164")]
	[Address(RVA = "0x133A414", Offset = "0x133A414", VA = "0x133A414")]
	public UIHudGrenadeSubBtnController()
	{
	}

	[Token(Token = "0x600F165")]
	[Address(RVA = "0x133A498", Offset = "0x133A498", VA = "0x133A498")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F166")]
	[Address(RVA = "0x133A53C", Offset = "0x133A53C", VA = "0x133A53C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F167")]
	[Address(RVA = "0x133A698", Offset = "0x133A698", VA = "0x133A698", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F168")]
	[Address(RVA = "0x133A6FC", Offset = "0x133A6FC", VA = "0x133A6FC")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600F169")]
	[Address(RVA = "0x133AA0C", Offset = "0x133AA0C", VA = "0x133AA0C")]
	public void SetData(UIHudGrenadeBtnController.ButtonType curType, int count, int itemType)
	{
	}

	[Token(Token = "0x600F16A")]
	[Address(RVA = "0x133B38C", Offset = "0x133B38C", VA = "0x133B38C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F16B")]
	[Address(RVA = "0x133B394", Offset = "0x133B394", VA = "0x133B394")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
