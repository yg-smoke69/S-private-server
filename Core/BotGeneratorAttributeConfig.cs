using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

[Token(Token = "0x2000C7A")]
internal class BotGeneratorAttributeConfig : ItemEditAttributeBaseConfig
{
	[Token(Token = "0x40066A7")]
	[FieldOffset(Offset = "0xC")]
	public string CountEachBatchTitleNameKey;

	[Token(Token = "0x40066A8")]
	[FieldOffset(Offset = "0x10")]
	public int CountEatchBatch;

	[Token(Token = "0x40066A9")]
	[FieldOffset(Offset = "0x14")]
	public int CountEatchBatchMin;

	[Token(Token = "0x40066AA")]
	[FieldOffset(Offset = "0x18")]
	public int CountEatchBatchMax;

	[Token(Token = "0x40066AB")]
	[FieldOffset(Offset = "0x1C")]
	public int CountEatchBatchStep;

	[Token(Token = "0x40066AC")]
	[FieldOffset(Offset = "0x20")]
	public string BatchCountTitleNameKey;

	[Token(Token = "0x40066AD")]
	[FieldOffset(Offset = "0x24")]
	public int BatchCount;

	[Token(Token = "0x40066AE")]
	[FieldOffset(Offset = "0x28")]
	public int BatchCountMin;

	[Token(Token = "0x40066AF")]
	[FieldOffset(Offset = "0x2C")]
	public int BatchCountMax;

	[Token(Token = "0x40066B0")]
	[FieldOffset(Offset = "0x30")]
	public int BatchCountStep;

	[Token(Token = "0x40066B1")]
	[FieldOffset(Offset = "0x34")]
	public string BatchIntervalTitleNameKey;

	[Token(Token = "0x40066B2")]
	[FieldOffset(Offset = "0x38")]
	public List<int> BatchInterval;

	[Token(Token = "0x40066B3")]
	[FieldOffset(Offset = "0x3C")]
	public string EnableDropTitleNameKey;

	[Token(Token = "0x40066B4")]
	[FieldOffset(Offset = "0x40")]
	public List<string> DropEnabledKey;

	[Token(Token = "0x40066B5")]
	[FieldOffset(Offset = "0x44")]
	public List<int> DropEnabledValue;

	[Token(Token = "0x6005FAF")]
	[Address(RVA = "0x2ED2EC8", Offset = "0x2ED2EC8", VA = "0x2ED2EC8")]
	public BotGeneratorAttributeConfig()
	{
	}

	[Token(Token = "0x6005FB0")]
	[Address(RVA = "0x2ED2F90", Offset = "0x2ED2F90", VA = "0x2ED2F90")]
	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectAttrBotGenerator sceneEditAttr)
	{
		return null;
	}

	[Token(Token = "0x6005FB1")]
	[Address(RVA = "0x2ED35BC", Offset = "0x2ED35BC", VA = "0x2ED35BC", Slot = "4")]
	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	[Token(Token = "0x6005FB2")]
	[Address(RVA = "0x2ED35C4", Offset = "0x2ED35C4", VA = "0x2ED35C4", Slot = "5")]
	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6005FB3")]
	[Address(RVA = "0x2ED3690", Offset = "0x2ED3690", VA = "0x2ED3690", Slot = "6")]
	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase sceneEditObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6005FB4")]
	[Address(RVA = "0x2ED3AE0", Offset = "0x2ED3AE0", VA = "0x2ED3AE0", Slot = "7")]
	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6005FB5")]
	[Address(RVA = "0x2ED3818", Offset = "0x2ED3818", VA = "0x2ED3818")]
	private void SetAttributeData(SceneEditObjectAttrBotGenerator botGeneraotr, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
