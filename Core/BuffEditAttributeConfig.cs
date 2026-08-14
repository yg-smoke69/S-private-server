using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

[Token(Token = "0x2000C7B")]
public class BuffEditAttributeConfig : ItemEditAttributeBaseConfig
{
	[Token(Token = "0x40066B6")]
	[FieldOffset(Offset = "0xC")]
	public string BuffTypeConfigTitleNameKey;

	[Token(Token = "0x40066B7")]
	[FieldOffset(Offset = "0x10")]
	public List<uint> BuffTypeList;

	[Token(Token = "0x40066B8")]
	[FieldOffset(Offset = "0x14")]
	public List<string> BuffTypeTxtKeyList;

	[Token(Token = "0x40066B9")]
	[FieldOffset(Offset = "0x18")]
	public string BuffTimeConfigTitleNameKey;

	[Token(Token = "0x40066BA")]
	[FieldOffset(Offset = "0x1C")]
	public int BuffMinTime;

	[Token(Token = "0x40066BB")]
	[FieldOffset(Offset = "0x20")]
	public int BuffMaxTime;

	[Token(Token = "0x40066BC")]
	[FieldOffset(Offset = "0x24")]
	public int BuffDefaultTime;

	[Token(Token = "0x40066BD")]
	[FieldOffset(Offset = "0x28")]
	public int BuffStepTime;

	[Token(Token = "0x6005FB6")]
	[Address(RVA = "0x14B71E8", Offset = "0x14B71E8", VA = "0x14B71E8")]
	public BuffEditAttributeConfig()
	{
	}

	[Token(Token = "0x6005FB7")]
	[Address(RVA = "0x14B72A8", Offset = "0x14B72A8", VA = "0x14B72A8")]
	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectBuff sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6005FB8")]
	[Address(RVA = "0x14B76DC", Offset = "0x14B76DC", VA = "0x14B76DC", Slot = "4")]
	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	[Token(Token = "0x6005FB9")]
	[Address(RVA = "0x14B76E4", Offset = "0x14B76E4", VA = "0x14B76E4", Slot = "5")]
	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6005FBA")]
	[Address(RVA = "0x14B77B0", Offset = "0x14B77B0", VA = "0x14B77B0", Slot = "6")]
	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase sceneEditObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6005FBB")]
	[Address(RVA = "0x14B7AA8", Offset = "0x14B7AA8", VA = "0x14B7AA8", Slot = "7")]
	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6005FBC")]
	[Address(RVA = "0x14B7938", Offset = "0x14B7938", VA = "0x14B7938")]
	private void SetAttributeData(SceneEditObjectBuff sceneBuff, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
