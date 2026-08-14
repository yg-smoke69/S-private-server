using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using message;

[Token(Token = "0x2000C92")]
public class TriggerEditAttributeConfig : ScaleItemEditAttributeConfig
{
	[Token(Token = "0x400671F")]
	[FieldOffset(Offset = "0x48")]
	public string TriggerTypeTitleNameKey;

	[Token(Token = "0x4006720")]
	[FieldOffset(Offset = "0x4C")]
	public OMDNLEEOJBD DefaultTriggerType;

	[Token(Token = "0x4006721")]
	[FieldOffset(Offset = "0x50")]
	public List<uint> TriggerTypeList;

	[Token(Token = "0x4006722")]
	[FieldOffset(Offset = "0x54")]
	public List<string> TriggerTypeNameKeyList;

	[Token(Token = "0x4006723")]
	[FieldOffset(Offset = "0x58")]
	public string TriggerIsShowTitleNameKey;

	[Token(Token = "0x4006724")]
	[FieldOffset(Offset = "0x5C")]
	public bool IsDefaultShow;

	[Token(Token = "0x4006725")]
	[FieldOffset(Offset = "0x60")]
	public List<string> TriggerShowConfigNameKeyList;

	[Token(Token = "0x17000809")]
	protected override int GetScaleUIDataBeginIndex
	{
		[Token(Token = "0x6006021")]
		[Address(RVA = "0x263C428", Offset = "0x263C428", VA = "0x263C428", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006020")]
	[Address(RVA = "0x263C348", Offset = "0x263C348", VA = "0x263C348")]
	public TriggerEditAttributeConfig()
	{
	}

	[Token(Token = "0x6006022")]
	[Address(RVA = "0x263C430", Offset = "0x263C430", VA = "0x263C430")]
	public List<ItemEditAttributeUIData> GetTriggerUIData(SceneEditObjectTrigger sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6006023")]
	[Address(RVA = "0x263C898", Offset = "0x263C898", VA = "0x263C898", Slot = "4")]
	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	[Token(Token = "0x6006024")]
	[Address(RVA = "0x263C934", Offset = "0x263C934", VA = "0x263C934", Slot = "5")]
	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6006025")]
	[Address(RVA = "0x263CA58", Offset = "0x263CA58", VA = "0x263CA58", Slot = "6")]
	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase sceneEditObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6006026")]
	[Address(RVA = "0x263CD78", Offset = "0x263CD78", VA = "0x263CD78", Slot = "7")]
	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6006027")]
	[Address(RVA = "0x263CC1C", Offset = "0x263CC1C", VA = "0x263CC1C")]
	private void SetTriggerAttributeData(SceneEditObjectTrigger triggerObj, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
