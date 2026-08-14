using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200225B")]
internal class UIHudUGCOneTeamMatchResultController : UIHudSingleFightMatchResultController
{
	[Token(Token = "0x200225C")]
	private sealed class _003CSetMatch_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D701")]
		[FieldOffset(Offset = "0x8")]
		internal UGCMatchStats matchStats;

		[Token(Token = "0x600BBA7")]
		[Address(RVA = "0x1A667CC", Offset = "0x1A667CC", VA = "0x1A667CC")]
		public _003CSetMatch_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600BBA8")]
		[Address(RVA = "0x1A669F4", Offset = "0x1A669F4", VA = "0x1A669F4")]
		internal bool _003C_003Em__0(UGCPlayerStats x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400D700")]
	[FieldOffset(Offset = "0x198")]
	private ulong m_SelfAccountID;

	[Token(Token = "0x600BB99")]
	[Address(RVA = "0x1A65974", Offset = "0x1A65974", VA = "0x1A65974")]
	public UIHudUGCOneTeamMatchResultController()
	{
	}

	[Token(Token = "0x600BB9A")]
	[Address(RVA = "0x1A65988", Offset = "0x1A65988", VA = "0x1A65988")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BB9B")]
	[Address(RVA = "0x1A65A30", Offset = "0x1A65A30", VA = "0x1A65A30", Slot = "56")]
	protected override bool IsNeedShowAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x600BB9C")]
	[Address(RVA = "0x1A65A88", Offset = "0x1A65A88", VA = "0x1A65A88", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600BB9D")]
	[Address(RVA = "0x1A65CFC", Offset = "0x1A65CFC", VA = "0x1A65CFC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600BB9E")]
	[Address(RVA = "0x1A65EB4", Offset = "0x1A65EB4", VA = "0x1A65EB4")]
	protected void OnScrollViewMoved()
	{
	}

	[Token(Token = "0x600BB9F")]
	[Address(RVA = "0x1A6611C", Offset = "0x1A6611C", VA = "0x1A6611C", Slot = "48")]
	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	[Token(Token = "0x600BBA0")]
	[Address(RVA = "0x1A66238", Offset = "0x1A66238", VA = "0x1A66238")]
	private void SetMatch(UGCMatchStats matchStats)
	{
	}

	[Token(Token = "0x600BBA1")]
	[Address(RVA = "0x1A667D4", Offset = "0x1A667D4", VA = "0x1A667D4", Slot = "63")]
	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600BBA2")]
	[Address(RVA = "0x1A669CC", Offset = "0x1A669CC", VA = "0x1A669CC")]
	public bool _003C_003EiFixBaseProxy_IsNeedShowAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x600BBA3")]
	[Address(RVA = "0x1A669D4", Offset = "0x1A669D4", VA = "0x1A669D4")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600BBA4")]
	[Address(RVA = "0x1A669DC", Offset = "0x1A669DC", VA = "0x1A669DC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600BBA5")]
	[Address(RVA = "0x1A669E4", Offset = "0x1A669E4", VA = "0x1A669E4")]
	public new void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	[Token(Token = "0x600BBA6")]
	[Address(RVA = "0x1A669EC", Offset = "0x1A669EC", VA = "0x1A669EC")]
	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}
}
