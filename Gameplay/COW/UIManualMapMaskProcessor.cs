using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200298D")]
public class UIManualMapMaskProcessor
{
	[Token(Token = "0x400FFD9")]
	private const int m_MaskTexW = 64;

	[Token(Token = "0x400FFDA")]
	private const int m_MaskTexH = 64;

	[Token(Token = "0x400FFDB")]
	[FieldOffset(Offset = "0x0")]
	private static Color m_DefMaskColor;

	[Token(Token = "0x6010AE5")]
	[Address(RVA = "0x2C3CA7C", Offset = "0x2C3CA7C", VA = "0x2C3CA7C")]
	public UIManualMapMaskProcessor()
	{
	}

	[Token(Token = "0x6010AE6")]
	[Address(RVA = "0x2C31E04", Offset = "0x2C31E04", VA = "0x2C31E04")]
	public static void ProcessMapMask(UITexture tex, List<UISprite> signList, uint[] radiusArray, bool unlockAll = false)
	{
	}

	[Token(Token = "0x6010AE7")]
	[Address(RVA = "0x2C3CA84", Offset = "0x2C3CA84", VA = "0x2C3CA84")]
	private static Vector2 Pos2Pixel(UITexture tex, Vector2 localPos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6010AE8")]
	[Address(RVA = "0x2C3CCD8", Offset = "0x2C3CCD8", VA = "0x2C3CCD8")]
	private static int CalRdius(int radius)
	{
		return default(int);
	}

	[Token(Token = "0x6010AE9")]
	[Address(RVA = "0x2C3CD50", Offset = "0x2C3CD50", VA = "0x2C3CD50")]
	private static bool IsInCircle(Vector2 pos, Vector2 center, float radius)
	{
		return default(bool);
	}
}
