using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002503")]
public class UIChangeNamePopupWindowController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400E5D5")]
	private const string IN_ANIM_NAME = "UIChangeNamePopupWindow_In";

	[Token(Token = "0x400E5D6")]
	[FieldOffset(Offset = "0x48")]
	private UIChangeNamePopupWindowView m_View;

	[Token(Token = "0x400E5D7")]
	[FieldOffset(Offset = "0x4C")]
	private LoginRes m_UserData;

	[Token(Token = "0x400E5D8")]
	[FieldOffset(Offset = "0x50")]
	private RenameCostData m_CostData;

	[Token(Token = "0x400E5D9")]
	[FieldOffset(Offset = "0x54")]
	private bool m_HasRequestedRename;

	[Token(Token = "0x400E5DA")]
	[FieldOffset(Offset = "0x58")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400E5DB")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_RenameCardEnabled;

	[Token(Token = "0x400E5DC")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<Item> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600D678")]
	[Address(RVA = "0x262610C", Offset = "0x262610C", VA = "0x262610C")]
	public UIChangeNamePopupWindowController()
	{
	}

	[Token(Token = "0x600D679")]
	[Address(RVA = "0x2626114", Offset = "0x2626114", VA = "0x2626114")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D67A")]
	[Address(RVA = "0x26261B8", Offset = "0x26261B8", VA = "0x26261B8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D67B")]
	[Address(RVA = "0x262655C", Offset = "0x262655C", VA = "0x262655C")]
	private void RefreshViewData()
	{
	}

	[Token(Token = "0x600D67C")]
	[Address(RVA = "0x26270F8", Offset = "0x26270F8", VA = "0x26270F8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D67D")]
	[Address(RVA = "0x2626D68", Offset = "0x2626D68", VA = "0x2626D68")]
	private void OnInputChange()
	{
	}

	[Token(Token = "0x600D67E")]
	[Address(RVA = "0x2627228", Offset = "0x2627228", VA = "0x2627228")]
	private bool IsNameValid(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x600D67F")]
	[Address(RVA = "0x26272FC", Offset = "0x26272FC", VA = "0x26272FC")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600D680")]
	[Address(RVA = "0x26278C8", Offset = "0x26278C8", VA = "0x26278C8")]
	private void OnUseCardClick()
	{
	}

	[Token(Token = "0x600D681")]
	[Address(RVA = "0x2627ABC", Offset = "0x2627ABC", VA = "0x2627ABC", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D682")]
	[Address(RVA = "0x26275F4", Offset = "0x26275F4", VA = "0x26275F4")]
	private void ShowRenameDiamondShortHint()
	{
	}

	[Token(Token = "0x600D683")]
	[Address(RVA = "0x262805C", Offset = "0x262805C", VA = "0x262805C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D684")]
	[Address(RVA = "0x26280F0", Offset = "0x26280F0", VA = "0x26280F0")]
	private void OnAnimEvtOccur(object[] data)
	{
	}

	[Token(Token = "0x600D685")]
	[Address(RVA = "0x262825C", Offset = "0x262825C", VA = "0x262825C")]
	private static bool _003CRefreshViewData_003Em__0(Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x600D686")]
	[Address(RVA = "0x2628344", Offset = "0x2628344", VA = "0x2628344")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D687")]
	[Address(RVA = "0x262834C", Offset = "0x262834C", VA = "0x262834C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
