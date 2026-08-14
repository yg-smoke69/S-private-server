using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x200205B")]
internal class UIHudCSSORoundResultController : UIBaseController
{
	[Token(Token = "0x400CAD2")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCSSORoundResultView m_View;

	[Token(Token = "0x400CAD3")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400CAD4")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_BonusItemList;

	[Token(Token = "0x400CAD5")]
	[FieldOffset(Offset = "0x34")]
	private byte m_MyTeamID;

	[Token(Token = "0x400CAD6")]
	[FieldOffset(Offset = "0x35")]
	private byte m_CurrRoundOppoTeamID;

	[Token(Token = "0x400CAD7")]
	private const string BONUESCOINSKEY = "${0}";

	[Token(Token = "0x400CAD8")]
	[FieldOffset(Offset = "0x36")]
	private bool m_LocalPlayerWin;

	[Token(Token = "0x400CAD9")]
	[FieldOffset(Offset = "0x37")]
	private bool m_IsSpecial;

	[Token(Token = "0x400CADA")]
	[FieldOffset(Offset = "0x38")]
	private bool m_HasMVP;

	[Token(Token = "0x600A567")]
	[Address(RVA = "0x21326E4", Offset = "0x21326E4", VA = "0x21326E4")]
	public UIHudCSSORoundResultController()
	{
	}

	[Token(Token = "0x600A568")]
	[Address(RVA = "0x213279C", Offset = "0x213279C", VA = "0x213279C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A569")]
	[Address(RVA = "0x2132844", Offset = "0x2132844", VA = "0x2132844", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A56A")]
	[Address(RVA = "0x2132B14", Offset = "0x2132B14", VA = "0x2132B14", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A56B")]
	[Address(RVA = "0x2132CB0", Offset = "0x2132CB0", VA = "0x2132CB0")]
	private void OnEarnedCoinChanged(object[] data)
	{
	}

	[Token(Token = "0x600A56C")]
	[Address(RVA = "0x2132E44", Offset = "0x2132E44", VA = "0x2132E44", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A56D")]
	[Address(RVA = "0x2133880", Offset = "0x2133880", VA = "0x2133880")]
	public void SetBonusDetailsView(NFEBFFPCGFE res)
	{
	}

	[Token(Token = "0x600A56E")]
	[Address(RVA = "0x2134560", Offset = "0x2134560", VA = "0x2134560")]
	private string GetDescriptionOfBonusType(IKFOMLELBPG bonusType)
	{
		return null;
	}

	[Token(Token = "0x600A56F")]
	[Address(RVA = "0x21332A8", Offset = "0x21332A8", VA = "0x21332A8")]
	private void SetTeamInfo()
	{
	}

	[Token(Token = "0x600A570")]
	[Address(RVA = "0x2134A20", Offset = "0x2134A20", VA = "0x2134A20")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x600A571")]
	[Address(RVA = "0x213542C", Offset = "0x213542C", VA = "0x213542C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A572")]
	[Address(RVA = "0x2135434", Offset = "0x2135434", VA = "0x2135434")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600A573")]
	[Address(RVA = "0x213543C", Offset = "0x213543C", VA = "0x213543C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
