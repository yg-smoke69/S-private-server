using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200063E")]
public class LevelInventoryShop : BaseLevelObject
{
	[Token(Token = "0x4004697")]
	[FieldOffset(Offset = "0x74")]
	public List<uint> ItemList;

	[Token(Token = "0x4004698")]
	[FieldOffset(Offset = "0x78")]
	public OJCOOJEIJPD ShopType;

	[Token(Token = "0x4004699")]
	[FieldOffset(Offset = "0x7C")]
	public ENNMDCLGJPA ItemShopType;

	[Token(Token = "0x400469A")]
	[FieldOffset(Offset = "0x80")]
	public GameObject HLGO;

	[Token(Token = "0x60026CB")]
	[Address(RVA = "0x24B0960", Offset = "0x24B0960", VA = "0x24B0960")]
	public LevelInventoryShop()
	{
	}

	[Token(Token = "0x60026CC")]
	[Address(RVA = "0x24B0970", Offset = "0x24B0970", VA = "0x24B0970", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60026CD")]
	[Address(RVA = "0x24B0A14", Offset = "0x24B0A14", VA = "0x24B0A14", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60026CE")]
	[Address(RVA = "0x24B0B40", Offset = "0x24B0B40", VA = "0x24B0B40")]
	public void OnLocalPlayerEnterTrigger()
	{
	}

	[Token(Token = "0x60026CF")]
	[Address(RVA = "0x24B0E10", Offset = "0x24B0E10", VA = "0x24B0E10")]
	public void OnLocalPlayerExitTrigger()
	{
	}

	[Token(Token = "0x60026D0")]
	[Address(RVA = "0x24B0BB0", Offset = "0x24B0BB0", VA = "0x24B0BB0")]
	public void HighLight(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x60026D1")]
	[Address(RVA = "0x24B0CD8", Offset = "0x24B0CD8", VA = "0x24B0CD8")]
	private void EMPKMGKHGMF(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x60026D2")]
	[Address(RVA = "0x24B0F34", Offset = "0x24B0F34", VA = "0x24B0F34")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}
}
