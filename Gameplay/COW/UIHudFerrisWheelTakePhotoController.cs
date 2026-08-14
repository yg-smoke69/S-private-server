using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023DD")]
public class UIHudFerrisWheelTakePhotoController : UIBaseController
{
	[Token(Token = "0x400DEE4")]
	[FieldOffset(Offset = "0x28")]
	private UIHudFerrisWheelTakePhotoView m_View;

	[Token(Token = "0x400DEE5")]
	[FieldOffset(Offset = "0x30")]
	private ulong m_PreUIGroup;

	[Token(Token = "0x600CA62")]
	[Address(RVA = "0x1B9BB28", Offset = "0x1B9BB28", VA = "0x1B9BB28")]
	public UIHudFerrisWheelTakePhotoController()
	{
	}

	[Token(Token = "0x600CA63")]
	[Address(RVA = "0x1B9BBAC", Offset = "0x1B9BBAC", VA = "0x1B9BBAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CA64")]
	[Address(RVA = "0x1B9BC50", Offset = "0x1B9BC50", VA = "0x1B9BC50", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CA65")]
	[Address(RVA = "0x1B9BDAC", Offset = "0x1B9BDAC", VA = "0x1B9BDAC")]
	private void TakePhoto()
	{
	}

	[Token(Token = "0x600CA66")]
	[Address(RVA = "0x1B9C000", Offset = "0x1B9C000", VA = "0x1B9C000", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600CA67")]
	[Address(RVA = "0x1B9C140", Offset = "0x1B9C140", VA = "0x1B9C140", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600CA68")]
	[Address(RVA = "0x1B9C258", Offset = "0x1B9C258", VA = "0x1B9C258")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CA69")]
	[Address(RVA = "0x1B9C260", Offset = "0x1B9C260", VA = "0x1B9C260")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600CA6A")]
	[Address(RVA = "0x1B9C268", Offset = "0x1B9C268", VA = "0x1B9C268")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
