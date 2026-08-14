using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.UGCUI;

[Token(Token = "0x2004104")]
public static class UGCUITools
{
	[Token(Token = "0x601A8BC")]
	[Address(RVA = "0x2C8D800", Offset = "0x2C8D800", VA = "0x2C8D800")]
	public static string RGBToHEX(Color32 c)
	{
		return null;
	}

	[Token(Token = "0x601A8BD")]
	[Address(RVA = "0x2C8D8F8", Offset = "0x2C8D8F8", VA = "0x2C8D8F8")]
	public static void ResizeWidget(UIWidget w, Pivot pivot, float x, float y, bool keepAspectRatio = false, int minWidth = 2, int minHeight = 2, int maxWidth = 100000, int maxHeight = 100000)
	{
	}

	[Token(Token = "0x601A8BE")]
	[Address(RVA = "0x2C8EBA0", Offset = "0x2C8EBA0", VA = "0x2C8EBA0")]
	public static void AdjustDepthByHierarchy(GameObject go, int depthStep = 1)
	{
	}

	[Token(Token = "0x601A8BF")]
	[Address(RVA = "0x2C8F340", Offset = "0x2C8F340", VA = "0x2C8F340")]
	public static int AdjustWidgetDepth(GameObject go, int initDepth = 0, int depthStep = 1, bool includeChildren = true)
	{
		return default(int);
	}

	[Token(Token = "0x601A8C0")]
	[Address(RVA = "0x2C8F560", Offset = "0x2C8F560", VA = "0x2C8F560")]
	public static void UpdateWidgetHorizontalAlignment(UGCHudWidget widget, int parentWidth)
	{
	}

	[Token(Token = "0x601A8C1")]
	[Address(RVA = "0x2C8F648", Offset = "0x2C8F648", VA = "0x2C8F648")]
	public static void UpdateWidgetVerticalAlignment(UGCHudWidget widget, int parentHeight)
	{
	}

	[Token(Token = "0x601A8C2")]
	[Address(RVA = "0x2C8F730", Offset = "0x2C8F730", VA = "0x2C8F730")]
	public static void UpdateWidgetAlignment(UGCHudWidget widget)
	{
	}

	[Token(Token = "0x601A8C3")]
	[Address(RVA = "0x2C8FA48", Offset = "0x2C8FA48", VA = "0x2C8FA48")]
	public static Transform GetHudPrefabRoot(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x601A8C4")]
	[Address(RVA = "0x2C8FB40", Offset = "0x2C8FB40", VA = "0x2C8FB40")]
	public static uint GetHudMaxUniqueID(GameObject go)
	{
		return default(uint);
	}

	[Token(Token = "0x601A8C5")]
	[Address(RVA = "0x2C8FC6C", Offset = "0x2C8FC6C", VA = "0x2C8FC6C")]
	public static GameObject CreateHudWidget(UGCHudWidgetType widgetType, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x601A8C6")]
	[Address(RVA = "0x2C8FFC0", Offset = "0x2C8FFC0", VA = "0x2C8FFC0")]
	public static string GetHudWidgetIcon(UGCHudWidgetType widgetType)
	{
		return null;
	}

	[Token(Token = "0x601A8C7")]
	[Address(RVA = "0x2C90070", Offset = "0x2C90070", VA = "0x2C90070")]
	public static string GetHudWidgetName(UGCHudWidgetType widgetType, uint uniqueId)
	{
		return null;
	}

	[Token(Token = "0x601A8C8")]
	[Address(RVA = "0x2C90198", Offset = "0x2C90198", VA = "0x2C90198")]
	public static bool IsHudWidget(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x601A8C9")]
	[Address(RVA = "0x2C90294", Offset = "0x2C90294", VA = "0x2C90294")]
	public static bool IsHudWidget(Transform transform)
	{
		return default(bool);
	}

	[Token(Token = "0x601A8CA")]
	[Address(RVA = "0x2C90390", Offset = "0x2C90390", VA = "0x2C90390")]
	public static string GetHudID(uint hudId)
	{
		return null;
	}

	[Token(Token = "0x601A8CB")]
	[Address(RVA = "0x2C9044C", Offset = "0x2C9044C", VA = "0x2C9044C")]
	public static uint GetHudID(string hudId)
	{
		return default(uint);
	}

	[Token(Token = "0x601A8CC")]
	[Address(RVA = "0x2C905AC", Offset = "0x2C905AC", VA = "0x2C905AC")]
	public static string GetHudWidgetID(uint hudId, uint widgetId)
	{
		return null;
	}

	[Token(Token = "0x601A8CD")]
	[Address(RVA = "0x2C90684", Offset = "0x2C90684", VA = "0x2C90684")]
	public static string GetHudWidgetID(string hudID, uint widgetId)
	{
		return null;
	}
}
