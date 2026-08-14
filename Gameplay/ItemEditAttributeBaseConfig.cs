using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C81")]
public class ItemEditAttributeBaseConfig : ScriptableObject
{
	[Token(Token = "0x6005FCB")]
	[Address(RVA = "0x3110900", Offset = "0x3110900", VA = "0x3110900")]
	public ItemEditAttributeBaseConfig()
	{
	}

	[Token(Token = "0x6005FCC")]
	[Address(RVA = "0x3110D50", Offset = "0x3110D50", VA = "0x3110D50")]
	public ItemEditAttributeUIDataHorizontalSelect GetResetPerRoundUIData(SceneEditObjectAttrBase sceneEditObject, bool isResetIfOldVersion = false)
	{
		return null;
	}

	[Token(Token = "0x6005FCD")]
	[Address(RVA = "0x31115CC", Offset = "0x31115CC", VA = "0x31115CC", Slot = "4")]
	public virtual List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	[Token(Token = "0x6005FCE")]
	[Address(RVA = "0x31115D4", Offset = "0x31115D4", VA = "0x31115D4", Slot = "5")]
	public virtual List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6005FCF")]
	[Address(RVA = "0x31115DC", Offset = "0x31115DC", VA = "0x31115DC", Slot = "6")]
	public virtual void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase sceneEditObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6005FD0")]
	[Address(RVA = "0x31115E0", Offset = "0x31115E0", VA = "0x31115E0", Slot = "7")]
	public virtual void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
