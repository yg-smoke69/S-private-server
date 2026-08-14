using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002172")]
internal class UILadderMatchSeasonInfoMissionItemController : UIBaseController
{
	[Token(Token = "0x400D1E5")]
	[FieldOffset(Offset = "0x28")]
	private UILadderMatchSeasonInfoMissionItemView m_View;

	[Token(Token = "0x400D1E6")]
	[FieldOffset(Offset = "0x2C")]
	public int MissionIndex;

	[Token(Token = "0x400D1E7")]
	[FieldOffset(Offset = "0x30")]
	private UIStandardItemMiniController m_ItemMiniCtrl;

	[Token(Token = "0x400D1E8")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400D1E9")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<uint, object> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600B109")]
	[Address(RVA = "0x22C81E4", Offset = "0x22C81E4", VA = "0x22C81E4")]
	public UILadderMatchSeasonInfoMissionItemController()
	{
	}

	[Token(Token = "0x600B10A")]
	[Address(RVA = "0x22C8268", Offset = "0x22C8268", VA = "0x22C8268")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B10B")]
	[Address(RVA = "0x22C8310", Offset = "0x22C8310", VA = "0x22C8310", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B10C")]
	[Address(RVA = "0x22C83CC", Offset = "0x22C83CC", VA = "0x22C83CC")]
	public void SetRewardData(RankingTaskInfo taskInfo)
	{
	}

	[Token(Token = "0x600B10D")]
	[Address(RVA = "0x22C8C74", Offset = "0x22C8C74", VA = "0x22C8C74")]
	private static bool _003CSetRewardData_003Em__0(uint i)
	{
		return default(bool);
	}

	[Token(Token = "0x600B10E")]
	[Address(RVA = "0x22C8C88", Offset = "0x22C8C88", VA = "0x22C8C88")]
	private static object _003CSetRewardData_003Em__1(uint s)
	{
		return null;
	}

	[Token(Token = "0x600B10F")]
	[Address(RVA = "0x22C8CF8", Offset = "0x22C8CF8", VA = "0x22C8CF8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
