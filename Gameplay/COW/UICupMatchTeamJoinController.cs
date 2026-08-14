using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002087")]
public class UICupMatchTeamJoinController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x2002088")]
	public enum ApplyState
	{
		[Token(Token = "0x400CBF6")]
		Normal,
		[Token(Token = "0x400CBF7")]
		Applying,
		[Token(Token = "0x400CBF8")]
		ApplySuccess,
		[Token(Token = "0x400CBF9")]
		CantApplyTeamFull
	}

	[Token(Token = "0x2002089")]
	private sealed class _003CRefreshFriendCupInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CBFA")]
		[FieldOffset(Offset = "0x8")]
		internal FriendAccountInfo friendAccountInfo;

		[Token(Token = "0x600A759")]
		[Address(RVA = "0x2AC2AE0", Offset = "0x2AC2AE0", VA = "0x2AC2AE0")]
		public _003CRefreshFriendCupInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600A75A")]
		[Address(RVA = "0x2AC316C", Offset = "0x2AC316C", VA = "0x2AC316C")]
		internal bool _003C_003Em__0(FriendAccountInfoWithCupTeamInfo f)
		{
			return default(bool);
		}

		[Token(Token = "0x600A75B")]
		[Address(RVA = "0x2AC31D4", Offset = "0x2AC31D4", VA = "0x2AC31D4")]
		internal bool _003C_003Em__1(CSAccountCupInfoRes info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400CBEC")]
	[FieldOffset(Offset = "0x48")]
	private UICupMatchTeamJoinView m_View;

	[Token(Token = "0x400CBED")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CBEE")]
	[FieldOffset(Offset = "0x50")]
	private UIModelFriends m_ModelFriends;

	[Token(Token = "0x400CBEF")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<ulong, ApplyState> m_ApplyStates;

	[Token(Token = "0x400CBF0")]
	[FieldOffset(Offset = "0x58")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CBF1")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_HasSearch;

	[Token(Token = "0x400CBF2")]
	[FieldOffset(Offset = "0x60")]
	private List<FriendAccountInfo> m_AllOnlineFriend;

	[Token(Token = "0x400CBF3")]
	[FieldOffset(Offset = "0x64")]
	private List<FriendAccountInfoWithCupTeamInfo> m_FriendsAccountInfoWitchCupTeamInfoList;

	[Token(Token = "0x400CBF4")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<FriendAccountInfo, ulong> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600A741")]
	[Address(RVA = "0x2ABFDC0", Offset = "0x2ABFDC0", VA = "0x2ABFDC0")]
	public UICupMatchTeamJoinController()
	{
	}

	[Token(Token = "0x600A742")]
	[Address(RVA = "0x2ABFEB4", Offset = "0x2ABFEB4", VA = "0x2ABFEB4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A743")]
	[Address(RVA = "0x2ABFF5C", Offset = "0x2ABFF5C", VA = "0x2ABFF5C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A744")]
	[Address(RVA = "0x2AC0660", Offset = "0x2AC0660", VA = "0x2AC0660", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A745")]
	[Address(RVA = "0x2AC070C", Offset = "0x2AC070C", VA = "0x2AC070C", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600A746")]
	[Address(RVA = "0x2AC0788", Offset = "0x2AC0788", VA = "0x2AC0788", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600A747")]
	[Address(RVA = "0x2AC0908", Offset = "0x2AC0908", VA = "0x2AC0908")]
	public void SetCupMatchType(int cupMatchKey)
	{
	}

	[Token(Token = "0x600A748")]
	[Address(RVA = "0x2AC09B8", Offset = "0x2AC09B8", VA = "0x2AC09B8")]
	private void InitApplyState()
	{
	}

	[Token(Token = "0x600A749")]
	[Address(RVA = "0x2AC0C88", Offset = "0x2AC0C88", VA = "0x2AC0C88")]
	public ApplyState GetApplyState(ulong id)
	{
		return default(ApplyState);
	}

	[Token(Token = "0x600A74A")]
	[Address(RVA = "0x2AC0B94", Offset = "0x2AC0B94", VA = "0x2AC0B94")]
	public void SetApplyState(ulong id, ApplyState state)
	{
	}

	[Token(Token = "0x600A74B")]
	[Address(RVA = "0x2AC0D94", Offset = "0x2AC0D94", VA = "0x2AC0D94")]
	private void Search()
	{
	}

	[Token(Token = "0x600A74C")]
	[Address(RVA = "0x2AC1320", Offset = "0x2AC1320", VA = "0x2AC1320")]
	private void ResetSearch()
	{
	}

	[Token(Token = "0x600A74D")]
	[Address(RVA = "0x2AC16C4", Offset = "0x2AC16C4", VA = "0x2AC16C4")]
	private int FriendSort(FriendAccountInfoWithCupTeamInfo a, FriendAccountInfoWithCupTeamInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x600A74E")]
	[Address(RVA = "0x2AC1870", Offset = "0x2AC1870", VA = "0x2AC1870", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A74F")]
	[Address(RVA = "0x2AC2204", Offset = "0x2AC2204", VA = "0x2AC2204")]
	private void RefreshFriendCupInfo(bool isSearch)
	{
	}

	[Token(Token = "0x600A750")]
	[Address(RVA = "0x2AC14F4", Offset = "0x2AC14F4", VA = "0x2AC14F4")]
	public void RefreshEasyListView(List<FriendAccountInfoWithCupTeamInfo> data)
	{
	}

	[Token(Token = "0x600A751")]
	[Address(RVA = "0x2AC2AE8", Offset = "0x2AC2AE8", VA = "0x2AC2AE8", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A752")]
	[Address(RVA = "0x2AC2B8C", Offset = "0x2AC2B8C", VA = "0x2AC2B8C")]
	private void OnSearchInputGetFocus()
	{
	}

	[Token(Token = "0x600A753")]
	[Address(RVA = "0x2AC2CA8", Offset = "0x2AC2CA8", VA = "0x2AC2CA8")]
	private void OnRefreshBtnClick()
	{
	}

	[Token(Token = "0x600A754")]
	[Address(RVA = "0x2AC037C", Offset = "0x2AC037C", VA = "0x2AC037C")]
	private void SetRefreshBtnState()
	{
	}

	[Token(Token = "0x600A755")]
	[Address(RVA = "0x2AC3060", Offset = "0x2AC3060", VA = "0x2AC3060")]
	private static ulong _003COnDataChanged_003Em__0(FriendAccountInfo f)
	{
		return default(ulong);
	}

	[Token(Token = "0x600A756")]
	[Address(RVA = "0x2AC3084", Offset = "0x2AC3084", VA = "0x2AC3084")]
	private void _003CSetRefreshBtnState_003Em__1()
	{
	}

	[Token(Token = "0x600A757")]
	[Address(RVA = "0x2AC315C", Offset = "0x2AC315C", VA = "0x2AC315C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A758")]
	[Address(RVA = "0x2AC3164", Offset = "0x2AC3164", VA = "0x2AC3164")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
