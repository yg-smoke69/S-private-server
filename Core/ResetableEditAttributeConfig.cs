using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

[Token(Token = "0x2000C8D")]
public class ResetableEditAttributeConfig : ItemEditAttributeBaseConfig
{
	[Token(Token = "0x600600D")]
	[Address(RVA = "0x316C2FC", Offset = "0x316C2FC", VA = "0x316C2FC")]
	public ResetableEditAttributeConfig()
	{
	}

	[Token(Token = "0x600600E")]
	[Address(RVA = "0x316C304", Offset = "0x316C304", VA = "0x316C304")]
	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectResetable sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x600600F")]
	[Address(RVA = "0x316C3CC", Offset = "0x316C3CC", VA = "0x316C3CC", Slot = "4")]
	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	[Token(Token = "0x6006010")]
	[Address(RVA = "0x316C3D4", Offset = "0x316C3D4", VA = "0x316C3D4", Slot = "5")]
	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6006011")]
	[Address(RVA = "0x316C4A0", Offset = "0x316C4A0", VA = "0x316C4A0", Slot = "6")]
	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase sceneEditObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6006012")]
	[Address(RVA = "0x316C714", Offset = "0x316C714", VA = "0x316C714", Slot = "7")]
	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6006013")]
	[Address(RVA = "0x316C628", Offset = "0x316C628", VA = "0x316C628")]
	private void SetAttributeData(SceneEditObjectResetable itemBox, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
