using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002255")]
internal class UIHudUGCInfectionMatchResultController : UIHudSingleFightMatchResultController
{
	[Token(Token = "0x2002256")]
	private sealed class _003CSetMatch_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D6F0")]
		[FieldOffset(Offset = "0x8")]
		internal UGCMatchStats matchStats;

		[Token(Token = "0x600BB62")]
		[Address(RVA = "0x1A5F200", Offset = "0x1A5F200", VA = "0x1A5F200")]
		public _003CSetMatch_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600BB63")]
		[Address(RVA = "0x1A5F208", Offset = "0x1A5F208", VA = "0x1A5F208")]
		internal bool _003C_003Em__0(UGCPlayerStats x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400D6EC")]
	[FieldOffset(Offset = "0x198")]
	private uint m_DelayID;

	[Token(Token = "0x400D6ED")]
	[FieldOffset(Offset = "0x19C")]
	private UIHudUGCInfectionMatchResultItemController m_SelfUIItem;

	[Token(Token = "0x400D6EE")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400D6EF")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600BB52")]
	[Address(RVA = "0x1597DE8", Offset = "0x1597DE8", VA = "0x1597DE8")]
	public UIHudUGCInfectionMatchResultController()
	{
	}

	[Token(Token = "0x600BB53")]
	[Address(RVA = "0x1597DF0", Offset = "0x1597DF0", VA = "0x1597DF0")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BB54")]
	[Address(RVA = "0x1597E98", Offset = "0x1597E98", VA = "0x1597E98", Slot = "56")]
	protected override bool IsNeedShowAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x600BB55")]
	[Address(RVA = "0x1597EF0", Offset = "0x1597EF0", VA = "0x1597EF0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600BB56")]
	[Address(RVA = "0x1598164", Offset = "0x1598164", VA = "0x1598164")]
	protected void OnScrollViewMoving()
	{
	}

	[Token(Token = "0x600BB57")]
	[Address(RVA = "0x15983F4", Offset = "0x15983F4", VA = "0x15983F4", Slot = "49")]
	protected override void OnShowDetailUI(bool show)
	{
	}

	[Token(Token = "0x600BB58")]
	[Address(RVA = "0x1598954", Offset = "0x1598954", VA = "0x1598954", Slot = "48")]
	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	[Token(Token = "0x600BB59")]
	[Address(RVA = "0x1598A70", Offset = "0x1598A70", VA = "0x1598A70")]
	private void SetMatch(UGCMatchStats matchStats)
	{
	}

	[Token(Token = "0x600BB5A")]
	[Address(RVA = "0x1599214", Offset = "0x1599214", VA = "0x1599214", Slot = "63")]
	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600BB5B")]
	[Address(RVA = "0x1599440", Offset = "0x1599440", VA = "0x1599440")]
	private static void _003COnShowDetailUI_003Em__0()
	{
	}

	[Token(Token = "0x600BB5C")]
	[Address(RVA = "0x159958C", Offset = "0x159958C", VA = "0x159958C")]
	private static void _003COnShowDetailUI_003Em__1()
	{
	}

	[Token(Token = "0x600BB5D")]
	[Address(RVA = "0x15996D8", Offset = "0x15996D8", VA = "0x15996D8")]
	public bool _003C_003EiFixBaseProxy_IsNeedShowAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x600BB5E")]
	[Address(RVA = "0x15996E0", Offset = "0x15996E0", VA = "0x15996E0")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600BB5F")]
	[Address(RVA = "0x15996E8", Offset = "0x15996E8", VA = "0x15996E8")]
	public new void _003C_003EiFixBaseProxy_OnShowDetailUI(bool P0)
	{
	}

	[Token(Token = "0x600BB60")]
	[Address(RVA = "0x15996F0", Offset = "0x15996F0", VA = "0x15996F0")]
	public new void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	[Token(Token = "0x600BB61")]
	[Address(RVA = "0x15996F8", Offset = "0x15996F8", VA = "0x15996F8")]
	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}
}
