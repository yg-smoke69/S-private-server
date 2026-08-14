using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

[Token(Token = "0x2000C93")]
public class BotGeneratorFunctionAttributeConfig : ItemFunctionAttributeBaseConfig
{
	[Token(Token = "0x4006726")]
	[FieldOffset(Offset = "0xC")]
	public string EditBotTitle;

	[Token(Token = "0x4006727")]
	[FieldOffset(Offset = "0x10")]
	public string EditButtonIcon;

	[Token(Token = "0x4006728")]
	[FieldOffset(Offset = "0x14")]
	public string EditBotDetailWindowConfig;

	[Token(Token = "0x4006729")]
	[FieldOffset(Offset = "0x18")]
	public string EditBotDetailWindowVariableConfig;

	[Token(Token = "0x400672A")]
	[FieldOffset(Offset = "0x1C")]
	private SceneEditObjectAttrBase attr;

	[Token(Token = "0x400672B")]
	[FieldOffset(Offset = "0x20")]
	private LLIBMMFAGDN mSettingData;

	[Token(Token = "0x1700080A")]
	public LLIBMMFAGDN SettingData
	{
		[Token(Token = "0x6006029")]
		[Address(RVA = "0x2ED3C40", Offset = "0x2ED3C40", VA = "0x2ED3C40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006028")]
	[Address(RVA = "0x2ED3C38", Offset = "0x2ED3C38", VA = "0x2ED3C38")]
	public BotGeneratorFunctionAttributeConfig()
	{
	}

	[Token(Token = "0x600602A")]
	[Address(RVA = "0x2ED3C48", Offset = "0x2ED3C48", VA = "0x2ED3C48", Slot = "4")]
	public override List<ItemFunctionUIData> GetUIData(SceneEditObjectAttrBase sceneAttr)
	{
		return null;
	}

	[Token(Token = "0x600602B")]
	[Address(RVA = "0x2ED4058", Offset = "0x2ED4058", VA = "0x2ED4058")]
	private void OnEditButtonClick()
	{
	}
}
