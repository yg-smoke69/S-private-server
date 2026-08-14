using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000C8B")]
public class MoveObjectEditAttributeConfig : ItemEditAttributeBaseConfig
{
	[Token(Token = "0x4006703")]
	[FieldOffset(Offset = "0xC")]
	public string MoveTypeConfigTitleNameKey;

	[Token(Token = "0x4006704")]
	[FieldOffset(Offset = "0x10")]
	public int DefaultMoveMoveCSVCoinfigID;

	[Token(Token = "0x4006705")]
	[FieldOffset(Offset = "0x14")]
	public List<int> MoveCSVCoinfigIDList;

	[Token(Token = "0x4006706")]
	[FieldOffset(Offset = "0x18")]
	public List<string> MoveNameKey;

	[Token(Token = "0x6005FFC")]
	[Address(RVA = "0x1C71C44", Offset = "0x1C71C44", VA = "0x1C71C44")]
	public MoveObjectEditAttributeConfig()
	{
	}

	[Token(Token = "0x6005FFD")]
	[Address(RVA = "0x1C71D0C", Offset = "0x1C71D0C", VA = "0x1C71D0C")]
	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectMoveObject sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6005FFE")]
	[Address(RVA = "0x1C71E74", Offset = "0x1C71E74", VA = "0x1C71E74", Slot = "5")]
	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6005FFF")]
	[Address(RVA = "0x1C71F40", Offset = "0x1C71F40", VA = "0x1C71F40", Slot = "4")]
	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	[Token(Token = "0x6006000")]
	[Address(RVA = "0x1C71F48", Offset = "0x1C71F48", VA = "0x1C71F48", Slot = "6")]
	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase sceneEditObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6006001")]
	[Address(RVA = "0x1C721D4", Offset = "0x1C721D4", VA = "0x1C721D4", Slot = "7")]
	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6006002")]
	[Address(RVA = "0x1C720F4", Offset = "0x1C720F4", VA = "0x1C720F4")]
	private void SetAttributeData(SceneEditObjectMoveObject moveObj, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
