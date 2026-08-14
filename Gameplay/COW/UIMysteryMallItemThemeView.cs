using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D4D")]
public class UIMysteryMallItemThemeView : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2002D4E")]
	public struct UIMysteryMallItemThemeObject
	{
		[Token(Token = "0x4011623")]
		[FieldOffset(Offset = "0x0")]
		public EThemeType themeType;

		[Token(Token = "0x4011624")]
		[FieldOffset(Offset = "0x4")]
		public GameObject mainObject;

		[Token(Token = "0x4011625")]
		[FieldOffset(Offset = "0x8")]
		public GameObject priceBg;

		[Token(Token = "0x4011626")]
		[FieldOffset(Offset = "0xC")]
		public UISprite discountBg;

		[Token(Token = "0x4011627")]
		[FieldOffset(Offset = "0x10")]
		public UISprite qualityBg;

		[Token(Token = "0x4011628")]
		[FieldOffset(Offset = "0x14")]
		public UISprite itemNameQualityBg;

		[Token(Token = "0x4011629")]
		[FieldOffset(Offset = "0x18")]
		public UILabel discountLabel;

		[Token(Token = "0x401162A")]
		[FieldOffset(Offset = "0x1C")]
		public UISprite SpriteBuy;
	}

	[Token(Token = "0x4011620")]
	[FieldOffset(Offset = "0xC")]
	public UIMysteryMallItemThemeObject[] ThemeObjectArray;

	[Token(Token = "0x4011621")]
	[FieldOffset(Offset = "0x10")]
	private UIMysteryMallItemThemeObject m_CurTheme;

	[Token(Token = "0x4011622")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<UIMysteryMallItemThemeObject> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6012F58")]
	[Address(RVA = "0x1B26F9C", Offset = "0x1B26F9C", VA = "0x1B26F9C")]
	public UIMysteryMallItemThemeView()
	{
	}

	[Token(Token = "0x6012F59")]
	[Address(RVA = "0x1B25160", Offset = "0x1B25160", VA = "0x1B25160")]
	public void SetThemeActive(bool isSuperReward)
	{
	}

	[Token(Token = "0x6012F5A")]
	[Address(RVA = "0x1B2556C", Offset = "0x1B2556C", VA = "0x1B2556C")]
	public void SetDiscount(uint discount, MeshRenderer vfxDiscout)
	{
	}

	[Token(Token = "0x6012F5B")]
	[Address(RVA = "0x1B25D58", Offset = "0x1B25D58", VA = "0x1B25D58")]
	public void SetQualityBG(BaseItemInfo itemInfo)
	{
	}

	[Token(Token = "0x6012F5C")]
	[Address(RVA = "0x1B25A54", Offset = "0x1B25A54", VA = "0x1B25A54")]
	public static void SetItemNameTheme(UILabel label)
	{
	}

	[Token(Token = "0x6012F5D")]
	[Address(RVA = "0x1B25B54", Offset = "0x1B25B54", VA = "0x1B25B54")]
	public static void SetQualityTimeLimit(UILabel label)
	{
	}

	[Token(Token = "0x6012F5E")]
	[Address(RVA = "0x1B265D8", Offset = "0x1B265D8", VA = "0x1B265D8")]
	public static void SetDiscountPriceTheme(UILabel label)
	{
	}

	[Token(Token = "0x6012F5F")]
	[Address(RVA = "0x1B26FA4", Offset = "0x1B26FA4", VA = "0x1B26FA4")]
	private static bool _003CSetThemeActive_003Em__0(UIMysteryMallItemThemeObject value)
	{
		return default(bool);
	}
}
