using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200299C")]
public class UIMapModePopMenuItemController : UIPopMenuItemBaseController
{
	[Token(Token = "0x4010011")]
	[FieldOffset(Offset = "0x2C")]
	private UIMapModePopMeuItemView m_View;

	[Token(Token = "0x4010012")]
	[FieldOffset(Offset = "0x30")]
	private PopMenuData m_Data;

	[Token(Token = "0x4010013")]
	[FieldOffset(Offset = "0x34")]
	private uint m_DelayCallID;

	[Token(Token = "0x4010014")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6010B6E")]
	[Address(RVA = "0x2805E34", Offset = "0x2805E34", VA = "0x2805E34")]
	public UIMapModePopMenuItemController()
	{
	}

	[Token(Token = "0x6010B6F")]
	[Address(RVA = "0x2805E3C", Offset = "0x2805E3C", VA = "0x2805E3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010B70")]
	[Address(RVA = "0x2805EE4", Offset = "0x2805EE4", VA = "0x2805EE4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010B71")]
	[Address(RVA = "0x28060D4", Offset = "0x28060D4", VA = "0x28060D4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010B72")]
	[Address(RVA = "0x2806244", Offset = "0x2806244", VA = "0x2806244", Slot = "31")]
	public override void SetItemData(PopMenuData data)
	{
	}

	[Token(Token = "0x6010B73")]
	[Address(RVA = "0x28064B8", Offset = "0x28064B8", VA = "0x28064B8")]
	private void SetSelectedState(bool selected)
	{
	}

	[Token(Token = "0x6010B74")]
	[Address(RVA = "0x2806550", Offset = "0x2806550", VA = "0x2806550")]
	public void OnPopMenuItemClick()
	{
	}

	[Token(Token = "0x6010B75")]
	[Address(RVA = "0x2806824", Offset = "0x2806824", VA = "0x2806824")]
	private void OnPopMenuSelected(object[] data)
	{
	}

	[Token(Token = "0x6010B76")]
	[Address(RVA = "0x28069A0", Offset = "0x28069A0", VA = "0x28069A0")]
	private static void _003COnPopMenuItemClick_003Em__0()
	{
	}

	[Token(Token = "0x6010B77")]
	[Address(RVA = "0x2806AEC", Offset = "0x2806AEC", VA = "0x2806AEC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010B78")]
	[Address(RVA = "0x2806AF4", Offset = "0x2806AF4", VA = "0x2806AF4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x6010B79")]
	[Address(RVA = "0x2806AFC", Offset = "0x2806AFC", VA = "0x2806AFC")]
	public void _003C_003EiFixBaseProxy_SetItemData(PopMenuData P0)
	{
	}
}
