using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200295A")]
public class UILuckyBagItemController : UIEasyListItemController
{
	[Token(Token = "0x200295B")]
	private enum LuckyBagState
	{
		[Token(Token = "0x400FEE4")]
		None,
		[Token(Token = "0x400FEE5")]
		CanDraw,
		[Token(Token = "0x400FEE6")]
		Drawed,
		[Token(Token = "0x400FEE7")]
		DrawOver
	}

	[Token(Token = "0x400FEDD")]
	[FieldOffset(Offset = "0x38")]
	private UILuckyBagItemView m_View;

	[Token(Token = "0x400FEDE")]
	[FieldOffset(Offset = "0x3C")]
	private ClanLuckyBag m_Data;

	[Token(Token = "0x400FEDF")]
	[FieldOffset(Offset = "0x40")]
	private LuckyBagState m_LuckyBagState;

	[Token(Token = "0x400FEE0")]
	[FieldOffset(Offset = "0x44")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400FEE1")]
	[FieldOffset(Offset = "0x48")]
	private uint m_BtnGreyColor;

	[Token(Token = "0x400FEE2")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_BtnYellowColor;

	[Token(Token = "0x60108D4")]
	[Address(RVA = "0x2200F94", Offset = "0x2200F94", VA = "0x2200F94")]
	public UILuckyBagItemController()
	{
	}

	[Token(Token = "0x60108D5")]
	[Address(RVA = "0x2200FB4", Offset = "0x2200FB4", VA = "0x2200FB4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60108D6")]
	[Address(RVA = "0x220105C", Offset = "0x220105C", VA = "0x220105C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60108D7")]
	[Address(RVA = "0x2201348", Offset = "0x2201348", VA = "0x2201348", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60108D8")]
	[Address(RVA = "0x22013AC", Offset = "0x22013AC", VA = "0x22013AC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60108D9")]
	[Address(RVA = "0x22014B8", Offset = "0x22014B8", VA = "0x22014B8")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x60108DA")]
	[Address(RVA = "0x220154C", Offset = "0x220154C", VA = "0x220154C")]
	private void ResetItemState()
	{
	}

	[Token(Token = "0x60108DB")]
	[Address(RVA = "0x220163C", Offset = "0x220163C", VA = "0x220163C")]
	private void SetLuckyBagState()
	{
	}

	[Token(Token = "0x60108DC")]
	[Address(RVA = "0x220173C", Offset = "0x220173C", VA = "0x220173C")]
	private void RefreshDrawBtnByState()
	{
	}

	[Token(Token = "0x60108DD")]
	[Address(RVA = "0x2201790", Offset = "0x2201790", VA = "0x2201790")]
	private void RefreshDrawTimes()
	{
	}

	[Token(Token = "0x60108DE")]
	[Address(RVA = "0x22018DC", Offset = "0x22018DC", VA = "0x22018DC")]
	private void RefreshCountDownLabel()
	{
	}

	[Token(Token = "0x60108DF")]
	[Address(RVA = "0x2201A5C", Offset = "0x2201A5C", VA = "0x2201A5C")]
	private void RefreshLuckyBagMessage()
	{
	}

	[Token(Token = "0x60108E0")]
	[Address(RVA = "0x2202044", Offset = "0x2202044", VA = "0x2202044")]
	private void OnDrawBtnClick()
	{
	}

	[Token(Token = "0x60108E1")]
	[Address(RVA = "0x220240C", Offset = "0x220240C", VA = "0x220240C")]
	private void OnLuckyBagBtnClick()
	{
	}

	[Token(Token = "0x60108E2")]
	[Address(RVA = "0x2202734", Offset = "0x2202734", VA = "0x2202734")]
	private void OnLuckyBagMessageClick()
	{
	}

	[Token(Token = "0x60108E3")]
	[Address(RVA = "0x22025E4", Offset = "0x22025E4", VA = "0x22025E4")]
	private string GetLuckyBagDescriptionByLevel(uint level)
	{
		return null;
	}

	[Token(Token = "0x60108E4")]
	[Address(RVA = "0x2202954", Offset = "0x2202954", VA = "0x2202954")]
	private string GetLuckyBagNameByLevel(uint level)
	{
		return null;
	}

	[Token(Token = "0x60108E5")]
	[Address(RVA = "0x2201EF4", Offset = "0x2201EF4", VA = "0x2201EF4")]
	private string GetLuckyBagSpriteByLevel(uint level)
	{
		return null;
	}

	[Token(Token = "0x60108E6")]
	[Address(RVA = "0x21FF360", Offset = "0x21FF360", VA = "0x21FF360")]
	public Vector3 GetDrawBtnPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60108E7")]
	[Address(RVA = "0x21FF1CC", Offset = "0x21FF1CC", VA = "0x21FF1CC")]
	public void EnbaleAnimation(bool v)
	{
	}

	[Token(Token = "0x60108E8")]
	[Address(RVA = "0x2202AA4", Offset = "0x2202AA4", VA = "0x2202AA4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60108E9")]
	[Address(RVA = "0x2202AAC", Offset = "0x2202AAC", VA = "0x2202AAC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
