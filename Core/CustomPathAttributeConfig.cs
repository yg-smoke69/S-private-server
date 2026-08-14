using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

[Token(Token = "0x2000C7C")]
public class CustomPathAttributeConfig : ItemEditAttributeBaseConfig
{
	[Token(Token = "0x40066BE")]
	[FieldOffset(Offset = "0xC")]
	public string CustomPathPointNumNameKey;

	[Token(Token = "0x40066BF")]
	[FieldOffset(Offset = "0x10")]
	public int PointMinNum;

	[Token(Token = "0x40066C0")]
	[FieldOffset(Offset = "0x14")]
	public int PointMaxNum;

	[Token(Token = "0x40066C1")]
	[FieldOffset(Offset = "0x18")]
	public int PointDefaultNum;

	[Token(Token = "0x6005FBD")]
	[Address(RVA = "0x230FD7C", Offset = "0x230FD7C", VA = "0x230FD7C")]
	public CustomPathAttributeConfig()
	{
	}

	[Token(Token = "0x6005FBE")]
	[Address(RVA = "0x230FD98", Offset = "0x230FD98", VA = "0x230FD98")]
	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectAttrCustomPath attrObj)
	{
		return null;
	}

	[Token(Token = "0x6005FBF")]
	[Address(RVA = "0x230FF2C", Offset = "0x230FF2C", VA = "0x230FF2C", Slot = "4")]
	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	[Token(Token = "0x6005FC0")]
	[Address(RVA = "0x230FF34", Offset = "0x230FF34", VA = "0x230FF34", Slot = "5")]
	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6005FC1")]
	[Address(RVA = "0x2310000", Offset = "0x2310000", VA = "0x2310000", Slot = "6")]
	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase sceneEditObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6005FC2")]
	[Address(RVA = "0x2310280", Offset = "0x2310280", VA = "0x2310280", Slot = "7")]
	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6005FC3")]
	[Address(RVA = "0x2310188", Offset = "0x2310188", VA = "0x2310188")]
	private void SetAttributeData(SceneEditObjectAttrCustomPath customPath, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
