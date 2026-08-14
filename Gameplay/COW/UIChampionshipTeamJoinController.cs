using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002023")]
public class UIChampionshipTeamJoinController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x2002024")]
	public enum ApplyState
	{
		[Token(Token = "0x400C9D5")]
		Normal,
		[Token(Token = "0x400C9D6")]
		Applying,
		[Token(Token = "0x400C9D7")]
		ApplySuccess,
		[Token(Token = "0x400C9D8")]
		CantApplyTeamFull
	}

	[Token(Token = "0x400C9CE")]
	[FieldOffset(Offset = "0x48")]
	private UIChampionshipTeamJoinView m_View;

	[Token(Token = "0x400C9CF")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C9D0")]
	[FieldOffset(Offset = "0x50")]
	private UIModelFriends m_ModelFriends;

	[Token(Token = "0x400C9D1")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<ulong, ApplyState> m_ApplyStates;

	[Token(Token = "0x400C9D2")]
	[FieldOffset(Offset = "0x58")]
	private uint m_ChampionshipType;

	[Token(Token = "0x400C9D3")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<FriendAccountInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600A2DE")]
	[Address(RVA = "0x2614DB4", Offset = "0x2614DB4", VA = "0x2614DB4")]
	public UIChampionshipTeamJoinController()
	{
	}

	[Token(Token = "0x600A2DF")]
	[Address(RVA = "0x2614E40", Offset = "0x2614E40", VA = "0x2614E40")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A2E0")]
	[Address(RVA = "0x2614EE4", Offset = "0x2614EE4", VA = "0x2614EE4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A2E1")]
	[Address(RVA = "0x26151D0", Offset = "0x26151D0", VA = "0x26151D0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A2E2")]
	[Address(RVA = "0x2615258", Offset = "0x2615258", VA = "0x2615258", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600A2E3")]
	[Address(RVA = "0x26152D4", Offset = "0x26152D4", VA = "0x26152D4", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600A2E4")]
	[Address(RVA = "0x2615454", Offset = "0x2615454", VA = "0x2615454")]
	public void SetChampionshipType(uint championshipType)
	{
	}

	[Token(Token = "0x600A2E5")]
	[Address(RVA = "0x26154B4", Offset = "0x26154B4", VA = "0x26154B4")]
	public ApplyState GetApplyState(ulong id)
	{
		return default(ApplyState);
	}

	[Token(Token = "0x600A2E6")]
	[Address(RVA = "0x26155C0", Offset = "0x26155C0", VA = "0x26155C0")]
	public void SetApplyState(ulong id, ApplyState state)
	{
	}

	[Token(Token = "0x600A2E7")]
	[Address(RVA = "0x26156B4", Offset = "0x26156B4", VA = "0x26156B4")]
	private void Search()
	{
	}

	[Token(Token = "0x600A2E8")]
	[Address(RVA = "0x2615B88", Offset = "0x2615B88", VA = "0x2615B88")]
	public void ShowSearchResultView()
	{
	}

	[Token(Token = "0x600A2E9")]
	[Address(RVA = "0x2615FB0", Offset = "0x2615FB0", VA = "0x2615FB0")]
	private int FriendSort(FriendAccountInfo a, FriendAccountInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x600A2EA")]
	[Address(RVA = "0x2616100", Offset = "0x2616100", VA = "0x2616100", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A2EB")]
	[Address(RVA = "0x2615DE0", Offset = "0x2615DE0", VA = "0x2615DE0")]
	public void RefreshEasyListView(List<FriendAccountInfo> data)
	{
	}

	[Token(Token = "0x600A2EC")]
	[Address(RVA = "0x26162C4", Offset = "0x26162C4", VA = "0x26162C4", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A2ED")]
	[Address(RVA = "0x2616358", Offset = "0x2616358", VA = "0x2616358")]
	private static bool _003CShowSearchResultView_003Em__0(FriendAccountInfo e)
	{
		return default(bool);
	}

	[Token(Token = "0x600A2EE")]
	[Address(RVA = "0x26163F4", Offset = "0x26163F4", VA = "0x26163F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A2EF")]
	[Address(RVA = "0x26163FC", Offset = "0x26163FC", VA = "0x26163FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
