using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003AA4")]
internal class UIHudInGameShopItemViewExt : UIHudInGameShopItemView
{
	[Token(Token = "0x2003AA5")]
	public enum CoinIconType
	{
		[Token(Token = "0x4018F0B")]
		ExchangeToken,
		[Token(Token = "0x4018F0C")]
		ShopCoin,
		[Token(Token = "0x4018F0D")]
		TrainingToken
	}

	[Token(Token = "0x4018EFE")]
	[FieldOffset(Offset = "0xA0")]
	private BitArrayBoolean m_ShowGraySprite;

	[Token(Token = "0x4018EFF")]
	public const uint ISUNLOCK = 1u;

	[Token(Token = "0x4018F00")]
	public const uint TOKEN_LACK = 2u;

	[Token(Token = "0x4018F01")]
	public const uint CAPACITY_LACK = 4u;

	[Token(Token = "0x4018F02")]
	public const uint LIMIT_LACK = 8u;

	[Token(Token = "0x4018F03")]
	public const uint PLIERS_NOTOK = 16u;

	[Token(Token = "0x4018F04")]
	public const uint IN_CD = 32u;

	[Token(Token = "0x4018F05")]
	public const uint NOT_MY_TURN = 64u;

	[Token(Token = "0x4018F06")]
	[FieldOffset(Offset = "0xA4")]
	private Color limitColor;

	[Token(Token = "0x4018F07")]
	[FieldOffset(Offset = "0xB4")]
	private Camera m_Camera;

	[Token(Token = "0x4018F08")]
	[FieldOffset(Offset = "0xB8")]
	private UICamera m_UICamera;

	[Token(Token = "0x4018F09")]
	[FieldOffset(Offset = "0xBC")]
	private float dist;

	[Token(Token = "0x60173AD")]
	[Address(RVA = "0x22A4138", Offset = "0x22A4138", VA = "0x22A4138")]
	public UIHudInGameShopItemViewExt()
	{
	}

	[Token(Token = "0x60173AE")]
	[Address(RVA = "0x22A053C", Offset = "0x22A053C", VA = "0x22A053C")]
	public void OnInit()
	{
	}

	[Token(Token = "0x60173AF")]
	[Address(RVA = "0x22A12AC", Offset = "0x22A12AC", VA = "0x22A12AC")]
	public void SetUIData(LGCOKIBHIJL itemData1, uint count1, bool showSkin = false, [Optional] LGCOKIBHIJL itemData2, uint price = 0u, uint quality = 0u, bool hasBonus = false, bool isLimited = false, bool showNewTag = false, bool showCoin = true, CoinIconType coinType = CoinIconType.ShopCoin)
	{
	}

	[Token(Token = "0x60173B0")]
	[Address(RVA = "0x22A4208", Offset = "0x22A4208", VA = "0x22A4208")]
	private void SetImageInOtherAtlas(bool hasBonus, bool showNewTag)
	{
	}

	[Token(Token = "0x60173B1")]
	[Address(RVA = "0x22A24B8", Offset = "0x22A24B8", VA = "0x22A24B8")]
	public void UpdateGrayCondition(uint condType, bool condValue, bool playFadeOut = false)
	{
	}

	[Token(Token = "0x60173B2")]
	[Address(RVA = "0x22A4594", Offset = "0x22A4594", VA = "0x22A4594")]
	public bool IsAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x60173B3")]
	[Address(RVA = "0x22A4390", Offset = "0x22A4390", VA = "0x22A4390")]
	public void RefreshShortCoinStatus(bool shortCoin)
	{
	}

	[Token(Token = "0x60173B4")]
	[Address(RVA = "0x22A44BC", Offset = "0x22A44BC", VA = "0x22A44BC")]
	public void RefreshLimiteStatus(bool isLimited)
	{
	}

	[Token(Token = "0x60173B5")]
	[Address(RVA = "0x229A8EC", Offset = "0x229A8EC", VA = "0x229A8EC")]
	public static string GetCoinIconByType(CoinIconType iconType)
	{
		return null;
	}

	[Token(Token = "0x60173B6")]
	[Address(RVA = "0x22A4610", Offset = "0x22A4610", VA = "0x22A4610")]
	private bool CheckPos(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x60173B7")]
	[Address(RVA = "0x22A496C", Offset = "0x22A496C", VA = "0x22A496C")]
	private bool CheckPCTouch(Vector3 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x60173B8")]
	[Address(RVA = "0x22A4A7C", Offset = "0x22A4A7C", VA = "0x22A4A7C")]
	private bool CheckMobileTouch()
	{
		return default(bool);
	}

	[Token(Token = "0x60173B9")]
	[Address(RVA = "0x22A4B74", Offset = "0x22A4B74", VA = "0x22A4B74")]
	private void TryGetCameraComponent()
	{
	}

	[Token(Token = "0x60173BA")]
	[Address(RVA = "0x22A0E60", Offset = "0x22A0E60", VA = "0x22A0E60")]
	public void Update()
	{
	}

	[Token(Token = "0x60173BB")]
	[Address(RVA = "0x22A4CD8", Offset = "0x22A4CD8", VA = "0x22A4CD8")]
	private void _003CUpdateGrayCondition_003Em__0()
	{
	}
}
