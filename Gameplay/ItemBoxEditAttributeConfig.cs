using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

[Token(Token = "0x2000C80")]
public class ItemBoxEditAttributeConfig : ItemEditAttributeBaseConfig
{
	[Token(Token = "0x40066D7")]
	[FieldOffset(Offset = "0xC")]
	public string TitleNameKey;

	[Token(Token = "0x40066D8")]
	[FieldOffset(Offset = "0x10")]
	public List<int> DropIDList;

	[Token(Token = "0x40066D9")]
	[FieldOffset(Offset = "0x14")]
	public List<string> DropIDTxtKeyList;

	[Token(Token = "0x6005FC4")]
	[Address(RVA = "0x3110840", Offset = "0x3110840", VA = "0x3110840")]
	public ItemBoxEditAttributeConfig()
	{
	}

	[Token(Token = "0x6005FC5")]
	[Address(RVA = "0x3110908", Offset = "0x3110908", VA = "0x3110908")]
	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectItemBox sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6005FC6")]
	[Address(RVA = "0x3110FCC", Offset = "0x3110FCC", VA = "0x3110FCC", Slot = "4")]
	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	[Token(Token = "0x6005FC7")]
	[Address(RVA = "0x3110FD4", Offset = "0x3110FD4", VA = "0x3110FD4", Slot = "5")]
	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6005FC8")]
	[Address(RVA = "0x31110A0", Offset = "0x31110A0", VA = "0x31110A0", Slot = "6")]
	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase sceneEditObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6005FC9")]
	[Address(RVA = "0x31113A4", Offset = "0x31113A4", VA = "0x31113A4", Slot = "7")]
	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6005FCA")]
	[Address(RVA = "0x3111228", Offset = "0x3111228", VA = "0x3111228")]
	private void SetAttributeData(SceneEditObjectItemBox itemBox, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
