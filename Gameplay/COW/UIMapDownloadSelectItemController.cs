using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002999")]
internal class UIMapDownloadSelectItemController : UIBaseController
{
	[Token(Token = "0x4010007")]
	[FieldOffset(Offset = "0x28")]
	public MapModeData Data;

	[Token(Token = "0x4010008")]
	[FieldOffset(Offset = "0x2C")]
	public bool IsSelected;

	[Token(Token = "0x4010009")]
	[FieldOffset(Offset = "0x30")]
	private UIMapDownloadSelectItemView m_View;

	[Token(Token = "0x6010B51")]
	[Address(RVA = "0x2801098", Offset = "0x2801098", VA = "0x2801098")]
	public UIMapDownloadSelectItemController()
	{
	}

	[Token(Token = "0x6010B52")]
	[Address(RVA = "0x280111C", Offset = "0x280111C", VA = "0x280111C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010B53")]
	[Address(RVA = "0x28011C4", Offset = "0x28011C4", VA = "0x28011C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010B54")]
	[Address(RVA = "0x28007C0", Offset = "0x28007C0", VA = "0x28007C0")]
	public void SetUIData(object data, int index)
	{
	}

	[Token(Token = "0x6010B55")]
	[Address(RVA = "0x2801320", Offset = "0x2801320", VA = "0x2801320")]
	private void OnBtnSelectClick()
	{
	}

	[Token(Token = "0x6010B56")]
	[Address(RVA = "0x280140C", Offset = "0x280140C", VA = "0x280140C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
