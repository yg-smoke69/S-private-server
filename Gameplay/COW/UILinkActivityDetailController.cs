using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200217F")]
public abstract class UILinkActivityDetailController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002180")]
	private sealed class _003CInitCdnTexture_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D22B")]
		[FieldOffset(Offset = "0x8")]
		internal Action<Texture> callback;

		[Token(Token = "0x400D22C")]
		[FieldOffset(Offset = "0xC")]
		internal UINetworkTexture tex;

		[Token(Token = "0x600B1B3")]
		[Address(RVA = "0x25515B8", Offset = "0x25515B8", VA = "0x25515B8")]
		public _003CInitCdnTexture_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B1B4")]
		[Address(RVA = "0x2552840", Offset = "0x2552840", VA = "0x2552840")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002181")]
	private sealed class _003CInitClaimBtn_003Ec__AnonStorey1
	{
		[Token(Token = "0x400D22D")]
		[FieldOffset(Offset = "0x8")]
		internal Transform parent;

		[Token(Token = "0x400D22E")]
		[FieldOffset(Offset = "0xC")]
		internal UILinkActivityDetailController _0024this;

		[Token(Token = "0x600B1B5")]
		[Address(RVA = "0x25520F4", Offset = "0x25520F4", VA = "0x25520F4")]
		public _003CInitClaimBtn_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600B1B6")]
		[Address(RVA = "0x25528F0", Offset = "0x25528F0", VA = "0x25528F0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400D226")]
	[FieldOffset(Offset = "0x28")]
	protected UIModelLinkActivity m_Model;

	[Token(Token = "0x400D227")]
	[FieldOffset(Offset = "0x2C")]
	protected LinkActivityData m_ActivityData;

	[Token(Token = "0x400D228")]
	[FieldOffset(Offset = "0x30")]
	protected float RewardedIconColorVal;

	[Token(Token = "0x400D229")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400D22A")]
	[FieldOffset(Offset = "0x4")]
	private static Callback _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600B195")]
	[Address(RVA = "0x25505CC", Offset = "0x25505CC", VA = "0x25505CC")]
	protected UILinkActivityDetailController()
	{
	}

	[Token(Token = "0x600B196")]
	[Address(RVA = "0x255065C", Offset = "0x255065C", VA = "0x255065C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B197")]
	[Address(RVA = "0x25507B4", Offset = "0x25507B4", VA = "0x25507B4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600B198")]
	[Address(RVA = "0x25508E4", Offset = "0x25508E4", VA = "0x25508E4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B199")]
	[Address(RVA = "0x255096C", Offset = "0x255096C", VA = "0x255096C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B19A")]
	[Address(RVA = "0x25509D0", Offset = "0x25509D0", VA = "0x25509D0", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B19B")]
	protected abstract void InitActivityInfo();

	[Token(Token = "0x600B19C")]
	[Address(RVA = "0x2550B68", Offset = "0x2550B68", VA = "0x2550B68")]
	protected void InitDaysLabel(UILabel days)
	{
	}

	[Token(Token = "0x600B19D")]
	[Address(RVA = "0x2550D08", Offset = "0x2550D08", VA = "0x2550D08")]
	protected void InitDaysLabel(UILabel curDay, UILabel totalDay)
	{
	}

	[Token(Token = "0x600B19E")]
	[Address(RVA = "0x2550EC4", Offset = "0x2550EC4", VA = "0x2550EC4")]
	protected void InitFinishCountLabel(UILabel label)
	{
	}

	[Token(Token = "0x600B19F")]
	[Address(RVA = "0x25510C4", Offset = "0x25510C4", VA = "0x25510C4")]
	public void InitFinishCountLabel(UILabel current, UILabel total)
	{
	}

	[Token(Token = "0x600B1A0")]
	[Address(RVA = "0x2551274", Offset = "0x2551274", VA = "0x2551274")]
	protected void InitFinishCountProgress(UIProgressBar bar)
	{
	}

	[Token(Token = "0x600B1A1")]
	[Address(RVA = "0x25513FC", Offset = "0x25513FC", VA = "0x25513FC")]
	protected void InitCdnTexture(UINetworkTexture tex, Action<Texture> callback)
	{
	}

	[Token(Token = "0x600B1A2")]
	protected void InitDailyRewards<T>(UIGrid grid, ref List<T> ctrls, int maxCount = 4) where T : UIBaseController, ISetBaseItemInfo
	{
	}

	[Token(Token = "0x600B1A3")]
	[Address(RVA = "0x25515C0", Offset = "0x25515C0", VA = "0x25515C0")]
	protected void InitBigRewardIcon(UISprite icon)
	{
	}

	[Token(Token = "0x600B1A4")]
	[Address(RVA = "0x25516EC", Offset = "0x25516EC", VA = "0x25516EC")]
	protected bool SetIconByItemId(UISprite icon, uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x600B1A5")]
	[Address(RVA = "0x2551A2C", Offset = "0x2551A2C", VA = "0x2551A2C", Slot = "34")]
	protected virtual void OnGotReward(AwardData award)
	{
	}

	[Token(Token = "0x600B1A6")]
	[Address(RVA = "0x2551D24", Offset = "0x2551D24", VA = "0x2551D24")]
	protected void InitCloseBtn(UIButton btn)
	{
	}

	[Token(Token = "0x600B1A7")]
	[Address(RVA = "0x254F108", Offset = "0x254F108", VA = "0x254F108", Slot = "35")]
	protected virtual void InitGotoBtn(UIButton btn)
	{
	}

	[Token(Token = "0x600B1A8")]
	[Address(RVA = "0x2551E48", Offset = "0x2551E48", VA = "0x2551E48")]
	protected void InitLinkBtn(UIButton btn)
	{
	}

	[Token(Token = "0x600B1A9")]
	[Address(RVA = "0x2551F6C", Offset = "0x2551F6C", VA = "0x2551F6C")]
	protected void InitClaimBtn(UIButton btn, Transform parent)
	{
	}

	[Token(Token = "0x600B1AA")]
	[Address(RVA = "0x25520FC", Offset = "0x25520FC", VA = "0x25520FC")]
	protected void ShowTooltip(Transform tr, uint itemId)
	{
	}

	[Token(Token = "0x600B1AB")]
	[Address(RVA = "0x255222C", Offset = "0x255222C", VA = "0x255222C")]
	protected void ShowTooltip(Transform tr, string nameKey, string descKey)
	{
	}

	[Token(Token = "0x600B1AC")]
	[Address(RVA = "0x2552460", Offset = "0x2552460", VA = "0x2552460")]
	protected void InitEndTime(UICountDownLabel timeLabel)
	{
	}

	[Token(Token = "0x600B1AD")]
	[Address(RVA = "0x25525DC", Offset = "0x25525DC", VA = "0x25525DC")]
	private static CommonRewardItemInfo _003COnGotReward_003Em__0(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x600B1AE")]
	[Address(RVA = "0x25525E4", Offset = "0x25525E4", VA = "0x25525E4")]
	private static void _003CInitGotoBtn_003Em__1()
	{
	}

	[Token(Token = "0x600B1AF")]
	[Address(RVA = "0x2552730", Offset = "0x2552730", VA = "0x2552730")]
	private void _003CInitLinkBtn_003Em__2()
	{
	}

	[Token(Token = "0x600B1B0")]
	[Address(RVA = "0x2552828", Offset = "0x2552828", VA = "0x2552828")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B1B1")]
	[Address(RVA = "0x2552830", Offset = "0x2552830", VA = "0x2552830")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600B1B2")]
	[Address(RVA = "0x2552838", Offset = "0x2552838", VA = "0x2552838")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
