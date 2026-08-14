using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022E3")]
public class RewardPopupData
{
	[Token(Token = "0x400D9CF")]
	[FieldOffset(Offset = "0x8")]
	public List<BaseItemInfo> RewardList;

	[Token(Token = "0x400D9D0")]
	[FieldOffset(Offset = "0xC")]
	public string Title;

	[Token(Token = "0x400D9D1")]
	[FieldOffset(Offset = "0x10")]
	public RewardBtn BtnData;

	[Token(Token = "0x400D9D2")]
	[FieldOffset(Offset = "0x14")]
	public string TransferHint;

	[Token(Token = "0x400D9D3")]
	[FieldOffset(Offset = "0x18")]
	public bool NeedMerge;

	[Token(Token = "0x600C020")]
	[Address(RVA = "0x2409B3C", Offset = "0x2409B3C", VA = "0x2409B3C")]
	public RewardPopupData(List<BaseItemInfo> reward_list)
	{
	}

	[Token(Token = "0x600C021")]
	[Address(RVA = "0x2409B74", Offset = "0x2409B74", VA = "0x2409B74")]
	public RewardPopupData(List<BaseItemInfo> reward_list, bool isGift)
	{
	}

	[Token(Token = "0x600C022")]
	[Address(RVA = "0x2409BAC", Offset = "0x2409BAC", VA = "0x2409BAC")]
	public RewardPopupData(List<BaseItemInfo> reward_list, string title)
	{
	}

	[Token(Token = "0x600C023")]
	[Address(RVA = "0x2409BE8", Offset = "0x2409BE8", VA = "0x2409BE8")]
	public RewardPopupData(List<BaseItemInfo> reward_list, string title, RewardBtn btn_data)
	{
	}

	[Token(Token = "0x600C024")]
	[Address(RVA = "0x2409C28", Offset = "0x2409C28", VA = "0x2409C28")]
	public RewardPopupData(List<BaseItemInfo> reward_list, string title, RewardBtn btn_data, string transfer_hint)
	{
	}

	[Token(Token = "0x600C025")]
	[Address(RVA = "0x2409C68", Offset = "0x2409C68", VA = "0x2409C68")]
	public RewardPopupData(List<BaseItemInfo> reward_list, string title, RewardBtn btn_data, string transfer_hint, bool needmerge)
	{
	}
}
