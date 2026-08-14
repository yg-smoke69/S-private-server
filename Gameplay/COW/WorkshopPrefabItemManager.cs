using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000AF5")]
internal class WorkshopPrefabItemManager
{
	[Token(Token = "0x4005F0E")]
	[FieldOffset(Offset = "0x0")]
	public static string IsPrefabNewKeyPrefix;

	[Token(Token = "0x4005F0F")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<uint, WorkShopResourceTypeData> mResourceTypeDataList;

	[Token(Token = "0x4005F10")]
	[FieldOffset(Offset = "0xC")]
	public List<uint> mItemTabList;

	[Token(Token = "0x4005F11")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<uint, List<uint>> mItemSubTabDic;

	[Token(Token = "0x4005F12")]
	[FieldOffset(Offset = "0x14")]
	public Dictionary<uint, List<uint>> mItemPrefabDic;

	[Token(Token = "0x4005F13")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<ModeTemplate, List<uint>> mMustModePrefabDic;

	[Token(Token = "0x4005F14")]
	[FieldOffset(Offset = "0x1C")]
	public Dictionary<ModeTemplate, List<uint>> mForbiddenPrefabDic;

	[Token(Token = "0x4005F15")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<uint, int> mItemTabIsNewDic;

	[Token(Token = "0x4005F16")]
	[FieldOffset(Offset = "0x24")]
	public Dictionary<uint, bool> mItemPrefabIsNewDic;

	[Token(Token = "0x4005F17")]
	[FieldOffset(Offset = "0x28")]
	private uint MustModeOptionID;

	[Token(Token = "0x4005F18")]
	[FieldOffset(Offset = "0x2C")]
	private bool mInited;

	[Token(Token = "0x4005F19")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6005461")]
	[Address(RVA = "0x2303FC0", Offset = "0x2303FC0", VA = "0x2303FC0")]
	public WorkshopPrefabItemManager()
	{
	}

	[Token(Token = "0x6005462")]
	[Address(RVA = "0x2304180", Offset = "0x2304180", VA = "0x2304180")]
	public void OnInit()
	{
	}

	[Token(Token = "0x6005463")]
	[Address(RVA = "0x2305984", Offset = "0x2305984", VA = "0x2305984")]
	public void OnChangeModeOrTemplate(uint modeType, uint templateID)
	{
	}

	[Token(Token = "0x6005464")]
	[Address(RVA = "0x23064D8", Offset = "0x23064D8", VA = "0x23064D8")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005465")]
	[Address(RVA = "0x230667C", Offset = "0x230667C", VA = "0x230667C")]
	public WorkShopResourceTypeData GetTabDataByOptionID(uint id)
	{
		return null;
	}

	[Token(Token = "0x6005466")]
	[Address(RVA = "0x2306764", Offset = "0x2306764", VA = "0x2306764")]
	public bool IsNewItemPrefab(uint prefabID)
	{
		return default(bool);
	}

	[Token(Token = "0x6005467")]
	[Address(RVA = "0x2306870", Offset = "0x2306870", VA = "0x2306870")]
	public bool ShouldShowNewForTab(uint optionID)
	{
		return default(bool);
	}

	[Token(Token = "0x6005468")]
	[Address(RVA = "0x230698C", Offset = "0x230698C", VA = "0x230698C")]
	public void RemoveNewItemPrefab(uint prefabID)
	{
	}

	[Token(Token = "0x6005469")]
	[Address(RVA = "0x23056F4", Offset = "0x23056F4", VA = "0x23056F4")]
	public void RefreshTabNew(uint optionID, bool isAdd = true)
	{
	}

	[Token(Token = "0x600546B")]
	[Address(RVA = "0x2306C5C", Offset = "0x2306C5C", VA = "0x2306C5C")]
	private int _003COnInit_003Em__0(uint aID, uint bID)
	{
		return default(int);
	}

	[Token(Token = "0x600546C")]
	[Address(RVA = "0x2306CCC", Offset = "0x2306CCC", VA = "0x2306CCC")]
	private int _003COnInit_003Em__1(uint aID, uint bID)
	{
		return default(int);
	}

	[Token(Token = "0x600546D")]
	[Address(RVA = "0x2306D3C", Offset = "0x2306D3C", VA = "0x2306D3C")]
	private static int _003COnInit_003Em__2(uint a, uint b)
	{
		return default(int);
	}
}
