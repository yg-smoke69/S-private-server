using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using message;

[Token(Token = "0x2000C8A")]
public class MiniSentryEditAttributeConfig : ItemEditAttributeBaseConfig
{
	[Token(Token = "0x40066EB")]
	[FieldOffset(Offset = "0xC")]
	public string HPConfigTitleNameKey;

	[Token(Token = "0x40066EC")]
	[FieldOffset(Offset = "0x10")]
	public uint HP;

	[Token(Token = "0x40066ED")]
	[FieldOffset(Offset = "0x14")]
	public uint HPMin;

	[Token(Token = "0x40066EE")]
	[FieldOffset(Offset = "0x18")]
	public uint HPMax;

	[Token(Token = "0x40066EF")]
	[FieldOffset(Offset = "0x1C")]
	public uint HPStep;

	[Token(Token = "0x40066F0")]
	[FieldOffset(Offset = "0x20")]
	public string AttackConfigTitleNameKey;

	[Token(Token = "0x40066F1")]
	[FieldOffset(Offset = "0x24")]
	public uint Attack;

	[Token(Token = "0x40066F2")]
	[FieldOffset(Offset = "0x28")]
	public uint AttackMin;

	[Token(Token = "0x40066F3")]
	[FieldOffset(Offset = "0x2C")]
	public uint AttackMax;

	[Token(Token = "0x40066F4")]
	[FieldOffset(Offset = "0x30")]
	public uint AttackStep;

	[Token(Token = "0x40066F5")]
	[FieldOffset(Offset = "0x34")]
	public string DefenseConfigTitleNameKey;

	[Token(Token = "0x40066F6")]
	[FieldOffset(Offset = "0x38")]
	public float Defense;

	[Token(Token = "0x40066F7")]
	[FieldOffset(Offset = "0x3C")]
	public float DefenseMin;

	[Token(Token = "0x40066F8")]
	[FieldOffset(Offset = "0x40")]
	public float DefenseMax;

	[Token(Token = "0x40066F9")]
	[FieldOffset(Offset = "0x44")]
	public float DefenseStep;

	[Token(Token = "0x40066FA")]
	[FieldOffset(Offset = "0x48")]
	public string AttackRangeConfigTitleNameKey;

	[Token(Token = "0x40066FB")]
	[FieldOffset(Offset = "0x4C")]
	public List<string> AttackRangeTitles;

	[Token(Token = "0x40066FC")]
	[FieldOffset(Offset = "0x50")]
	public List<OCFECNAGADB> RangeList;

	[Token(Token = "0x40066FD")]
	[FieldOffset(Offset = "0x54")]
	public string AttackIntervalConfigTitleNameKey;

	[Token(Token = "0x40066FE")]
	[FieldOffset(Offset = "0x58")]
	public float AttackInterval;

	[Token(Token = "0x40066FF")]
	[FieldOffset(Offset = "0x5C")]
	public float AttackIntervalMin;

	[Token(Token = "0x4006700")]
	[FieldOffset(Offset = "0x60")]
	public float AttackIntervalMax;

	[Token(Token = "0x4006701")]
	[FieldOffset(Offset = "0x64")]
	public float AttackIntervalStep;

	[Token(Token = "0x4006702")]
	[FieldOffset(Offset = "0x68")]
	public string TeamConfigTitleNameKey;

	[Token(Token = "0x6005FF5")]
	[Address(RVA = "0x1C6F210", Offset = "0x1C6F210", VA = "0x1C6F210")]
	public MiniSentryEditAttributeConfig()
	{
	}

	[Token(Token = "0x6005FF6")]
	[Address(RVA = "0x1C6F218", Offset = "0x1C6F218", VA = "0x1C6F218")]
	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectMiniSentry miniSentryObj)
	{
		return null;
	}

	[Token(Token = "0x6005FF7")]
	[Address(RVA = "0x1C6FC4C", Offset = "0x1C6FC4C", VA = "0x1C6FC4C", Slot = "4")]
	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	[Token(Token = "0x6005FF8")]
	[Address(RVA = "0x1C6FC54", Offset = "0x1C6FC54", VA = "0x1C6FC54", Slot = "5")]
	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6005FF9")]
	[Address(RVA = "0x1C6FD20", Offset = "0x1C6FD20", VA = "0x1C6FD20", Slot = "6")]
	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase sceneEditObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6005FFA")]
	[Address(RVA = "0x1C70310", Offset = "0x1C70310", VA = "0x1C70310", Slot = "7")]
	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6005FFB")]
	[Address(RVA = "0x1C6FEA8", Offset = "0x1C6FEA8", VA = "0x1C6FEA8")]
	private void SetAttributeData(SceneEditObjectMiniSentry sceneMiniSentry, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
