using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW.GamePlay;

[Token(Token = "0x200281E")]
internal class UIHudRangeShopController : UIBaseController
{
	[Token(Token = "0x400F7A4")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDRangeShopView NOJLDPLOCIH;

	[Token(Token = "0x400F7A5")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIHudRangeShopItemController> DCBCJLPFHAD;

	[Token(Token = "0x400F7A6")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<uint, List<HOHGGABAMLM>> CICJALEFHPH;

	[Token(Token = "0x400F7A7")]
	[FieldOffset(Offset = "0x34")]
	private uint FPHONGFBDFA;

	[Token(Token = "0x400F7A8")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<HOHGGABAMLM> HMDOHFBHDOB;

	[Token(Token = "0x600F9F9")]
	[Address(RVA = "0xF78BEC", Offset = "0xF78BEC", VA = "0xF78BEC")]
	public UIHudRangeShopController()
	{
	}

	[Token(Token = "0x600F9FA")]
	[Address(RVA = "0xF78CD8", Offset = "0xF78CD8", VA = "0xF78CD8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F9FB")]
	[Address(RVA = "0xF78D7C", Offset = "0xF78D7C", VA = "0xF78D7C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F9FC")]
	[Address(RVA = "0xF790B0", Offset = "0xF790B0", VA = "0xF790B0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600F9FD")]
	[Address(RVA = "0xF791E4", Offset = "0xF791E4", VA = "0xF791E4")]
	public bool HasCacheRangeShopItem(uint POOPHEIGELJ)
	{
		return default(bool);
	}

	[Token(Token = "0x600F9FE")]
	[Address(RVA = "0xF792B0", Offset = "0xF792B0", VA = "0xF792B0")]
	public void InitByCache(uint POOPHEIGELJ)
	{
	}

	[Token(Token = "0x600F9FF")]
	[Address(RVA = "0xF7938C", Offset = "0xF7938C", VA = "0xF7938C")]
	public void InitData(List<HOHGGABAMLM> JMHKDJDCIEH, uint POOPHEIGELJ)
	{
	}

	[Token(Token = "0x600FA00")]
	[Address(RVA = "0xF79C48", Offset = "0xF79C48", VA = "0xF79C48")]
	private void HBHOCPNGKAL(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600FA01")]
	[Address(RVA = "0xF79D30", Offset = "0xF79D30", VA = "0xF79D30")]
	private void DPLPKGNPDIJ()
	{
	}

	[Token(Token = "0x600FA02")]
	[Address(RVA = "0xF79F7C", Offset = "0xF79F7C", VA = "0xF79F7C")]
	private static int LNANDOKKPKA(HOHGGABAMLM AAFBIANMEAL, HOHGGABAMLM KENDCFNPDCE)
	{
		return default(int);
	}

	[Token(Token = "0x600FA03")]
	[Address(RVA = "0xF79FBC", Offset = "0xF79FBC", VA = "0xF79FBC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FA04")]
	[Address(RVA = "0xF79FC4", Offset = "0xF79FC4", VA = "0xF79FC4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
