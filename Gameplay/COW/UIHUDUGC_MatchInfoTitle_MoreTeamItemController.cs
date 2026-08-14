using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002454")]
internal class UIHUDUGC_MatchInfoTitle_MoreTeamItemController : UIBaseController
{
	[Token(Token = "0x400E1A6")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_MatchInfoTitle_MoreTeamItemView m_View;

	[Token(Token = "0x400E1A7")]
	[FieldOffset(Offset = "0x2C")]
	private UIHUDUGC_MatchInfoTitleController.MatchInfoTitleData m_ViewData;

	[Token(Token = "0x400E1A8")]
	[FieldOffset(Offset = "0x30")]
	private uint m_TeamIndex;

	[Token(Token = "0x400E1A9")]
	[FieldOffset(Offset = "0x34")]
	private Color m_DefaultColor;

	[Token(Token = "0x17001118")]
	public uint TeamIndex
	{
		[Token(Token = "0x600CE65")]
		[Address(RVA = "0x2E1303C", Offset = "0x2E1303C", VA = "0x2E1303C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x600CE64")]
	[Address(RVA = "0x2E13DFC", Offset = "0x2E13DFC", VA = "0x2E13DFC")]
	public UIHUDUGC_MatchInfoTitle_MoreTeamItemController()
	{
	}

	[Token(Token = "0x600CE66")]
	[Address(RVA = "0x2E13ED4", Offset = "0x2E13ED4", VA = "0x2E13ED4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CE67")]
	[Address(RVA = "0x2E13F78", Offset = "0x2E13F78", VA = "0x2E13F78", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CE68")]
	[Address(RVA = "0x2E13094", Offset = "0x2E13094", VA = "0x2E13094")]
	public void SetViewData(UIHUDUGC_MatchInfoTitleController.MatchInfoTitleData viewData)
	{
	}

	[Token(Token = "0x600CE69")]
	[Address(RVA = "0x2E1286C", Offset = "0x2E1286C", VA = "0x2E1286C")]
	public void SetData(int rank, MatchTeam team, bool isSelf)
	{
	}

	[Token(Token = "0x600CE6A")]
	[Address(RVA = "0x2E12C80", Offset = "0x2E12C80", VA = "0x2E12C80")]
	public void SetFinishTeammateNum(int num)
	{
	}

	[Token(Token = "0x600CE6B")]
	[Address(RVA = "0x2E12DCC", Offset = "0x2E12DCC", VA = "0x2E12DCC")]
	public void SetTeamTargetScore(int num, int max)
	{
	}

	[Token(Token = "0x600CE6C")]
	[Address(RVA = "0x2E14034", Offset = "0x2E14034", VA = "0x2E14034")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
