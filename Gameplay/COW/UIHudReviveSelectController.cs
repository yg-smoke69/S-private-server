using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200283A")]
internal class UIHudReviveSelectController : UIBaseController
{
	[Token(Token = "0x400F82D")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDReviveSelectView m_View;

	[Token(Token = "0x400F82E")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_RequestAll;

	[Token(Token = "0x400F82F")]
	[FieldOffset(Offset = "0x30")]
	private List<InstantKillPlayerData> m_PlayerList;

	[Token(Token = "0x400F830")]
	[FieldOffset(Offset = "0x34")]
	private int m_Selected;

	[Token(Token = "0x400F831")]
	[FieldOffset(Offset = "0x38")]
	private int mOwnerItemId;

	[Token(Token = "0x600FB02")]
	[Address(RVA = "0x13FA6CC", Offset = "0x13FA6CC", VA = "0x13FA6CC")]
	public UIHudReviveSelectController()
	{
	}

	[Token(Token = "0x600FB03")]
	[Address(RVA = "0x13FA78C", Offset = "0x13FA78C", VA = "0x13FA78C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FB04")]
	[Address(RVA = "0x13FA830", Offset = "0x13FA830", VA = "0x13FA830", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FB05")]
	[Address(RVA = "0x13FAB5C", Offset = "0x13FAB5C", VA = "0x13FAB5C")]
	public void SetUIData(bool all, int itemId = 0)
	{
	}

	[Token(Token = "0x600FB06")]
	[Address(RVA = "0x13FAC60", Offset = "0x13FAC60", VA = "0x13FAC60")]
	private void RefreshPendingReviveTeammates()
	{
	}

	[Token(Token = "0x600FB07")]
	[Address(RVA = "0x13FBD4C", Offset = "0x13FBD4C", VA = "0x13FBD4C")]
	private void OnPlayer1Click()
	{
	}

	[Token(Token = "0x600FB08")]
	[Address(RVA = "0x13FBFEC", Offset = "0x13FBFEC", VA = "0x13FBFEC")]
	private void OnPlayer2Click()
	{
	}

	[Token(Token = "0x600FB09")]
	[Address(RVA = "0x13FC054", Offset = "0x13FC054", VA = "0x13FC054")]
	private void OnPlayer3Click()
	{
	}

	[Token(Token = "0x600FB0A")]
	[Address(RVA = "0x13FBDB4", Offset = "0x13FBDB4", VA = "0x13FBDB4")]
	private void OnPlayerClick()
	{
	}

	[Token(Token = "0x600FB0B")]
	[Address(RVA = "0x13FC0BC", Offset = "0x13FC0BC", VA = "0x13FC0BC")]
	private void OnCancelClick()
	{
	}

	[Token(Token = "0x600FB0C")]
	[Address(RVA = "0x13FC1DC", Offset = "0x13FC1DC", VA = "0x13FC1DC")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600FB0D")]
	[Address(RVA = "0x13FC8B4", Offset = "0x13FC8B4", VA = "0x13FC8B4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
