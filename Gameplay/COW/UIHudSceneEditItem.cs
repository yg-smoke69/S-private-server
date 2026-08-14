using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002334")]
internal class UIHudSceneEditItem
{
	[Token(Token = "0x400DB4E")]
	[FieldOffset(Offset = "0x8")]
	public WorkShopPrefabResourceContentConfigData configData;

	[Token(Token = "0x400DB4F")]
	[FieldOffset(Offset = "0xC")]
	public bool IsSelected;

	[Token(Token = "0x400DB50")]
	[FieldOffset(Offset = "0xD")]
	public bool IsMustMode;

	[Token(Token = "0x600C360")]
	[Address(RVA = "0x24D5574", Offset = "0x24D5574", VA = "0x24D5574")]
	public UIHudSceneEditItem()
	{
	}
}
