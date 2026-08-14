using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x20000FF")]
public class CreditPunishManager : SingletonModule<CreditPunishManager>
{
	[Token(Token = "0x2000100")]
	private sealed class _003CShowBanCupAndChampionshipWindow_003Ec__AnonStorey0
	{
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x8")]
		internal UINavigationUtil.UINavigationFrom navigationFrom;

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1C83E38", Offset = "0x1C83E38", VA = "0x1C83E38")]
		public _003CShowBanCupAndChampionshipWindow_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1C85EDC", Offset = "0x1C85EDC", VA = "0x1C85EDC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4000663")]
	[FieldOffset(Offset = "0xC")]
	private List<ForbidMode> m_ListForbidMode;

	[Token(Token = "0x4000664")]
	[FieldOffset(Offset = "0x10")]
	private List<CreditPunishDesc> m_CreditPunishDesc;

	[Token(Token = "0x4000665")]
	[FieldOffset(Offset = "0x14")]
	private uint m_CurCreditScore;

	[Token(Token = "0x4000666")]
	[FieldOffset(Offset = "0x18")]
	private uint m_PunishScoreBase;

	[Token(Token = "0x4000667")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_IsBanRoom;

	[Token(Token = "0x4000668")]
	[FieldOffset(Offset = "0x1D")]
	private bool m_IsBanCupMatch;

	[Token(Token = "0x4000669")]
	[FieldOffset(Offset = "0x1E")]
	private bool m_IsBanChampionship;

	[Token(Token = "0x400066A")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<CreditPunishDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400066B")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<CreditPunishDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400066C")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<tcp.CreditPunishInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x6000663")]
	[Address(RVA = "0x1C81FD8", Offset = "0x1C81FD8", VA = "0x1C81FD8")]
	public CreditPunishManager()
	{
	}

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x1C820D0", Offset = "0x1C820D0", VA = "0x1C820D0", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x1C821BC", Offset = "0x1C821BC", VA = "0x1C821BC", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x1C82210", Offset = "0x1C82210", VA = "0x1C82210")]
	public void LoginInit()
	{
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x1C82280", Offset = "0x1C82280", VA = "0x1C82280")]
	private void InitCreditPunishDesc()
	{
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0x1C82464", Offset = "0x1C82464", VA = "0x1C82464")]
	private void InitCurCreditScore()
	{
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0x1C82590", Offset = "0x1C82590", VA = "0x1C82590")]
	private void InitCurCreditScorePunish()
	{
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x1C82608", Offset = "0x1C82608", VA = "0x1C82608")]
	private bool UpdateCurPunishMent(uint creditScore, int credit_score_delta = 0, bool is_init = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0x1C82A84", Offset = "0x1C82A84", VA = "0x1C82A84")]
	public bool UpdateCurScoreAndPunishMent(uint creditScore, int credit_score_delta)
	{
		return default(bool);
	}

	[Token(Token = "0x600066C")]
	[Address(RVA = "0x1C82B84", Offset = "0x1C82B84", VA = "0x1C82B84")]
	private string GetGroupModeNameByGroupMode(uint groupMode)
	{
		return null;
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0x1C82E10", Offset = "0x1C82E10", VA = "0x1C82E10")]
	private void ShowPunishWindow(string gameModeName, [Optional] List<string> groupMemeberNames, uint punishBaseScore = 0u, string groupModeName = "")
	{
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0x1C833DC", Offset = "0x1C833DC", VA = "0x1C833DC")]
	public void ShowBanRoomWindow([Optional] List<string> groupMemeberNames)
	{
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x1C83A68", Offset = "0x1C83A68", VA = "0x1C83A68")]
	public void ShowBanCupAndChampionshipWindow(UINavigationUtil.UINavigationFrom navigationFrom, bool isSelf = true)
	{
	}

	[Token(Token = "0x6000670")]
	[Address(RVA = "0x1C83E40", Offset = "0x1C83E40", VA = "0x1C83E40")]
	public void CheckForbidGamePunishChanged(out object[] param)
	{
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0x1C841F4", Offset = "0x1C841F4", VA = "0x1C841F4")]
	public bool IsMemeberCreditForbidGamePunish(List<tcp.CreditPunishInfo> punishInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0x1C84464", Offset = "0x1C84464", VA = "0x1C84464")]
	private bool IsSelectedModeCreditForbidGamePunish(ForbidMode selectMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0x1C846EC", Offset = "0x1C846EC", VA = "0x1C846EC")]
	public bool CheckSelectedModeCreditForbidGamePunish(List<MapModeData> selectMapModes, uint groupMode = 0u)
	{
		return default(bool);
	}

	[Token(Token = "0x6000674")]
	[Address(RVA = "0x1C848D0", Offset = "0x1C848D0", VA = "0x1C848D0")]
	public bool CheckSelectedModeCreditForbidGamePunish(MapModeData selectMapMode, uint groupMode = 0u)
	{
		return default(bool);
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0x1C84ADC", Offset = "0x1C84ADC", VA = "0x1C84ADC")]
	public bool CheckCreditBanRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6000676")]
	[Address(RVA = "0x1C84C18", Offset = "0x1C84C18", VA = "0x1C84C18")]
	public bool CheckCreditBanCupMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0x1C84D54", Offset = "0x1C84D54", VA = "0x1C84D54")]
	public bool CheckCreditBanChampionship()
	{
		return default(bool);
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0x1C84E90", Offset = "0x1C84E90", VA = "0x1C84E90")]
	private bool CheckSelectedModeCreditForbidGamePunish(ForbidMode selectMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0x1C84FA0", Offset = "0x1C84FA0", VA = "0x1C84FA0")]
	public bool CheckSelectedModeCreditForbidGamePunish(GroupInfo groupInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0x1C854B0", Offset = "0x1C854B0", VA = "0x1C854B0")]
	public bool CheckSelectedModeGroupCreditForbidGamePunish(GroupInfo groupInfo, MapModeData selectMapMode)
	{
		return default(bool);
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0x1C85734", Offset = "0x1C85734", VA = "0x1C85734")]
	public bool CheckSelectedTeamModeCreditForbidGamePunish(MapModeData selectedMapData, HHDIPHFOBFO groupMode, GroupInfo groupInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0x1C8520C", Offset = "0x1C8520C", VA = "0x1C8520C")]
	private List<string> GetSelectedModeCreditPunishTeamMembers(GroupInfo groupInfo, ForbidMode selectMode, out uint punishBaseScore)
	{
		return null;
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0x1C859C0", Offset = "0x1C859C0", VA = "0x1C859C0")]
	private bool CheckSelectedModeTeamMemberCreditForbidGamePunish(List<tcp.CreditPunishInfo> creditPunishInfo, ForbidMode selectMode, out uint punish_score)
	{
		return default(bool);
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0x1C85DF4", Offset = "0x1C85DF4", VA = "0x1C85DF4")]
	private static int _003CInitCreditPunishDesc_003Em__0(CreditPunishDesc l, CreditPunishDesc r)
	{
		return default(int);
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0x1C85E3C", Offset = "0x1C85E3C", VA = "0x1C85E3C")]
	private static bool _003CShowBanRoomWindow_003Em__1(CreditPunishDesc value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x1C85E6C", Offset = "0x1C85E6C", VA = "0x1C85E6C")]
	private static int _003CCheckSelectedModeTeamMemberCreditForbidGamePunish_003Em__2(tcp.CreditPunishInfo l, tcp.CreditPunishInfo r)
	{
		return default(int);
	}
}
