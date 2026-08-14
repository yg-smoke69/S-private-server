using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

[Token(Token = "0x2000C79")]
public class BigToyBallAttributeConfig : ItemEditAttributeBaseConfig
{
	[Token(Token = "0x400669D")]
	[FieldOffset(Offset = "0xC")]
	public string VelocityXZConfigTitleNameKey;

	[Token(Token = "0x400669E")]
	[FieldOffset(Offset = "0x10")]
	public float VelocityXZ;

	[Token(Token = "0x400669F")]
	[FieldOffset(Offset = "0x14")]
	public float VelocityXZMin;

	[Token(Token = "0x40066A0")]
	[FieldOffset(Offset = "0x18")]
	public float VelocityXZMax;

	[Token(Token = "0x40066A1")]
	[FieldOffset(Offset = "0x1C")]
	public float VelocityXZStep;

	[Token(Token = "0x40066A2")]
	[FieldOffset(Offset = "0x20")]
	public string VelocityYConfigTitleNameKey;

	[Token(Token = "0x40066A3")]
	[FieldOffset(Offset = "0x24")]
	public float VelocityY;

	[Token(Token = "0x40066A4")]
	[FieldOffset(Offset = "0x28")]
	public float VelocityYMin;

	[Token(Token = "0x40066A5")]
	[FieldOffset(Offset = "0x2C")]
	public float VelocityYMax;

	[Token(Token = "0x40066A6")]
	[FieldOffset(Offset = "0x30")]
	public float VelocityYStep;

	[Token(Token = "0x6005FA8")]
	[Address(RVA = "0x2ED059C", Offset = "0x2ED059C", VA = "0x2ED059C")]
	public BigToyBallAttributeConfig()
	{
	}

	[Token(Token = "0x6005FA9")]
	[Address(RVA = "0x2ED05C8", Offset = "0x2ED05C8", VA = "0x2ED05C8")]
	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectBigToyBall bigToyBall)
	{
		return null;
	}

	[Token(Token = "0x6005FAA")]
	[Address(RVA = "0x2ED0834", Offset = "0x2ED0834", VA = "0x2ED0834", Slot = "4")]
	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	[Token(Token = "0x6005FAB")]
	[Address(RVA = "0x2ED083C", Offset = "0x2ED083C", VA = "0x2ED083C", Slot = "5")]
	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	[Token(Token = "0x6005FAC")]
	[Address(RVA = "0x2ED0908", Offset = "0x2ED0908", VA = "0x2ED0908", Slot = "6")]
	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase sceneEditObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6005FAD")]
	[Address(RVA = "0x2ED0C14", Offset = "0x2ED0C14", VA = "0x2ED0C14", Slot = "7")]
	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	[Token(Token = "0x6005FAE")]
	[Address(RVA = "0x2ED0A90", Offset = "0x2ED0A90", VA = "0x2ED0A90")]
	private void SetAttributeData(SceneEditObjectBigToyBall ballObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
