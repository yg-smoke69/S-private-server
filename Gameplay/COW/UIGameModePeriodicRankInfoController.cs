using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026AE")]
internal class UIGameModePeriodicRankInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x20026AF")]
	private sealed class _003CRefreshDownloadState_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EEBE")]
		[FieldOffset(Offset = "0x8")]
		internal List<ResourceID> listNeedDownloadMapRes;

		[Token(Token = "0x400EEBF")]
		[FieldOffset(Offset = "0xC")]
		internal UIGameModePeriodicRankInfoController _0024this;

		[Token(Token = "0x600E92B")]
		[Address(RVA = "0x218F6C4", Offset = "0x218F6C4", VA = "0x218F6C4")]
		public _003CRefreshDownloadState_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E92C")]
		[Address(RVA = "0x2190118", Offset = "0x2190118", VA = "0x2190118")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400EEB7")]
	[FieldOffset(Offset = "0x28")]
	private UIGameModePeriodicRankInfoView m_View;

	[Token(Token = "0x400EEB8")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x400EEB9")]
	[FieldOffset(Offset = "0x30")]
	private UIModelPeriodicLadderMatch m_ModelPeriodicLadderMatch;

	[Token(Token = "0x400EEBA")]
	[FieldOffset(Offset = "0x34")]
	private List<GameObject> m_StarList;

	[Token(Token = "0x400EEBB")]
	[FieldOffset(Offset = "0x38")]
	private List<GameObject> m_BlackStarList;

	[Token(Token = "0x400EEBC")]
	[FieldOffset(Offset = "0x3C")]
	private MapModeData m_SelectedMapModeData;

	[Token(Token = "0x400EEBD")]
	[FieldOffset(Offset = "0x40")]
	private UINewDownloadInfoController m_DownloadCtrl;

	[Token(Token = "0x600E918")]
	[Address(RVA = "0x218C638", Offset = "0x218C638", VA = "0x218C638")]
	public UIGameModePeriodicRankInfoController()
	{
	}

	[Token(Token = "0x600E919")]
	[Address(RVA = "0x218C6BC", Offset = "0x218C6BC", VA = "0x218C6BC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E91A")]
	[Address(RVA = "0x218C764", Offset = "0x218C764", VA = "0x218C764", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E91B")]
	[Address(RVA = "0x218CFE0", Offset = "0x218CFE0", VA = "0x218CFE0", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E91C")]
	[Address(RVA = "0x218D0BC", Offset = "0x218D0BC", VA = "0x218D0BC", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E91D")]
	[Address(RVA = "0x218E368", Offset = "0x218E368", VA = "0x218E368")]
	public void SetViewData(List<MapModeData> data)
	{
	}

	[Token(Token = "0x600E91E")]
	[Address(RVA = "0x218E474", Offset = "0x218E474", VA = "0x218E474")]
	private void OnMapSelectConfirm(object[] data)
	{
	}

	[Token(Token = "0x600E91F")]
	[Address(RVA = "0x218DFA8", Offset = "0x218DFA8", VA = "0x218DFA8")]
	private void RefreshSelectedMap(MapModeData data)
	{
	}

	[Token(Token = "0x600E920")]
	[Address(RVA = "0x218E8CC", Offset = "0x218E8CC", VA = "0x218E8CC")]
	private void RefreshAdvanceNotice()
	{
	}

	[Token(Token = "0x600E921")]
	[Address(RVA = "0x218D8D4", Offset = "0x218D8D4", VA = "0x218D8D4")]
	private void RefreshSeasonInfo()
	{
	}

	[Token(Token = "0x600E922")]
	[Address(RVA = "0x218D3A8", Offset = "0x218D3A8", VA = "0x218D3A8")]
	private void RefreshRankInfo()
	{
	}

	[Token(Token = "0x600E923")]
	[Address(RVA = "0x218EB88", Offset = "0x218EB88", VA = "0x218EB88")]
	private void RefreshRankIconAndStars(ResourceID id, int star)
	{
	}

	[Token(Token = "0x600E924")]
	[Address(RVA = "0x218DCB4", Offset = "0x218DCB4", VA = "0x218DCB4")]
	private void RefreshLockState()
	{
	}

	[Token(Token = "0x600E925")]
	[Address(RVA = "0x218F424", Offset = "0x218F424", VA = "0x218F424")]
	private void RefreshDownloadState()
	{
	}

	[Token(Token = "0x600E926")]
	[Address(RVA = "0x218F940", Offset = "0x218F940", VA = "0x218F940")]
	private void OnMapChangeButtonClicked()
	{
	}

	[Token(Token = "0x600E927")]
	[Address(RVA = "0x218FADC", Offset = "0x218FADC", VA = "0x218FADC")]
	private void OnClickBtnModelPick()
	{
	}

	[Token(Token = "0x600E928")]
	[Address(RVA = "0x218FDF0", Offset = "0x218FDF0", VA = "0x218FDF0")]
	private void OnClickBtnRankIcon()
	{
	}

	[Token(Token = "0x600E929")]
	[Address(RVA = "0x218F6CC", Offset = "0x218F6CC", VA = "0x218F6CC")]
	private List<ResourceID> GetNeedDownloadMapResList()
	{
		return null;
	}

	[Token(Token = "0x600E92A")]
	[Address(RVA = "0x2190110", Offset = "0x2190110", VA = "0x2190110")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
