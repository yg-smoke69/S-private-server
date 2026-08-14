using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002BEC")]
internal class UIVeteranRewardsController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002BED")]
	private sealed class _003CTopFX_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010C69")]
		[FieldOffset(Offset = "0x8")]
		internal int tmp;

		[Token(Token = "0x4010C6A")]
		[FieldOffset(Offset = "0xC")]
		internal UIVeteranRewardsController _0024this;

		[Token(Token = "0x601235A")]
		[Address(RVA = "0x2CBE30C", Offset = "0x2CBE30C", VA = "0x2CBE30C")]
		public _003CTopFX_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601235B")]
		[Address(RVA = "0x2CBEE0C", Offset = "0x2CBEE0C", VA = "0x2CBEE0C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002BEE")]
	private sealed class _003CBottomFX_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010C6B")]
		[FieldOffset(Offset = "0x8")]
		internal int tmp;

		[Token(Token = "0x4010C6C")]
		[FieldOffset(Offset = "0xC")]
		internal UIVeteranRewardsController _0024this;

		[Token(Token = "0x601235C")]
		[Address(RVA = "0x2CBE314", Offset = "0x2CBE314", VA = "0x2CBE314")]
		public _003CBottomFX_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601235D")]
		[Address(RVA = "0x2CBECA4", Offset = "0x2CBECA4", VA = "0x2CBECA4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002BEF")]
	private sealed class _003CBigDayFX_003Ec__AnonStorey2
	{
		[Token(Token = "0x4010C6D")]
		[FieldOffset(Offset = "0x8")]
		internal VeteranRewardItem item;

		[Token(Token = "0x4010C6E")]
		[FieldOffset(Offset = "0xC")]
		internal UIVeteranRewardsController _0024this;

		[Token(Token = "0x601235E")]
		[Address(RVA = "0x2CBE31C", Offset = "0x2CBE31C", VA = "0x2CBE31C")]
		public _003CBigDayFX_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601235F")]
		[Address(RVA = "0x2CBEAE0", Offset = "0x2CBEAE0", VA = "0x2CBEAE0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4010C61")]
	[FieldOffset(Offset = "0x48")]
	private UIVeteranRewardsView m_View;

	[Token(Token = "0x4010C62")]
	[FieldOffset(Offset = "0x4C")]
	private int m_RewardListCount;

	[Token(Token = "0x4010C63")]
	[FieldOffset(Offset = "0x50")]
	private List<UIVeteranRewardsItemController> m_ItemControllerList;

	[Token(Token = "0x4010C64")]
	[FieldOffset(Offset = "0x54")]
	private UIVeteranRewardsItemController m_LastItemController;

	[Token(Token = "0x4010C65")]
	[FieldOffset(Offset = "0x58")]
	private uint m_TopDelaycall;

	[Token(Token = "0x4010C66")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_BottomDelaycall;

	[Token(Token = "0x4010C67")]
	[FieldOffset(Offset = "0x60")]
	private uint m_BigDayDelaycall;

	[Token(Token = "0x4010C68")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6012348")]
	[Address(RVA = "0x2CBC7BC", Offset = "0x2CBC7BC", VA = "0x2CBC7BC")]
	public UIVeteranRewardsController()
	{
	}

	[Token(Token = "0x6012349")]
	[Address(RVA = "0x2CBC848", Offset = "0x2CBC848", VA = "0x2CBC848")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601234A")]
	[Address(RVA = "0x2CBC8EC", Offset = "0x2CBC8EC", VA = "0x2CBC8EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601234B")]
	[Address(RVA = "0x2CBCC8C", Offset = "0x2CBCC8C", VA = "0x2CBCC8C")]
	private void PlayAnimation()
	{
	}

	[Token(Token = "0x601234C")]
	[Address(RVA = "0x2CBCD64", Offset = "0x2CBCD64", VA = "0x2CBCD64", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601234D")]
	[Address(RVA = "0x2CBCE1C", Offset = "0x2CBCE1C", VA = "0x2CBCE1C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601234E")]
	[Address(RVA = "0x2CBD1F8", Offset = "0x2CBD1F8", VA = "0x2CBD1F8")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x601234F")]
	[Address(RVA = "0x2CBDBC4", Offset = "0x2CBDBC4", VA = "0x2CBDBC4")]
	private void TopFX()
	{
	}

	[Token(Token = "0x6012350")]
	[Address(RVA = "0x2CBDE88", Offset = "0x2CBDE88", VA = "0x2CBDE88")]
	private void BottomFX()
	{
	}

	[Token(Token = "0x6012351")]
	[Address(RVA = "0x2CBE168", Offset = "0x2CBE168", VA = "0x2CBE168")]
	private void BigDayFX(VeteranRewardItem item)
	{
	}

	[Token(Token = "0x6012352")]
	[Address(RVA = "0x2CBD6B0", Offset = "0x2CBD6B0", VA = "0x2CBD6B0")]
	private void ResetState()
	{
	}

	[Token(Token = "0x6012353")]
	[Address(RVA = "0x2CBE324", Offset = "0x2CBE324", VA = "0x2CBE324", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6012354")]
	[Address(RVA = "0x2CBE49C", Offset = "0x2CBE49C", VA = "0x2CBE49C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012355")]
	[Address(RVA = "0x2CBE7C0", Offset = "0x2CBE7C0", VA = "0x2CBE7C0")]
	private void OnClose()
	{
	}

	[Token(Token = "0x6012356")]
	[Address(RVA = "0x2CBEAC0", Offset = "0x2CBEAC0", VA = "0x2CBEAC0")]
	private static CommonRewardItemInfo _003COnDataChanged_003Em__0(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6012357")]
	[Address(RVA = "0x2CBEAC8", Offset = "0x2CBEAC8", VA = "0x2CBEAC8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012358")]
	[Address(RVA = "0x2CBEAD0", Offset = "0x2CBEAD0", VA = "0x2CBEAD0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6012359")]
	[Address(RVA = "0x2CBEAD8", Offset = "0x2CBEAD8", VA = "0x2CBEAD8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
