using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x20020ED")]
internal class UIHudTakeTurnsShopController : UIHudCSShopController
{
	[Token(Token = "0x20020EE")]
	private sealed class _003COnOthersChoosingMaskClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CDF0")]
		[FieldOffset(Offset = "0x8")]
		internal TweenScale ts;

		[Token(Token = "0x600AAA3")]
		[Address(RVA = "0x1FFEDEC", Offset = "0x1FFEDEC", VA = "0x1FFEDEC")]
		public _003COnOthersChoosingMaskClick_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600AAA4")]
		[Address(RVA = "0x1FFEE1C", Offset = "0x1FFEE1C", VA = "0x1FFEE1C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400CDE6")]
	[FieldOffset(Offset = "0x5C")]
	private NLGKDGCHAIB m_RoundState;

	[Token(Token = "0x400CDE7")]
	[FieldOffset(Offset = "0x60")]
	private List<UIHudTakeTurnsShopRoundItemController> m_RoundItemCtrls;

	[Token(Token = "0x400CDE8")]
	[FieldOffset(Offset = "0x64")]
	private List<int> m_RoundTypes;

	[Token(Token = "0x400CDE9")]
	[FieldOffset(Offset = "0x68")]
	private List<int> m_RoundStates;

	[Token(Token = "0x400CDEA")]
	[FieldOffset(Offset = "0x6C")]
	private HashSet<int> m_RoundScrollPlayed;

	[Token(Token = "0x400CDEB")]
	[FieldOffset(Offset = "0x70")]
	private bool m_NeedPlayRoundScroll;

	[Token(Token = "0x400CDEC")]
	[FieldOffset(Offset = "0x74")]
	private float m_RoundScrollStartX;

	[Token(Token = "0x400CDED")]
	[FieldOffset(Offset = "0x78")]
	private float m_RoundScrollTarX;

	[Token(Token = "0x400CDEE")]
	private const float RoundScrollDuration = 1f;

	[Token(Token = "0x400CDEF")]
	[FieldOffset(Offset = "0x7C")]
	private uint m_OthersChoosingMaskDelayCall;

	[Token(Token = "0x600AA94")]
	[Address(RVA = "0x1FFC860", Offset = "0x1FFC860", VA = "0x1FFC860")]
	public UIHudTakeTurnsShopController()
	{
	}

	[Token(Token = "0x600AA95")]
	[Address(RVA = "0x1FFC954", Offset = "0x1FFC954", VA = "0x1FFC954")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AA96")]
	[Address(RVA = "0x1FFC9FC", Offset = "0x1FFC9FC", VA = "0x1FFC9FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AA97")]
	[Address(RVA = "0x1FFCAE8", Offset = "0x1FFCAE8", VA = "0x1FFCAE8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600AA98")]
	[Address(RVA = "0x1FFCBF8", Offset = "0x1FFCBF8", VA = "0x1FFCBF8", Slot = "40")]
	protected override void SetUIData()
	{
	}

	[Token(Token = "0x600AA99")]
	[Address(RVA = "0x1FFCE74", Offset = "0x1FFCE74", VA = "0x1FFCE74", Slot = "42")]
	protected override UIHudCSEquipCategoryController CreateCategory(Transform container)
	{
		return null;
	}

	[Token(Token = "0x600AA9A")]
	[Address(RVA = "0x1FFCF6C", Offset = "0x1FFCF6C", VA = "0x1FFCF6C")]
	public void SetTakeTurnsShopView(NLGKDGCHAIB state, int curRound, int maxRound)
	{
	}

	[Token(Token = "0x600AA9B")]
	[Address(RVA = "0x1FFE6B8", Offset = "0x1FFE6B8", VA = "0x1FFE6B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600AA9C")]
	[Address(RVA = "0x1FFE910", Offset = "0x1FFE910", VA = "0x1FFE910", Slot = "43")]
	protected override bool CheckCanPurchase()
	{
		return default(bool);
	}

	[Token(Token = "0x600AA9D")]
	[Address(RVA = "0x1FFEAC4", Offset = "0x1FFEAC4", VA = "0x1FFEAC4")]
	private void OnOthersChoosingMaskClick(object[] data)
	{
	}

	[Token(Token = "0x600AA9E")]
	[Address(RVA = "0x1FFEDF4", Offset = "0x1FFEDF4", VA = "0x1FFEDF4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AA9F")]
	[Address(RVA = "0x1FFEDFC", Offset = "0x1FFEDFC", VA = "0x1FFEDFC")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600AAA0")]
	[Address(RVA = "0x1FFEE04", Offset = "0x1FFEE04", VA = "0x1FFEE04")]
	public void _003C_003EiFixBaseProxy_SetUIData()
	{
	}

	[Token(Token = "0x600AAA1")]
	[Address(RVA = "0x1FFEE0C", Offset = "0x1FFEE0C", VA = "0x1FFEE0C")]
	public UIHudCSEquipCategoryController _003C_003EiFixBaseProxy_CreateCategory(Transform P0)
	{
		return null;
	}

	[Token(Token = "0x600AAA2")]
	[Address(RVA = "0x1FFEE14", Offset = "0x1FFEE14", VA = "0x1FFEE14")]
	public bool _003C_003EiFixBaseProxy_CheckCanPurchase()
	{
		return default(bool);
	}
}
