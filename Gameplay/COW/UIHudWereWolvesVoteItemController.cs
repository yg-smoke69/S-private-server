using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028C9")]
public class UIHudWereWolvesVoteItemController : UIEasyListItemController
{
	[Token(Token = "0x400FAF4")]
	[FieldOffset(Offset = "0x38")]
	private UIHudWereWolvesVoteItemView m_View;

	[Token(Token = "0x400FAF5")]
	[FieldOffset(Offset = "0x3C")]
	private HDCFACOPKDC m_info;

	[Token(Token = "0x400FAF6")]
	[FieldOffset(Offset = "0x40")]
	private List<UIHudWereWolvesVoteIndexController> m_IdxChildList;

	[Token(Token = "0x400FAF7")]
	[FieldOffset(Offset = "0x48")]
	private ulong m_userId;

	[Token(Token = "0x601011E")]
	[Address(RVA = "0x257C1BC", Offset = "0x257C1BC", VA = "0x257C1BC")]
	public UIHudWereWolvesVoteItemController()
	{
	}

	[Token(Token = "0x601011F")]
	[Address(RVA = "0x257C248", Offset = "0x257C248", VA = "0x257C248")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010120")]
	[Address(RVA = "0x257C2F0", Offset = "0x257C2F0", VA = "0x257C2F0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010121")]
	[Address(RVA = "0x257C774", Offset = "0x257C774", VA = "0x257C774", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6010122")]
	[Address(RVA = "0x257CA48", Offset = "0x257CA48", VA = "0x257CA48", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6010123")]
	[Address(RVA = "0x257CCA4", Offset = "0x257CCA4", VA = "0x257CCA4", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x6010124")]
	[Address(RVA = "0x257CF80", Offset = "0x257CF80", VA = "0x257CF80")]
	private void QuickChatBtnClick()
	{
	}

	[Token(Token = "0x6010125")]
	[Address(RVA = "0x257D248", Offset = "0x257D248", VA = "0x257D248")]
	private void OnVoteSelectChanged(object[] data)
	{
	}

	[Token(Token = "0x6010126")]
	[Address(RVA = "0x257D2B0", Offset = "0x257D2B0", VA = "0x257D2B0")]
	private void OnPlayerRoleChange(object[] data)
	{
	}

	[Token(Token = "0x6010127")]
	[Address(RVA = "0x257D570", Offset = "0x257D570", VA = "0x257D570", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6010128")]
	[Address(RVA = "0x257EC3C", Offset = "0x257EC3C", VA = "0x257EC3C")]
	private void OnMuteStateChange(object[] data)
	{
	}

	[Token(Token = "0x6010129")]
	[Address(RVA = "0x257EE90", Offset = "0x257EE90", VA = "0x257EE90")]
	private void OnPlayerVoiceStateChange(object[] data)
	{
	}

	[Token(Token = "0x601012A")]
	[Address(RVA = "0x257F0CC", Offset = "0x257F0CC", VA = "0x257F0CC")]
	private void OnLocalPlayerVoiceStateChange(object[] data)
	{
	}

	[Token(Token = "0x601012B")]
	[Address(RVA = "0x257CD10", Offset = "0x257CD10", VA = "0x257CD10")]
	public void RefreshSelectHighlight()
	{
	}

	[Token(Token = "0x601012C")]
	[Address(RVA = "0x257BA54", Offset = "0x257BA54", VA = "0x257BA54")]
	public UIWidget GetEnabelQuickChatBtnTutWidget()
	{
		return null;
	}

	[Token(Token = "0x601012D")]
	[Address(RVA = "0x257F268", Offset = "0x257F268", VA = "0x257F268")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601012E")]
	[Address(RVA = "0x257F270", Offset = "0x257F270", VA = "0x257F270")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x601012F")]
	[Address(RVA = "0x257F278", Offset = "0x257F278", VA = "0x257F278")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6010130")]
	[Address(RVA = "0x257F280", Offset = "0x257F280", VA = "0x257F280")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
