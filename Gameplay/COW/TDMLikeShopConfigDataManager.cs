using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2000243")]
internal class TDMLikeShopConfigDataManager
{
	[Token(Token = "0x4000DCC")]
	[FieldOffset(Offset = "0x8")]
	private bool hasSyncWithServer;

	[Token(Token = "0x4000DCD")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, List<TDMLikeShopConfigData>> m_TDMLikeShopDataDic;

	[Token(Token = "0x4000DCE")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, TDMLikeShopConfigData> m_TDMLikeShopDataExpandDic;

	[Token(Token = "0x6000B5B")]
	[Address(RVA = "0x2892508", Offset = "0x2892508", VA = "0x2892508")]
	public TDMLikeShopConfigDataManager()
	{
	}

	[Token(Token = "0x6000B5C")]
	[Address(RVA = "0x28925C8", Offset = "0x28925C8", VA = "0x28925C8")]
	public void LoadTDMLikeShopData()
	{
	}

	[Token(Token = "0x6000B5D")]
	[Address(RVA = "0x2892BE8", Offset = "0x2892BE8", VA = "0x2892BE8")]
	public void OnServerSyncTDMLikeShop(List<AGBFCOGPPAB> tdmShopItems)
	{
	}

	[Token(Token = "0x6000B5E")]
	[Address(RVA = "0x2893350", Offset = "0x2893350", VA = "0x2893350")]
	public List<uint> GetTDMShopFilterList()
	{
		return null;
	}

	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0x289344C", Offset = "0x289344C", VA = "0x289344C")]
	public TDMLikeShopConfigData GetTDMShopDataByIndex(uint index)
	{
		return null;
	}

	[Token(Token = "0x6000B60")]
	[Address(RVA = "0x2893534", Offset = "0x2893534", VA = "0x2893534")]
	public uint GetMainItemDataIDByIndexId(uint indexId)
	{
		return default(uint);
	}

	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x2893900", Offset = "0x2893900", VA = "0x2893900")]
	public List<TDMLikeShopConfigData> GetTDMShopItemListByFilter(uint filter)
	{
		return null;
	}

	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x28939E8", Offset = "0x28939E8", VA = "0x28939E8")]
	public void OnCleanUp()
	{
	}

	[Token(Token = "0x6000B63")]
	[Address(RVA = "0x2892B04", Offset = "0x2892B04", VA = "0x2892B04")]
	private ResourceID GetShopConfigRes()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6000B64")]
	[Address(RVA = "0x2893AA8", Offset = "0x2893AA8", VA = "0x2893AA8")]
	public ResourceID GetTDMLikeConfigName(uint map_id, uint mode_id)
	{
		return default(ResourceID);
	}
}
