using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032A5")]
public class UIModelUGCResourceSelect : UIBaseModel
{
	[Token(Token = "0x20032A6")]
	public enum ETableType
	{
		[Token(Token = "0x401347C")]
		enIcon,
		[Token(Token = "0x401347D")]
		enVFX,
		[Token(Token = "0x401347E")]
		enSound,
		[Token(Token = "0x401347F")]
		enObject,
		[Token(Token = "0x4013480")]
		enItem
	}

	[Token(Token = "0x20032A7")]
	public delegate void OnFinalSelected(string resourceName, int itemID);

	[Token(Token = "0x401347A")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, List<HINGGIJEKGM>> DataMaps;

	[Token(Token = "0x6015577")]
	[Address(RVA = "0x16A27F4", Offset = "0x16A27F4", VA = "0x16A27F4")]
	public UIModelUGCResourceSelect()
	{
	}

	[Token(Token = "0x6015578")]
	[Address(RVA = "0x16A28AC", Offset = "0x16A28AC", VA = "0x16A28AC", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6015579")]
	[Address(RVA = "0x16A2904", Offset = "0x16A2904", VA = "0x16A2904")]
	private void MakeSureTableLoaded()
	{
	}

	[Token(Token = "0x601557A")]
	private void LoadSortAndBuild<T>(ETableType tableType, List<T> rawList) where T : HINGGIJEKGM
	{
	}

	[Token(Token = "0x601557B")]
	[Address(RVA = "0x16A2C78", Offset = "0x16A2C78", VA = "0x16A2C78")]
	public void GetResourceTypeList(ETableType tableType, List<int> retTypeIDList, List<string> retTypeLocKeyList)
	{
	}

	[Token(Token = "0x601557C")]
	[Address(RVA = "0x169DA4C", Offset = "0x169DA4C", VA = "0x169DA4C")]
	public List<HINGGIJEKGM> GetResourceDataList(ETableType tableType)
	{
		return null;
	}

	[Token(Token = "0x601557D")]
	[Address(RVA = "0x16A2F28", Offset = "0x16A2F28", VA = "0x16A2F28")]
	public void GetResourceDataByType(ETableType tableType, int itemType, List<object> retDataList)
	{
	}

	[Token(Token = "0x601557E")]
	[Address(RVA = "0x16A3134", Offset = "0x16A3134", VA = "0x16A3134")]
	public static void TryPreviewResource(ValueData valueData)
	{
	}

	[Token(Token = "0x601557F")]
	[Address(RVA = "0x16A3254", Offset = "0x16A3254", VA = "0x16A3254")]
	public static bool TryExtSelect(ValueData valueData, OnFinalSelected callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6015580")]
	private static int _003CLoadSortAndBuild_00601_003Em__0<T>(T item1, T item2) where T : HINGGIJEKGM
	{
		return default(int);
	}
}
