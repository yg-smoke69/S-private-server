using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002E3C")]
public class GachaResultInfo
{
	[Token(Token = "0x4011ACF")]
	[FieldOffset(Offset = "0x8")]
	public uint gachaId;

	[Token(Token = "0x4011AD0")]
	[FieldOffset(Offset = "0xC")]
	public UIModelGacha.GachaDrawType gachaType;

	[Token(Token = "0x4011AD1")]
	[FieldOffset(Offset = "0x10")]
	public List<ExchangedAward> lotteries;

	[Token(Token = "0x4011AD2")]
	[FieldOffset(Offset = "0x14")]
	public List<ExchangedAward> rewards;

	[Token(Token = "0x4011AD3")]
	[FieldOffset(Offset = "0x18")]
	public List<ExchangedAward> extraRewards;

	[Token(Token = "0x4011AD4")]
	[FieldOffset(Offset = "0x1C")]
	public List<uint> rewardIDs;

	[Token(Token = "0x4011AD5")]
	[FieldOffset(Offset = "0x20")]
	public uint act_progress;

	[Token(Token = "0x601355D")]
	[Address(RVA = "0x10555D0", Offset = "0x10555D0", VA = "0x10555D0")]
	public GachaResultInfo()
	{
	}

	[Token(Token = "0x601355E")]
	[Address(RVA = "0x10555D8", Offset = "0x10555D8", VA = "0x10555D8")]
	public void ProcessGachaResultInfo(uint chestID, UIModelGacha.GachaDrawType drawType, CSLotteryRes gachaResult)
	{
	}
}
