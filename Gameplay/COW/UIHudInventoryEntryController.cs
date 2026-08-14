using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002789")]
internal class UIHudInventoryEntryController : UIBaseController
{
	[Token(Token = "0x400F428")]
	[FieldOffset(Offset = "0x28")]
	private UIHudInventoryEntryView m_View;

	[Token(Token = "0x400F429")]
	[FieldOffset(Offset = "0x2C")]
	private Color32 m_CommonColor;

	[Token(Token = "0x400F42A")]
	[FieldOffset(Offset = "0x30")]
	private Color32 m_MaxColor;

	[Token(Token = "0x400F42B")]
	[FieldOffset(Offset = "0x34")]
	public bool InventoryDisabled;

	[Token(Token = "0x400F42C")]
	[FieldOffset(Offset = "0x38")]
	private uint m_DelayCall;

	[Token(Token = "0x600F316")]
	[Address(RVA = "0x2094FF8", Offset = "0x2094FF8", VA = "0x2094FF8")]
	public UIHudInventoryEntryController()
	{
	}

	[Token(Token = "0x600F317")]
	[Address(RVA = "0x20950D8", Offset = "0x20950D8", VA = "0x20950D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F318")]
	[Address(RVA = "0x209517C", Offset = "0x209517C", VA = "0x209517C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F319")]
	[Address(RVA = "0x209573C", Offset = "0x209573C", VA = "0x209573C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F31A")]
	[Address(RVA = "0x2095BB0", Offset = "0x2095BB0", VA = "0x2095BB0")]
	private void OnBtnInventoryClick()
	{
	}

	[Token(Token = "0x600F31B")]
	[Address(RVA = "0x2095E5C", Offset = "0x2095E5C", VA = "0x2095E5C")]
	private void OnAddLocalPlayer(object[] param)
	{
	}

	[Token(Token = "0x600F31C")]
	[Address(RVA = "0x2095F1C", Offset = "0x2095F1C", VA = "0x2095F1C")]
	private void OnCapacityRefresh(object[] param)
	{
	}

	[Token(Token = "0x600F31D")]
	[Address(RVA = "0x2096488", Offset = "0x2096488", VA = "0x2096488")]
	private void OnInventoryPickup(object[] param)
	{
	}

	[Token(Token = "0x600F31E")]
	[Address(RVA = "0x2096698", Offset = "0x2096698", VA = "0x2096698")]
	private void OnInventoryNoCapacityToPickup(object[] param)
	{
	}

	[Token(Token = "0x600F31F")]
	[Address(RVA = "0x20968E8", Offset = "0x20968E8", VA = "0x20968E8")]
	private void ShowTutoDropCamouflageOpenBag(object[] param)
	{
	}

	[Token(Token = "0x600F320")]
	[Address(RVA = "0x2096B38", Offset = "0x2096B38", VA = "0x2096B38")]
	private void OnInventoryUpdateLevel(object[] param)
	{
	}

	[Token(Token = "0x600F321")]
	[Address(RVA = "0x2096D28", Offset = "0x2096D28", VA = "0x2096D28", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F322")]
	[Address(RVA = "0x2096E8C", Offset = "0x2096E8C", VA = "0x2096E8C")]
	private void OnRichInventory(object[] param)
	{
	}

	[Token(Token = "0x600F323")]
	[Address(RVA = "0x20970D0", Offset = "0x20970D0", VA = "0x20970D0")]
	private void OnEnableInventory(object[] param)
	{
	}

	[Token(Token = "0x600F324")]
	[Address(RVA = "0x20971E4", Offset = "0x20971E4", VA = "0x20971E4")]
	private void OnTrainingZoneChanged(object[] param)
	{
	}

	[Token(Token = "0x600F325")]
	[Address(RVA = "0x20972E4", Offset = "0x20972E4", VA = "0x20972E4")]
	private void _003COnRichInventory_003Em__0()
	{
	}

	[Token(Token = "0x600F326")]
	[Address(RVA = "0x2097328", Offset = "0x2097328", VA = "0x2097328")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F327")]
	[Address(RVA = "0x2097330", Offset = "0x2097330", VA = "0x2097330")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F328")]
	[Address(RVA = "0x2097338", Offset = "0x2097338", VA = "0x2097338")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
