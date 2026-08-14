using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028D3")]
internal class UIHudZombieModeBuffChooseController : UIBaseController
{
	[Token(Token = "0x400FB22")]
	[FieldOffset(Offset = "0x28")]
	private UIHudZombieModeBuffChooseView m_View;

	[Token(Token = "0x400FB23")]
	private const uint BuffCnt = 4u;

	[Token(Token = "0x6010184")]
	[Address(RVA = "0x2944F80", Offset = "0x2944F80", VA = "0x2944F80")]
	public UIHudZombieModeBuffChooseController()
	{
	}

	[Token(Token = "0x6010185")]
	[Address(RVA = "0x2945004", Offset = "0x2945004", VA = "0x2945004")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010186")]
	[Address(RVA = "0x29450AC", Offset = "0x29450AC", VA = "0x29450AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010187")]
	[Address(RVA = "0x29451BC", Offset = "0x29451BC", VA = "0x29451BC")]
	private void SetView()
	{
	}

	[Token(Token = "0x6010188")]
	[Address(RVA = "0x2945510", Offset = "0x2945510", VA = "0x2945510")]
	private void OnBtnSelectClick(object[] param)
	{
	}

	[Token(Token = "0x6010189")]
	[Address(RVA = "0x29456B0", Offset = "0x29456B0", VA = "0x29456B0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
