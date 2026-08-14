using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200254F")]
public class UIClanMemberPageController : UIPreviewBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x400E716")]
	[FieldOffset(Offset = "0x38")]
	private UIClanMemberPageView m_View;

	[Token(Token = "0x400E717")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400E718")]
	[FieldOffset(Offset = "0x40")]
	private bool isGridExpand;

	[Token(Token = "0x400E719")]
	[FieldOffset(Offset = "0x41")]
	private bool isCurrentTab;

	[Token(Token = "0x400E71A")]
	[FieldOffset(Offset = "0x48")]
	private ulong m_SelectedAccountID;

	[Token(Token = "0x400E71B")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400E71C")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400E71D")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x600D953")]
	[Address(RVA = "0x2B3D6C8", Offset = "0x2B3D6C8", VA = "0x2B3D6C8")]
	public UIClanMemberPageController()
	{
	}

	[Token(Token = "0x600D954")]
	[Address(RVA = "0x2B3D6D0", Offset = "0x2B3D6D0", VA = "0x2B3D6D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D955")]
	[Address(RVA = "0x2B3D774", Offset = "0x2B3D774", VA = "0x2B3D774", Slot = "52")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D956")]
	[Address(RVA = "0x2B3D7F0", Offset = "0x2B3D7F0", VA = "0x2B3D7F0", Slot = "51")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D957")]
	[Address(RVA = "0x2B3D8E8", Offset = "0x2B3D8E8", VA = "0x2B3D8E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D958")]
	[Address(RVA = "0x2B3E628", Offset = "0x2B3E628", VA = "0x2B3E628", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D959")]
	[Address(RVA = "0x2B3E8D8", Offset = "0x2B3E8D8", VA = "0x2B3E8D8")]
	public void RefreshViewData(List<ClanMember> memberList)
	{
	}

	[Token(Token = "0x600D95A")]
	[Address(RVA = "0x2B3EB70", Offset = "0x2B3EB70", VA = "0x2B3EB70")]
	private void RefreshClanNum()
	{
	}

	[Token(Token = "0x600D95B")]
	[Address(RVA = "0x2B3E080", Offset = "0x2B3E080", VA = "0x2B3E080")]
	private void RefreshClanInfo()
	{
	}

	[Token(Token = "0x600D95C")]
	[Address(RVA = "0x2B3F658", Offset = "0x2B3F658", VA = "0x2B3F658")]
	public void RefreshAvatar()
	{
	}

	[Token(Token = "0x600D95D")]
	[Address(RVA = "0x2B3F8F4", Offset = "0x2B3F8F4", VA = "0x2B3F8F4")]
	private void OnClickExtend()
	{
	}

	[Token(Token = "0x600D95E")]
	[Address(RVA = "0x2B40414", Offset = "0x2B40414", VA = "0x2B40414")]
	private void OnOpenApplyList()
	{
	}

	[Token(Token = "0x600D95F")]
	[Address(RVA = "0x2B405F8", Offset = "0x2B405F8", VA = "0x2B405F8")]
	private void OnRecruitClick()
	{
	}

	[Token(Token = "0x600D960")]
	[Address(RVA = "0x2B40A40", Offset = "0x2B40A40", VA = "0x2B40A40")]
	public void OnFriendPageClick()
	{
	}

	[Token(Token = "0x600D961")]
	[Address(RVA = "0x2B40BFC", Offset = "0x2B40BFC", VA = "0x2B40BFC")]
	private void OnBtnLeaveClanClick()
	{
	}

	[Token(Token = "0x600D962")]
	[Address(RVA = "0x2B414C8", Offset = "0x2B414C8", VA = "0x2B414C8")]
	private void OnArrowClick()
	{
	}

	[Token(Token = "0x600D963")]
	[Address(RVA = "0x2B3EEA0", Offset = "0x2B3EEA0", VA = "0x2B3EEA0")]
	private void OnMemberItemSelected(object[] param)
	{
	}

	[Token(Token = "0x600D964")]
	[Address(RVA = "0x2B41534", Offset = "0x2B41534", VA = "0x2B41534")]
	private void OnTabSelected(object[] param)
	{
	}

	[Token(Token = "0x600D965")]
	[Address(RVA = "0x2B41738", Offset = "0x2B41738", VA = "0x2B41738")]
	private void OnInspectClick()
	{
	}

	[Token(Token = "0x600D966")]
	[Address(RVA = "0x2B41AC8", Offset = "0x2B41AC8", VA = "0x2B41AC8")]
	private void OnAddFriendClick()
	{
	}

	[Token(Token = "0x600D967")]
	[Address(RVA = "0x2B41D48", Offset = "0x2B41D48", VA = "0x2B41D48")]
	private void OnGiftClick()
	{
	}

	[Token(Token = "0x600D968")]
	[Address(RVA = "0x2B3F6C8", Offset = "0x2B3F6C8", VA = "0x2B3F6C8")]
	private void TryShowPreviewAvatar(ulong accountID)
	{
	}

	[Token(Token = "0x600D969")]
	[Address(RVA = "0x2B41F50", Offset = "0x2B41F50", VA = "0x2B41F50")]
	private bool ShowAvatar(ulong accountID)
	{
		return default(bool);
	}

	[Token(Token = "0x600D96A")]
	[Address(RVA = "0x2B42150", Offset = "0x2B42150", VA = "0x2B42150")]
	private void ShowLoading(bool show)
	{
	}

	[Token(Token = "0x600D96B")]
	[Address(RVA = "0x2B42204", Offset = "0x2B42204", VA = "0x2B42204", Slot = "53")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D96C")]
	[Address(RVA = "0x2B425F0", Offset = "0x2B425F0", VA = "0x2B425F0", Slot = "54")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D96D")]
	[Address(RVA = "0x2B426A8", Offset = "0x2B426A8", VA = "0x2B426A8", Slot = "31")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600D96E")]
	[Address(RVA = "0x2B42718", Offset = "0x2B42718", VA = "0x2B42718", Slot = "32")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600D96F")]
	[Address(RVA = "0x2B42770", Offset = "0x2B42770", VA = "0x2B42770")]
	private static void _003COnClickExtend_003Em__0()
	{
	}

	[Token(Token = "0x600D970")]
	[Address(RVA = "0x2B42808", Offset = "0x2B42808", VA = "0x2B42808")]
	private static void _003COnClickExtend_003Em__1()
	{
	}

	[Token(Token = "0x600D971")]
	[Address(RVA = "0x2B428DC", Offset = "0x2B428DC", VA = "0x2B428DC")]
	private static void _003COnBtnLeaveClanClick_003Em__2()
	{
	}

	[Token(Token = "0x600D972")]
	[Address(RVA = "0x2B429B8", Offset = "0x2B429B8", VA = "0x2B429B8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D973")]
	[Address(RVA = "0x2B429C0", Offset = "0x2B429C0", VA = "0x2B429C0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
