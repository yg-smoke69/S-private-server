using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002564")]
public class UIClanWarRankController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x2002565")]
	private enum ERankType
	{
		[Token(Token = "0x400E780")]
		None,
		[Token(Token = "0x400E781")]
		Clan,
		[Token(Token = "0x400E782")]
		Person
	}

	[Token(Token = "0x2002566")]
	private sealed class _003CShowSelfPerson_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E783")]
		[FieldOffset(Offset = "0x8")]
		internal ulong myAccountId;

		[Token(Token = "0x600DA6C")]
		[Address(RVA = "0x2906430", Offset = "0x2906430", VA = "0x2906430")]
		public _003CShowSelfPerson_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600DA6D")]
		[Address(RVA = "0x29066C4", Offset = "0x29066C4", VA = "0x29066C4")]
		internal bool _003C_003Em__0(ClanWarMemberStatus x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E778")]
	[FieldOffset(Offset = "0x28")]
	private UIClanWarRankView m_View;

	[Token(Token = "0x400E779")]
	[FieldOffset(Offset = "0x2C")]
	private UIClanWarRankItemController m_SelfItem;

	[Token(Token = "0x400E77A")]
	[FieldOffset(Offset = "0x30")]
	private UIClanWarRankItemController.DisplayType m_ItemDisplayType;

	[Token(Token = "0x400E77B")]
	[FieldOffset(Offset = "0x34")]
	private ERankType m_CurrentRankType;

	[Token(Token = "0x400E77C")]
	[FieldOffset(Offset = "0x38")]
	private UIModelLeaderBoard m_ModelLeaderBoard;

	[Token(Token = "0x400E77D")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400E77E")]
	[FieldOffset(Offset = "0x40")]
	private bool m_FirstPerson;

	[Token(Token = "0x600DA57")]
	[Address(RVA = "0x2904C64", Offset = "0x2904C64", VA = "0x2904C64")]
	public UIClanWarRankController()
	{
	}

	[Token(Token = "0x600DA58")]
	[Address(RVA = "0x2904CF0", Offset = "0x2904CF0", VA = "0x2904CF0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DA59")]
	[Address(RVA = "0x2904D98", Offset = "0x2904D98", VA = "0x2904D98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DA5A")]
	[Address(RVA = "0x2905244", Offset = "0x2905244", VA = "0x2905244", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600DA5B")]
	[Address(RVA = "0x29052F0", Offset = "0x29052F0", VA = "0x29052F0", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600DA5C")]
	[Address(RVA = "0x2905470", Offset = "0x2905470", VA = "0x2905470", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600DA5D")]
	[Address(RVA = "0x29054EC", Offset = "0x29054EC", VA = "0x29054EC", Slot = "33")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600DA5E")]
	[Address(RVA = "0x2905D10", Offset = "0x2905D10", VA = "0x2905D10", Slot = "34")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600DA5F")]
	[Address(RVA = "0x2904F3C", Offset = "0x2904F3C", VA = "0x2904F3C")]
	private void InitView()
	{
	}

	[Token(Token = "0x600DA60")]
	[Address(RVA = "0x2905F28", Offset = "0x2905F28", VA = "0x2905F28")]
	public void HideReturnBtn()
	{
	}

	[Token(Token = "0x600DA61")]
	[Address(RVA = "0x2905FD8", Offset = "0x2905FD8", VA = "0x2905FD8")]
	private void ShowRankList(ERankType rankType)
	{
	}

	[Token(Token = "0x600DA62")]
	[Address(RVA = "0x2906180", Offset = "0x2906180", VA = "0x2906180")]
	private void SwitchListTitle(ERankType rankType)
	{
	}

	[Token(Token = "0x600DA63")]
	[Address(RVA = "0x290591C", Offset = "0x290591C", VA = "0x290591C")]
	private void ShowPersonRank()
	{
	}

	[Token(Token = "0x600DA64")]
	[Address(RVA = "0x2905608", Offset = "0x2905608", VA = "0x2905608")]
	private void ShowClanRank()
	{
	}

	[Token(Token = "0x600DA65")]
	[Address(RVA = "0x2905A60", Offset = "0x2905A60", VA = "0x2905A60")]
	private void ShowSelfPerson()
	{
	}

	[Token(Token = "0x600DA66")]
	[Address(RVA = "0x2905760", Offset = "0x2905760", VA = "0x2905760")]
	private void ShowSelfClan()
	{
	}

	[Token(Token = "0x600DA67")]
	[Address(RVA = "0x2906260", Offset = "0x2906260", VA = "0x2906260")]
	private void RequestClanRank()
	{
	}

	[Token(Token = "0x600DA68")]
	[Address(RVA = "0x2905DB4", Offset = "0x2905DB4", VA = "0x2905DB4")]
	private void OnSelectedToggleButton(UIToggleButton toggle)
	{
	}

	[Token(Token = "0x600DA69")]
	[Address(RVA = "0x2906518", Offset = "0x2906518", VA = "0x2906518")]
	private void OnClickReturnBtn()
	{
	}

	[Token(Token = "0x600DA6A")]
	[Address(RVA = "0x29066B4", Offset = "0x29066B4", VA = "0x29066B4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DA6B")]
	[Address(RVA = "0x29066BC", Offset = "0x29066BC", VA = "0x29066BC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
