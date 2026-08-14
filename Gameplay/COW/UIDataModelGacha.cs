using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002E45")]
public class UIDataModelGacha
{
	[Token(Token = "0x4011AF8")]
	[FieldOffset(Offset = "0x0")]
	public static uint GACHA_MODEL_IDTYPE_MASK;

	[Token(Token = "0x4011AF9")]
	[FieldOffset(Offset = "0x8")]
	public GachaCDNAdData GachaCDNInfo;

	[Token(Token = "0x4011AFA")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<uint, GachaInfoDataBase> GachaAllInfoDic;

	[Token(Token = "0x4011AFB")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<uint, GachaPackageInfoData> GachaPackageInfoDic;

	[Token(Token = "0x4011AFC")]
	[FieldOffset(Offset = "0x14")]
	public Dictionary<uint, GachaSpecialInfoData> SpecialGachaInfoDic;

	[Token(Token = "0x4011AFD")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<uint, GachaSpDescData> GachaSpDescDic;

	[Token(Token = "0x4011AFE")]
	[FieldOffset(Offset = "0x1C")]
	public Dictionary<uint, GachaResultInfo> GachaResultInfoDic;

	[Token(Token = "0x4011AFF")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<uint, ELottery.Type> m_AllGachaChestTypeDic;

	[Token(Token = "0x60135C7")]
	[Address(RVA = "0x11F0F34", Offset = "0x11F0F34", VA = "0x11F0F34")]
	public UIDataModelGacha()
	{
	}

	[Token(Token = "0x60135C8")]
	[Address(RVA = "0x11F10E8", Offset = "0x11F10E8", VA = "0x11F10E8")]
	public void ClearInfoData()
	{
	}

	[Token(Token = "0x60135C9")]
	[Address(RVA = "0x11F122C", Offset = "0x11F122C", VA = "0x11F122C")]
	public void ProcessSpecialDesc(ChestSpecialExchangeDesc desc)
	{
	}

	[Token(Token = "0x60135CA")]
	[Address(RVA = "0x11F140C", Offset = "0x11F140C", VA = "0x11F140C")]
	public void CacheGachaResult(uint chestID, UIModelGacha.GachaDrawType drawType, uint jackpotID, CSLotteryRes gachaResult)
	{
	}

	[Token(Token = "0x60135CB")]
	[Address(RVA = "0x11F18C4", Offset = "0x11F18C4", VA = "0x11F18C4")]
	public ELottery.Type GetGachaTypeByID(uint gachaID)
	{
		return default(ELottery.Type);
	}

	[Token(Token = "0x60135CC")]
	[Address(RVA = "0x11F19AC", Offset = "0x11F19AC", VA = "0x11F19AC")]
	public bool IsEnergyGacha(uint gachaID)
	{
		return default(bool);
	}

	[Token(Token = "0x60135CD")]
	[Address(RVA = "0x11F1A28", Offset = "0x11F1A28", VA = "0x11F1A28")]
	public bool IsSpecialGachaData(ELottery.Type chestType)
	{
		return default(bool);
	}

	[Token(Token = "0x60135CE")]
	[Address(RVA = "0x11F1B14", Offset = "0x11F1B14", VA = "0x11F1B14")]
	public bool HasGachaDesc(uint gachaID)
	{
		return default(bool);
	}

	[Token(Token = "0x60135CF")]
	[Address(RVA = "0x11F1C20", Offset = "0x11F1C20", VA = "0x11F1C20")]
	public void ProcessGachaDescInfo(GachaDesc descInfo)
	{
	}

	[Token(Token = "0x60135D0")]
	[Address(RVA = "0x11F17D4", Offset = "0x11F17D4", VA = "0x11F17D4")]
	public GachaInfoDataBase GetGachaInfoByID(uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x60135D1")]
	[Address(RVA = "0x11F1F84", Offset = "0x11F1F84", VA = "0x11F1F84")]
	public void MarkGachaGachaType(uint gachaID, ELottery.Type gachaType)
	{
	}

	[Token(Token = "0x60135D2")]
	[Address(RVA = "0x11F206C", Offset = "0x11F206C", VA = "0x11F206C")]
	public ClientChestType GetClientChestTypeByID(uint gachaID)
	{
		return null;
	}
}
