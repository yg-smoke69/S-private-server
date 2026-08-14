using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

[Token(Token = "0x2000C94")]
public class CustomPointFunctionAttributeConfig : ItemFunctionAttributeBaseConfig
{
	[Token(Token = "0x2000C95")]
	private sealed class _003COnRemoveButtonClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x4006730")]
		[FieldOffset(Offset = "0x8")]
		internal SceneEditObjectAttrCustomPoint point;

		[Token(Token = "0x6006030")]
		[Address(RVA = "0x231095C", Offset = "0x231095C", VA = "0x231095C")]
		public _003COnRemoveButtonClick_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6006031")]
		[Address(RVA = "0x2310964", Offset = "0x2310964", VA = "0x2310964")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400672C")]
	[FieldOffset(Offset = "0xC")]
	public string EditPointTitle;

	[Token(Token = "0x400672D")]
	[FieldOffset(Offset = "0x10")]
	public string RemovePointButtonIcon;

	[Token(Token = "0x400672E")]
	[FieldOffset(Offset = "0x14")]
	public string AddPointButtonIcon;

	[Token(Token = "0x400672F")]
	[FieldOffset(Offset = "0x18")]
	private SceneEditObjectAttrBase attr;

	[Token(Token = "0x600602C")]
	[Address(RVA = "0x23103D8", Offset = "0x23103D8", VA = "0x23103D8")]
	public CustomPointFunctionAttributeConfig()
	{
	}

	[Token(Token = "0x600602D")]
	[Address(RVA = "0x23103E0", Offset = "0x23103E0", VA = "0x23103E0", Slot = "4")]
	public override List<ItemFunctionUIData> GetUIData(SceneEditObjectAttrBase sceneAttr)
	{
		return null;
	}

	[Token(Token = "0x600602E")]
	[Address(RVA = "0x2310678", Offset = "0x2310678", VA = "0x2310678")]
	private void OnAddButtonClick()
	{
	}

	[Token(Token = "0x600602F")]
	[Address(RVA = "0x23107D4", Offset = "0x23107D4", VA = "0x23107D4")]
	private void OnRemoveButtonClick()
	{
	}
}
