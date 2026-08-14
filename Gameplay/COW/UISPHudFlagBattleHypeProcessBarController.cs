using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B33")]
public class UISPHudFlagBattleHypeProcessBarController : UIHudFlagBattleHypeProcessBarController
{
	[Token(Token = "0x4010932")]
	[FieldOffset(Offset = "0x90")]
	internal UIModelSpectator m_ModelSpectator;

	[Token(Token = "0x4010933")]
	[FieldOffset(Offset = "0x98")]
	private IHAAMHPPLMG m_LastTargetId;

	[Token(Token = "0x4010934")]
	[FieldOffset(Offset = "0xB0")]
	private int m_LastHypeCount;

	[Token(Token = "0x6011C77")]
	[Address(RVA = "0x1D1CBA0", Offset = "0x1D1CBA0", VA = "0x1D1CBA0")]
	public UISPHudFlagBattleHypeProcessBarController()
	{
	}

	[Token(Token = "0x6011C78")]
	[Address(RVA = "0x1D1CC4C", Offset = "0x1D1CC4C", VA = "0x1D1CC4C")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011C79")]
	[Address(RVA = "0x1D1CCF4", Offset = "0x1D1CCF4", VA = "0x1D1CCF4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011C7A")]
	[Address(RVA = "0x1D1CF00", Offset = "0x1D1CF00", VA = "0x1D1CF00", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011C7B")]
	[Address(RVA = "0x1D1D09C", Offset = "0x1D1D09C", VA = "0x1D1D09C", Slot = "37")]
	protected override void OnSwitchObserver(object[] data)
	{
	}

	[Token(Token = "0x6011C7C")]
	[Address(RVA = "0x1D1D25C", Offset = "0x1D1D25C", VA = "0x1D1D25C")]
	private void SetPlayerHype(PlayerNetwork playernetWork)
	{
	}

	[Token(Token = "0x6011C7D")]
	[Address(RVA = "0x1D1D59C", Offset = "0x1D1D59C", VA = "0x1D1D59C")]
	private bool NeedUpdateDesc(int hypeCount, IHAAMHPPLMG playerID)
	{
		return default(bool);
	}

	[Token(Token = "0x6011C7E")]
	[Address(RVA = "0x1D1D70C", Offset = "0x1D1D70C", VA = "0x1D1D70C", Slot = "35")]
	protected override void ShowSliderLvInfo(Dictionary<byte, uint> selectedAtt)
	{
	}

	[Token(Token = "0x6011C7F")]
	[Address(RVA = "0x1D1DC24", Offset = "0x1D1DC24", VA = "0x1D1DC24")]
	private void OnSelectAttributeSpectator(object[] data)
	{
	}

	[Token(Token = "0x6011C80")]
	[Address(RVA = "0x1D1DF68", Offset = "0x1D1DF68", VA = "0x1D1DF68")]
	private void OnSwitchHypeDescShow(object[] data)
	{
	}

	[Token(Token = "0x6011C81")]
	[Address(RVA = "0x1D1DFEC", Offset = "0x1D1DFEC", VA = "0x1D1DFEC", Slot = "32")]
	protected override void ShowDetail(bool b)
	{
	}

	[Token(Token = "0x6011C82")]
	[Address(RVA = "0x1D1E3D8", Offset = "0x1D1E3D8", VA = "0x1D1E3D8", Slot = "36")]
	protected override void OnHypeLevelChange(object[] data)
	{
	}

	[Token(Token = "0x6011C83")]
	[Address(RVA = "0x1D1E45C", Offset = "0x1D1E45C", VA = "0x1D1E45C", Slot = "34")]
	protected override void UpdateSliderInfo()
	{
	}

	[Token(Token = "0x6011C84")]
	[Address(RVA = "0x1D1E69C", Offset = "0x1D1E69C", VA = "0x1D1E69C", Slot = "31")]
	protected override void OnLevelUpBtnClick()
	{
	}

	[Token(Token = "0x6011C85")]
	[Address(RVA = "0x1D1E6F0", Offset = "0x1D1E6F0", VA = "0x1D1E6F0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011C86")]
	[Address(RVA = "0x1D1E6F8", Offset = "0x1D1E6F8", VA = "0x1D1E6F8")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011C87")]
	[Address(RVA = "0x1D1E700", Offset = "0x1D1E700", VA = "0x1D1E700")]
	public void _003C_003EiFixBaseProxy_OnSwitchObserver(object[] P0)
	{
	}

	[Token(Token = "0x6011C88")]
	[Address(RVA = "0x1D1E708", Offset = "0x1D1E708", VA = "0x1D1E708")]
	public void _003C_003EiFixBaseProxy_ShowSliderLvInfo(Dictionary<byte, uint> P0)
	{
	}

	[Token(Token = "0x6011C89")]
	[Address(RVA = "0x1D1E710", Offset = "0x1D1E710", VA = "0x1D1E710")]
	public void _003C_003EiFixBaseProxy_ShowDetail(bool P0)
	{
	}

	[Token(Token = "0x6011C8A")]
	[Address(RVA = "0x1D1E718", Offset = "0x1D1E718", VA = "0x1D1E718")]
	public void _003C_003EiFixBaseProxy_OnHypeLevelChange(object[] P0)
	{
	}

	[Token(Token = "0x6011C8B")]
	[Address(RVA = "0x1D1E720", Offset = "0x1D1E720", VA = "0x1D1E720")]
	public void _003C_003EiFixBaseProxy_UpdateSliderInfo()
	{
	}

	[Token(Token = "0x6011C8C")]
	[Address(RVA = "0x1D1E728", Offset = "0x1D1E728", VA = "0x1D1E728")]
	public void _003C_003EiFixBaseProxy_OnLevelUpBtnClick()
	{
	}
}
