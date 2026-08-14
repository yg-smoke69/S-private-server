using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028CA")]
public class UIHudWereWolvesVoteResultController : UIBaseController
{
	[Token(Token = "0x20028CB")]
	public enum WereWolvesBannerType
	{
		[Token(Token = "0x400FAFA")]
		Eject,
		[Token(Token = "0x400FAFB")]
		Alert
	}

	[Token(Token = "0x400FAF8")]
	[FieldOffset(Offset = "0x28")]
	private UIHudWereWolvesVoteResultView m_View;

	[Token(Token = "0x6010131")]
	[Address(RVA = "0x257F9EC", Offset = "0x257F9EC", VA = "0x257F9EC")]
	public UIHudWereWolvesVoteResultController()
	{
	}

	[Token(Token = "0x6010132")]
	[Address(RVA = "0x257FA70", Offset = "0x257FA70", VA = "0x257FA70")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010133")]
	[Address(RVA = "0x257FB18", Offset = "0x257FB18", VA = "0x257FB18", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010134")]
	[Address(RVA = "0x257FC68", Offset = "0x257FC68", VA = "0x257FC68", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6010135")]
	[Address(RVA = "0x257FD9C", Offset = "0x257FD9C", VA = "0x257FD9C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6010136")]
	[Address(RVA = "0x257FE14", Offset = "0x257FE14", VA = "0x257FE14")]
	private void OnBannerInfo(object[] data)
	{
	}

	[Token(Token = "0x6010137")]
	[Address(RVA = "0x2580838", Offset = "0x2580838", VA = "0x2580838")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010138")]
	[Address(RVA = "0x2580840", Offset = "0x2580840", VA = "0x2580840")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x6010139")]
	[Address(RVA = "0x2580848", Offset = "0x2580848", VA = "0x2580848")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
