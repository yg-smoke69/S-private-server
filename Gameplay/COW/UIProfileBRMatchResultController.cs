using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002A86")]
public class UIProfileBRMatchResultController : UIProfileBaseMatchResultController
{
	[Token(Token = "0x2002A87")]
	private sealed class _003COnReportCheatSent_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010532")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountID;

		[Token(Token = "0x601153B")]
		[Address(RVA = "0xF099A0", Offset = "0xF099A0", VA = "0xF099A0")]
		public _003COnReportCheatSent_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601153C")]
		[Address(RVA = "0xF09B48", Offset = "0xF09B48", VA = "0xF09B48")]
		internal bool _003C_003Em__0(CandidateReporteeData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4010529")]
	[FieldOffset(Offset = "0x54")]
	private UIProfileBRMatchResultView m_View;

	[Token(Token = "0x401052A")]
	[FieldOffset(Offset = "0x58")]
	private List<UIProfileNormalMatchResultItemController> m_ItemCtrlList;

	[Token(Token = "0x401052B")]
	[FieldOffset(Offset = "0x5C")]
	private Dictionary<ulong, ExtraPlayerDataForMatchResult> m_PlayerMatchResultDataMap;

	[Token(Token = "0x401052C")]
	[FieldOffset(Offset = "0x60")]
	private MatchStats m_MatchStats;

	[Token(Token = "0x401052D")]
	[FieldOffset(Offset = "0x68")]
	private ulong m_MatchID;

	[Token(Token = "0x401052E")]
	[FieldOffset(Offset = "0x70")]
	private bool m_SHowFastGift;

	[Token(Token = "0x401052F")]
	[FieldOffset(Offset = "0x74")]
	private CandidateReporteeData m_DefaultReportee;

	[Token(Token = "0x4010530")]
	[FieldOffset(Offset = "0x78")]
	private List<CandidateReporteeData> m_ReporteeList;

	[Token(Token = "0x4010531")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<TeammateStats, FriendInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170012C7")]
	protected List<UIProfileNormalMatchResultItemController> ItemCtrlList
	{
		[Token(Token = "0x6011515")]
		[Address(RVA = "0xF03CC8", Offset = "0xF03CC8", VA = "0xF03CC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012C8")]
	protected Dictionary<ulong, ExtraPlayerDataForMatchResult> PlayerMatchResultDataMap
	{
		[Token(Token = "0x6011516")]
		[Address(RVA = "0xF03DA0", Offset = "0xF03DA0", VA = "0xF03DA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6011514")]
	[Address(RVA = "0xF03C24", Offset = "0xF03C24", VA = "0xF03C24")]
	public UIProfileBRMatchResultController()
	{
	}

	[Token(Token = "0x6011517")]
	[Address(RVA = "0xF03E78", Offset = "0xF03E78", VA = "0xF03E78", Slot = "50")]
	protected virtual int[] GetInfoTypes(int type)
	{
		return null;
	}

	[Token(Token = "0x6011518")]
	[Address(RVA = "0xF03F74", Offset = "0xF03F74", VA = "0xF03F74", Slot = "47")]
	protected override int[] GetInfoTypesData()
	{
		return null;
	}

	[Token(Token = "0x6011519")]
	[Address(RVA = "0xF04044", Offset = "0xF04044", VA = "0xF04044")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601151A")]
	[Address(RVA = "0xF040E8", Offset = "0xF040E8", VA = "0xF040E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601151B")]
	[Address(RVA = "0xF04744", Offset = "0xF04744", VA = "0xF04744")]
	private void InitTypeList(MatchStats stats)
	{
	}

	[Token(Token = "0x601151C")]
	[Address(RVA = "0xF04AE0", Offset = "0xF04AE0", VA = "0xF04AE0", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x601151D")]
	[Address(RVA = "0xF04E50", Offset = "0xF04E50", VA = "0xF04E50")]
	private void OnClickDataBtn()
	{
	}

	[Token(Token = "0x601151E")]
	[Address(RVA = "0xF04EE0", Offset = "0xF04EE0", VA = "0xF04EE0")]
	private void OnClickReportBtn()
	{
	}

	[Token(Token = "0x601151F")]
	[Address(RVA = "0xF05204", Offset = "0xF05204", VA = "0xF05204", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x6011520")]
	[Address(RVA = "0xF05624", Offset = "0xF05624", VA = "0xF05624")]
	private void OnShareBtnClick()
	{
	}

	[Token(Token = "0x6011521")]
	[Address(RVA = "0xF0598C", Offset = "0xF0598C", VA = "0xF0598C")]
	private void OnNextBtnClick()
	{
	}

	[Token(Token = "0x6011522")]
	[Address(RVA = "0xF059F0", Offset = "0xF059F0", VA = "0xF059F0")]
	private void OnFastGiftClick()
	{
	}

	[Token(Token = "0x6011523")]
	[Address(RVA = "0xF055A0", Offset = "0xF055A0", VA = "0xF055A0")]
	private bool GetDataBtnVisibility()
	{
		return default(bool);
	}

	[Token(Token = "0x6011524")]
	[Address(RVA = "0xF05D00", Offset = "0xF05D00", VA = "0xF05D00")]
	public void ShowMatchResultUIData(MatchStats stats, ulong matchID)
	{
	}

	[Token(Token = "0x6011525")]
	[Address(RVA = "0xF07934", Offset = "0xF07934", VA = "0xF07934")]
	private void ShowBiaoqianWindow(MatchStats stats)
	{
	}

	[Token(Token = "0x6011526")]
	[Address(RVA = "0xF072A0", Offset = "0xF072A0", VA = "0xF072A0")]
	private void SetResultDescTextByRank(uint rank)
	{
	}

	[Token(Token = "0x6011527")]
	[Address(RVA = "0xF07658", Offset = "0xF07658", VA = "0xF07658")]
	private void CheckNeedShowRewardAndReportBtn(MatchStats stats)
	{
	}

	[Token(Token = "0x6011528")]
	[Address(RVA = "0xF07ED4", Offset = "0xF07ED4", VA = "0xF07ED4", Slot = "48")]
	protected override void OnChangePageType()
	{
	}

	[Token(Token = "0x6011529")]
	[Address(RVA = "0xF0641C", Offset = "0xF0641C", VA = "0xF0641C")]
	protected void UpdateDataBtnStatus()
	{
	}

	[Token(Token = "0x601152A")]
	[Address(RVA = "0xF08158", Offset = "0xF08158", VA = "0xF08158", Slot = "49")]
	protected override void UpdateInfoTitles()
	{
	}

	[Token(Token = "0x601152B")]
	[Address(RVA = "0xF06680", Offset = "0xF06680", VA = "0xF06680")]
	protected void OnSetMatchResultInfo(MatchStats stats)
	{
	}

	[Token(Token = "0x601152C")]
	[Address(RVA = "0xF0918C", Offset = "0xF0918C", VA = "0xF0918C")]
	private Transform GetItemTransform(int index)
	{
		return null;
	}

	[Token(Token = "0x601152D")]
	[Address(RVA = "0xF08D3C", Offset = "0xF08D3C", VA = "0xF08D3C")]
	private void UpdatePlayerListInfo(List<TeammateStats> players)
	{
	}

	[Token(Token = "0x601152E")]
	[Address(RVA = "0xF05784", Offset = "0xF05784", VA = "0xF05784")]
	private void SendShareBtnClickLog()
	{
	}

	[Token(Token = "0x601152F")]
	[Address(RVA = "0xF08AC0", Offset = "0xF08AC0", VA = "0xF08AC0")]
	private TeammateStats ConstructSelfTeammateData(MatchStats stats)
	{
		return null;
	}

	[Token(Token = "0x6011530")]
	[Address(RVA = "0xF09288", Offset = "0xF09288", VA = "0xF09288")]
	private ExtraPlayerDataForMatchResult GetPlayerMatchResultData(ulong accountID)
	{
		return null;
	}

	[Token(Token = "0x6011531")]
	[Address(RVA = "0xF0939C", Offset = "0xF0939C", VA = "0xF0939C")]
	private void CreatePlayerMatchResultData(ulong accountID, ulong localPlayerID, bool isFriend = false)
	{
	}

	[Token(Token = "0x6011532")]
	[Address(RVA = "0xF05FCC", Offset = "0xF05FCC", VA = "0xF05FCC")]
	private void ConstructPlayerMatchResultInfo(MatchStats stats)
	{
	}

	[Token(Token = "0x6011533")]
	[Address(RVA = "0xF096A0", Offset = "0xF096A0", VA = "0xF096A0")]
	private void OnReportCheatSent(object[] param)
	{
	}

	[Token(Token = "0x6011534")]
	[Address(RVA = "0xF099A8", Offset = "0xF099A8", VA = "0xF099A8")]
	private static FriendInfo _003COnFastGiftClick_003Em__0(TeammateStats teamMate)
	{
		return null;
	}

	[Token(Token = "0x6011535")]
	[Address(RVA = "0xF099B0", Offset = "0xF099B0", VA = "0xF099B0")]
	public int[] _003C_003EiFixBaseProxy_GetInfoTypesData()
	{
		return null;
	}

	[Token(Token = "0x6011536")]
	[Address(RVA = "0xF09A84", Offset = "0xF09A84", VA = "0xF09A84")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011537")]
	[Address(RVA = "0xF09A88", Offset = "0xF09A88", VA = "0xF09A88")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x6011538")]
	[Address(RVA = "0xF09A90", Offset = "0xF09A90", VA = "0xF09A90")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	[Token(Token = "0x6011539")]
	[Address(RVA = "0xF09A98", Offset = "0xF09A98", VA = "0xF09A98")]
	public void _003C_003EiFixBaseProxy_OnChangePageType()
	{
	}

	[Token(Token = "0x601153A")]
	[Address(RVA = "0xF09AF0", Offset = "0xF09AF0", VA = "0xF09AF0")]
	public void _003C_003EiFixBaseProxy_UpdateInfoTitles()
	{
	}
}
