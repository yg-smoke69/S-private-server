using System.Collections.Generic;
using COW.Gameplay.UGC.BlockEdit;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000C1F")]
public static class BEUtil
{
	[Token(Token = "0x4006475")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, List<BEEnumData>> BEEnumDic;

	[Token(Token = "0x6005CA6")]
	[Address(RVA = "0x2E4BA54", Offset = "0x2E4BA54", VA = "0x2E4BA54")]
	public static int GetEnumIndex(List<BEEnumData> enumList, ValueData valueData)
	{
		return default(int);
	}

	[Token(Token = "0x6005CA7")]
	[Address(RVA = "0x2E4BB88", Offset = "0x2E4BB88", VA = "0x2E4BB88")]
	public static List<BEEnumData> GetEnumList(string enumType)
	{
		return null;
	}

	[Token(Token = "0x6005CA8")]
	[Address(RVA = "0x2E4BCA0", Offset = "0x2E4BCA0", VA = "0x2E4BCA0")]
	private static void InitBEEnumDic()
	{
	}

	[Token(Token = "0x6005CA9")]
	[Address(RVA = "0x2E4CB98", Offset = "0x2E4CB98", VA = "0x2E4CB98")]
	public static string ColorToHex(Color32 color)
	{
		return null;
	}

	[Token(Token = "0x6005CAA")]
	[Address(RVA = "0x2E4CCC8", Offset = "0x2E4CCC8", VA = "0x2E4CCC8")]
	public static Color HexToColor(string hex)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6005CAB")]
	[Address(RVA = "0x2E4CFC4", Offset = "0x2E4CFC4", VA = "0x2E4CFC4")]
	public static int IntFromColor(Color color)
	{
		return default(int);
	}

	[Token(Token = "0x6005CAC")]
	[Address(RVA = "0x2E4D05C", Offset = "0x2E4D05C", VA = "0x2E4D05C")]
	public static Color ColorFromInt(int color)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6005CAD")]
	[Address(RVA = "0x2E4D0CC", Offset = "0x2E4D0CC", VA = "0x2E4D0CC")]
	public static string InputValToDecimal(string val)
	{
		return null;
	}
}
