using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

[Token(Token = "0x2000C8E")]
public class ScaleItemEditAttributeConfig : ItemEditAttributeBaseConfig
{
	[Token(Token = "0x400670A")]
	[FieldOffset(Offset = "0xC")]
	public string ScaleXConfigTitleNameKey;

	[Token(Token = "0x400670B")]
	[FieldOffset(Offset = "0x10")]
	public float ScaleXMinValue;

	[Token(Token = "0x400670C")]
	[FieldOffset(Offset = "0x14")]
	public float ScaleXMaxValue;

	[Token(Token = "0x400670D")]
	[FieldOffset(Offset = "0x18")]
	public float ScaleXDefaultValue;

	[Token(Token = "0x400670E")]
	[FieldOffset(Offset = "0x1C")]
	public float ScaleXStepValue;

	[Token(Token = "0x400670F")]
	[FieldOffset(Offset = "0x20")]
	public string ScaleYConfigTitleNameKey;

	[Token(Token = "0x4006710")]
	[FieldOffset(Offset = "0x24")]
	public float ScaleYMinValue;

	[Token(Token = "0x4006711")]
	[FieldOffset(Offset = "0x28")]
	public float ScaleYMaxValue;

	[Token(Token = "0x4006712")]
	[FieldOffset(Offset = "0x2C")]
	public float ScaleYDefaultValue;

	[Token(Token = "0x4006713")]
	[FieldOffset(Offset = "0x30")]
	public float ScaleYStepValue;

	[Token(Token = "0x4006714")]
	[FieldOffset(Offset = "0x34")]
	public string ScaleZConfigTitleNameKey;

	[Token(Token = "0x4006715")]
	[FieldOffset(Offset = "0x38")]
	public float ScaleZMinValue;

	[Token(Token = "0x4006716")]
	[FieldOffset(Offset = "0x3C")]
	public float ScaleZMaxValue;

	[Token(Token = "0x4006717")]
	[FieldOffset(Offset = "0x40")]
	public float ScaleZDefaultValue;

	[Token(Token = "0x4006718")]
	[FieldOffset(Offset = "0x44")]
	public float ScaleZStepValue;

	[Token(Token = "0x17000808")]
	protected virtual int GetScaleUIDataBeginIndex
	{
		[Token(Token = "0x6006015")]
		[Address(RVA = "0x21C0094", Offset = "0x21C0094", VA = "0x21C0094", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006014")]
	[Address(RVA = "0x21C008C", Offset = "0x21C008C", VA = "0x21C008C")]
	public ScaleItemEditAttributeConfig()
	{
	}

	[Token(Token = "0x6006016")]
	[Address(RVA = "0x21C009C", Offset = "0x21C009C", VA = "0x21C009C")]
	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectScalableItem sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6006017")]
	[Address(RVA = "0x21C045C", Offset = "0x21C045C", VA = "0x21C045C", Slot = "4")]
	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	[Token(Token = "0x6006018")]
	[Address(RVA = "0x21C0464", Offset = "0x21C0464", VA = "0x21C0464", Slot = "5")]
	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6006019")]
	[Address(RVA = "0x21C0530", Offset = "0x21C0530", VA = "0x21C0530", Slot = "6")]
	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase sceneEditObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x600601A")]
	[Address(RVA = "0x21C08D8", Offset = "0x21C08D8", VA = "0x21C08D8", Slot = "7")]
	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x600601B")]
	[Address(RVA = "0x21C06BC", Offset = "0x21C06BC", VA = "0x21C06BC")]
	protected void SetScaleAttributeData(SceneEditObjectScalableItem scalableItem, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
