using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022D8")]
public class RewardWndCfg
{
	[Token(Token = "0x400D9A1")]
	[FieldOffset(Offset = "0x8")]
	public Action m_CloseAction;

	[Token(Token = "0x400D9A2")]
	[FieldOffset(Offset = "0xC")]
	public Action m_OpenAction;

	[Token(Token = "0x400D9A3")]
	[FieldOffset(Offset = "0x10")]
	public bool m_EnableFastEquip;

	[Token(Token = "0x400D9A4")]
	[FieldOffset(Offset = "0x11")]
	public bool m_EnableShowAnim;

	[Token(Token = "0x400D9A5")]
	[FieldOffset(Offset = "0x12")]
	public bool m_EnabeMerge;

	[Token(Token = "0x400D9A6")]
	[FieldOffset(Offset = "0x14")]
	public string m_Title;

	[Token(Token = "0x400D9A7")]
	[FieldOffset(Offset = "0x18")]
	public string m_TransferHint;

	[Token(Token = "0x400D9A8")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_Instantly;

	[Token(Token = "0x400D9A9")]
	[FieldOffset(Offset = "0x1D")]
	public bool m_IsShowAll;

	[Token(Token = "0x400D9AA")]
	[FieldOffset(Offset = "0x1E")]
	public bool m_IsCrate;

	[Token(Token = "0x400D9AB")]
	[FieldOffset(Offset = "0x1F")]
	public bool m_IsBigPrice;

	[Token(Token = "0x400D9AC")]
	[FieldOffset(Offset = "0x20")]
	public bool m_IsLinkAvatar;

	[Token(Token = "0x400D9AD")]
	[FieldOffset(Offset = "0x21")]
	public bool m_EnableOptionalSelect;

	[Token(Token = "0x400D9AE")]
	[FieldOffset(Offset = "0x22")]
	public bool m_EnablOkBtn;

	[Token(Token = "0x400D9AF")]
	[FieldOffset(Offset = "0x23")]
	public bool m_UseSkipReward;

	[Token(Token = "0x400D9B0")]
	[FieldOffset(Offset = "0x24")]
	public UICommonRewardWndController.WndStyleEnum m_Style;

	[Token(Token = "0x400D9B1")]
	[FieldOffset(Offset = "0x28")]
	public bool m_ChildWndKeepStyle;

	[Token(Token = "0x400D9B2")]
	[FieldOffset(Offset = "0x2C")]
	public List<uint> m_FeatureConditonList;

	[Token(Token = "0x400D9B3")]
	[FieldOffset(Offset = "0x30")]
	public List<CommonRewardItemInfo> m_RewardInfoList;

	[Token(Token = "0x600C006")]
	[Address(RVA = "0x240A528", Offset = "0x240A528", VA = "0x240A528")]
	public RewardWndCfg()
	{
	}
}
